/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DE LA VISTA:		V_ORDEN_SALIDA_INCIDENCIAS
	FECHA DE CREACI�N: 		10/05/2022
	AUTOR:				�scar L�pez
	VSS:				
	USO:				##VISUAL##

	DESCRIPCION DE LA VISTA:	Vista para mostrar la informaci�n detallada de las incidencias de las salidas y presentarlos en tabla

-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACI�N:
--	AUTOR:
--	EXPLICACI�N:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

CREATE VIEW V_ORDEN_SALIDA_INCIDENCIAS AS
SELECT INC.ID_INCIDENCIA, INC.DES_INCIDENCIA, CAB.ESTADO, INC.COD_PETICION, CAB.ID_EMPRESA, CAB.DIRECCION_ENTREGA, CAB.COD_POSTAL, CAB.POBLACION
 
FROM ORDEN_SALIDA_INCIDENCIAS INC

left JOIN ORDEN_SALIDA_CAB CAB
ON INC.COD_PETICION = CAB.COD_PETICION









