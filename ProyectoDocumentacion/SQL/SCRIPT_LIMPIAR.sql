DELETE FROM ORDEN_SALIDA_INCIDENCIAS

DELETE FROM ORDEN_SALIDA_LIN
DELETE FROM ORDEN_SALIDA_CAB

DELETE FROM RECEPCIONES_LIN
DELETE FROM RECEPCIONES_CAB

DELETE FROM MOVIMIENTOS_PICKING
DELETE FROM MOVIMIENTOS_PICKING_LOG

DBCC CHECKIDENT ("MOVIMIENTOS_PICKING", RESEED, 1);

DBCC CHECKIDENT ("MOVIMIENTOS_PICKING_LOG", RESEED, 1);

delete from PALETS;
update UBICACIONES set LLENA = 0;