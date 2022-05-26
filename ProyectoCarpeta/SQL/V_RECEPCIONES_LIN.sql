/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DE LA VISTA:		V_RECEPCIONES_LIN
	FECHA DE CREACIÓN: 		10/05/2022
	AUTOR:				Óscar López
	VSS:				
	USO:				##VISUAL##

	DESCRIPCION DE LA VISTA:	Vista para mostrar la información detallada de las lineas de las recepciones y presentarlos en tabla

-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:
--	AUTOR:
--	EXPLICACIÓN:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

CREATE VIEW V_RECEPCIONES_LIN AS
SELECT ALBARAN, COD_LINEA, RECEPCIONES_LIN.COD_REFERENCIA, REFERENCIAS.DES_REFERENCIA, CANTIDAD, CANTIDAD_MAL_ESTADO, EXCEDENTE, FALTA, REFERENCIAS.PRECIO , STOCK
 
FROM RECEPCIONES_LIN
LEFT JOIN REFERENCIAS
ON RECEPCIONES_LIN.COD_REFERENCIA = REFERENCIAS.COD_REFERENCIA

LEFT JOIN V_REFERENCIAS
ON V_REFERENCIAS.COD_REFERENCIA = RECEPCIONES_LIN.COD_REFERENCIA;