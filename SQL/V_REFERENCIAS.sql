/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DE LA VISTA:		V_REFERENCIAS
	FECHA DE CREACI�N: 		04/05/2022
	AUTOR:				�scar L�pez
	VSS:				
	USO:				##VISUAL##

	DESCRIPCION DE LA VISTA:	Vista para mostrar la informaci�n detallada de las referencias y presentarlas en tabla

-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACI�N:
--	AUTOR:
--	EXPLICACI�N:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

CREATE VIEW V_REFERENCIAS AS
SELECT COD_REFERENCIA, ID_EMPRESA, DES_REFERENCIA, PRECIO, FECH_CREACION, IMAGEN, ESTADO, 

dbo.FN_CONSULTAR_STOCK_REFERENCIA(COD_REFERENCIA) AS STOCK
 
FROM REFERENCIAS;








