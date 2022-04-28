ALTER PROCEDURE PA_RECEPCIONES_CAB
	
	@ALBARAN	int,
	@ESTADO		INT,
	@PROVEEDOR	VARCHAR(50),
	@FECH_CREACION	date,
	@FECH_LLEGADA	date,

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
		BEGIN TRANSACTION TR_RECEPCIONES_CAB
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @INVOKER = 0
	BEGIN
		
		INSERT INTO RECEPCIONES_CAB 
		VALUES(@ALBARAN, @ESTADO, @PROVEEDOR, @FECH_CREACION, @FECH_LLEGADA);

		SET @MENSAJE = 'CABECERA CREADA.'
	END

	ELSE IF @INVOKER = 1
	BEGIN
		UPDATE RECEPCIONES_CAB
		SET FECH_LLEGADA = @FECH_LLEGADA,
		ESTADO = @ESTADO
		WHERE ALBARAN = @ALBARAN;
		SET @MENSAJE = 'CABECERA EDITADA.'
	END
	
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		COMMIT TRANSACTION TR_RECEPCIONES_CAB
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
		ROLLBACK TRANSACTION TR_RECEPCIONES_CAB
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

