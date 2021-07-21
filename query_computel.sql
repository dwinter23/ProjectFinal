select * from ProdFaltantes;
insert into ProdFaltantes values(1, '01/05/15', 5, 'Buena condicion', 1, 1);
insert into ProdFaltantes values(2, '01/05/15', 0, 'No existe reporte', 1, 1);

select * from DetProdFaltantes;
insert into DetProdFaltantes values(1, 0, 'Buena condicion', 1);

select * from Proveedor;
insert into Proveedor values(1, 'Compact', 'Arnold', '365 av. Norton', 'America', '124512451');

select * from Inventario;
select * from DetInventario;

select * from DetFacturaComp;
select COUNT(categoria) from Producto Group By categoria;

select * from DetFacturaComp;
insert into DetFacturaComp values (1, 5, 15.45, 4512, 1);

select * from DetDocVenta;
insert into DetDocVenta values(1, 1, 1, 5.12, 45.32);

select * from OrdenComp;
select * from DetOrdenComp;


select * from Cotizacion;
select * from DetCotizacion;
select * from producto;

select * from DetCotizacion;

select * from usuario;
insert into usuario values(1, 'Admindbo', 'aaaa');

select * from TipoEmpleado;
insert into TipoEmpleado values(1, 'Admin_database');

select * from Trabajador;
insert into trabajador values(1, 1, '', 50, 'Central Av.', 1);

select tr.id_usuario, te.discripcion from trabajador tr inner join TipoEmpleado te on tr.idtipoempleado = te.idtipoempleado;