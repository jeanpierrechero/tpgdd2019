create view mavema_pie.listar_viajes_dos
AS

select p2.puer_nombre as origen,p.puer_nombre as destino,c.cruc_codigo as crucero,
	v.viaj_fecha_inicio as salida, v.viaj_fecha_fin as llegada, v.viaj_fecha_llegada_estimada as estimacion
from mavema_pie.viaje v
	join mavema_pie.tramo_recorrido tr on tr.reco_codigo = v.viaj_recorrido
	join mavema_pie.tramo t on t.tram_codigo = tr.tram_codigo
	join mavema_pie.puerto p on p.puer_codigo = t.tram_puerto_desde
	join mavema_pie.puerto p2 on p2.puer_codigo = t.tram_puerto_hasta
	join mavema_pie.crucero c on c.cruc_codigo = v.viaj_crucero
	join mavema_pie.fabricante f on f.fabr_codigo = c.cruc_fabricante