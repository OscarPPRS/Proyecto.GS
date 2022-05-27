/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DEL PROCEDIMIENTO:	PA_RECEPCIONES_LIN
	FECHA DE CREACI�N: 		05/05/2022
	AUTOR:				�scar L�pez
	VSS:				
	USO:				##VISUAL##

	FUNCIONAMIENTO:			Inserta o elimina las l�neas de una recepci�n.


-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACI�N:
--	AUTOR:
--	EXPLICACI�N:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/


CREATE PROCEDURE PA_RECEPCIONES_LIN
	
	@ALBARAN	INT,
	@COD_LINEA	INT,
	@COD_REFERENCIA	VARCHAR(30),
	@CANTIDAD	INT,
	@CANTIDAD_MAL_ESTADO INT,
	@EXCEDENTE INT,
	@FALTA INT,

	@INVOKER	INT,		-- ESTE PAR�METRO LO DEBEN TENER TODOS LOS PAS
	@USUARIO	VARCHAR(12),	-- ESTE PAR�METRO LO DEBEN TENER TODOS LOS PAS
	@CULTURA	VARCHAR(5),
	 
	@RETCODE	INT OUTPUT,		--DEFINICI�N OBLIGATORIA
	@MENSAJE	VARCHAR(1000)	OUTPUT	--DEFINICI�N OBLIGATORIA

AS

BEGIN TRY

	DECLARE @N_TRANS		INT = 0	 --NUMERO DE TRANSACCIONES ACTIVAS	(@@TRANCOUNT)
	SET @N_TRANS = @@TRANCOUNT

	
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacci�n por encima no hacemos nada
	BEGIN
		BEGIN TRANSACTION TR_RECEPCIONES_LIN
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @INVOKER = 0 --CREA UNA LINEA PARA UN ALBARAN
	BEGIN		
		INSERT INTO RECEPCIONES_LIN (ALBARAN, COD_LINEA, COD_REFERENCIA, CANTIDAD, CANTIDAD_MAL_ESTADO, EXCEDENTE, FALTA)
		VALUES(@ALBARAN, @COD_LINEA ,@COD_REFERENCIA, @CANTIDAD, @CANTIDAD_MAL_ESTADO, @EXCEDENTE, @FALTA);

		SET @MENSAJE = 'LINEA CREADA.'
	END
	
	IF @INVOKER = 2 --BORRA TODAS LAS LINEAS PARA UN ALBARAN INTRODUCIDO
	BEGIN
		DELETE 
		FROM RECEPCIONES_LIN
		WHERE ALBARAN = @ALBARAN; 

		SET @MENSAJE = 'LINEAS ELIMINADAS.'
		
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacci�n por encima no hacemos nada
	BEGIN
		COMMIT TRANSACTION TR_RECEPCIONES_LIN
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	SET @MENSAJE = 'El proceso se ha realizado correctamente.'
	SET @RETCODE = 0
	RETURN @RETCODE
END TRY
BEGIN CATCH
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0 AND @@TRANCOUNT > 0				-- Si hay una transacci�n por encima no hacemos nada
	BEGIN
		ROLLBACK TRANSACTION TR_RECEPCIONES_LIN
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @MENSAJE = '' 
	BEGIN
		SET  @MENSAJE = ERROR_MESSAGE()
	END
	
	SET @RETCODE = -1
		
	RETURN @RETCODE
END CATCH

	SET @RETCODE = -1		
	RETURN @RETCODE