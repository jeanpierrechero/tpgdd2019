--marfgam

use [GD1C2019]
go

delete from mavema_pie.tramo_recorrido;
delete from mavema_pie.recorrido;
delete from mavema_pie.tramo;
delete from mavema_pie.cabina;
delete from mavema_pie.crucero;
delete from mavema_pie.puerto;
delete from mavema_pie.tipo_servicio;
delete from mavema_pie.fabricante;
delete from mavema_pie.viaje;

ALTER TABLE mavema_pie.pasaje DROP CONSTRAINT factura_pasaje_fk;
ALTER TABLE mavema_pie.pasaje DROP CONSTRAINT reserva_pasaje_fk;
ALTER TABLE mavema_pie.pasaje DROP CONSTRAINT pasajero_pasaje_fk;
ALTER TABLE mavema_pie.pasaje DROP CONSTRAINT viaje_pasaje_fk;
ALTER TABLE mavema_pie.tramo_recorrido DROP CONSTRAINT recorrido_tramorecorrido_fk;
ALTER TABLE mavema_pie.tramo_recorrido DROP CONSTRAINT tramo_tramorecorrido_fk;
ALTER TABLE mavema_pie.tramo DROP CONSTRAINT puerto_desde_tramo_fk;
ALTER TABLE mavema_pie.tramo DROP CONSTRAINT puerto_hasta_tramo_fk;
ALTER TABLE mavema_pie.viaje DROP CONSTRAINT recorrido_viaje_fk;
ALTER TABLE mavema_pie.viaje DROP CONSTRAINT crucero_viaje_fk;
ALTER TABLE mavema_pie.historial DROP CONSTRAINT crucero_historial_fk;
ALTER TABLE mavema_pie.cabina DROP CONSTRAINT crucero_cabina_fk;
ALTER TABLE mavema_pie.cabina DROP CONSTRAINT tipo_servicio_cabina_fk;
ALTER TABLE mavema_pie.crucero DROP CONSTRAINT fabricante_crucero_fk;
ALTER TABLE mavema_pie.reserva DROP CONSTRAINT usuario_reserva_fk;
ALTER TABLE mavema_pie.factura DROP CONSTRAINT usuario_factura_fk;
ALTER TABLE mavema_pie.factura DROP CONSTRAINT forma_pago_factura_fk;
ALTER TABLE mavema_pie.login DROP CONSTRAINT usuario_login_fk;
ALTER TABLE mavema_pie.usuario_role DROP CONSTRAINT usuario_usuario_role_fk;
ALTER TABLE mavema_pie.usuario_role DROP CONSTRAINT role_usuario_role_fk;
ALTER TABLE mavema_pie.role_funcionalidad DROP CONSTRAINT funcionalidad_role_funcionalidad_fk;
ALTER TABLE mavema_pie.role_funcionalidad DROP CONSTRAINT role_role_funcionalidad_fk;

--






-- DROP TABLES
DROP TABLE mavema_pie.usuario;
DROP TABLE mavema_pie.login;
DROP TABLE mavema_pie.usuario_role;
DROP TABLE mavema_pie.role;
DROP TABLE mavema_pie.funcionalidad;
DROP TABLE mavema_pie.role_funcionalidad;
DROP TABLE mavema_pie.factura;
DROP TABLE mavema_pie.reserva;
DROP TABLE mavema_pie.pasaje;
DROP TABLE mavema_pie.pasajero;
DROP TABLE mavema_pie.forma_pago;
DROP TABLE mavema_pie.viaje;
DROP TABLE mavema_pie.recorrido;
DROP TABLE mavema_pie.tramo;
DROP TABLE mavema_pie.puerto;
DROP TABLE mavema_pie.tramo_recorrido;
DROP TABLE mavema_pie.crucero;
DROP TABLE mavema_pie.estado;
DROP TABLE mavema_pie.historial;
DROP TABLE mavema_pie.fabricante;
DROP TABLE mavema_pie.cabina;
DROP TABLE mavema_pie.tipo_servicio;


