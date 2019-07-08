--marfgam

use [GD1C2019]
go

--CREATE SCHEMA [mavema_pie]
--GO

-- TABLAS DE USUARIO
CREATE TABLE mavema_pie.usuario (
	usua_codigo DECIMAL(18) NOT NULL IDENTITY,
	usua_docu_tipo CHAR(3) NOT NULL,
	usua_docu_numero DECIMAL(18) NOT NULL,
	usua_nombre NVARCHAR(255) NOT NULL,
	usua_apellido NVARCHAR(255) NOT NULL,
	usua_direccion NVARCHAR(255) NOT NULL,
	usua_telefono INT NOT NULL,
	usua_mail NVARCHAR(255) NOT NULL,
	usua_fecha_nac DATETIME2(3) NOT NULL,
	usua_fecha_alta DATETIME NOT NULL,
);
CREATE TABLE mavema_pie.login (
	logi_usuario DECIMAL(18) NOT NULL,
	logi_username NVARCHAR(50) NOT NULL,
	logi_password NVARCHAR(50) NOT NULL,
	logi_activo CHAR(1) NOT NULL,
	logi_intentos_fallidos BIT NOT NULL,
);
CREATE TABLE mavema_pie.usuario_role (
	role_codigo INT NOT NULL,
	usua_codigo DECIMAL(18) NOT NULL,
);
CREATE TABLE mavema_pie.role (
	role_codigo INT NOT NULL IDENTITY,
	role_nombre NVARCHAR(50) NOT NULL,
	role_activo bit NOT NULL,
);
CREATE TABLE mavema_pie.funcionalidad (
	func_codigo INT NOT NULL IDENTITY,
	func_nombre NVARCHAR(255) NOT NULL
);
CREATE TABLE mavema_pie.role_funcionalidad (
	func_codigo INT NOT NULL,
	role_codigo INT NOT NULL
);

--Ventas
CREATE TABLE mavema_pie.factura (
	fact_codigo DECIMAL(18) NOT NULL,
	fact_forma_pago DECIMAL(6) NOT NULL,
	fact_cliente DECIMAL(18) NOT NULL,
	fact_fecha_creacion DATETIME2(3) NOT NULL
);
CREATE TABLE mavema_pie.reserva (
	rese_codigo DECIMAL(18) NOT NULL IDENTITY,
	rese_cliente DECIMAL(18) NOT NULL,
	rese_fecha DATETIME2(3) NOT NULL,
);
CREATE TABLE mavema_pie.pasaje (
	pasa_codigo DECIMAL(18) NOT NULL,
	pasa_factura DECIMAL(18) NULL,
	pasa_pasajero DECIMAL(18) NOT NULL,
	pasa_reserva DECIMAL(18) NULL,
	pasa_viaje DECIMAL(18) NOT NULL,
	pasa_cabina DECIMAL(6) NOT NULL,
	pasa_fecha_cancelacion DATETIME2(3),
	pasa_motivo_cancelacion NVARCHAR(255),
);
CREATE TABLE mavema_pie.pasajero (
	jero_codigo DECIMAL(18) NOT NULL IDENTITY,
	jero_nacimiento DATETIME2(3) NOT NULL,
	jero_docu_numero DECIMAL(18,0) NOT NULL,
	jero_nombre NVARCHAR(255) NOT NULL,
	jero_apellido NVARCHAR(255) NOT NULL,
	jero_docu_tipo CHAR(3) NOT NULL
);
CREATE TABLE mavema_pie.forma_pago (
	form_codigo DECIMAL(6) NOT NULL IDENTITY,
	form_nombre NVARCHAR(100) NOT NULL
);

--Viaje
CREATE TABLE mavema_pie.viaje (
	viaj_codigo DECIMAL(18) NOT NULL IDENTITY,
	viaj_recorrido DECIMAL(18) NOT NULL,
	viaj_crucero NVARCHAR(50) NOT NULL,
	viaj_fecha_inicio DATETIME2(3) NOT NULL,
	viaj_fecha_fin DATETIME2(3) NULL,
	viaj_fecha_llegada_estimada DATETIME2(3) NOT NULL
);
CREATE TABLE mavema_pie.recorrido (
	reco_codigo DECIMAL(18) NOT NULL,
	--reco_tramo INT NOT NULL,
	reco_activo BIT NOT NULL,
);
CREATE TABLE mavema_pie.puerto (
	puer_codigo INT NOT NULL IDENTITY,
	puer_nombre NVARCHAR(255) NOT NULL,
	--puer_ISO3 CHAR(3) NOT NULL,
);
CREATE TABLE mavema_pie.tramo (
	tram_codigo INT NOT NULL IDENTITY,
	tram_precio_base DECIMAL(18,2) NOT NULL,
	tram_puerto_desde INT NOT NULL,
	tram_puerto_hasta INT NOT NULL,
	tram_duracion DECIMAL(2) NOT NULL,
);
CREATE TABLE mavema_pie.tramo_recorrido(
	reco_codigo DECIMAL(18) NOT NULL,
	tram_codigo INT NOT NULL
);

