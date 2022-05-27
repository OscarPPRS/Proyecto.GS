/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DEL PROCEDIMIENTO:	PA_ORDEN_SALIDA_LIN
	FECHA DE CREACIÓN: 		05/05/2022
	AUTOR:				Óscar López
	VSS:				
	USO:				##VISUAL##

	FUNCIONAMIENTO:			Crea una línea de una orden de salida.


-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:
--	AUTOR:
--	EXPLICACIÓN:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/


CREATE PROCEDURE PA_ORDEN_SALIDA_LIN
	
	@COD_PETICION	int,
	@COD_LINEA		INT,
	@COD_REFERENCIA	VARCHAR(30),
	@CANTIDAD	INT,	

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
		BEGIN TRANSACTION TR_ORDEN_SALIDA_LIN
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @INVOKER = 0
	BEGIN
		
		INSERT INTO ORDEN_SALIDA_LIN (COD_PETICION, COD_LINEA, COD_REFERENCIA, CANTIDAD)
		VALUES(@COD_PETICION,@COD_LINEA, @COD_REFERENCIA, @CANTIDAD);

		SET @MENSAJE = 'LINEA DE SALIDA CREADA.'
	END
	
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		COMMIT TRANSACTION TR_ORDEN_SALIDA_LIN
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
		ROLLBACK TRANSACTION TR_ORDEN_SALIDA_LIN
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

