USE GD1C2019
GO

ALTER TABLE [mavema_pie].[role_funcionalidad]  
DROP CONSTRAINT [funcionalidad_role_funcionalidad_fk]
GO

ALTER TABLE [mavema_pie].[role_funcionalidad]  
DROP CONSTRAINT [role_role_funcionalidad_fk] 
GO

ALTER TABLE [mavema_pie].[modelo]  
DROP CONSTRAINT [fabricante_fk] 
GO

ALTER TABLE [mavema_pie].[tramo] 
DROP CONSTRAINT [tramo_puerto_origen_fk] 
GO

ALTER TABLE [mavema_pie].[tramo]  
DROP CONSTRAINT [tramo_puerto_destino_fk]
GO

ALTER TABLE [mavema_pie].[tramo_recorrido]  
DROP CONSTRAINT [tramo_recorrido_codigo_fk]
GO

ALTER TABLE [mavema_pie].[tramo_recorrido]  
DROP CONSTRAINT [tramo_tramo_codigo_fk]
GO

ALTER TABLE [mavema_pie].[cabina]  
DROP CONSTRAINT [cabina_tipo_servicio_fk] 
GO

ALTER TABLE [mavema_pie].[cabina]  
DROP CONSTRAINT [cabina_modelo_fk] 
GO

ALTER TABLE [mavema_pie].[crucero]  
DROP CONSTRAINT [crucero_modelo_fk]
GO

ALTER TABLE [mavema_pie].[crucero]  
DROP CONSTRAINT [crucero_estado_fk] 
GO

ALTER TABLE [mavema_pie].[viaje]  
DROP CONSTRAINT [viaje_recorrido_fk] 
GO

ALTER TABLE [mavema_pie].[viaje]  
DROP CONSTRAINT [viaje_crucero_fk]
GO

ALTER TABLE [mavema_pie].[historial]  
DROP CONSTRAINT [crucero_historial_fk] 
GO

ALTER TABLE [mavema_pie].[usuario_rol]  
DROP CONSTRAINT [usuario_usuario_rol_fk] 
GO

ALTER TABLE [mavema_pie].[usuario_rol]  
DROP CONSTRAINT [role_usuario_rol_fk] 
GO

ALTER TABLE [mavema_pie].[factura]  
DROP CONSTRAINT [factura_forma_pago_fk] 
GO

ALTER TABLE [mavema_pie].[factura]  
DROP CONSTRAINT [factura_cliente_fk]
GO

ALTER TABLE [mavema_pie].[reserva]  
DROP CONSTRAINT [reserva_cliente_fk] 
GO

ALTER TABLE [mavema_pie].[pasaje]  
DROP CONSTRAINT [pasajero_pasaje_fk] 
GO

ALTER TABLE [mavema_pie].[pasaje]  
DROP CONSTRAINT [viaje_pasaje_fk] 
GO

ALTER TABLE [mavema_pie].[pasaje]  
DROP CONSTRAINT [factura_pasaje_fk] 
GO

ALTER TABLE [mavema_pie].[pasaje]  
DROP CONSTRAINT [reserva_pasaje_fk]
GO

ALTER TABLE [mavema_pie].[login]  
DROP CONSTRAINT [usuario_login_fk] 
GO

--- TABLAS

TRUNCATE TABLE mavema_pie.funcionalidad
TRUNCATE TABLE mavema_pie.role
TRUNCATE TABLE mavema_pie.role_funcionalidad
TRUNCATE TABLE mavema_pie.forma_pago
TRUNCATE TABLE mavema_pie.pasajero
TRUNCATE TABLE mavema_pie.estado
TRUNCATE TABLE mavema_pie.fabricante
TRUNCATE TABLE mavema_pie.modelo
TRUNCATE TABLE mavema_pie.puerto
TRUNCATE TABLE mavema_pie.tramo
TRUNCATE TABLE mavema_pie.recorrido
TRUNCATE TABLE mavema_pie.tramo_recorrido
TRUNCATE TABLE mavema_pie.tipo_servicio
TRUNCATE TABLE mavema_pie.cabina
TRUNCATE TABLE mavema_pie.crucero
TRUNCATE TABLE mavema_pie.viaje
TRUNCATE TABLE mavema_pie.historial
TRUNCATE TABLE mavema_pie.usuario
TRUNCATE TABLE mavema_pie.login
TRUNCATE TABLE mavema_pie.usuario_rol
TRUNCATE TABLE mavema_pie.factura
TRUNCATE TABLE mavema_pie.reserva
TRUNCATE TABLE mavema_pie.pasaje
GO

DROP TABLE mavema_pie.funcionalidad
DROP TABLE mavema_pie.role
DROP TABLE mavema_pie.role_funcionalidad
DROP TABLE mavema_pie.forma_pago
DROP TABLE mavema_pie.pasajero
DROP TABLE mavema_pie.estado
DROP TABLE mavema_pie.fabricante
DROP TABLE mavema_pie.modelo
DROP TABLE mavema_pie.puerto
DROP TABLE mavema_pie.tramo
DROP TABLE mavema_pie.recorrido
DROP TABLE mavema_pie.tramo_recorrido
DROP TABLE mavema_pie.tipo_servicio
DROP TABLE mavema_pie.cabina
DROP TABLE mavema_pie.crucero
DROP TABLE mavema_pie.viaje
DROP TABLE mavema_pie.historial
DROP TABLE mavema_pie.usuario
DROP TABLE mavema_pie.login
DROP TABLE mavema_pie.usuario_rol
DROP TABLE mavema_pie.factura
DROP TABLE mavema_pie.reserva
DROP TABLE mavema_pie.pasaje
GO