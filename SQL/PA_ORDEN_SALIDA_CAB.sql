/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DEL PROCEDIMIENTO:	PA_ORDEN_SALIDA_CAB
	FECHA DE CREACIÓN: 		05/05/2022
	AUTOR:				Óscar López
	VSS:				
	USO:				##VISUAL##

	FUNCIONAMIENTO:			Genera una cabecera de pedido o actualiza el estado de la cabecera del pedido


-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:
--	AUTOR:
--	EXPLICACIÓN:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

CREATE PROCEDURE PA_ORDEN_SALIDA_CAB
	
	@COD_PETICION	INT,
	@ESTADO		INT,
	@ID_EMPRESA	INT,
	@DIRECCION_ENTREGA	VARCHAR(300),
	@COD_POSTAL	VARCHAR(10),
	@POBLACION	VARCHAR(100),
	@PROVINCIA	VARCHAR(100),
	@TELEFONO	VARCHAR(20),
	@FECH_CREACION	DATE,

	@INVOKER	INT,		-- ESTE PARÁMETRO LO DEBEN TENER TODOS LOS PAS
	@USUARIO	VARCHAR(12),	-- ESTE PARÁMETRO LO DEBEN TENER TODOS LOS PAS
	@CULTURA	VARCHAR(5),
	 
	@RETCODE	INT OUTPUT,		--DEFINICIÓN OBLIGATORIA
	@MENSAJE	VARCHAR(1000)	OUTPUT	--DEFINICIÓN OBLIGATORIA

AS

BEGIN TRY

	DECLARE @N_TRANS		INT = 0	 --NUMERO DE TRANSACCIONES ACTIVAS	(@@TRANCOUNT)
	SET @N_TRANS = @@TRANCOUNT

	
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		BEGIN TRANSACTION TR_ORDEN_SALIDA_CAB
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @INVOKER = 0 --CREAR CABECERA DE PEDIDO
	BEGIN
		
		INSERT INTO ORDEN_SALIDA_CAB (COD_PETICION, ESTADO, ID_EMPRESA, DIRECCION_ENTREGA, COD_POSTAL, POBLACION, PROVINCIA, TELEFONO, FECH_CREACION)
		VALUES(@COD_PETICION, @ESTADO, @ID_EMPRESA, @DIRECCION_ENTREGA, @COD_POSTAL, @POBLACION, @PROVINCIA, @TELEFONO, @FECH_CREACION);

		SET @MENSAJE = 'ORDEN DE SALIDA CREADA.'
	END

	IF @INVOKER = 1 --EDITAR ESTADO DEL PEDIDO
	BEGIN
		
		UPDATE ORDEN_SALIDA_CAB
		SET ESTADO = ISNULL(@ESTADO, ESTADO)
		WHERE COD_PETICION = @COD_PETICION


		--SI EL ESTADO DEL PEDIDO SE PASA A REVISADO, MOVEMOS LOS PALETS DE ESE PEDIDO A A ZONA DE CARGA

		IF @ESTADO = 4
		BEGIN
		UPDATE PALETS
		SET UBICACION = 'ZC_01_01'
		WHERE PETICION_SALIDA = @COD_PETICION
		END

		--SI EL ESTADO DEL PEDIDO PASA A ENVIADO, QUITAMOS LA UBICACION DE LOS PALETS Y LOS PONEMOS COMO ENVIADOS.

		IF @ESTADO = 5
		BEGIN
		UPDATE PALETS
		SET UBICACION = NULL, COD_ESTADO = 5
		WHERE PETICION_SALIDA = @COD_PETICION
		END

		SET @MENSAJE = 'ORDEN DE SALIDA EDITADA.'

	END
	
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		COMMIT TRANSACTION TR_ORDEN_SALIDA_CAB
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	SET @MENSAJE = 'El proceso se ha realizado correctamente.'
	SET @RETCODE = 0
	RETURN @RETCODE
END TRY
BEGIN CATCH
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0 AND @@TRANCOUNT > 0				-- Si hay una transacción por encima no hacemos nada
	BEGIN
		ROLLBACK TRANSACTION TR_ORDEN_SALIDA_CAB
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

