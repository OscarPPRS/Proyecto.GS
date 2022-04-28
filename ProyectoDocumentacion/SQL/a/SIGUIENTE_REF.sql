




/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DEL PROCEDIMIENTO:	PA_SALIDA_CAB
	FECHA DE CREACIÓN: 		08/03/2022
	AUTOR:				Hector Ramirez Gonzalez
	VSS:				 
	USO:				WINFORMS

	FUNCIONAMIENTO:			INSERTA,MODIFICA,Y ELIMINA CREA PEDIDO DE SALIDA


-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:
--	AUTOR:
--	EXPLICACIÓN:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

BEGIN


	DECLARE @NUM INT;
	DECLARE @SIGUIENTE_ID VARCHAR(20);





SELECT @NUM = COUNT(*)   FROM REFERENCIAS;

SET @NUM = @NUM+1;

SELECT CONCAT('R00',@NUM);

END



SELECT CONCAT('A0',COUNT(*)) FROM REFERENCIAS;