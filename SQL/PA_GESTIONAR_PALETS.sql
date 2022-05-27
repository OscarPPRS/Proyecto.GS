/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DEL PROCEDIMIENTO:	PA_GESTIONAR_PALETS
	FECHA DE CREACIÓN: 		05/05/2022
	AUTOR:				Óscar López
	VSS:				
	USO:				##VISUAL##

	FUNCIONAMIENTO:			Gestion de palets, reubicacion, ubicacion de recepciones, juntar, partir y eliminar.


-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:
--	AUTOR:
--	EXPLICACIÓN:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

CREATE PROCEDURE PA_GESTIONAR_PALETS
	
	@COD_PALET INT,
	@COD_UBICACION_NUEVA VARCHAR(30),
	@COD_PALET_ABSORBIDO int,
	@CANTIDAD_PARTIDA INT,


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
			
			--OBTENEMOS EL CODIGO DE LA UBICACION YA QUE EL COMBOBOX QUE INTRODUCE LA DESCRIPCION

			SELECT @COD_UBICACION_NUEVA = COD_UBICACION
			FROM UBICACIONES
			WHERE DESC_UBICACION = @COD_UBICACION_NUEVA


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

		   SET @MENSAJE = 'PALET REUBICADO'
     
		 END   
  
		 IF @INVOKER = 1 --ELIMINAR PALET  
  
		--ELIMINAR PALET EN BASE AL CODIGO DE PALET  Y LIBERACION DE UBICACION

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
			

			SET @MENSAJE = 'PALET ELIMINADO'
    
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

		   SET @MENSAJE = 'PALET UBICADO'
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

			SET @MENSAJE = 'PALETS JUNTADOS'

			EXEC PA_GENERAR_ETIQUETA  @COD_PALET, @INVOKER, @USUARIO, @CULTURA, @RETCODE, @MENSAJE
       
		 END

		 
		 IF @INVOKER = 4 --PARTIR PALETS
  
		 BEGIN   
			
			--ACTUALIZAR EL PALET DEL QUE SACAMOS COSAS
			UPDATE PALETS
			SET CANTIDAD = CANTIDAD - @CANTIDAD_PARTIDA
			WHERE COD_PALET = @COD_PALET

			--GENERAMOS EL CODIGO DEL PROXIMO PALET

			DECLARE @COD_PALET_SIGUIENTE INT

			SELECT @COD_PALET_SIGUIENTE = COUNT(*) FROM PALETS;

			SET @COD_PALET_SIGUIENTE = @COD_PALET_SIGUIENTE+1;

			--CREAMOS EL PALET

			INSERT INTO PALETS (COD_PALET, COD_REFERENCIA, UBICACION, COD_ESTADO, FECH_INSERT, CANTIDAD, ALBARAN_RECEPCION, ETIQUETA, PETICION_SALIDA, PALET_PADRE)

			VALUES
			(@COD_PALET_SIGUIENTE,

			(SELECT COD_REFERENCIA 
			FROM PALETS
			WHERE COD_PALET = @COD_PALET), 

			'ZD_01_01' , 3, GETDATE(), @CANTIDAD_PARTIDA, NULL, 'aA', NULL, @COD_PALET);

			EXEC PA_GENERAR_ETIQUETA  @COD_PALET, @INVOKER, @USUARIO, @CULTURA, @RETCODE, @MENSAJE

			EXEC PA_GENERAR_ETIQUETA  @COD_PALET_SIGUIENTE, @INVOKER,@USUARIO, @CULTURA, @RETCODE, @MENSAJE

			SET @MENSAJE = 'PALET PARTIDO'
       
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