/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DE LA VISTA:		V_PALETS
	FECHA DE CREACIÓN: 		04/04/2022
	AUTOR:				Óscar López
	VSS:				
	USO:				##VISUAL##

	DESCRIPCION DE LA VISTA:	Vista para mostrar la información detallada de los palets y presentarlos en tabla

-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:
--	AUTOR:
--	EXPLICACIÓN:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

CREATE VIEW V_PALETS AS
SELECT PAL.COD_PALET, EST.DESC_ESTADO,PAL.COD_ESTADO, COD_REFERENCIA, PAL.CANTIDAD, ISNULL(PAL.UBICACION,'No disponible') as UBICACION, 
		ISNULL(UBI.DESC_UBICACION,'') as DESC_UBICACION, ISNULL(UBI.CALLE,'') as CALLE, ISNULL(UBI.POSICION,'') as POSICION, PAL.FECH_INSERT,  
		ISNULL(PAL.ALBARAN_RECEPCION,'') as ALBARAN_RECEPCION, ISNULL(PAL.PETICION_SALIDA,'') as PETICION_SALIDA, ISNULL(PAL.PALET_PADRE,'') as PALET_PADRE
 
FROM PALETS PAL

left JOIN UBICACIONES UBI
ON PAL.UBICACION = UBI.COD_UBICACION

left JOIN ESTADOS_PALETS EST
ON PAL.COD_ESTADO = EST.COD_ESTADO;








