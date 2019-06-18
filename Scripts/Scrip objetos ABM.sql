/*
alter view listaRolesDisponibles
as
select r.role_nombre NOMBRE,f.func_nombre FUNCIONALIDAD,r.role_activo ESTADO from mavema_pie.role r join mavema_pie.role_funcionalidad  r_f on r.role_codigo = r_f.role_codigo join mavema_pie.funcionalidad f on r_f.func_codigo = f.func_codigo where r.role_activo = 1  group by r.role_nombre,f.func_nombre,r.role_activo
*/


/*
alter view listaRoles
as
select r.role_nombre NOMBRE,f.func_nombre FUNCIONALIDAD,r.role_activo ESTADO from mavema_pie.role r join mavema_pie.role_funcionalidad  r_f on r.role_codigo = r_f.role_codigo join mavema_pie.funcionalidad f on r_f.func_codigo = f.func_codigo  group by r.role_nombre,f.func_nombre,r.role_activo
*/


/*
alter procedure dar_de_baja_role
@role decimal(6,0) 
as begin
update mavema_pie.role
set role_activo = 0
where @role = role_codigo

update mavema_pie.usuario_rol
set role_codigo = null
where role_codigo = @role
end
*/

/*
create function crear_nuevo_id_rol(@nombre_rol nvarchar(50))
returns int
begin
declare @cantidadRegistros int 
set @cantidadRegistros= (select max(role_codigo) from mavema_pie.role)+1
return @cantidadRegistros
end
*/
/*
alter procedure eliminar_funcionalidad_rol
@rol decimal(6,0),
@funcionalidad_nombre nvarchar(50)

as begin
declare @funcionalidad_codigo decimal(6,0) 
set @funcionalidad_codigo = (select func_codigo from mavema_pie.funcionalidad where func_nombre = @funcionalidad_nombre )
delete from mavema_pie.role_funcionalidad
where role_codigo = @rol and func_codigo = @funcionalidad_codigo

end
*/


/*
--este store solo ingresa el nombre y asiga codigo del rol entrante
alter procedure dar_de_alta_role
@nombre_rol nvarchar(50),
@rol_codigo int output
as begin
set @rol_codigo = dbo.crear_nuevo_id_rol(@nombre_rol)
insert into mavema_pie.role(role_codigo,role_nombre,role_activo )
values (   dbo.crear_nuevo_id_rol(@nombre_rol)    ,@nombre_rol,1);

end
*/
/*
--este store asigna una funcionalidad a un rol en especifico, 
alter procedure asignar_funcionalidad_rol
@rol decimal(6,0),
@funcionalidad_nombre nvarchar(50)
as begin
declare @funcionalidad_codigo decimal(6,0) 
set @funcionalidad_codigo = (select func_codigo from mavema_pie.funcionalidad where func_nombre = @funcionalidad_nombre )
insert into mavema_pie.role_funcionalidad(func_codigo,role_codigo)
values (@funcionalidad_codigo,@rol)

end
*/
/*create view listaFuncionalidades       --llena el comboBox
as
select func_nombre  from mavema_pie.funcionalidad
*/

/*ABM recorridos */
/*
alter procedure alta_recorrido
@tramo decimal(18,2)
as begin
declare @nuevoCodigo decimal(18,0)
set @nuevoCodigo = (select max(reco_codigo) from mavema_pie.recorrido )+1
insert into mavema_pie.recorrido(reco_codigo,reco_activo)
values (@nuevoCodigo,1);


insert into mavema_pie.tramo_recorrido(reco_codigo,tram_codigo)
values (@nuevoCodigo,@tramo);

end
*/
/*
alter procedure agregar_tramo_a_recorrido
@recorrido decimal(18,0),
@nuevo_tramo decimal(18,2)
as begin
insert into mavema_pie.tramo_recorrido(reco_codigo,tram_codigo)
values (@recorrido,@nuevo_tramo);

end
*/
/*
alter procedure eliminar_tramo_a_recorrido
@recorrido decimal(18,0),
@tramo decimal(18,2)
as begin
delete from mavema_pie.tramo_recorrido
where reco_codigo = @recorrido and tram_codigo = @tramo
end
*/
/*
alter procedure baja_recorrido
@recorrido decimal(18,0)
as begin
update  mavema_pie.recorrido
set reco_activo = 0
where reco_codigo = @recorrido

end
*/
/*
create view lista_recorridos_disponibles 
as
select r.reco_codigo CODIGO_RECORRIDO,(select puer_nombre from mavema_pie.puerto where puer_codigo = t.tram_puerto_desde)PUERTO_ORIGEN,(select puer_nombre from mavema_pie.puerto where puer_codigo = t.tram_puerto_hasta)PUERTO_DESTINO,t.tram_precio_base PRECIO_BASE,t.tram_duracion DURACION from mavema_pie.recorrido r join mavema_pie.tramo_recorrido tr on r.reco_codigo = tr.reco_codigo join mavema_pie.tramo t on tr.tram_codigo = t.tram_codigo  where r.reco_activo != 0 group by r.reco_codigo,t.tram_puerto_desde,t.tram_puerto_hasta,t.tram_precio_base,t.tram_duracion
*/

