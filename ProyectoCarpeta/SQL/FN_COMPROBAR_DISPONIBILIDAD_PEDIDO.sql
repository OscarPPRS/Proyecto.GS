/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DE LA FUNCIÓN		FN_COMPROBAR_DISPONIBILIDAD_PEDIDO
	FECHA DE CREACIÓN: 		04/05/2022		
	AUTOR:				Óscar López
	VSS:				
	USO:				##VISUAL##

	FUNCIONAMIENTO:			Comprueba el stock de una petición para que el programa sepa si puede asignar ese pedido.

	PARAMETROS:			(OPCIONAL)
		PARAMETRO1 		INPUT	EXPLICACION
		PARAMETRO2 		OUTPUT	EXPLICACION

-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:
--	AUTOR:
--	EXPLICACIÓN:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

CREATE FUNCTION dbo.FN_COMPROBAR_DISPONIBILIDAD_PEDIDO
(@PETICION AS INT)

RETURNS BIT

AS 

BEGIN

	--Consulta las lineas de una peticion y si hay alguna linea en la que no hay stock, devuelve false

	DECLARE  @REFERENCIA VARCHAR(30),
		 @FILAS_DEVUELTAS INT = 0,
		 @SALIDA BIT = 0

	--Consulta que devuelve solo las filas en las que no hay stock
	SELECT  @FILAS_DEVUELTAS += 1
	FROM ORDEN_SALIDA_LIN
	JOIN ORDEN_SALIDA_CAB
	ON ORDEN_SALIDA_CAB.COD_PETICION = ORDEN_SALIDA_LIN.COD_PETICION
	WHERE ORDEN_SALIDA_LIN.COD_PETICION = @PETICION
	AND CANTIDAD > dbo.FN_CONSULTAR_STOCK_REFERENCIA(COD_REFERENCIA)
	AND ESTADO = 1

	--Si no sale ninguna fila, devuelve true

	IF @FILAS_DEVUELTAS = 0
	BEGIN
		SET @SALIDA = 1
	END

	RETURN @SALIDA	
END;



