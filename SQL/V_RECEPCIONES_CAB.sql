/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DE LA VISTA:		V_RECEPCIONES_CAB
	FECHA DE CREACI�N: 		10/05/2022
	AUTOR:				�scar L�pez
	VSS:				
	USO:				##VISUAL##

	DESCRIPCION DE LA VISTA:	Vista para mostrar la informaci�n detallada de las cabeceras de las recepciones y presentarlos en tabla

-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACI�N:
--	AUTOR:
--	EXPLICACI�N:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

CREATE VIEW V_RECEPCIONES_CAB AS

SELECT ALBARAN, ESTADO, DES_ESTADO, RECEPCIONES_CAB.ID_EMPRESA, EMPRESAS.DES_EMPRESA, FECH_CREACION, FECH_LLEGADA,

(SELECT COUNT(*)
FROM RECEPCIONES_LIN
WHERE RECEPCIONES_CAB.ALBARAN = RECEPCIONES_LIN.ALBARAN) AS CANTIDAD_LINEAS

FROM RECEPCIONES_CAB
LEFT JOIN ESTADOS_RECEPCION
ON ESTADO = COD_ESTADO

LEFT JOIN EMPRESAS
ON RECEPCIONES_CAB.ID_EMPRESA = EMPRESAS.ID_EMPRESA;
;