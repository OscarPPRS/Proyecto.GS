USE AYLA1
GO

/*-----------------------------------------------------------------------------------------------------------------------------------------------------

	NOMBRE DEL PROCEDIMIENTO:	PA_SALIDA_LIN
	FECHA DE CREACI�N: 		08/03/2022
	AUTOR:				Hector Ramirez Gonzalez
	VSS:				 
	USO:				WINFORMS

	FUNCIONAMIENTO:			INSERTA,MODIFICA, CANCELA EL PEDIDO Y TRASPASO A ICP  
					
					INVOKER 1 --> INSERTAR
					INVOKER 2 --> MODIFICAR
					INVOKER	3 --> CANCELAR	(ESTADO)
					INVOKER 4 --> TRASPASAR A ICP	(ESTADO)


-------------------------------------------------------------------------------------------------------------------------------------------------------
--	FECHA DE MODIFICACI�N:
--	AUTOR:
--	EXPLICACI�N:	
------------------------------------------------------------------------------------------------------------------------------------------------------*/

ALTER PROC PA_SALIDA_CAB
	

	 @PETICION  VARCHAR(12),   
	 @NOMBRE   VARCHAR(50),   
	 @DIRECCION_ENTREGA VARCHAR(300),   
	 @CODIGO_POSTAL  VARCHAR(10),   
	 @POBLACION  VARCHAR(50),  
	 @PROVINCIA  VARCHAR(50),  
	 @TELEFONO  VARCHAR(20),  
  

	 
	@INVOKER		INT,
	
	@MENSAJE		VARCHAR(1000) OUTPUT,
	@RETCODE		INT OUTPUT

AS
	
BEGIN TRY
 

	DECLARE @N_TRANS		INT = 0	 --NUMERO DE TRANSACCIONES ACTIVAS	(@@TRANCOUNT)
	SET @N_TRANS = @@TRANCOUNT


	IF @INVOKER = 1 AND EXISTS( SELECT * FROM ORDEN_SALIDA_CAB WITH(NOLOCK) WHERE UPPER(PETICION) = UPPER(@PETICION) ) -- CREAR SALIDA CAB
	BEGIN
		
		 SET @MENSAJE = 'YA EXISTE ESTE PEDIDO';
		 SET @RETCODE = -2;
		 RETURN  @RETCODE;

	END
	ELSE IF @INVOKER != 1 AND EXISTS( SELECT * FROM ORDEN_SALIDA_CAB WITH(NOLOCK) WHERE UPPER(PETICION) = UPPER(@PETICION) AND ID_ESTADO <> 1 ) -- IMPEDIR MODIFICACION SI ESTA TRASPASADO A ICP
	BEGIN
		
		IF @INVOKER = 2					-- MENSAJE ERROR MODIFICAR
		BEGIN
			 SET @MENSAJE = 'NO SE PUEDE CANCELAR, SI EL PEDIDO HA SIDO TRASPASADO A ICP';
		END
		ELSE						-- MENSAJE ERROR CANCELAR
		BEGIN
			IF @INVOKER = 3
			BEGIN
				SET @MENSAJE = 'NO SE PUEDE MODIFICAR, EL PEDIDO HA SIDO TRASPASADO A ICP';
			END
			ELSE 		
			BEGIN
				IF @INVOKER = 4			 --MENSAJE ERROR SI YA HA SIDO TRASPASADO
				BEGIN
					SET @MENSAJE = 'YA HA SIDO TRASPASADO';
				END
				ELSE
				BEGIN		
					SET @MENSAJE = 'ERROR';
				END
			END
		END
		
	 

	        SET @RETCODE = -1;
		RETURN  @RETCODE;

	END

 

	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacci�n por encima no hacemos nada
	BEGIN
		BEGIN TRANSACTION TR_SALIDA_CAB
	END
	----------------------------------------------------------------------------------------------------------------------------------------------

	

	IF @INVOKER = 1 -- CREAR SALIDA CAB
	BEGIN
		
		INSERT INTO ORDEN_SALIDA_CAB (PETICION,NOMBRE_CLIENTE,DIRECCION_ENTREGA,CODIGO_POSTAL,POBLACION,PROVINCIA,TELEFONO,F_CREACION,ID_ESTADO)
		VALUES(UPPER(@PETICION),@NOMBRE,@DIRECCION_ENTREGA, @CODIGO_POSTAL,@POBLACION,@PROVINCIA,@TELEFONO,GETDATE(),1);

		-- INSERTAR LAS LINEAS DE ORDEN SALIDA CORRESPONDIENTE QUE SE UBICAN EN LA TABLA TEMPORAL DE ELLAS.

		INSERT INTO ORDEN_SALIDA_LIN
		(PETICION,LINEA,REFERENCIA,CANTIDAD)
		 SELECT T1.PETICION,T1.LINEA,T1.REFERENCIA,T1.CANTIDAD FROM AUX_ORDEN_LIN T1 WITH(NOLOCK) WHERE UPPER(T1.PETICION) =	UPPER(@PETICION)

		DELETE AUX_ORDEN_LIN WHERE PETICION = @PETICION

		SET @MENSAJE = 'PEDIDO CREADO.'
	END
	ELSE IF @INVOKER = 2  -- MODIFICAR SALIDA CAB
	BEGIN 

		UPDATE ORDEN_SALIDA_CAB  
		SET 
		NOMBRE_CLIENTE=@NOMBRE, 
		DIRECCION_ENTREGA=@DIRECCION_ENTREGA, 
		CODIGO_POSTAL=@CODIGO_POSTAL,
		POBLACION=@POBLACION,
		PROVINCIA=@PROVINCIA,
		TELEFONO=@TELEFONO 
		WHERE UPPER(PETICION) = UPPER(@PETICION);


		--PARA A�ADIR LAS LINEAS QUE NO EXISTE EN LA PRINCIPAL PERO SI EN LA TEMPORAL 

		INSERT INTO ORDEN_SALIDA_LIN(PETICION,LINEA,REFERENCIA,CANTIDAD)
		SELECT 
			T1.PETICION,T1.LINEA,T1.REFERENCIA,T1.CANTIDAD 
		FROM AUX_ORDEN_LIN T1
		LEFT JOIN ORDEN_SALIDA_LIN T2 
		ON
		T1.PETICION = T2.PETICION AND T1.REFERENCIA = T2.REFERENCIA
		WHERE T2.PETICION IS NULL AND T1.PETICION = @PETICION

		--ACTUALIZAR LAS LINEAS CON LOS NUEVOS DATOS QUE SE ENCUENTRAN EN LA TEMPORAL

		UPDATE T2 SET CANTIDAD = T1.CANTIDAD
		FROM AUX_ORDEN_LIN T1
		INNER JOIN ORDEN_SALIDA_LIN T2
		ON
		T1.PETICION = T2.PETICION AND T1.REFERENCIA = T2.REFERENCIA
		WHERE 
		T1.PETICION = @PETICION

		
		DELETE FROM ORDEN_SALIDA_LIN
		FROM ORDEN_SALIDA_LIN T1
		LEFT JOIN
		AUX_ORDEN_LIN T2
		ON
		T1.PETICION =T2.PETICION AND T1.REFERENCIA = T2.REFERENCIA
		WHERE
		T2.REFERENCIA IS NULL AND T1.PETICION = @PETICION	


		DELETE AUX_ORDEN_LIN WHERE PETICION = @PETICION -- ELIMINAR LAS LINEAS DE LA TABLA TEMPORAL

		SET @MENSAJE = 'PEDIDO MODIFICADO.'

	END
	ELSE IF @INVOKER = 3 -- CANCELAR EL PEDIDO
	BEGIN
		UPDATE ORDEN_SALIDA_CAB  SET ID_ESTADO	= 3 WHERE UPPER(PETICION) = UPPER(@PETICION);
		SET @MENSAJE = 'CANCELADO.'
	END
	ELSE IF @INVOKER = 4 -- TRASPASAR ICP
	BEGIN
		UPDATE ORDEN_SALIDA_CAB  SET ID_ESTADO	= 2 WHERE UPPER(PETICION) = UPPER(@PETICION);
		SET @MENSAJE = 'TRASPASADO.'
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacci�n por encima no hacemos nada
	BEGIN
		COMMIT TRANSACTION TR_SALIDA_CAB
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	

	IF @MENSAJE = ''
	BEGIN
		SET @MENSAJE = 'El proceso se ha realizado correctamente.'
	END 
	 
	SET @RETCODE = 0

	RETURN @RETCODE

