DELETE FROM ORDEN_SALIDA_LIN
DELETE FROM ORDEN_SALIDA_CAB

DELETE FROM RECEPCIONES_LIN
DELETE FROM RECEPCIONES_CAB

delete from PALETS;
update UBICACIONES set LLENA = 0;