/*
create view lista_recorridos
as
select r.reco_codigo CODIGO_RECORRIDO,(select puer_nombre from mavema_pie.puerto where puer_codigo = t.tram_puerto_desde)PUERTO_ORIGEN,(select puer_nombre from mavema_pie.puerto where puer_codigo = t.tram_puerto_hasta)PUERTO_DESTINO,t.tram_precio_base PRECIO_BASE,t.tram_duracion DURACION from mavema_pie.recorrido r join mavema_pie.tramo_recorrido tr on r.reco_codigo = tr.reco_codigo join mavema_pie.tramo t on tr.tram_codigo = t.tram_codigo  where r.reco_activo != 0 group by r.reco_codigo,t.tram_puerto_desde,t.tram_puerto_hasta,t.tram_precio_base,t.tram_duracion

*/
/*
alter procedure modificar_tramo_origen
@tram_codigo decimal(18,2),
@nuevo_puerto decimal(18,0) 
as begin

update mavema_pie.tramo
set tram_puerto_desde = @nuevo_puerto
where tram_codigo = @tram_codigo

end
*/
/*
alter procedure modificar_tramo_destino
@tram_codigo decimal(18,2),
@nuevo_puerto decimal(18,0) 
as begin

update mavema_pie.tramo
set tram_puerto_hasta = @nuevo_puerto
where tram_codigo = @tram_codigo

end
*/
/*ABM cruceros*/
/*
create view listaCruceros
as
select cruc_codigo CODIGO,cruc_modelo MODELO,(select fabr_nombre from mavema_pie.fabricante where fabr_codigo = cruc_fabricante) FABRICANTE,(select esta_descripcion_corta from mavema_pie.estado e where cruc_codigo = e.esta_codigo ) ESTADO,cruc_fecha_alta FECHA_ALTA,cruc_baja_definitiva FECHA_BAJA_DEF from mavema_pie.crucero group by cruc_codigo,cruc_modelo,cruc_fabricante,cruc_fecha_alta,cruc_baja_definitiva
*/
/*
create view listaCrucerosDisponibles
as
select cruc_codigo CODIGO,cruc_modelo MODELO,(select fabr_nombre from mavema_pie.fabricante where fabr_codigo = cruc_fabricante) FABRICANTE,(select esta_descripcion_corta from mavema_pie.estado e where cruc_codigo = e.esta_codigo ) ESTADO,cruc_fecha_alta FECHA_ALTA,cruc_baja FECHA_BAJA_TEMPORAL from mavema_pie.crucero where cruc_baja_DEFINITIVA is null  group by cruc_codigo,cruc_modelo,cruc_fabricante,cruc_fecha_alta,cruc_baja
*/
/*
alter procedure alta_crucero
@id nvarchar(50),
@modelo nvarchar(50),
@fabricante_nombre nvarchar(255),
@fecha_alta datetime
as begin
declare @id_fabicante decimal(6),@cod_historial decimal(12,0)
set @cod_historial = (select count(*) from mavema_pie.historial)+1
set @id_fabicante = (select fabr_codigo from mavema_pie.fabricante where fabr_nombre = @fabricante_nombre)
insert into mavema_pie.crucero(cruc_codigo,cruc_fecha_alta,cruc_baja_definitiva,cruc_fabricante,cruc_modelo)
values (@id,@fecha_alta,null,@id_fabicante,@modelo);
insert into mavema_pie.historial(hist_codigo,hist_crucero,hist_fecha_inicio,hist_fecha_fin,hist_comentario)
values (@cod_historial,@id,null,null,null);

end
*/
/*
alter procedure baja_temporal_crucero
@id_crucero nvarchar(50),
@fecha_inicio datetime,@fecha_estimada_fin datetime,
@comentario nvarchar(255)
as begin
update  mavema_pie.historial
set hist_fecha_fin = @fecha_estimada_fin,
hist_comentario = @comentario,
hist_fecha_inicio =@fecha_inicio
where hist_crucero = @id_crucero

end
*/
/*
create procedure baja_permanente_crucero(@id_crucero nvarchar(50), @fecha_baja datetime)
as begin
update mavema_pie.crucero



end
*/
