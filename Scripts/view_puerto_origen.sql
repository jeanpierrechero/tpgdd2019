create view mavema_pie.listado_puertos_origen

as 
	select distinct p.* from mavema_pie.puerto p
	join mavema_pie.tramo t on t.tram_puerto_desde = p.puer_codigo
