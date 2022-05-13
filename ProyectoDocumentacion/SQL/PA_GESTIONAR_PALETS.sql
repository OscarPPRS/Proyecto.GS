ALTER PROCEDURE PA_GESTIONAR_PALETS
	
	@COD_PALET INT,
	@COD_UBICACION_NUEVA VARCHAR(30),
	@COD_PALET_ABSORBIDO int,
	@CANTIDAD_PARTIDA INT,


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
		BEGIN TRANSACTION TR_GESTIONAR_PALETS
	END
	----------------------------------------------------------------------------------------------------------------------------------------------

	
	 IF @INVOKER = 0 -- REUBICAR PALET  
  
      
		 BEGIN   
			

			--Liberar la ubicacion del palet que movemos

			UPDATE UBICACIONES
			SET LLENA = 0
			FROM UBICACIONES
			JOIN PALETS
			ON PALETS.UBICACION = UBICACIONES.COD_UBICACION
			WHERE PALETS.COD_PALET = @COD_PALET
			



		--Cambiar la ubicacion del palet
		   UPDATE PALETS  
		   SET UBICACION = @COD_UBICACION_NUEVA  
		   WHERE COD_PALET = @COD_PALET  
			
			--Cambiar la ubicacion nueva a lleno pero solamente si la reubicacion se realiza a una posicion en una calle.

		UPDATE UBICACIONES
		   SET LLENA = 
		   CASE WHEN LEFT(@COD_UBICACION_NUEVA,2) like 'CA' THEN 1
		   ELSE 0 END

		   WHERE COD_UBICACION = @COD_UBICACION_NUEVA


     
		 END   
  
		 IF @INVOKER = 1 --ELIMINAR PALET  
  
      
		 BEGIN   
    
			UPDATE UBICACIONES
			SET LLENA = 0
			FROM UBICACIONES
			JOIN PALETS
			ON PALETS.UBICACION = UBICACIONES.COD_UBICACION
			WHERE PALETS.COD_PALET = @COD_PALET

		   UPDATE PALETS  
			   SET COD_ESTADO = 7,  
				   UBICACION = NULL  
		   WHERE COD_PALET = @COD_PALET  
  
    
		 END  
  
		 IF @INVOKER = 2 --UBICAR RECEPCIONES  
  
      
		 BEGIN   
    
		  --COLOCAMOS EN LA UBICACION QUE SE HA SELECCIONADO Y CAMBIAMOS EL ESTADO A LIBRE, PERO SOLO EN CASO DE QUE EL PALET NO ESTE DAÑADO, EN ESE CASO LO UBICAMOS COMO DAÑADO  
     
		   UPDATE PALETS  
		   SET UBICACION = @COD_UBICACION_NUEVA,  
				COD_ESTADO =   
				CASE WHEN COD_ESTADO = 6 THEN 6  
				ELSE 1 END  
      
		   WHERE COD_PALET = @COD_PALET 
		   
		   UPDATE UBICACIONES
		   SET LLENA = 1
		   WHERE COD_UBICACION = @COD_UBICACION_NUEVA    
		 END  

		 IF @INVOKER = 3 --JUNTAR PALETS
  
		 BEGIN   
    
			DECLARE @CANTIDAD_ABSORBIDA INT,	
					 @UBICACION_PALET_ABSORBIDO VARCHAR(30)

			--GUARDAMOS LA CANTIDAD QUE VA A ABSORBER Y EL CODIGO USANDO LA UBICACION DEL PALET QUE VA A SER ABSORBIDO
			SELECT @CANTIDAD_ABSORBIDA = CANTIDAD, @UBICACION_PALET_ABSORBIDO = UBICACION
			FROM PALETS PAL
			WHERE COD_PALET = @COD_PALET_ABSORBIDO

			--ACTUALIZAMOS LA CANTIDAD DEL PALET SUMANDO AMBOS

			 UPDATE PALETS
			 SET CANTIDAD += @CANTIDAD_ABSORBIDA
			 WHERE COD_PALET = @COD_PALET

			 --LIBERAMOS LA UBICACION DEL PALET ABSORBIDO

			 UPDATE UBICACIONES
			SET LLENA = 0
			WHERE COD_UBICACION = @UBICACION_PALET_ABSORBIDO

			--MARCAMOS EL PALET ABSORBIDO COMO ELIMINADO

			 UPDATE PALETS
			 SET COD_ESTADO = 7,
				UBICACION = NULL
			WHERE COD_PALET = @COD_PALET_ABSORBIDO

			EXEC PA_GENERAR_ETIQUETA  @COD_PALET, @INVOKER, @RETCODE, @MENSAJE
       
		 END

		 
		 IF @INVOKER = 4 --PARTIR PALETS
  
		 BEGIN   
			
			UPDATE PALETS
			SET CANTIDAD = CANTIDAD - @CANTIDAD_PARTIDA
			WHERE COD_PALET = @COD_PALET

			DECLARE @COD_PALET_SIGUIENTE INT

			SELECT @COD_PALET_SIGUIENTE = COUNT(*) FROM PALETS;

			SET @COD_PALET_SIGUIENTE = @COD_PALET_SIGUIENTE+1;

			INSERT INTO PALETS 

			VALUES
			(@COD_PALET_SIGUIENTE,
			(SELECT COD_REFERENCIA FROM PALETS WHERE COD_PALET = @COD_PALET), 
			'ZD_01_01' , 3, GETDATE(), @CANTIDAD_PARTIDA, NULL, 'aA', NULL, @COD_PALET);

			EXEC PA_GENERAR_ETIQUETA  @COD_PALET, @INVOKER, @RETCODE, @MENSAJE

			EXEC PA_GENERAR_ETIQUETA  @COD_PALET_SIGUIENTE, @INVOKER, @RETCODE, @MENSAJE
       
		 END
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		COMMIT TRANSACTION TR_GESTIONAR_PALETS
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
		ROLLBACK TRANSACTION TR_GESTIONAR_PALETS
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