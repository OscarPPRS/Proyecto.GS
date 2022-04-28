ALTER PROCEDURE PA_MOVIMIENTOS_PICKING
	
	@COD_PETICION INT,


	@INVOKER	INT,		-- ESTE PARÁMETRO LO DEBEN TENER TODOS LOS PAS

	@RETCODE	INT OUTPUT, --DEFINICIÓN OBLIGATORIA
	@MENSAJE	VARCHAR(1000)	OUTPUT	--DEFINICIÓN OBLIGATORIA


AS

BEGIN TRY

	DECLARE @N_TRANS		INT = 0	 --NUMERO DE TRANSACCIONES ACTIVAS	(@@TRANCOUNT)
	SET @N_TRANS = @@TRANCOUNT

	
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		BEGIN TRANSACTION TR_MOVIMIENTOS_PICKING
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @INVOKER = 0 

	--RESTAR STOCK

	BEGIN
		INSERT INTO MOVIMIENTOS_PICKING (COD_PETICION, COD_PALET, FECH_REALIZACION, REALIZADO, CANTIDAD)
		SELECT  COD_PETICION, 

		(SELECT TOP 1 COD_PALET
		FROM PALETS PAL
		WHERE LIN.COD_REFERENCIA = PAL.COD_REFERENCIA
		ORDER BY PAL.UBICACION
		--CAMBIAR ESTADO PALET
	)
		
		, NULL, 0, CANTIDAD
		FROM ORDEN_SALIDA_LIN LIN
		WHERE COD_PETICION = @COD_PETICION;
	END


	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		COMMIT TRANSACTION TR_MOVIMIENTOS_PICKING
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
		ROLLBACK TRANSACTION TR_MOVIMIENTOS_PICKING
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