/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DE LA VISTA:		V_REFERENCIAS
	FECHA DE CREACIÓN: 		04/05/2022
	AUTOR:				Óscar López
	VSS:				
	USO:				##VISUAL##

	DESCRIPCION DE LA VISTA:	Vista para mostrar la información detallada de las referencias y presentarlas en tabla

-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:
--	AUTOR:
--	EXPLICACIÓN:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

CREATE VIEW V_REFERENCIAS AS
SELECT COD_REFERENCIA, ID_EMPRESA, DES_REFERENCIA, PRECIO, FECH_CREACION, IMAGEN, ESTADO, 

dbo.FN_CONSULTAR_STOCK_REFERENCIA(COD_REFERENCIA) AS STOCK
 
FROM REFERENCIAS;








