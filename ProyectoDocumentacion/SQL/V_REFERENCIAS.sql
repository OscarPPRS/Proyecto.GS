ALTER VIEW V_REFERENCIAS AS
SELECT COD_REFERENCIA, ID_EMPRESA, DES_REFERENCIA, PRECIO, FECH_CREACION, IMAGEN, ESTADO, 

dbo.COMPROBAR_STOCK(COD_REFERENCIA) AS STOCK
 
FROM REFERENCIAS;








