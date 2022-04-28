USE AYLA1;
GO 

/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DEL PROCEDIMIENTO:	PA_COMPROBAR_STOCK
	FECHA DE CREACIÓN: 		09/03/2022
	AUTOR:				Hector Ramirez Gonzalez
	VSS:				 
	USO:				WINFORMS

	FUNCIONAMIENTO:			Comprueba el stock de una referencia ;

 

-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:
--	AUTOR:
--	EXPLICACIÓN:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

ALTER PROCEDURE PA_COMPROBAR_STOCK
	
	@REF  VARCHAR(20),
	@CANTIDAD INT,

	@INVOKER	INT,		 
	 

	@RETCODE	INT OUTPUT,		--DEFINICIÓN OBLIGATORIA  Stock = 0 , No Stock = 1 , Error = -1
	@MENSAJE	VARCHAR(1000)	OUTPUT	--DEFINICIÓN OBLIGATORIA

AS

BEGIN TRY 

	IF NOT EXISTS ( SELECT * FROM REFERENCIAS WITH(NOLOCK) WHERE REFERENCIA = @REF )
	BEGIN 
		SET @MENSAJE = 'No existe referencia.'
		SET @RETCODE = -1

		RETURN @RETCODE
	END
	


	IF @INVOKER = 1 AND EXISTS (SELECT * FROM V_LISTADOS_REFERENCIAS_STOCK WITH(NOLOCK) WHERE STOCK>0 AND REFERENCIA = @REF) --Comprobacion simple de stock
	BEGIN
		SET @MENSAJE = 'HAY STOCK .'
		SET @RETCODE = 0

		RETURN @RETCODE
	END
	ELSE IF @INVOKER = 1
	BEGIN 

		SET @MENSAJE = 'NO HAY STOCK'
		SET @RETCODE = 1

		RETURN @RETCODE
	END

	IF @INVOKER = 0 --Comprobacion stock pedido
	BEGIN
		
		IF @CANTIDAD = 0
		BEGIN 
			SET @MENSAJE = 'CANTIDAD NO PUEDE SER 0'
			SET @RETCODE = -1

			RETURN @RETCODE
		END

		IF NOT EXISTS ( SELECT * FROM V_LISTADOS_REFERENCIAS_STOCK WITH(NOLOCK)  WHERE (STOCK-@CANTIDAD)>= 0 AND REFERENCIA= @REF )
		BEGIN
			SET @MENSAJE = 'NO HAY STOCK .'
			SET @RETCODE = 1

			RETURN @CANTIDAD
		END
	
		 
	END
	
	 
	SET @MENSAJE = 'STOCK DISPONIBLE'
	SET @RETCODE = 0

	RETURN @RETCODE
	
END TRY
BEGIN CATCH
	 
	IF @MENSAJE = '' 
	BEGIN
		SET  @MENSAJE = ERROR_MESSAGE()
	END
	
	SET @RETCODE = -1
		
	RETURN @RETCODE
END CATCH

	SET @RETCODE = -1		
	RETURN @RETCODE

GO




--						PRUEBAS



--DECLARE @MENSAJE_S VARCHAR(1000)

--SET @MENSAJE_S = '';


--DECLARE @RECODE INT = 0;

--EXEC @RECODE=PA_COMPROBAR_STOCK 'A02',0,0,0,@MENSAJE = @MENSAJE_S OUTPUT;

--SELECT @MENSAJE_S,@RECODE;