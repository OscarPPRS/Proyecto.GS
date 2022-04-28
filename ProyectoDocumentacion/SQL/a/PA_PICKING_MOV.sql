USE AYLA1;
GO

/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DEL PROCEDIMIENTO:	PA_PICKING_MOV
	FECHA DE CREACIÓN: 		16/03/2022
	AUTOR:				Héctor Ramirez Gonzalez
	VSS:				 
	USO:				WinForms

	FUNCIONAMIENTO:			GENERA EL LOG DE MOVIMIENTO PICKING

	PARAMETROS:			(OPCIONAL)
		PARAMETRO1 		INPUT	EXPLICACION
		PARAMETRO2 		OUTPUT	EXPLICACION

-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:
--	AUTOR:
--	EXPLICACIÓN:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

ALTER PROCEDURE PA_PICKING_MOV
	
	@PETICION VARCHAR(20),	
	 

	@INVOKER	INT,		-- ESTE PARÁMETRO LO DEBEN TENER TODOS LOS PAS
	 

	@RETCODE	INT OUTPUT, --DEFINICIÓN OBLIGATORIA
	@MENSAJE	VARCHAR(1000)	OUTPUT	--DEFINICIÓN OBLIGATORIA

AS
BEGIN TRY

	DECLARE C_PEDIDO_REFS CURSOR
	FOR SELECT LINEA,REFERENCIA,CANTIDAD FROM ORDEN_SALIDA_LIN WHERE PETICION = @PETICION


	DECLARE @LINEA INT
	DECLARE @REFERENCIA VARCHAR(20)
	DECLARE @CANTIDAD INT


	IF NOT EXISTS (SELECT * FROM ORDEN_SALIDA_LIN WHERE PETICION = @PETICION)
	BEGIN

		SET @MENSAJE = 'NO EXISTE PEDIDO'
		SET @RETCODE = -1
		
		RETURN @RETCODE
	END

	
	IF NOT EXISTS (SELECT * FROM ORDEN_SALIDA_CAB WHERE PETICION = @PETICION  AND ID_ESTADO = 2)
	BEGIN

		SET @MENSAJE = 'NO ESTA TRASPASADO A ICP'
		SET @RETCODE = -1
		
		RETURN @RETCODE
	END


	
	DECLARE @N_TRANS		INT = 0	 --NUMERO DE TRANSACCIONES ACTIVAS	(@@TRANCOUNT)
	SET @N_TRANS = @@TRANCOUNT
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0		
					-- Si hay una transacción por encima no hacemos nada
	BEGIN
		BEGIN TRANSACTION TR_PA_PICKING_MOV
	END
	----------------------------------------------------------------------------------------------------------------------------------------------

	IF @INVOKER = 0
	BEGIN
		
		OPEN C_PEDIDO_REFS -- ABRIR CURSOR

		FETCH NEXT FROM C_PEDIDO_REFS 
		INTO @LINEA,  @REFERENCIA ,@CANTIDAD
	
		WHILE @@FETCH_STATUS = 0  
		BEGIN  
			
			DECLARE @STOCK_BAJO INT

			
			DECLARE @ID_PALET INT
			DECLARE @UBI VARCHAR(30)

			WHILE @CANTIDAD > 0
			BEGIN
				SET  @STOCK_BAJO = 0

				SET @ID_PALET = NULL
				SET @UBI = NULL
				
				-- Recoge el el id palet si el stock del palet es superior
				SELECT TOP 1 @ID_PALET =ISNULL(PL.PALET,0), @UBI=ISNULL(PL.UBICACION,'') 
				FROM 
				PALETS PL WITH(NOLOCK)
				OUTER APPLY(
				SELECT SUM(ISNULL(PM.CANTIDAD,0)) AS CANTIDAD 
				FROM PICKING_MOV PM WITH(NOLOCK)
				WHERE 
				PL.PALET = PM.PALET AND PM.ESTADO_PICKING = 0) O1
				WHERE 
				PL.ESTADO = 2 AND  PL.REFERENCIA = @REFERENCIA 
				AND  
				(PL.CANTIDAD-ISNULL(O1.CANTIDAD,0)) > @CANTIDAD ORDER BY F_INSERT ASC 

			 
				PRINT  @CANTIDAD

				IF @ID_PALET IS NULL AND @UBI IS NULL
				BEGIN
					 

					

					SELECT TOP 1 @ID_PALET =ISNULL( PL.PALET,0), @UBI=ISNULL(PL.UBICACION,'') 
					FROM 
					PALETS PL WITH(NOLOCK)
					OUTER APPLY(
					SELECT SUM(ISNULL(PM.CANTIDAD,0)) AS CANTIDAD 
					FROM PICKING_MOV PM WITH(NOLOCK)
					WHERE 
					PL.PALET = PM.PALET AND PM.ESTADO_PICKING = 0) O1
					WHERE 
					PL.ESTADO = 2 AND  PL.REFERENCIA = @REFERENCIA 
					AND  
					(PL.CANTIDAD-ISNULL(O1.CANTIDAD,0)) = @CANTIDAD ORDER BY F_INSERT ASC 

					PRINT CONCAT(@CANTIDAD,'  A  ')

					IF @ID_PALET IS NOT NULL
					BEGIN
						UPDATE PALETS SET ESTADO = 5  WHERE PALET = @ID_PALET
					END
			
				END

			 
			
				--PALET BAJO
				IF @ID_PALET IS NULL AND @UBI IS NULL
				BEGIN
				
					PRINT CONCAT(@CANTIDAD,'  A  ')
				 
			 
					SELECT TOP 1 @ID_PALET =ISNULL( PL.PALET,0), @UBI=ISNULL(PL.UBICACION,'') ,
					@STOCK_BAJO =  (PL.CANTIDAD-ISNULL(O1.CANTIDAD,0))
					FROM 
					PALETS PL
					OUTER APPLY(
					SELECT SUM(ISNULL(PM.CANTIDAD,0)) AS CANTIDAD 
					FROM PICKING_MOV PM
					WHERE 
					PL.PALET = PM.PALET AND PM.ESTADO_PICKING = 0) O1
					WHERE 
					PL.ESTADO = 2 AND  PL.REFERENCIA = @REFERENCIA 
					AND  
					(PL.CANTIDAD-ISNULL(O1.CANTIDAD,0)) < @CANTIDAD ORDER BY F_INSERT ASC 
					 
					PRINT @STOCK_BAJO

					
					IF @ID_PALET IS NOT NULL
					BEGIN
						SET  @CANTIDAD = @CANTIDAD - @STOCK_BAJO

						UPDATE PALETS SET ESTADO = 5  WHERE PALET = @ID_PALET
					

						INSERT INTO PICKING_MOV(PEDIDO,LINEA,REFERENCIA,CANTIDAD,PALET,UBICACION,ESTADO_PICKING)
						VALUES(@PETICION,@LINEA,@REFERENCIA,@STOCK_BAJO,@ID_PALET,@UBI,0)
					END
			 
				END

	
				IF @STOCK_BAJO = 0
				BEGIN
					INSERT INTO PICKING_MOV(PEDIDO,LINEA,REFERENCIA,CANTIDAD,PALET,UBICACION,ESTADO_PICKING)
					VALUES(@PETICION,@LINEA,@REFERENCIA,@CANTIDAD,@ID_PALET,@UBI,0)

					SET @CANTIDAD = @STOCK_BAJO
				END
			 
			


			END

			FETCH NEXT FROM C_PEDIDO_REFS 
			INTO @LINEA,  @REFERENCIA ,@CANTIDAD

		END -- FIN BUCLE


		UPDATE ORDEN_SALIDA_CAB SET ID_ESTADO = 7 WHERE PETICION =  @PETICION

		CLOSE C_PEDIDO_REFS
		DEALLOCATE C_PEDIDO_REFS

		

	END -- FIN INVOKER


	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		COMMIT TRANSACTION TR_PA_PICKING_MOV
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
		ROLLBACK TRANSACTION  TR_PA_PICKING_MOV
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @MENSAJE = '' 
	BEGIN
		SET  @MENSAJE = ERROR_MESSAGE()
	END
	
	DEALLOCATE C_PEDIDO_REFS

	SET @RETCODE = -1
		
	RETURN @RETCODE
END CATCH

	SET @RETCODE = -1		
	RETURN @RETCODE




/*----------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------
------------------------------               PRUEBAS              ------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------


DECLARE @RETCODE	INT
DECLARE @PARAMETRO1	VARCHAR(10)
DECLARE @PARAMETRO2	INT
DECLARE @PARAMETRO3	VARCHAR(20)
DECLARE @MENSAJE	VARCHAR(1000)

SET @MENSAJE 		= ''

EXEC @RETCODE = PA_XXXX @PARAMETRO1, @PARAMETRO2, @PARAMETRO3 OUTPUT, @MENSAJE OUTPUT

PRINT 'RETCODE:	' 	+ ISNULL(CAST(@RETCODE AS VARCHAR(10)), 'NULO')
PRINT 'MENSAJE:	' 	+ ISNULL(@MENSAJE, 'NULO')
PRINT 'PARAMETRO3''	+ ISNULL(@PARAMETRO3, 'NULO')



------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------
------------------------------             FIN PRUEBAS            ------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------*/
