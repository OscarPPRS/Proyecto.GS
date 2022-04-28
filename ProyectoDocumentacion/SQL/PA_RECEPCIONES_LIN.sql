ALTER PROCEDURE PA_RECEPCIONES_LIN
	
	@ALBARAN	INT,
	@COD_LINEA	INT,
	@COD_REFERENCIA	VARCHAR(30),
	@CANTIDAD	INT,

	@INVOKER	INT,			-- ESTE PARÁMETRO LO DEBEN TENER TODOS LOS PAS
	 
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
	IF @INVOKER = 0
	BEGIN		
		INSERT INTO RECEPCIONES_LIN 
		VALUES(@ALBARAN, @COD_LINEA ,@COD_REFERENCIA, @CANTIDAD);

		SET @MENSAJE = 'LINEA CREADA.'
	END
	
	IF @INVOKER = 2
	BEGIN
		DELETE 
		FROM RECEPCIONES_LIN
		WHERE ALBARAN = @ALBARAN; 
		
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