--Crucero
CREATE TABLE mavema_pie.crucero (
	cruc_codigo NVARCHAR(50) NOT NULL,
	cruc_modelo NVARCHAR(50) NOT NULL,
	cruc_fabricante INT NOT NULL,
	cruc_fecha_alta DATETIME NOT NULL,
	cruc_baja DATETIME NULL,
	cruc_baja_DEFINITIVA BIT NOT NULL,
);
CREATE TABLE mavema_pie.estado (
	esta_codigo INT NOT NULL IDENTITY,
	esta_descripcion_corta NVARCHAR(50) NOT NULL,
);
CREATE TABLE mavema_pie.historial (
	hist_codigo DECIMAL(12) NOT NULL IDENTITY,
	hist_crucero NVARCHAR(50) NOT NULL,
	hist_fecha_inicio DATETIME NOT NULL,
	hist_fecha_fin DATETIME,
	hist_comentario NVARCHAR(255) NOT NULL,
);
CREATE TABLE mavema_pie.fabricante (
	fabr_codigo INT NOT NULL IDENTITY,
	fabr_nombre NVARCHAR(255) NOT NULL,
	--fabr_nombre_corto CHAR(10) NOT NULL,
);
CREATE TABLE mavema_pie.cabina (
	cabi_codigo DECIMAL(6) NOT NULL IDENTITY,
	cabi_crucero NVARCHAR(50) NOT NULL,
	cabi_tipo INT NOT NULL,
	cabi_numero DECIMAL(18) NOT NULL,
	cabi_piso DECIMAL(18) NOT NULL,
);
CREATE TABLE mavema_pie.tipo_servicio (
	tipo_codigo INT NOT NULL IDENTITY,
	tipo_porc_recargo DECIMAL(18,2) NOT NULL,
	tipo_nombre NVARCHAR(255) NOT NULL,
	--tipo_nombre_corto CHAR(10) NOT NULL,
);


--------------

ALTER TABLE mavema_pie.funcionalidad ADD CONSTRAINT funcionalidad_pk PRIMARY KEY (func_codigo);

ALTER TABLE mavema_pie.role ADD CONSTRAINT role_pk PRIMARY KEY (role_codigo);

ALTER TABLE mavema_pie.role_funcionalidad ADD CONSTRAINT role_funcionalidad_pk PRIMARY KEY(func_codigo,role_codigo);
ALTER TABLE mavema_pie.role_funcionalidad ADD CONSTRAINT funcionalidad_role_funcionalidad_fk FOREIGN KEY (func_codigo) REFERENCES mavema_pie.funcionalidad (func_codigo);
ALTER TABLE mavema_pie.role_funcionalidad ADD CONSTRAINT role_role_funcionalidad_fk FOREIGN KEY (role_codigo) REFERENCES mavema_pie.role (role_codigo);

ALTER TABLE mavema_pie.usuario ADD CONSTRAINT usuario_pk PRIMARY KEY(usua_codigo);

ALTER TABLE mavema_pie.usuario_role ADD CONSTRAINT usuario_role_pk PRIMARY KEY (role_codigo, usua_codigo)
ALTER TABLE mavema_pie.usuario_role ADD CONSTRAINT usuario_usuario_role_fk FOREIGN KEY (usua_codigo) REFERENCES mavema_pie.usuario (usua_codigo)
ALTER TABLE mavema_pie.usuario_role ADD CONSTRAINT role_usuario_role_fk FOREIGN KEY (role_codigo) REFERENCES mavema_pie.role (role_codigo)

ALTER TABLE mavema_pie.login ADD CONSTRAINT login_pk PRIMARY KEY (logi_usuario);
ALTER TABLE mavema_pie.login ADD CONSTRAINT usuario_login_fk FOREIGN KEY (logi_usuario)	REFERENCES mavema_pie.usuario(usua_codigo);

ALTER TABLE mavema_pie.forma_pago ADD CONSTRAINT forma_pago_pk PRIMARY KEY (form_codigo);

ALTER TABLE mavema_pie.factura ADD CONSTRAINT factura_pk PRIMARY KEY (fact_codigo);
ALTER TABLE mavema_pie.factura ADD CONSTRAINT usuario_factura_fk FOREIGN KEY (fact_cliente) REFERENCES mavema_pie.usuario(usua_codigo);
ALTER TABLE mavema_pie.factura ADD CONSTRAINT forma_pago_factura_fk FOREIGN KEY (fact_forma_pago) REFERENCES mavema_pie.forma_pago(form_codigo);

ALTER TABLE mavema_pie.reserva ADD CONSTRAINT reserva_pk PRIMARY KEY (rese_codigo);
ALTER TABLE mavema_pie.reserva ADD CONSTRAINT usuario_reserva_fk FOREIGN KEY (rese_cliente) REFERENCES mavema_pie.usuario(usua_codigo);

