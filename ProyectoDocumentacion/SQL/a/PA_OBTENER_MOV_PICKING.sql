USE AYLA1
GO

/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DEL PROCEDIMIENTO:	PA_OBTENER_MOV_PICKING
	FECHA DE CREACIÓN: 		17/03/2022
	AUTOR:				Hector Ramirez Gonzalez
	VSS:				 
	USO:				WINFORMS

	FUNCIONAMIENTO:			PA que obtiene las picadas del picking.Recibe la picada anterior que la cambiara de estado
				        y devuelve la siguiente picada del pedido.  
					
					Invoker = 0 Primera picada
					Invoker = 1 Recibe la picada anterior, la cambia de estado y devuelve la siguiente
					Invoker = 2 

	PARAMETROS:			(OPCIONAL)
		PARAMETRO1 		INPUT	EXPLICACION
		PARAMETRO2 		OUTPUT	EXPLICACION

-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:
--	AUTOR:
--	EXPLICACIÓN:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

ALTER PROCEDURE PA_OBTENER_MOV_PICKING
	
	@PETICION	VARCHAR(12),
	@LINEA		INT,
	@REFERENCIA	VARCHAR(20),
	@CANTIDAD	INT,
	@PALET		INT,
	@UBICACION	VARCHAR(30),	
	 

	@INVOKER	INT,		-- ESTE PARÁMETRO LO DEBEN TENER TODOS LOS PAS
	 

	@RETCODE	INT OUTPUT, --DEFINICIÓN OBLIGATORIA
	@MENSAJE	VARCHAR(1000)	OUTPUT	--DEFINICIÓN OBLIGATORIA

AS

