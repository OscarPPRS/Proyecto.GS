/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DEL PROCEDIMIENTO:	PA_RECEPCIONES_LIN
	FECHA DE CREACIÓN: 		05/05/2022
	AUTOR:				Óscar López
	VSS:				
	USO:				##VISUAL##

	FUNCIONAMIENTO:			Inserta o elimina las líneas de una recepción.


-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:
--	AUTOR:
--	EXPLICACIÓN:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/


CREATE PROCEDURE PA_RECEPCIONES_LIN
	
	@ALBARAN	INT,
	@COD_LINEA	INT,
	@COD_REFERENCIA	VARCHAR(30),
	@CANTIDAD	INT,
	@CANTIDAD_MAL_ESTADO INT,
	@EXCEDENTE INT,
	@FALTA INT,

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
		BEGIN TRANSACTION TR_RECEPCIONES_LIN
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @INVOKER = 0 --CREA UNA LINEA PARA UN ALBARAN
	BEGIN		
		INSERT INTO RECEPCIONES_LIN (ALBARAN, COD_LINEA, COD_REFERENCIA, CANTIDAD, CANTIDAD_MAL_ESTADO, EXCEDENTE, FALTA)
		VALUES(@ALBARAN, @COD_LINEA ,@COD_REFERENCIA, @CANTIDAD, @CANTIDAD_MAL_ESTADO, @EXCEDENTE, @FALTA);

		SET @MENSAJE = 'LINEA CREADA.'
	END
	
	IF @INVOKER = 2 --BORRA TODAS LAS LINEAS PARA UN ALBARAN INTRODUCIDO
	BEGIN
		DELETE 
		FROM RECEPCIONES_LIN
		WHERE ALBARAN = @ALBARAN; 

		SET @MENSAJE = 'LINEAS ELIMINADAS.'
		
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		COMMIT TRANSACTION TR_RECEPCIONES_LIN
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
		ROLLBACK TRANSACTION TR_RECEPCIONES_LIN
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