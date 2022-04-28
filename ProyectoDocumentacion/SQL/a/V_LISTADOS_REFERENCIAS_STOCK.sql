USE AYLA1
GO
 /*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DE LA VISTA:		V_LISTADOS_REFERENCIAS_STOCK
	FECHA DE CREACIÓN: 		09/03/2022
	AUTOR:				Hector Ramirez Gonzalez
	VSS:				 
	USO:				VISUAL

	DESCRIPCION DE LA VISTA:	Vista de las referencias junto a stock disponible

-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:	10/03/2022
--	AUTOR: Hector Ramirez Gonzalez
--	EXPLICACIÓN:	se ha añadido el stock 0 de referencias que no tienen recepciones
------------------------------------------------------------------------------------------------------------------------------------------------------*/

ALTER VIEW V_LISTADOS_REFERENCIAS_STOCK
AS
	SELECT 
	REF.REFERENCIA AS REFERENCIA,
	REF.DES_REFERENCIA AS DESCRIPCION,
	REF.PRECIO AS PRECIO ,
	REF.F_CREACION AS F_CREACION ,
	ISNULL(A1.STOCK,0)-ISNULL(PM.CANTIDAD,0) AS STOCK
        FROM
	 REFERENCIAS REF
	  WITH(NOLOCK) 
	OUTER APPLY(
	
		SELECT SUM(PL.CANTIDAD) AS STOCK FROM PALETS PL  WITH(NOLOCK) WHERE PL.REFERENCIA = REF.REFERENCIA AND PL.ESTADO = 2
	
	) A1
	LEFT OUTER JOIN 
	(
		
		SELECT REFERENCIA,SUM(CANTIDAD) AS CANTIDAD FROM PICKING_MOV WITH(NOLOCK)
		WHERE 
			ESTADO_PICKING = 0
		GROUP BY REFERENCIA

	
	) PM
	ON
	REF.REFERENCIA = PM.REFERENCIA
	 

GO






	SELECT * FROM V_LISTADOS_REFERENCIAS_STOCK

	
	

 