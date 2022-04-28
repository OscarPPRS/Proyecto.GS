ALTER PROCEDURE PA_REFERENCIAS
	
	@COD_REFERENCIA VARCHAR(30),
	@ID_EMPRESA INT,
	@DES_REFERENCIA VARCHAR(500),
	@PRECIO FLOAT,
	@IMAGEN VARCHAR(2000),
	@ESTADO BIT,


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
		BEGIN TRANSACTION TR_REFERENCIAS
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @INVOKER = 0 -- INSERTAR REFERENCIA
	BEGIN
		DECLARE @NUMERADOR INT
		DECLARE @PREFIJO VARCHAR(30)
		DECLARE @CODIGO VARCHAR(30);
		
		SELECT @PREFIJO = COD_REFERENCIA
		FROM REFERENCIAS
		WHERE ID_EMPRESA = @ID_EMPRESA
		
		SET @PREFIJO = LEFT(@PREFIJO,3);
		
		SELECT @NUMERADOR = COUNT(*) 
		FROM REFERENCIAS
		WHERE ID_EMPRESA = @ID_EMPRESA;

		SET @NUMERADOR =  @NUMERADOR +1;

		SET @CODIGO =LEFT(@PREFIJO,3) + Right(replicate('0',5) + convert(varchar(5), @NUMERADOR), 5);

		INSERT INTO REFERENCIAS (COD_REFERENCIA, ID_EMPRESA, DES_REFERENCIA, PRECIO, FECH_CREACION, IMAGEN, ESTADO)
		VALUES(@CODIGO,@ID_EMPRESA, @DES_REFERENCIA, @PRECIO, GETDATE(), @IMAGEN, @ESTADO);

		SET @MENSAJE = @CODIGO;
	END
	ELSE IF @INVOKER = 1  -- MODIFICAR DATOS REFERENCIA
	BEGIN 

		UPDATE REFERENCIAS  
		SET 
		 
		DES_REFERENCIA = @DES_REFERENCIA,
		PRECIO = @PRECIO,
		IMAGEN = @IMAGEN
		WHERE COD_REFERENCIA = @COD_REFERENCIA;


		SET @MENSAJE = 'REFERENCIA ACTUALIZADA.'

	END
	ELSE IF @INVOKER = 3  -- MODIFICAR ESTADO
	BEGIN 

		UPDATE REFERENCIAS  
		SET 		 
		ESTADO = @ESTADO
		WHERE COD_REFERENCIA = @COD_REFERENCIA;


		SET @MENSAJE = 'REFERENCIA ACTUALIZADA.'

	END


	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		COMMIT TRANSACTION TR_REFERENCIAS
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
		ROLLBACK TRANSACTION TR_REFERENCIAS
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