USE AYLA1
GO
 /*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DE LA VISTA:		V_PEDIDOS_Y_ESTADO
	FECHA DE CREACIÓN: 		10/03/2022
	AUTOR:				Hector Ramirez Gonzalez
	VSS:				 
	USO:				VISUAL

	DESCRIPCION DE LA VISTA:	Vista de pedidos y su estado

-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:	
--	AUTOR: 
--	EXPLICACIÓN:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/


ALTER VIEW V_PEDIDOS_Y_ESTADO
AS
	SELECT 
		OSB.PETICION,
		OSB.NOMBRE_CLIENTE AS 'NOMBRE CLIENTE',
		OSB.TELEFONO AS TELEFONO,
		OSB.DIRECCION_ENTREGA AS 'DIRECCION ENTREGA',
		OSB.CODIGO_POSTAL AS 'CODIGO POSTAL',
		OSB.PROVINCIA AS PROVINCIA,
		OSB.POBLACION AS POBLACION,
		OSB.F_CREACION AS 'FECHA CREACION',
		OSB.ID_ESTADO AS 'ID_ESTADO',
		EP.DESC_ESTADO AS ESTADO
 
        FROM ORDEN_SALIDA_CAB OSB WITH(NOLOCK) 
	INNER JOIN 
	ESTADOS_PEDIDOS EP WITH(NOLOCK) 
	ON
	EP.ID_ESTADO = OSB.ID_ESTADO;

GO

select * from ESTADOS_PEDIDOS;