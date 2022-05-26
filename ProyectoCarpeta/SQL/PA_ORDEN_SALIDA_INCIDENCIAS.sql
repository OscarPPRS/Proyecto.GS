/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DEL PROCEDIMIENTO:	PA_ORDEN_SALIDA_INCIDENCIAS
	FECHA DE CREACIÓN: 		05/05/2022
	AUTOR:				Óscar López
	VSS:				
	USO:				##VISUAL##

	FUNCIONAMIENTO:			Genera una incidencia para  una petición de salida o actualiza una incidencia existente como resuelta.


-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:
--	AUTOR:
--	EXPLICACIÓN:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

CREATE PROCEDURE PA_ORDEN_SALIDA_INCIDENCIAS
	
	@COD_PETICION INT,
	@DESCRIPCION VARCHAR(500),

	@INVOKER	INT,		-- ESTE PARÁMETRO LO DEBEN TENER TODOS LOS PAS
	@USUARIO	VARCHAR(12),	-- ESTE PARÁMETRO LO DEBEN TENER TODOS LOS PAS
	@CULTURA	VARCHAR(5),
	 
	@RETCODE	INT OUTPUT,		--DEFINICIÓN OBLIGATORIA
	@MENSAJE	VARCHAR(1000)	OUTPUT	--DEFINICIÓN OBLIGATORIA

AS

BEGIN TRY

	DECLARE @N_TRANS		INT = 0	 --NUMERO DE TRANSACCIONES ACTIVAS	(@@TRANCOUNT)
	SET @N_TRANS = @@TRANCOUNT

	
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		BEGIN TRANSACTION TR_ORDEN_SALIDA_INCIDENCIAS
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @INVOKER = 0 --INSERTA UNA NUEVA INCIDENCIA
	BEGIN
		
		INSERT INTO ORDEN_SALIDA_INCIDENCIAS (COD_PETICION, DES_INCIDENCIA, RESUELTA)
		VALUES(@COD_PETICION, @DESCRIPCION, 0);

		SET @MENSAJE = 'INCIDENCIA CREADA.'
	END

	IF @INVOKER = 1 --ACTUALIZA UNA INCIDENCIA A RESUELTA
	BEGIN
		
		UPDATE ORDEN_SALIDA_INCIDENCIAS
		SET RESUELTA = 1
		WHERE COD_PETICION = @COD_PETICION

	END
	
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		COMMIT TRANSACTION TR_ORDEN_SALIDA_INCIDENCIAS
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	SET @MENSAJE = 'El proceso se ha realizado correctamente.'
	SET @RETCODE = 0
	RETURN @RETCODE
END TRY
BEGIN CATCH
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0 AND @@TRANCOUNT > 0				-- Si hay una transacción por encima no hacemos nada
	BEGIN
		ROLLBACK TRANSACTION TR_ORDEN_SALIDA_INCIDENCIAS
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @MENSAJE = '' 
	BEGIN
		SET  @MENSAJE = ERROR_MESSAGE()
	END
	
	SET @RETCODE = -1
		
	RETURN @RETCODE
END CATCH

	SET @RETCODE = -1		
	RETURN @RETCODE