ALTER TABLE mavema_pie.pasajero ADD CONSTRAINT pasajero_pk PRIMARY KEY (jero_codigo);

ALTER TABLE mavema_pie.estado ADD CONSTRAINT estado_pk PRIMARY KEY (esta_codigo);


ALTER TABLE mavema_pie.fabricante ADD CONSTRAINT fabricante_pk PRIMARY KEY (fabr_codigo);

ALTER TABLE mavema_pie.tipo_servicio ADD CONSTRAINT tipo_servicio_pk PRIMARY KEY (tipo_codigo);

ALTER TABLE mavema_pie.crucero ADD CONSTRAINT crucero_pk PRIMARY KEY (cruc_codigo);
ALTER TABLE mavema_pie.crucero ADD CONSTRAINT fabricante_crucero_fk FOREIGN KEY (cruc_fabricante) REFERENCES mavema_pie.fabricante(fabr_codigo);


ALTER TABLE mavema_pie.cabina ADD CONSTRAINT cabina_pk PRIMARY KEY (cabi_codigo);
ALTER TABLE mavema_pie.cabina ADD CONSTRAINT crucero_cabina_fk FOREIGN KEY (cabi_crucero) REFERENCES mavema_pie.crucero(cruc_codigo);
ALTER TABLE mavema_pie.cabina ADD CONSTRAINT tipo_servicio_cabina_fk FOREIGN KEY (cabi_tipo) REFERENCES mavema_pie.tipo_servicio(tipo_codigo);


ALTER TABLE mavema_pie.historial ADD CONSTRAINT historial_pk PRIMARY KEY (hist_codigo);
ALTER TABLE mavema_pie.historial ADD CONSTRAINT crucero_historial_fk FOREIGN KEY (hist_crucero) REFERENCES mavema_pie.crucero(cruc_codigo);

ALTER TABLE mavema_pie.recorrido ADD CONSTRAINT recorrido_pk PRIMARY KEY (reco_codigo);

ALTER TABLE mavema_pie.viaje ADD CONSTRAINT viaje_pk PRIMARY KEY (viaj_codigo);
ALTER TABLE mavema_pie.viaje ADD CONSTRAINT recorrido_viaje_fk FOREIGN KEY (viaj_recorrido) REFERENCES mavema_pie.recorrido(reco_codigo);
ALTER TABLE mavema_pie.viaje ADD CONSTRAINT crucero_viaje_fk FOREIGN KEY (viaj_crucero) REFERENCES mavema_pie.crucero(cruc_codigo);

ALTER TABLE mavema_pie.puerto ADD CONSTRAINT puerto_pk PRIMARY KEY (puer_codigo);

ALTER TABLE mavema_pie.tramo ADD CONSTRAINT tramo_pk PRIMARY KEY (tram_codigo);
ALTER TABLE mavema_pie.tramo ADD CONSTRAINT puerto_desde_tramo_fk FOREIGN KEY (tram_puerto_desde) REFERENCES mavema_pie.puerto(puer_codigo);
ALTER TABLE mavema_pie.tramo ADD CONSTRAINT puerto_hasta_tramo_fk FOREIGN KEY (tram_puerto_hasta) REFERENCES mavema_pie.puerto(puer_codigo);

ALTER TABLE mavema_pie.tramo_recorrido ADD CONSTRAINT tramorecorrido_pk PRIMARY KEY (tram_codigo, reco_codigo);
ALTER TABLE mavema_pie.tramo_recorrido ADD CONSTRAINT recorrido_tramorecorrido_fk FOREIGN KEY (reco_codigo) REFERENCES mavema_pie.recorrido(reco_codigo);
ALTER TABLE mavema_pie.tramo_recorrido ADD CONSTRAINT tramo_tramorecorrido_fk FOREIGN KEY (tram_codigo) REFERENCES mavema_pie.tramo(tram_codigo);


ALTER TABLE mavema_pie.pasaje ADD CONSTRAINT pasaje_pk PRIMARY KEY (pasa_codigo);
ALTER TABLE mavema_pie.pasaje ADD CONSTRAINT factura_pasaje_fk FOREIGN KEY (pasa_factura) REFERENCES mavema_pie.factura(fact_codigo);
ALTER TABLE mavema_pie.pasaje ADD CONSTRAINT reserva_pasaje_fk FOREIGN KEY (pasa_reserva) REFERENCES mavema_pie.reserva(rese_codigo);
ALTER TABLE mavema_pie.pasaje ADD CONSTRAINT pasajero_pasaje_fk FOREIGN KEY (pasa_pasajero) REFERENCES mavema_pie.pasajero(jero_codigo);
ALTER TABLE mavema_pie.pasaje ADD CONSTRAINT viaje_pasaje_fk FOREIGN KEY (pasa_viaje) REFERENCES mavema_pie.viaje(viaj_codigo);
ALTER TABLE mavema_pie.pasaje ADD CONSTRAINT cabina_pasaje_fk FOREIGN KEY (pasa_cabina) REFERENCES mavema_pie.cabina(cabi_codigo);