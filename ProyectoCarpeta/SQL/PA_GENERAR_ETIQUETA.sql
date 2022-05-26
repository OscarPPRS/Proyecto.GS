/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DEL PROCEDIMIENTO:	PA_GENERAR_ETIQUETA
	FECHA DE CREACI�N: 		05/05/2022
	AUTOR:				�scar L�pez
	VSS:				
	USO:				##VISUAL##

	FUNCIONAMIENTO:			Dado un palet, genera una etiqueta y la almacena en un campo.


-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACI�N:
--	AUTOR:
--	EXPLICACI�N:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/


CREATE PROCEDURE PA_GENERAR_ETIQUETA
	
	@COD_PALET INT,


	@INVOKER	INT,		-- ESTE PAR�METRO LO DEBEN TENER TODOS LOS PAS
	@USUARIO	VARCHAR(12),	-- ESTE PAR�METRO LO DEBEN TENER TODOS LOS PAS
	@CULTURA	VARCHAR(5),

	@RETCODE	INT OUTPUT, --DEFINICI�N OBLIGATORIA
	@MENSAJE	VARCHAR(1000)	OUTPUT	--DEFINICI�N OBLIGATORIA

AS

BEGIN TRY

	DECLARE @N_TRANS		INT = 0	 --NUMERO DE TRANSACCIONES ACTIVAS	(@@TRANCOUNT)
	SET @N_TRANS = @@TRANCOUNT

	
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacci�n por encima no hacemos nada
	BEGIN
		BEGIN TRANSACTION TR_GENERAR_ETIQUETA
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	
	--DECLARAMOS LAS VARIABLES NECESARIAS Y OBTENEMOS LOS DATOS DEL PALET PARA PONERLOS EN LA ETIQUETA


	DECLARE @TEXTO_ETIQUETA VARCHAR (4000),
		@COD_PALET_FORMATEADO VARCHAR(8),
		@CANTIDAD INT,
		@COD_REFERENCIA VARCHAR(30);

		SELECT @CANTIDAD = CANTIDAD, @COD_REFERENCIA = COD_REFERENCIA
		FROM PALETS
		WHERE COD_PALET = @COD_PALET

	--DAR FORMATO AL TEXTO DEL CODIGO DEL PALET PARA QUE TENGA LOS CEROS NECESARIOS Y LA ETIQUETA SALGA CONSISTENTE A PESAR DEL NUMERO DE PALET

	SET @COD_PALET_FORMATEADO = Right(replicate('0',8) + convert(varchar(8), @COD_PALET), 8);

	--CONCATENAMOS EL TEXTO DE LA ETIQUETA A LOS DATOS DEL PALET

	SET @TEXTO_ETIQUETA =  

	'^XA

	^FX Top section with logo, name and address.

	^FO50,0^GFA,5000,5000,25,,::::::::::::::::::::::::::::::::::::::::::::::::V03JFCW01IF8,U03LFCU01KF8,0MFL01NFCJ01LFE007KFE,0MFL0PFJ01LFE01MF8,0MFK03PFCI01LFE03MFE,0MFK0RFI01LFE0OF,0MFJ01RF8001LFE1OF8,0MFJ07RFE001LFE3OFC,0MFJ0TF001LFE7OFE,0MFI01TF801LFE7PF,0MFI03TFC01LFEQF8,0MFI07TFC01XFC,0MFI0UFE01XFC,0MF001VF01XFE,0MF003VF01XFE,0MF003VF81YF,0MF007LFE01MF81NFE00NF,0MF007LF8007LFC1NFC003MF8,0MF00MFI03LFC1NFI01MF8,0MF00LFEI01LFE1MFEJ0MFC,0MF01LFEI01LFE1MFCJ07LFC,0MF01LFCJ0LFE1MFCJ07LFC,0MF03LFCJ0LFE1MF8J03LFE,0MF03LFCJ0MF1MF8J03LFE,0MF03LF8J0MF1MF8J01LFE,0MF07LF8J0MF1MFK01LFE,0MF07LF8J07LF1MFK01MF,0MF07LF8Q01MFL0MF,0MF07LFR01LFEL0MF,0MF0MFR01LFEL0MF,::0MF0MFR01LFEL0MF8::0MF0MFR01LFEL07LF8::::0MF0MFR01LFEL0MF80MF0MFR01LFEL0MF,:::0MF0MFK07LF1LFEL0MF,:0MF07LF8J0MF1MFL0MF,0MF07LF8J0MF1MFK01LFE,::0MF07LFCJ0LFE1MF8J01LFE,0MF03LFCJ0LFE1MF8J03LFC,0MF03LFCI01LFE1MFCJ03LFC,0MF03LFEI01LFE1MFCJ07LFC,0MF01LFEI03LFC1MFEJ0MF8,0MF01MFI03LFC1NFJ0MF8,0MF00MF8007LF81NF8003MF,0MF00MFC01MF81NFE007MF,0MF007MF9NF01OFC7MFE,0MF007VF01XFE,0MF003UFE01XFC,:0MF001UFC01XF8,0MFI0UF801XF,0MFI07TF001WFE,0MFI03SFE001LFEPFC,0MFI01SF8001LFE7OF8,0MFJ0SFI01LFE3OF,0MFJ03QFEI01LFE1NFE,0MFK0QF8I01LFE0NF8,0MFK07OFEJ01LFE03MF,0MFL0OFK01LFE01LFC,07KF6L01MF8K01LFE003KF,U03KFCL01LFEI0JF8,W03FCN01LFEJ0FF,gN01LFE,:::::::R08U01LFE,:gN01LFE,:01I0E001F0100E031EI0FI0801LFE,07003FC07D8083F83FE3838C03A01LFE,06006060E0E3861C0703060E02601LFE,0700C060400187I030186I06701LFE,0400E011C00187I070186I06101LFE,0700E031C00182E004028EI06301LFE,0600A071436381BC07028EI0E381LFE,0500C071C0A1801806038CI0C001LFE,0700C07040E38006070386I0FF81LFE,0700E06040A0860E070186070C9C1LFE,070030E0E061871C0703838C180C1LFE,07F81F803FE183F0070381F8300E1LFE,gN01LFE,,:::::::::::::::::::::::::::::::::::::::::::::::::^FS

	^CF0,60
	^FO350,70^FDICP Logistica^FS
	^CF0,30
	^FO50,170^GB700,3,3^FS

	^FX Second section with recipient address and permit information.
	^CFA,30
	^FO50,200^FDNumero de palet:^FS
	^FO50,250^FDReferencia:^FS
	^FO50,300^FDCantidad:^FS


	^FO400,200^FD' + @COD_PALET_FORMATEADO + '^FS
	^FO400,250^FD' + @COD_REFERENCIA + '^FS
	^FO400,300^FD' +  convert(varchar(8), @CANTIDAD) +'^FS
	^FO50,350^GB700,3,3^FS

	^FX Third section with bar code.
	^BY5,2,150
	^FO100,380^BC^FD' + @COD_PALET_FORMATEADO + '^FS

	^XZ'

	--ACTUALIZAMOS EL PALET 

	UPDATE PALETS
	SET ETIQUETA = @TEXTO_ETIQUETA
	WHERE COD_PALET = @COD_PALET

	SET @MENSAJE = 'ETIQUETA GENERADA'

	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacci�n por encima no hacemos nada
	BEGIN
		COMMIT TRANSACTION TR_GENERAR_ETIQUETA
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
		ROLLBACK TRANSACTION TR_GENERAR_ETIQUETA
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