/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DE LA FUNCI�N		FN_CONSULTAR_STOCK_REFERENCIA
	FECHA DE CREACI�N: 		28/04/2022		
	AUTOR:				�scar L�pez
	VSS:				
	USO:				##VISUAL##

	FUNCIONAMIENTO:			Devuelve el stock a partir del c�digo de referencia que se entregue

	PARAMETROS:			(OPCIONAL)
		PARAMETRO1 		INPUT	EXPLICACION
		PARAMETRO2 		OUTPUT	EXPLICACION

-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACI�N:
--	AUTOR:
--	EXPLICACI�N:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

CREATE FUNCTION dbo.FN_CONSULTAR_STOCK_REFERENCIA
(@COD_REFERENCIA AS VARCHAR(30))

RETURNS INT

AS 

BEGIN

	DECLARE  @CANTIDAD_TOTAL INT,
		 @CANTIDAD_BLOQUEADA INT,
		 @STOCK INT

	--Se obtiene la cantidad de unidades en palets libres o asignados

	SELECT @CANTIDAD_TOTAL = SUM(CANTIDAD) 
	FROM PALETS 
	WHERE PALETS.COD_REFERENCIA = @COD_REFERENCIA
	AND (COD_ESTADO = 1 OR COD_ESTADO = 2)

	--Se le resta la cantidad de los movimientos pendientes de realizar

	SELECT @CANTIDAD_BLOQUEADA = SUM(MOVIMIENTOS_PICKING.CANTIDAD)
	FROM MOVIMIENTOS_PICKING	
	JOIN PALETS
	ON MOVIMIENTOS_PICKING.COD_PALET = PALETS.COD_PALET
	AND COD_REFERENCIA = @COD_REFERENCIA
	WHERE REALIZADO = 0

	SET @STOCK = ISNULL(@CANTIDAD_TOTAL,0)-ISNULL(@CANTIDAD_BLOQUEADA,0)

   RETURN @STOCK

END;