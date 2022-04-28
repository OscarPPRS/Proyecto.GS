ALTER PROCEDURE PA_EMAIL_RECEPCIONES
	
	@DESTINATARIOS VARCHAR(1000),
	@ASUNTO_EMAIL VARCHAR(200),
	@ALBARAN INT,


	@INVOKER	INT,		-- ESTE PAR�METRO LO DEBEN TENER TODOS LOS PAS

	@RETCODE	INT OUTPUT, --DEFINICI�N OBLIGATORIA
	@MENSAJE	VARCHAR(1000)	OUTPUT	--DEFINICI�N OBLIGATORIA

AS

BEGIN TRY

	DECLARE @N_TRANS		INT = 0	 --NUMERO DE TRANSACCIONES ACTIVAS	(@@TRANCOUNT)
	SET @N_TRANS = @@TRANCOUNT

	
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacci�n por encima no hacemos nada
	BEGIN
		BEGIN TRANSACTION TR_EMAIL_RECEPCIONES
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	DECLARE @TEXTO VARCHAR(MAX),
		@FECH_CREACION DATE,
		@FECH_LLEGADA DATE;

	SELECT @FECH_CREACION = FECH_CREACION, @FECH_LLEGADA = FECH_LLEGADA
	FROM RECEPCIONES_CAB
	WHERE @ALBARAN = ALBARAN;

	SET @TEXTO = '<!DOCTYPE html>
<html>

<head>
  <style>
    body {
      background-color: #dad8d5;
      text-align: center;
    }

    h1, h2 {
      color: #21293f;
    }

    table, th, td {
      border: 2px solid #21293f;
      border-collapse: collapse;
      color: #21293f;  
    }

    table{
      margin: 0 auto;
    }

  </style>
</head>

<body>

  <img src="https://icplogistica.es/wp-content/uploads/2021/03/ICP-logo.png" alt="ICP Logo">
  <br /> 
  <h1>Hola, tenemos informaci�n sobre el material que nos envi�.</h1>
  <h2>Material v�lido recibido:</h2>
  <br /> 
  <table>
    <tr>
      <th>Albar�n</th>
      <th>Fecha de creaci�n</th>
      <th>Fecha de llegada</th>
    </tr>
    <tr>
      <td>'+ CONVERT(VARCHAR(30), @ALBARAN) +'</td>
      <td>'+ CONVERT(VARCHAR(30), @FECH_CREACION)+'</td>
      <td>'+ CONVERT(VARCHAR(30),@FECH_LLEGADA)+'</td>
    </tr>
  </table>
  <br /> <br /> 

  <table>
    <tr>
      <th>L�nea</th>
      <th>Referencia</th>
      <th>Producto</th>
      <th>Cantidad recibida</th>
      <th>Precio unitario</th>
    </tr>';

    SELECT @TEXTO += '<tr><td>'+CONVERT(VARCHAR(30),COD_LINEA)+'</td><td>'+CONVERT(VARCHAR(30),RECEPCIONES_LIN.COD_REFERENCIA)
    +'</td><td>'+CONVERT(VARCHAR(500),DES_REFERENCIA)+'</td><td>'+CONVERT(VARCHAR(30),CANTIDAD)+'</td><td>'+CONVERT(VARCHAR(30),PRECIO)+'</td></tr>'
    FROM RECEPCIONES_LIN
    JOIN REFERENCIAS
    ON RECEPCIONES_LIN.COD_REFERENCIA = REFERENCIAS.COD_REFERENCIA   
    WHERE ALBARAN = @ALBARAN;

    SET @TEXTO +=

  '</table>


</body>

</html>';

	EXEC PA_ENVIAR_DBMAIL @DESTINATARIOS, @TEXTO, @ASUNTO_EMAIL, '','','', 'html', 'low', 'normal', '', 0, ''
	

	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacci�n por encima no hacemos nada
	BEGIN
		COMMIT TRANSACTION TR_EMAIL_RECEPCIONES
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
		ROLLBACK TRANSACTION TR_EMAIL_RECEPCIONES
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