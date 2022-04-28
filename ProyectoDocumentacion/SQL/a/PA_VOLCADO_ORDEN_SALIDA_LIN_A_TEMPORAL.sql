USE AYLA1
GO

/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DEL PROCEDIMIENTO:	PA_VOLCADO_ORDEN_SALIDA_LIN_A_TEMPORAL
	FECHA DE CREACIÓN: 		15/03/2022
	AUTOR:				Hector Ramirez Gonzalez
	VSS:				 
	USO:				WINFORMS

	FUNCIONAMIENTO:			Vuelca los datos de las lineas de ORDEN_SALIDA_LIN a la tabla temporal AUX_ORDEN_LIN

	PARAMETROS:			(OPCIONAL)
		PARAMETRO1 		INPUT	EXPLICACION
		PARAMETRO2 		OUTPUT	EXPLICACION

-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:
--	AUTOR:
--	EXPLICACIÓN:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

ALTER PROCEDURE PA_VOLCADO_ORDEN_SALIDA_LIN_A_TEMPORAL
	
	@PETICION	VARCHAR(12),	

	@INVOKER	INT,		-- ESTE PARÁMETRO LO DEBEN TENER TODOS LOS PAS
	@RETCODE	INT OUTPUT, --DEFINICIÓN OBLIGATORIA
	@MENSAJE	VARCHAR(1000)	OUTPUT	--DEFINICIÓN OBLIGATORIA

AS

BEGIN TRY
	

	IF @INVOKER = 1 AND NOT EXISTS (SELECT * FROM ORDEN_SALIDA_LIN WITH(NOLOCK) WHERE PETICION = @PETICION)
	BEGIN
		SET @MENSAJE = 'No existe lineas de ningun pedido.'
		SET @RETCODE = 0
		RETURN @RETCODE
	END

	DECLARE @N_TRANS		INT = 0	 --NUMERO DE TRANSACCIONES ACTIVAS	(@@TRANCOUNT)
	SET @N_TRANS = @@TRANCOUNT

	
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		BEGIN TRANSACTION TR_NOMBRE_TRANSACTION
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @INVOKER = 1	--VOLCAR DATOS DE ORDEN_SALIDA_LIN A AUX_ORDEN_LIN
	BEGIN
		INSERT INTO AUX_ORDEN_LIN(PETICION,LINEA,REFERENCIA,CANTIDAD) 
		SELECT  PETICION,LINEA,REFERENCIA,CANTIDAD
		FROM ORDEN_SALIDA_LIN WHERE PETICION=@PETICION;

		SET @MENSAJE = 'Volcado completado'
	END

	IF @INVOKER = 2 --LIMPIAR TABLA AUXILIAR
	BEGIN
		DELETE AUX_ORDEN_LIN WHERE PETICION = @PETICION
		SET @MENSAJE = 'Volcado completado'
	END


	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		COMMIT TRANSACTION TR_NOMBRE_TRANSACTION
	END
	----------------------------------------------------------------------------------------------------------------------------------------------

	IF @MENSAJE = ''
	BEGIN 
		SET @MENSAJE = 'El proceso se ha realizado correctamente.'
	END

	
	SET @RETCODE = 0
	RETURN @RETCODE
END TRY
BEGIN CATCH
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0 AND @@TRANCOUNT > 0				-- Si hay una transacción por encima no hacemos nada
	BEGIN
		ROLLBACK TRANSACTION TR_NOMBRE_TRANSACTION
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


GO


 

	 
/*----------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------
------------------------------               PRUEBAS              ------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------


	EXEC PA_VOLCADO_ORDEN_SALIDA_LIN_A_TEMPORAL 'P13',1,0,''

	SELECT * FROM AUX_ORDEN_LIN


	DELETE FROM AUX_ORDEN_LIN


------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------
------------------------------             FIN PRUEBAS            ------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------*/
