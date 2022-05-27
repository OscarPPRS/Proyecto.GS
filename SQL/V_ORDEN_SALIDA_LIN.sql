/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DE LA VISTA:		V_ORDEN_SALIDA_LIN
	FECHA DE CREACI�N: 		10/05/2022
	AUTOR:				�scar L�pez
	VSS:				
	USO:				##VISUAL##

	DESCRIPCION DE LA VISTA:	Vista para mostrar la informaci�n detallada de las lineas de las salidas y presentarlos en tabla

-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACI�N:
--	AUTOR:
--	EXPLICACI�N:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

CREATE VIEW V_ORDEN_SALIDA_LIN AS
SELECT COD_PETICION, COD_LINEA, ORDEN_SALIDA_LIN.COD_REFERENCIA, REFERENCIAS.DES_REFERENCIA, CANTIDAD, REFERENCIAS.PRECIO , STOCK
 
FROM ORDEN_SALIDA_LIN
LEFT JOIN REFERENCIAS
ON ORDEN_SALIDA_LIN.COD_REFERENCIA = REFERENCIAS.COD_REFERENCIA

LEFT JOIN V_REFERENCIAS
ON V_REFERENCIAS.COD_REFERENCIA = ORDEN_SALIDA_LIN.COD_REFERENCIA;