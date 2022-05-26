/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DEL PROCEDIMIENTO:	PA_EMAIL_RECEPCIONES
	FECHA DE CREACIÓN: 		05/05/2022
	AUTOR:				Óscar López
	VSS:				
	USO:				##VISUAL##

	FUNCIONAMIENTO:			Genera el email correspondiente para una recepcion y lo envía, añadiendo falta de material si fuese necesario.


-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACIÓN:
--	AUTOR:
--	EXPLICACIÓN:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/


CREATE PROCEDURE PA_EMAIL_RECEPCIONES
	
	@DESTINATARIOS VARCHAR(1000),
	@ASUNTO_EMAIL VARCHAR(200),
	@ALBARAN INT,


	@INVOKER	INT,		-- ESTE PARÁMETRO LO DEBEN TENER TODOS LOS PAS
	@USUARIO	VARCHAR(12),	-- ESTE PARÁMETRO LO DEBEN TENER TODOS LOS PAS
	@CULTURA	VARCHAR(5),

	@RETCODE	INT OUTPUT, --DEFINICIÓN OBLIGATORIA
	@MENSAJE	VARCHAR(1000)	OUTPUT	--DEFINICIÓN OBLIGATORIA

AS

BEGIN TRY

	DECLARE @N_TRANS		INT = 0	 --NUMERO DE TRANSACCIONES ACTIVAS	(@@TRANCOUNT)
	SET @N_TRANS = @@TRANCOUNT

	
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
	BEGIN
		BEGIN TRANSACTION TR_EMAIL_RECEPCIONES
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	DECLARE @TEXTO VARCHAR(MAX),
		@FECH_CREACION DATE,
		@FECH_LLEGADA DATE,
		@TEXTO_FALTAS VARCHAR(MAX);

	--OBTIENE LOS DATOS DEL ALBARAN

	SELECT @FECH_CREACION = FECH_CREACION, @FECH_LLEGADA = FECH_LLEGADA
	FROM RECEPCIONES_CAB
	WHERE @ALBARAN = ALBARAN;

	--GENERA TEXTO PARA LA FALTA DE MATERIAL SI EXISTIESE FALTA DE MATERIAL EN ESE ALBARAN

	  IF (SELECT SUM(FALTA)
		FROM RECEPCIONES_LIN
		WHERE ALBARAN =  @ALBARAN) > 0

		BEGIN
			SET @TEXTO_FALTAS =   '<h2>FALTA DE MATERIAL:</h2> <br /> <br /> <table>
    <tr>
      <th>Línea</th>
      <th>Referencia</th>
      <th>Producto</th>
      <th>Cantidad no recibida</th>
    </tr>';

	--SELECCIONA LOS CAMPOS CON FALTA DE MATERIAL Y CONCATENA FILAS PARA UNA TABLA

    SELECT @TEXTO_FALTAS += '<tr><td>'+CONVERT(VARCHAR(30),COD_LINEA)+'</td><td>'+CONVERT(VARCHAR(30),RECEPCIONES_LIN.COD_REFERENCIA)
    +'</td><td>'+CONVERT(VARCHAR(500),DES_REFERENCIA)+'</td><td>'+CONVERT(VARCHAR(30),FALTA)+'</td></tr>'
    FROM RECEPCIONES_LIN
    JOIN REFERENCIAS
    ON RECEPCIONES_LIN.COD_REFERENCIA = REFERENCIAS.COD_REFERENCIA   
    WHERE ALBARAN = @ALBARAN
	AND FALTA > 0;

    SET @TEXTO_FALTAS +=

  '</table>'
		END
  

  --CONCATENACION DEL CUERPO DEL EMAIL.

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
  <h1>Hola, tenemos información sobre el material que nos envió.</h1>
  <h2>Material válido recibido:</h2>
  <br /> 
  <table>
    <tr>
      <th>Albarán</th>
      <th>Fecha de creación</th>
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
      <th>Línea</th>
      <th>Referencia</th>
      <th>Producto</th>
      <th>Cantidad recibida</th>
      <th>Precio unitario</th>
    </tr>';

	--SELECCIONA LAS LINEAS Y CONCATENA LOS DATOS NECESARIOS EN UNA TABLA HTML

    SELECT @TEXTO += '<tr><td>'+CONVERT(VARCHAR(30),COD_LINEA)+'</td><td>'+CONVERT(VARCHAR(30),RECEPCIONES_LIN.COD_REFERENCIA)
    +'</td><td>'+CONVERT(VARCHAR(500),DES_REFERENCIA)+'</td><td>'+CONVERT(VARCHAR(30),CANTIDAD)+'</td><td>'+CONVERT(VARCHAR(30),PRECIO)+'</td></tr>'
    FROM RECEPCIONES_LIN
    JOIN REFERENCIAS
    ON RECEPCIONES_LIN.COD_REFERENCIA = REFERENCIAS.COD_REFERENCIA   
    WHERE ALBARAN = @ALBARAN;

    SET @TEXTO +=

  '</table>  <br /> <br /> '+
  

  ISNULL(@TEXTO_FALTAS, '')
  
  
  +


'</body>
</html>';

	EXEC PA_ENVIAR_DBMAIL @DESTINATARIOS, @TEXTO, @ASUNTO_EMAIL, '','','', 'html', 'low', 'normal', '', 0, ''

	SET @MENSAJE = 'EMAIL ENVIADO'
	

	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacción por encima no hacemos nada
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
	IF @N_TRANS = 0 AND @@TRANCOUNT > 0				-- Si hay una transacción por encima no hacemos nada
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