BEGIN TRY
	
	DECLARE @N_PICADAS INT
	DECLARE @N_TRANS		INT = 0	 --NUMERO DE TRANSACCIONES ACTIVAS	(@@TRANCOUNT)
	SET @N_TRANS = @@TRANCOUNT

	IF NOT EXISTS ( SELECT * FROM PICKING_MOV  WITH (NOLOCK) WHERE PEDIDO = @PETICION )
	BEGIN

		SET @MENSAJE = 'No existe movimientos de este pedido.'
		SET @RETCODE = -2
		
		RETURN @RETCODE
	END

	IF NOT EXISTS ( SELECT * FROM PICKING_MOV WITH (NOLOCK) WHERE PEDIDO = @PETICION AND ESTADO_PICKING = 0 ) -- SI NO HAY PICADAS DISPONICLES
		--SET @INVOKER = 2
	BEGIN

		SET @MENSAJE = 'No picadas disponibles.'
		SET @RETCODE = -2
		
		RETURN @RETCODE
	END


	IF @INVOKER = 0 -- OBTENER PRIMERA PICADA
	BEGIN
		
		SELECT TOP 1 * FROM PICKING_MOV WHERE PEDIDO =  @PETICION AND ESTADO_PICKING = 0

		SET @MENSAJE = 'Primera picada'
		SET @RETCODE = 0
		
		RETURN @RETCODE
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		BEGIN TRANSACTION TR_OBTENER_MOV_PICKING
	END
	----------------------------------------------------------------------------------------------------------------------------------------------

	

	IF @INVOKER = 1 -- OBTENER SEGUNDA PICADA y UPDATE DE LA ANTERIOR
	BEGIN

		
		
		SELECT @N_PICADAS = COUNT(*) FROM PICKING_MOV WHERE PEDIDO = @PETICION AND ESTADO_PICKING = 0	

		PRINT @N_PICADAS
		SET @MENSAJE = 'NO HAY PICADAS (0)'

		IF @N_PICADAS > 1
		BEGIN
			 	 
			
			UPDATE PICKING_MOV 
			SET ESTADO_PICKING = 1 
			WHERE
			PEDIDO =  @PETICION 
			AND 
			LINEA = @LINEA
			AND 
			REFERENCIA = @REFERENCIA
			AND
			CANTIDAD = @CANTIDAD
			AND 
			PALET = @PALET
			AND
			UBICACION = @UBICACION

			PRINT @N_PICADAS

			

			SET @MENSAJE = 'SIGUIENTE PICADA'
			SET @RETCODE = 0
		
			 

		END

		IF @N_PICADAS = 1
		BEGIN
		      
			 

			UPDATE PICKING_MOV 
			SET ESTADO_PICKING = 1 
			WHERE
			PEDIDO =  @PETICION 
			AND 
			LINEA = @LINEA
			AND 
			REFERENCIA = @REFERENCIA
			AND
			CANTIDAD = @CANTIDAD
			AND 
			PALET = @PALET
			AND
			UBICACION =  @UBICACION;

			UPDATE PL SET ESTADO = 3,PETICION = @PETICION
			FROM 
			PICKING_MOV PM
			INNER JOIN 
			PALETS PL
			ON 
			PM.PALET = PL.PALET
			WHERE 
			PM.PEDIDO = @PETICION 
			AND 
			ESTADO_PICKING = 1 
			AND 
			PL.CANTIDAD = PM.CANTIDAD

			--CREAR PALETS HIJOS
			INSERT INTO PALETS(REFERENCIA,CANTIDAD,
			ESTADO,UBICACION,F_INSERT,PALET_PADRE,PETICION)
			SELECT PM.REFERENCIA,PM.CANTIDAD,3,'U007',GETDATE(),PL.PALET,@PETICION FROM PICKING_MOV PM
			INNER JOIN 
			PALETS PL
			ON 
			PM.PALET = PL.PALET
			WHERE 
			PM.PEDIDO = @PETICION 
			AND 
			ESTADO_PICKING = 1 
			AND 
			PL.CANTIDAD > PM.CANTIDAD ;

			

			--ACTUALIZAR PALETS
			UPDATE PL SET CANTIDAD = (PL.CANTIDAD-PM.CANTIDAD)
			FROM 
			PALETS PL
			INNER JOIN 
			PICKING_MOV PM
			ON 
			PM.PALET = PL.PALET
			WHERE 
			PM.PEDIDO = @PETICION 
			AND 
			ESTADO_PICKING = 1 
			AND 
			PL.CANTIDAD > PM.CANTIDAD;


			UPDATE ORDEN_SALIDA_CAB SET ID_ESTADO = 5  WHERE PETICION =  @PETICION



			SET @MENSAJE = 'Picking finalizado'
			SET @RETCODE = 1 

		END

		


	END


	--IF @INVOKER = 2 -- PICADA FINAL
	--BEGIN



	--	UPDATE PICKING_MOV 
	--	SET ESTADO_PICKING = 1 
	--	WHERE
	--	PEDIDO =  @PETICION 
	--	AND 
	--	LINEA = @LINEA
	--	AND 
	--	REFERENCIA = @REFERENCIA
	--	AND
	--	CANTIDAD = @CANTIDAD
	--	AND 
	--	PALET = @PALET
	--	AND
	--	UBICACION =  @UBICACION;


	--	SELECT TOP 1 * FROM PICKING_MOV WHERE PEDIDO =  @PETICION AND ESTADO_PICKING = 0

	--	SET @MENSAJE = 'Picking finalizado'
	--	SET @RETCODE = 0
		
	--	RETURN @RETCODE


	--END

	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		COMMIT TRANSACTION TR_OBTENER_MOV_PICKING
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	
	IF @INVOKER = 1
	BEGIN
		SELECT TOP 1 * FROM PICKING_MOV WHERE PEDIDO = @PETICION AND ESTADO_PICKING = 0
	END

	IF @MENSAJE = ''
	BEGIN
		SET @MENSAJE = 'El proceso se ha realizado correctamente.'
	END
	 
	 
	RETURN @RETCODE
END TRY
BEGIN CATCH
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0 AND @@TRANCOUNT > 0				-- Si hay una transacción por encima no hacemos nada
	BEGIN
		ROLLBACK TRANSACTION TR_OBTENER_MOV_PICKING
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
