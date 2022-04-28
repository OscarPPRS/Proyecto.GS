USE AYLA1
GO

/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DEL PROCEDIMIENTO:	PA_ORDEN_INSERT_LINEA_TEMPORAL
	FECHA DE CREACIÓN: 		11/03/2022
	AUTOR:				Hector Ramirez Gonzalez
	VSS:				 
	USO:				WinForms

	FUNCIONAMIENTO:			Inserta en una tabla temporal los datos de la linea de una orden salida lin

	PARAMETROS:			(OPCIONAL)
		PARAMETRO1 		INPUT	EXPLICACION
		PARAMETRO2 		OUTPUT	EXPLICACION

-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:
--	AUTOR:
--	EXPLICACIÓN:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

ALTER PROCEDURE PA_ORDEN_INSERT_LINEA_TEMPORAL
	
	@PETICION	VARCHAR(12),
	@REFERENCIA	VARCHAR(20),
	@CANTIDAD	INT,

	@INVOKER	INT,		-- ESTE PARÁMETRO LO DEBEN TENER TODOS LOS PAS
	 
	@RETCODE	INT OUTPUT, --DEFINICIÓN OBLIGATORIA
	@MENSAJE	VARCHAR(1000)	OUTPUT	--DEFINICIÓN OBLIGATORIA

AS	

BEGIN TRY


	IF NOT EXISTS (SELECT * FROM REFERENCIAS WITH(NOLOCK) WHERE REFERENCIA=@REFERENCIA)
	BEGIN
		
		SET	@MENSAJE = 'NO EXISTE REFERENCIA'
		SET	@RETCODE = -1
		
		RETURN	@RETCODE 

	END 

	IF @INVOKER = 0 AND EXISTS (SELECT REFERENCIA FROM AUX_ORDEN_LIN WITH(NOLOCK) WHERE PETICION = @PETICION AND REFERENCIA = @REFERENCIA)	--CAMBIA INVOKER SI YA EXISTE LINEA 
	BEGIN
		 
		SET @INVOKER = 1 -- CAMBIAR A MODIFICAR
	END
	
	DECLARE @N_TRANS		INT = 0	 --NUMERO DE TRANSACCIONES ACTIVAS	(@@TRANCOUNT)
	SET @N_TRANS = @@TRANCOUNT
	
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		BEGIN TRANSACTION TR_ORDEN_INSERT_LINEA_TEMPORAL
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
 
	IF @INVOKER = 0		--INSERTAR LINEA
	BEGIN
		
		DECLARE @LIN_NEXT INT;
	
		SELECT @LIN_NEXT = COUNT(*) FROM AUX_ORDEN_LIN WITH(NOLOCK) WHERE PETICION = @PETICION;

		SET @LIN_NEXT = @LIN_NEXT+1; --SIGUIENTE LINEA
		
		INSERT INTO AUX_ORDEN_LIN VALUES(@PETICION,@LIN_NEXT,@REFERENCIA,@CANTIDAD);

		SET @MENSAJE = 'INSERTADO'
		SET @RETCODE = 0
		


	END



	IF @INVOKER = 1		--MODIFICAR LINEA
	BEGIN
	
		UPDATE AUX_ORDEN_LIN SET CANTIDAD = @CANTIDAD WHERE PETICION = @PETICION AND REFERENCIA = @REFERENCIA
		
		SET @MENSAJE = 'MODIFICADO CORRECTAMENTE'
		SET @RETCODE = 0
		
		 
	END


	IF @INVOKER = 2		-- ELIMINAR LINEA
	BEGIN

		DELETE AUX_ORDEN_LIN WHERE PETICION = @PETICION AND REFERENCIA = @REFERENCIA
	
		UPDATE AUX_ORDEN_LIN SET LINEA = O1.LINEA  FROM AUX_ORDEN_LIN T1 OUTER APPLY 
		( SELECT T2.REFERENCIA AS REFERENCIA,ROW_NUMBER() OVER(ORDER BY T2.LINEA ASC) AS LINEA 
		FROM AUX_ORDEN_LIN T2 WHERE T2.PETICION = T1.PETICION  ) O1 WHERE T1.REFERENCIA = O1.REFERENCIA
		
		SET @MENSAJE = 'LINEA ELIMINADA CORRECTAMENTE'
		SET @RETCODE = 0
		
		 
	END


	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		COMMIT TRANSACTION TR_ORDEN_INSERT_LINEA_TEMPORAL
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
		ROLLBACK TRANSACTION TR_ORDEN_INSERT_LINEA_TEMPORAL
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


DECLARE @N_TRANS		INT = 0	 --NUMERO DE TRANSACCIONES ACTIVAS	(@@TRANCOUNT)
SET @N_TRANS = @@TRANCOUNT

PRINT @N_TRANS

DECLARE @MESS VARCHAR(1000)
DECLARE @RET INT

EXEC PA_ORDEN_INSERT_LINEA_TEMPORAL
 @PETICION = 'P03',
 @REFERENCIA='A01',
 @CANTIDAD =10,
 @INVOKER=2, 
 @RETCODE=@RET OUTPUT, 
 @MENSAJE = @MESS OUTPUT

SELECT * FROM AUX_ORDEN_LIN;
SELECT @MESS;

SELECT AOL.LINEA,AOL.REFERENCIA,REF.DES_REFERENCIA AS DESCRIPCION,REF.PRECIO AS PRECIO ,AOL.CANTIDAD AS CANTIDAD
 FROM AUX_ORDEN_LIN AOL INNER JOIN REFERENCIAS REF ON REF.REFERENCIA=AOL.REFERENCIA
WHERE PETICION = 'P01';
 
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
