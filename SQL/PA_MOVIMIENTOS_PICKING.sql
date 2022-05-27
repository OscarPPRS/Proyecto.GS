/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DEL PROCEDIMIENTO:	PA_MOVIMIENTOS_PICKING
	FECHA DE CREACI�N: 		05/05/2022
	AUTOR:				�scar L�pez
	VSS:				
	USO:				##VISUAL##

	FUNCIONAMIENTO:			Genera un nuevo movimiento dada una l�nea de una orden de salida, asignando los palets necesarios para la recogida
							Confirma un movimiento de picking y genera el palet correspondiente o actualiza.


-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACI�N:
--	AUTOR:
--	EXPLICACI�N:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/


CREATE PROCEDURE PA_MOVIMIENTOS_PICKING
	
	@COD_PETICION INT,
	@COD_LINEA INT,
	@COD_MOVIMIENTO INT,


	@INVOKER	INT,		-- ESTE PAR�METRO LO DEBEN TENER TODOS LOS PAS
	@USUARIO	VARCHAR(12),	-- ESTE PAR�METRO LO DEBEN TENER TODOS LOS PAS
	@CULTURA	VARCHAR(5),

	@RETCODE	INT OUTPUT, --DEFINICI�N OBLIGATORIA
	@MENSAJE	VARCHAR(1000)	OUTPUT	--DEFINICI�N OBLIGATORIA


AS

