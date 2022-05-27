/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DE LA VISTA:		V_MOVIMIENTOS_PICKING
	FECHA DE CREACIÓN: 		10/05/2022
	AUTOR:				Óscar López
	VSS:				
	USO:				##VISUAL##

	DESCRIPCION DE LA VISTA:	Vista para mostrar la información detallada de los movimientos de picking y presentarlos en tabla

-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:
--	AUTOR:
--	EXPLICACIÓN:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

CREATE VIEW V_MOVIMIENTOS_PICKING AS
SELECT COD_MOVIMIENTO, COD_PETICION, MOV.COD_PALET, PAL.COD_REFERENCIA, REF.DES_REFERENCIA, 
ISNULL(PAL.UBICACION,'NO EXISTE') AS UBICACION, UBI.CALLE, UBI.POSICION, MOV.CANTIDAD, MOV.REALIZADO
 
FROM MOVIMIENTOS_PICKING MOV
LEFT JOIN PALETS PAL
ON PAL.COD_PALET = MOV.COD_PALET

LEFT JOIN V_REFERENCIAS REF
ON REF.COD_REFERENCIA = PAL.COD_REFERENCIA

LEFT JOIN UBICACIONES UBI
ON PAL.UBICACION = UBI.COD_UBICACION;