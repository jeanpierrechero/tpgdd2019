use [GD1C2019]
go

ALTER PROCEDURE mavema_pie.sp_migracion
	@vari int
AS
	BEGIN TRY
		BEGIN TRANSACTION

			
			--INSERT FORMA DE PAGO
			INSERT INTO mavema_pie.forma_pago(form_nombre)
			VALUES ('Efectivo')

			--INSERT FUNCIONALIDADES
			INSERT INTO mavema_pie.funcionalidad(func_nombre)
			VALUES ('ALTA_USUARIO'),
				   ('MODIFICAR_USUARIO'),
				   ('ELIMINAR_USUARIO'),
				   ('ALTA_ROL'),
				   ('MODIFICAR_ROL'),
				   ('ELIMINAR_ROL'),
				   ('ALTA_PUERTO'),
				   ('MODIFICAR_PUERTO'),
				   ('ELIMINAR_PUERTO'),
				   ('ALTA_RECORRIDO'),
				   ('MODIFICAR_RECORRIDO'),
				   ('ELIMINAR_RECORRIDO'),
				   ('ALTA_CRUCERO'),
				   ('MODIFICAR_CRUCERO'),
				   ('ELIMINAR_CRUCERO'),
				   ('GENERAR_VIAJE'),
				   ('GENERAR_PASAJE'),
				   ('RESERVAR_PASAJE')

			--INSERT ROLE
			INSERT INTO mavema_pie.role (role_nombre,role_activo)
			VALUES	('ADMIN',1),
					('CLIENTE', 1)

			--INSERT ROLE FUNCIONALIDAD
			INSERT INTO mavema_pie.role_funcionalidad(role_codigo,func_codigo)
			(SELECT (SELECT top 1 role_codigo FROM mavema_pie.role WHERE role_nombre = 'ADMIN'), func_codigo FROM mavema_pie.funcionalidad)

			--INSERT USUARIO
			INSERT INTO mavema_pie.usuario (usua_docu_tipo,usua_docu_numero,usua_nombre,usua_apellido,usua_direccion,usua_telefono,usua_mail,
											usua_fecha_nac,usua_fecha_alta)
			VALUES ('DNI',12345678,'admin','admin','',1111111111,'admin@admin.com','1990-01-01','2018-01-01')

			--INSERT lOGIN
			INSERT INTO mavema_pie.login(logi_usuario,logi_username,logi_password,logi_intentos_fallidos,logi_activo)
			VALUES ((SELECT top 1 usua_codigo FROM mavema_pie.usuario WHERE usua_nombre = 'admin'),'admin', HASHBYTES('SHA2_256', 'w23e'),0,1)

			--INSERT USUARIO ROL
			INSERT INTO mavema_pie.usuario_role(usua_codigo,role_codigo)
			(SELECT usua_codigo, (SELECT top 1 role_codigo FROM mavema_pie.role WHERE role_nombre = 'ADMIN') 
			FROM mavema_pie.usuario WHERE usua_nombre = 'admin')

			--INSERT TABLE FABRICANTE
			INSERT INTO mavema_pie.fabricante (fabr_nombre)
			(SELECT DISTINCT CRU_FABRICANTE FROM gd_esquema.Maestra)

			--INSERT TIPO DE SERVICIO
			INSERT INTO mavema_pie.tipo_servicio (tipo_porc_recargo, tipo_nombre)
			(SELECT DISTINCT CABINA_TIPO_PORC_RECARGO, CABINA_TIPO FROM gd_esquema.Maestra)

			--INSERT PUERTO
			INSERT INTO mavema_pie.puerto (puer_nombre)
			((SELECT DISTINCT PUERTO_DESDE FROM gd_esquema.Maestra)
			UNION
			(SELECT DISTINCT PUERTO_HASTA FROM gd_esquema.Maestra))

			--INSERT CRUCERO
			INSERT INTO mavema_pie.crucero (cruc_fabricante, cruc_modelo, cruc_codigo, cruc_fecha_alta, cruc_baja_definitiva)
			(SELECT DISTINCT fa.fabr_codigo, M.CRUCERO_MODELO, M.CRUCERO_IDENTIFICADOR,'1900-01-01',0
			from gd_esquema.Maestra M join mavema_pie.fabricante fa on fa.fabr_nombre = M.CRU_FABRICANTE) 

			--INSERT CABINA
			INSERT INTO mavema_pie.cabina(cabi_crucero, cabi_tipo, cabi_numero, cabi_piso)
			(SELECT DISTINCT M.CRUCERO_IDENTIFICADOR, tipo_codigo, M.CABINA_NRO,M.CABINA_PISO
			FROM gd_esquema.Maestra M join mavema_pie.tipo_servicio on M.CABINA_TIPO = tipo_nombre)

			--TRAMO
			INSERT INTO mavema_pie.tramo (tram_precio_base, tram_puerto_desde, tram_puerto_hasta, tram_duracion)
			(SELECT DISTINCT RECORRIDO_PRECIO_BASE ,p1.puer_codigo,p2.puer_codigo,DATEDIFF(HOUR, FECHA_SALIDA, FECHA_LLEGADA_ESTIMADA)
			FROM gd_esquema.Maestra join mavema_pie.puerto p1 on PUERTO_DESDE = p1.puer_nombre join mavema_pie.puerto p2 on PUERTO_HASTA=p2.puer_nombre
			where p1.puer_codigo > p2.puer_codigo)

			--RECORRIDO
			INSERT INTO mavema_pie.recorrido (reco_codigo,reco_activo)
			(SELECT DISTINCT RECORRIDO_CODIGO,1 from gd_esquema.Maestra)

			-- reco tramo
			INSERT INTO mavema_pie.tramo_recorrido(reco_codigo, tram_codigo)
			(SELECT DISTINCT RECORRIDO_CODIGO, T1.tram_codigo
				from gd_esquema.Maestra 
				join mavema_pie.puerto p1 on p1.puer_nombre = PUERTO_DESDE 
				join mavema_pie.puerto p2 on p2.puer_nombre = PUERTO_HASTA 
				join mavema_pie.tramo t1 on t1.tram_puerto_desde=p1.puer_codigo and t1.tram_puerto_hasta=p2.puer_codigo)
			
			--Viaje
			INSERT INTO mavema_pie.viaje(viaj_recorrido, viaj_crucero, viaj_fecha_inicio, viaj_fecha_fin, viaj_fecha_llegada_estimada)
			(select distinct RECORRIDO_CODIGO, CRUCERO_IDENTIFICADOR,FECHA_SALIDA,FECHA_LLEGADA,FECHA_LLEGADA_ESTIMADA
			from gd_esquema.Maestra)

			--Usuario
			INSERT INTO mavema_pie.usuario(usua_docu_tipo, usua_docu_numero, usua_nombre, usua_apellido, usua_direccion, usua_telefono, usua_mail, usua_fecha_nac, usua_fecha_alta)
			(select distinct 'DNI', CLI_DNI,CLI_NOMBRE,CLI_APELLIDO,CLI_DIRECCION,CLI_TELEFONO,CLI_MAIL,CLI_FECHA_NAC,'1900-01-01'
			from gd_esquema.Maestra)
			
			--Reserva
			SET IDENTITY_INSERT mavema_pie.reserva ON;  
			INSERT INTO mavema_pie.reserva(rese_codigo, rese_cliente, rese_fecha)
			(select distinct  RESERVA_CODIGO, usua_codigo, RESERVA_FECHA
			from gd_esquema.Maestra join mavema_pie.usuario on usua_docu_numero = CLI_DNI and usua_apellido = CLI_APELLIDO and usua_nombre = CLI_NOMBRE
			where RESERVA_CODIGO is not null)
			DBCC CHECKIDENT ('mavema_pie.reserva', RESEED, 54999999);
			SET IDENTITY_INSERT mavema_pie.reserva OFF;  
			
			

		COMMIT TRANSACTION

	END TRY
	BEGIN CATCH
		SELECT ERROR_NUMBER() AS ErrorNumber
		 ,ERROR_SEVERITY() AS ErrorSeverity
		 ,ERROR_STATE() AS ErrorState
		 ,ERROR_PROCEDURE() AS ErrorProcedure
		 ,ERROR_LINE() AS ErrorLine
		 ,ERROR_MESSAGE() AS ErrorMessage;
		 ROLLBACK
	END CATCH
GO



exec mavema_pie.sp_migracion @vari = 12