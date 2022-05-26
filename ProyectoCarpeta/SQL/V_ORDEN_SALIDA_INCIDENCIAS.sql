/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DE LA VISTA:		V_ORDEN_SALIDA_INCIDENCIAS
	FECHA DE CREACIÓN: 		10/05/2022
	AUTOR:				Óscar López
	VSS:				
	USO:				##VISUAL##

	DESCRIPCION DE LA VISTA:	Vista para mostrar la información detallada de las incidencias de las salidas y presentarlos en tabla

-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:
--	AUTOR:
--	EXPLICACIÓN:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

CREATE VIEW V_ORDEN_SALIDA_INCIDENCIAS AS
SELECT INC.ID_INCIDENCIA, INC.DES_INCIDENCIA, CAB.ESTADO, INC.COD_PETICION, CAB.ID_EMPRESA, CAB.DIRECCION_ENTREGA, CAB.COD_POSTAL, CAB.POBLACION
 
FROM ORDEN_SALIDA_INCIDENCIAS INC

left JOIN ORDEN_SALIDA_CAB CAB
ON INC.COD_PETICION = CAB.COD_PETICION









