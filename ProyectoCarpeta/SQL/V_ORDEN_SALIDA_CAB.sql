/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DE LA VISTA:		V_ORDEN_SALIDA_CAB
	FECHA DE CREACIÓN: 		24/04/2022
	AUTOR:				Óscar López
	VSS:				
	USO:				##VISUAL##

	DESCRIPCION DE LA VISTA:	Vista para mostrar la información detallada de las cabeceras de ordenes de salida y presentarlos en tabla

-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:
--	AUTOR:
--	EXPLICACIÓN:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

CREATE VIEW V_ORDEN_SALIDA_CAB AS

SELECT COD_PETICION, ESTADO, DES_ESTADO, ORDEN_SALIDA_CAB.ID_EMPRESA, DES_EMPRESA, DIRECCION_ENTREGA, COD_POSTAL, POBLACION, PROVINCIA, TELEFONO, FECH_CREACION,

(SELECT COUNT(*)
FROM ORDEN_SALIDA_LIN
WHERE ORDEN_SALIDA_CAB.COD_PETICION = ORDEN_SALIDA_LIN.COD_PETICION) AS CANTIDAD_LINEAS

FROM ORDEN_SALIDA_CAB
LEFT JOIN ESTADOS_ORDEN_SALIDA
ON ESTADO = COD_ESTADO
LEFT JOIN EMPRESAS
ON ORDEN_SALIDA_CAB.ID_EMPRESA = EMPRESAS.ID_EMPRESA;