END TRY

BEGIN CATCH
	
	----------------------------------------------------------------------------------------------------------------------------------------------
	IF @N_TRANS = 0						-- Si hay una transacci�n por encima no hacemos nada
	BEGIN
		ROLLBACK TRANSACTION TR_SALIDA_CAB
	END
	----------------------------------------------------------------------------------------------------------------------------------------------
	

	SET @MENSAJE =  ERROR_MESSAGE();

END CATCH

	SET @RETCODE = -1		
	RETURN @RETCODE

GO



--PRUEBAS
 
-- SELECT OSC.*,EP.DESC_ESTADO 
-- FROM ORDEN_SALIDA_CAB OSC
-- INNER JOIN ESTADOS_PEDIDOS EP
-- ON OSC.ID_ESTADO = EP.ID_ESTADO;


--DECLARE @MENSAJE_S VARCHAR(1000);
--DECLARE @RES INT;

--SET @MENSAJE_S = '';

--EXEC @RES = PA_SALIDA_CAB 
--@PETICION='P001',
--@NOMBRE='PRUEBA 2',
--@DIRECCION_ENTREGA='DIRECCION DE PRUEBA',
--@CODIGO_POSTAL='19004',
--@POBLACION='GUADALAJARA',
--@PROVINCIA='GUADALAJARA',
--@TELEFONO='546',
--@INVOKER=2, @MENSAJE = @MENSAJE_S OUTPUT,@RETCODE=0;

--SELECT @MENSAJE_S,@RES;
--GO
--SELECT * FROM ESTADOS_PEDIDOS ;
 

-- select * from REFERENCIAS;


-- SELECT * FROM ORDEN_SALIDA_CAB;
-- SELECT * FROM ORDEN_SALIDA_LIN;

-- SELECT * FROM AUX_ORDEN_LIN;