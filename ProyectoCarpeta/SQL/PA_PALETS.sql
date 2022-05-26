/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DEL PROCEDIMIENTO:	PA_PALETS
	FECHA DE CREACIÓN: 		05/05/2022
	AUTOR:				Óscar López
	VSS:				
	USO:				##VISUAL##

	FUNCIONAMIENTO:			Genera los palets para una línea o genera un palet hijo para el picking.


-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:
--	AUTOR:
--	EXPLICACIÓN:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

CREATE PROCEDURE PA_PALETS
	
	@COD_REFERENCIA VARCHAR(30),
	@COD_ESTADO INT,
	@CANTIDAD INT,
	@ALBARAN INT,
	@PETICION INT, 
	@COD_PALET_PADRE INT,


	@INVOKER	INT,		-- ESTE PARÁMETRO LO DEBEN TENER TODOS LOS PAS
	@USUARIO	VARCHAR(12),	-- ESTE PARÁMETRO LO DEBEN TENER TODOS LOS PAS
	@CULTURA	VARCHAR(5),

	@RETCODE	INT OUTPUT, --DEFINICIÓN OBLIGATORIA
	@MENSAJE	VARCHAR(1000)	OUTPUT	--DEFINICIÓN OBLIGATORIA

AS

BEGIN TRY

	

	DECLARE @N_TRANS		INT = 0	 --NUMERO DE TRANSACCIONES ACTIVAS	(@@TRANCOUNT)
	SET @N_TRANS = @@TRANCOUNT

	
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		BEGIN TRANSACTION TR_PALETS
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	DECLARE @COD_PALET_MODIFICADO INT,
		@CANTIDAD_PALET_MODIFICADO INT,
		@CANTIDAD_MAXIMA_PALET INT, --CANTIDAD MAXIMA DE LOS PALETS
		@CANTIDAD_INPUT INT,--CANTIDAD QUE SE PASARA A LAS LLAMADAS RECURSIVAS
		@COD_PALET_SIGUIENTE INT; --NUMERADOR DE PALETS
		SET @CANTIDAD_MAXIMA_PALET = 1000;
	
	
	IF @INVOKER = 0 -- INSERTAR PALET			
	BEGIN	
	DECLARE @CANTIDAD_INTRODUCIDA INT;
		

		--Si la cantidad a introducir supera la maxima, introduce un palet con la cantidad maxima
		IF @CANTIDAD > @CANTIDAD_MAXIMA_PALET
		BEGIN
			SET @CANTIDAD_INTRODUCIDA = @CANTIDAD_MAXIMA_PALET
		END
		
		--Si es menor, introduce directamente un palet con esa cantidad
		ELSE  
		BEGIN
			SET @CANTIDAD_INTRODUCIDA = @CANTIDAD
		END
										
		--Obtener el numero de palet
	
		SELECT @COD_PALET_SIGUIENTE = COUNT(*) FROM PALETS;

		SET @COD_PALET_SIGUIENTE = @COD_PALET_SIGUIENTE+1;

		--Insertar palet en la zona de descarga.

		INSERT INTO PALETS (COD_PALET, COD_REFERENCIA, UBICACION, COD_ESTADO, FECH_INSERT, CANTIDAD, ALBARAN_RECEPCION, ETIQUETA, PETICION_SALIDA, PALET_PADRE) 

		VALUES(@COD_PALET_SIGUIENTE,@COD_REFERENCIA, 'ZD_01_01', @COD_ESTADO, GETDATE(), @CANTIDAD_INTRODUCIDA, @ALBARAN, 'aA', @PETICION, @COD_PALET_PADRE);

		SET @MENSAJE = 'PALET CREADO.'

		EXEC PA_GENERAR_ETIQUETA  @COD_PALET_SIGUIENTE, @INVOKER,@USUARIO, @CULTURA, @RETCODE, @MENSAJE

		--Llamada a la funcion de nuevo para seguir introduciendo palets, pasando con una variable la cantidad a introducir

		IF @CANTIDAD > @CANTIDAD_MAXIMA_PALET

		BEGIN
			SET @CANTIDAD_INPUT = @CANTIDAD - @CANTIDAD_INTRODUCIDA

			EXEC PA_PALETS @COD_REFERENCIA, @COD_ESTADO, 
			@CANTIDAD_INPUT,@ALBARAN, @PETICION, @COD_PALET_PADRE , @INVOKER, @USUARIO, @CULTURA,@RETCODE, @MENSAJE 

		END
	END
			

	IF @INVOKER = 3 -- CREAR PALET HIJO PICKING

				
	BEGIN	
		
										
		--Obtener el numero de palet		
	
		SELECT @COD_PALET_SIGUIENTE = COUNT(*) FROM PALETS;

		SET @COD_PALET_SIGUIENTE = @COD_PALET_SIGUIENTE+1;

		INSERT INTO PALETS (COD_PALET, COD_REFERENCIA, UBICACION, COD_ESTADO, FECH_INSERT, CANTIDAD, ALBARAN_RECEPCION, ETIQUETA, PETICION_SALIDA, PALET_PADRE) 

		VALUES(@COD_PALET_SIGUIENTE,@COD_REFERENCIA, 'ZR_01_01' , @COD_ESTADO, GETDATE(), @CANTIDAD, @ALBARAN, 'aA', @PETICION, @COD_PALET_PADRE);

		EXEC PA_GENERAR_ETIQUETA  @COD_PALET_SIGUIENTE, @INVOKER,@USUARIO, @CULTURA, @RETCODE, @MENSAJE

		SET @MENSAJE = 'PALET HIJO CREADO.'
		 
	END	




	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		COMMIT TRANSACTION TR_PALETS
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
		ROLLBACK TRANSACTION TR_PALETS
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