BEGIN TRY

	DECLARE @N_TRANS		INT = 0	 --NUMERO DE TRANSACCIONES ACTIVAS	(@@TRANCOUNT)
	SET @N_TRANS = @@TRANCOUNT

	
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacci�n por encima no hacemos nada
	BEGIN
		BEGIN TRANSACTION TR_MOVIMIENTOS_PICKING
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF ((@INVOKER = 0) 
	AND (dbo.FN_COMPROBAR_DISPONIBILIDAD_PEDIDO(@COD_PETICION) = 1)) --CREAR MOVIMIENTO
	BEGIN
		--CAMBIAR ESTADO DE LA PETICION A ASIGNADO

		--SI EL ESTADO ES DIFERENTE DE ASIGNADO, LO ASIGNAMOS
		IF(	(SELECT ESTADO
			FROM ORDEN_SALIDA_CAB
			WHERE COD_PETICION = @COD_PETICION) != 2)

		BEGIN

			UPDATE ORDEN_SALIDA_CAB
			SET ESTADO = 2
			WHERE COD_PETICION = @COD_PETICION

		END

		DECLARE @CANTIDAD_LINEA INT,
			@CANTIDAD_PALET INT,
			@COD_PALET_MOVIMIENTO INT,
			@COD_REFERENCIA_LINEA VARCHAR(30)

		--OBTENER LOS DATOS DE LA LINEA A A�ADIR

		SELECT @CANTIDAD_LINEA = CANTIDAD, @COD_REFERENCIA_LINEA = COD_REFERENCIA
		FROM ORDEN_SALIDA_LIN
		WHERE @COD_PETICION = COD_PETICION
		AND @COD_LINEA = COD_LINEA

		--OBTENER EL PALET DEL QUE VAMOS A EXTRAER, EN ESTE CASO POR FIFO
		--LOS MOVIMIENTOS PENDIENTES EN ESE PALET MENOS SU CANTIDAD DEBE SER SUPERIOR A LA CANTIDAD QUE QUEREMOS EXTRAER

		SELECT TOP 1 @COD_PALET_MOVIMIENTO = PAL.COD_PALET, @CANTIDAD_PALET = (PAL.CANTIDAD - ISNULL((SELECT SUM(CANTIDAD)
							FROM MOVIMIENTOS_PICKING 
							WHERE REALIZADO = 0
							AND COD_PALET  = PAL.COD_PALET),0)) 
		FROM PALETS PAL
		WHERE PAL.COD_REFERENCIA = @COD_REFERENCIA_LINEA
		AND (PAL.COD_ESTADO = 1 OR PAL.COD_ESTADO = 2)
		AND (PAL.CANTIDAD - ISNULL((SELECT SUM(CANTIDAD)
					FROM MOVIMIENTOS_PICKING 
					WHERE REALIZADO = 0
					AND COD_PALET  = PAL.COD_PALET),0)) > 0
		AND (PAL.COD_ESTADO = 1 OR PAL.COD_ESTADO = 2)
		ORDER BY PAL.FECH_INSERT asc, PAL.COD_PALET asc


		--ACCEDEMOS AL BUCLE EN CASO DE QUE NECESITEMOS COGER DE VARIOS PALETS

			WHILE @CANTIDAD_LINEA > @CANTIDAD_PALET
			BEGIN	
				
				--INSERTAMOS LOS DATOS

				INSERT INTO MOVIMIENTOS_PICKING (COD_PETICION, COD_PALET, FECH_REALIZACION, REALIZADO, CANTIDAD)
				VALUES (@COD_PETICION, @COD_PALET_MOVIMIENTO, GETDATE(), 0, @CANTIDAD_PALET)
				
				--RESTAMOS LA CANTIDAD RECOGIDA PARA POSTERIORMENTE COMPROBAR SI TENEMOS QUE RECOGER DE MAS PALETS

				SET @CANTIDAD_LINEA = @CANTIDAD_LINEA - @CANTIDAD_PALET

				--ASIGNAMOS EL PALET DEL QUE VAMOS A REALIZAR EL MOVIMIENTO

				UPDATE PALETS
				SET COD_ESTADO = 2
				WHERE COD_PALET = @COD_PALET_MOVIMIENTO

				--OBTENEMOS LA INFORMACION DEL SIGUIENTE PALET
				SELECT TOP 1 @COD_PALET_MOVIMIENTO = PAL.COD_PALET, @CANTIDAD_PALET = (PAL.CANTIDAD - ISNULL((SELECT SUM(CANTIDAD)
									FROM MOVIMIENTOS_PICKING 
									WHERE REALIZADO = 0
									AND COD_PALET  = PAL.COD_PALET),0)) 
				FROM PALETS PAL
				WHERE PAL.COD_REFERENCIA = @COD_REFERENCIA_LINEA
				AND (PAL.COD_ESTADO = 1 OR PAL.COD_ESTADO = 2)
				AND (PAL.CANTIDAD - ISNULL((SELECT SUM(CANTIDAD)
							FROM MOVIMIENTOS_PICKING 
							WHERE REALIZADO = 0
							AND COD_PALET  = PAL.COD_PALET),0)) > 0
				ORDER BY PAL.FECH_INSERT asc, PAL.COD_PALET asc

			END 
				
			--INSERTAMOS MOVIMIENTO Y ASIGNAMOS EL PALET

			INSERT INTO MOVIMIENTOS_PICKING (COD_PETICION, COD_PALET, FECH_REALIZACION, REALIZADO, CANTIDAD)
			VALUES (@COD_PETICION, @COD_PALET_MOVIMIENTO, GETDATE(), 0, @CANTIDAD_LINEA)

			

			UPDATE PALETS
			SET COD_ESTADO = 2
			WHERE COD_PALET = @COD_PALET_MOVIMIENTO

			SET @MENSAJE = 'MOVIMIENTO GENERADO'

	END

	IF @INVOKER = 1 --CONFIRMAR MOVIMIENTO
	BEGIN

		
		DECLARE @CANTIDAD_EXTRAIDA INT,
			@CANTIDAD_RESTANTE INT
		
		--OBTENEMOS LAS CANTIDADES DEL PALET DEL QUE HEMOS COGIDO Y LA CANTIDAD QUE HEMOS COGIDO

		SELECT @CANTIDAD_EXTRAIDA = MOV.CANTIDAD, @CANTIDAD_RESTANTE = PAL.CANTIDAD
		FROM MOVIMIENTOS_PICKING MOV
		INNER JOIN PALETS PAL
		ON MOV.COD_PALET = PAL.COD_PALET
		WHERE MOV.COD_MOVIMIENTO = @COD_MOVIMIENTO

		

		--MARCAMOS EL MOVIMIENTO COMO REALIZADO

		UPDATE MOVIMIENTOS_PICKING
		SET REALIZADO = 1
		WHERE COD_MOVIMIENTO = @COD_MOVIMIENTO

		--INSERTAMOS LOS DATOS DE LA PICADA EN EL LOG

		INSERT INTO MOVIMIENTOS_PICKING_LOG (COD_PETICION, COD_PALET, FECH_REALIZACION, CANTIDAD, UBICACION)
		SELECT COD_PETICION, MOV.COD_PALET, FECH_REALIZACION, MOV.CANTIDAD, UBI.COD_UBICACION		
		FROM MOVIMIENTOS_PICKING MOV
		JOIN PALETS PAL
		ON PAL.COD_PALET = MOV.COD_PALET
		JOIN UBICACIONES UBI
		ON UBI.COD_UBICACION = PAL.UBICACION
		WHERE COD_MOVIMIENTO = @COD_MOVIMIENTO
		

		--SI NO EXISTEN MAS MOVIMIENTOS NO REALIZADOS DE ESA PETICION, CAMBIAMOS EL ESTADO DE LA PETICION A EJECUTADO

		IF NOT EXISTS	(SELECT *
				FROM MOVIMIENTOS_PICKING
				WHERE COD_PETICION =
							(SELECT COD_PETICION
							FROM MOVIMIENTOS_PICKING
							WHERE COD_MOVIMIENTO = @COD_MOVIMIENTO)
				AND REALIZADO = 0)
			BEGIN

			UPDATE ORDEN_SALIDA_CAB
			SET ESTADO = 3
			WHERE COD_PETICION =	(SELECT COD_PETICION
						FROM MOVIMIENTOS_PICKING
						WHERE COD_MOVIMIENTO = @COD_MOVIMIENTO)

			END

		--SI LA CANTIDAD QUE EXTRAEMOS ES IGUAL A LA QUE QUEDA EN EL PALET, COGEMOS EL PALET ENTERO Y LO MARCAMOS PARA SALIDA

		IF (@CANTIDAD_RESTANTE - @CANTIDAD_EXTRAIDA) = 0
			BEGIN
				
				--MARCAR LA UBICACION COMO VACIA
				UPDATE UBICACIONES
				SET LLENA = 0
				FROM UBICACIONES UBI
				INNER JOIN PALETS PAL
				ON UBI.COD_UBICACION = PAL.UBICACION
				INNER JOIN MOVIMIENTOS_PICKING MOV
				ON MOV.COD_PALET = PAL.COD_PALET
				WHERE MOV.COD_MOVIMIENTO = @COD_MOVIMIENTO
				
				UPDATE PAL
				SET COD_ESTADO = 4, UBICACION = 'ZR_01_01', PETICION_SALIDA = @COD_PETICION
				FROM PALETS PAL
				INNER JOIN MOVIMIENTOS_PICKING MOV
				ON MOV.COD_PALET = PAL.COD_PALET
				WHERE MOV.COD_MOVIMIENTO = @COD_MOVIMIENTO
			END


		--SI AUN QUEDAN UNIDADES EN EL PALET TRAS EXTRAER, LAS RESTAMOS, LIBERAMOS EL PALET PADRE, ACTUALIZAMOS SU ETIQUETA Y GENERAMOS EL PALET HIJO
		ELSE
			BEGIN

			DECLARE @COD_REFERENCIA VARCHAR(30),
				@ALBARAN INT,
				@COD_PALET INT,
				@CANTIDAD INT;

				SELECT   @COD_REFERENCIA = PAL.COD_REFERENCIA, @ALBARAN= PAL.ALBARAN_RECEPCION, @COD_PALET = PAL.COD_PALET, @COD_PETICION = MOV.COD_PETICION, @CANTIDAD = PAL.CANTIDAD
				FROM PALETS PAL
				INNER JOIN MOVIMIENTOS_PICKING MOV
				ON MOV.COD_PALET = PAL.COD_PALET
				WHERE MOV.COD_MOVIMIENTO = @COD_MOVIMIENTO
				
				UPDATE PALETS
				SET CANTIDAD = @CANTIDAD - @CANTIDAD_EXTRAIDA
				FROM PALETS PAL
				INNER JOIN MOVIMIENTOS_PICKING MOV
				ON MOV.COD_PALET = PAL.COD_PALET
				WHERE MOV.COD_MOVIMIENTO = @COD_MOVIMIENTO

				--SI NO EXISTEN MAS MOVIMIENTOS PARA ESE PALET SIN REALIZAR, CAMBIAMOS EL ESTADO A LIBRE

				IF(NOT EXISTS(SELECT *
					  FROM MOVIMIENTOS_PICKING
					  WHERE COD_PALET = @COD_PALET
					  AND REALIZADO = 0)	)
				BEGIN
					UPDATE PALETS
					SET COD_ESTADO = 1
					WHERE COD_PALET = @COD_PALET
				END

				SET @CANTIDAD = @CANTIDAD - @CANTIDAD_EXTRAIDA

				EXEC PA_GENERAR_ETIQUETA  @COD_PALET, @INVOKER, @USUARIO, @CULTURA, @RETCODE, @MENSAJE

				EXEC PA_PALETS @COD_REFERENCIA, 4, @CANTIDAD_EXTRAIDA, @ALBARAN, @COD_PETICION, @COD_PALET , 3, @USUARIO, @CULTURA, @RETCODE, @MENSAJE 
			END

			SET @MENSAJE = 'MOVIMIENTO CONFIRMADO'
	END

	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacci�n por encima no hacemos nada
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
	IF @N_TRANS = 0 AND @@TRANCOUNT > 0				-- Si hay una transacci�n por encima no hacemos nada
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