-- ************************************** [Producto]
CREATE TABLE [Producto]
(
 [idproducto]    char(10) NOT NULL ,
 [nombre]        varchar(24) NOT NULL ,
 [categoria]     varchar(24) NOT NULL ,
 [descripcion]   varchar(50) NOT NULL ,
 [preciounidad]  money NOT NULL ,
 [precioventa]   money NOT NULL ,
 [unidadesstock] int NOT NULL ,
 [unidadesorden] int NOT NULL ,


 CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED ([idproducto] ASC)
);
GO


-- ************************************** [boleta]
CREATE TABLE [boleta]
(
 [idboleta] char(8) NOT NULL ,
 [dni]      varchar(8) NOT NULL ,


 CONSTRAINT [PK_boleta] PRIMARY KEY CLUSTERED ([idboleta] ASC)
);
GO

-- ************************************** [factura]
CREATE TABLE [factura]
(
 [idfactura] char(8) NOT NULL ,
 [ruc]       varchar(20) NOT NULL ,


 CONSTRAINT [PK_factura] PRIMARY KEY CLUSTERED ([idfactura] ASC)
);
GO


-- ************************************** [Cliente]
CREATE TABLE [Cliente]
(
 [idcliente]       char(10) NOT NULL ,
 [nombre]          varchar(24) NOT NULL ,
 [direccion]       varchar(35) NULL ,
 [edad]            int NULL ,
 [satisfaccion]    int NULL ,
 [punto_inflexion] decimal(5,0) NULL ,


 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED ([idcliente] ASC)
);
GO



-- ************************************** [Proveedor]
CREATE TABLE [Proveedor]
(
 [idproveedor]    char(10) NOT NULL ,
 [nombrecompania] varchar(24) NOT NULL ,
 [nombrecontacto] varchar(24) NOT NULL ,
 [direccion]      varchar(24) NOT NULL ,
 [region]         varchar(24) NOT NULL ,
 [telefono]       varchar(24) NOT NULL ,


 CONSTRAINT [PK_proveedor] PRIMARY KEY CLUSTERED ([idproveedor] ASC)
);
GO


-- ************************************** [TipoEmpleado]
CREATE TABLE [TipoEmpleado]
(
 [idtipoempleado] char(8) NOT NULL ,
 [discripcion]    varchar(25) NOT NULL ,


 CONSTRAINT [PK_tipoempleado] PRIMARY KEY CLUSTERED ([idtipoempleado] ASC)
);
GO


-- ************************************** [Usuario]
CREATE TABLE [Usuario]
(
 [id_usuario] nvarchar(8) NOT NULL ,
 [Nombre]     varchar(20) NOT NULL ,
 [contrasena] varchar(24) NOT NULL ,


 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED ([id_usuario] ASC)
);
GO


-- *************************************A partir de aqui todos con la clave foranea como rama de las principales


---------------------------------------------------------------COMPRAS


-- ************************************** [DetCotizacion]
CREATE TABLE [DetCotizacion]
(
 [iddetcotizacion] char(8) NOT NULL ,
 [cantidad]        int NOT NULL ,
 [precio]          money NOT NULL ,
 [detalle]         varchar(35) NOT NULL ,
 [idproducto]      char(10) NOT NULL ,


 CONSTRAINT [PK_detcotizacion] PRIMARY KEY CLUSTERED ([iddetcotizacion] ASC),
 CONSTRAINT [FK_335] FOREIGN KEY ([idproducto])  REFERENCES [Producto]([idproducto])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_336] ON [DetCotizacion] 
 (
  [idproducto] ASC
 )

GO


-- ************************************** [Cotizacion]
CREATE TABLE [Cotizacion]
(
 [idcotizacion]    char(8) NOT NULL ,
 [idproveedor]     char(10) NOT NULL ,
 [empresa_nom]     varchar(24) NOT NULL ,
 [fecha]           date NOT NULL ,
 [iddetcotizacion]  char(8) NOT NULL ,


 CONSTRAINT [PK_cotizacion] PRIMARY KEY CLUSTERED ([idcotizacion] ASC),
 CONSTRAINT [FK_262] FOREIGN KEY ([iddetcotizacion])  REFERENCES [DetCotizacion]([iddetcotizacion]),
 CONSTRAINT [FK_341] FOREIGN KEY ([idproveedor])  REFERENCES [Proveedor]([idproveedor])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_263] ON [Cotizacion] 
 (
  [iddetcotizacion] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_342] ON [Cotizacion] 
 (
  [idproveedor] ASC
 )

GO


-- ************************************** [DetGuiaEntradaC]
CREATE TABLE [DetGuiaEntradaC]
(
 [iddetguiaentradac] char(8) NOT NULL ,
 [cantidad]          int NOT NULL ,
 [descripcion]       varchar(35) NOT NULL ,
 [idproducto]        char(10) NOT NULL ,
 [idproducto_1]      char(10) NOT NULL ,


 CONSTRAINT [PK_detguiaentradac] PRIMARY KEY CLUSTERED ([iddetguiaentradac] ASC),
 CONSTRAINT [FK_310] FOREIGN KEY ([idproducto])  REFERENCES [Producto]([idproducto]),
 CONSTRAINT [FK_332] FOREIGN KEY ([idproducto_1])  REFERENCES [Producto]([idproducto])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_311] ON [DetGuiaEntradaC] 
 (
  [idproducto] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_333] ON [DetGuiaEntradaC] 
 (
  [idproducto_1] ASC
 )

GO


-- ************************************** [GuiaEntradaC]
CREATE TABLE [GuiaEntradaC]
(
 [idguiaentradac]     char(8) NOT NULL ,
 [fecha]              date NOT NULL ,
 [moneda]             varchar(24) NOT NULL ,
 [estatus]            varchar(24) NOT NULL ,
 [origen]             varchar(24) NOT NULL ,
 [destino]            varchar(24) NOT NULL ,
 [observacion]        varchar(35) NOT NULL ,
 [nombre_autorizante] varchar(24) NOT NULL ,
 [iddetguiaentradac]   char(8) NOT NULL ,


 CONSTRAINT [PK_guiaentradac] PRIMARY KEY CLUSTERED ([idguiaentradac] ASC),
 CONSTRAINT [FK_265] FOREIGN KEY ([iddetguiaentradac])  REFERENCES [DetGuiaEntradaC]([iddetguiaentradac])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_266] ON [GuiaEntradaC] 
 (
  [iddetguiaentradac] ASC
 )

GO


-- ************************************** [DetFacturaComp]
CREATE TABLE [DetFacturaComp]
(
 [iddetfacturacomp] char(8) NOT NULL ,
 [cantidad]         int NOT NULL ,
 [igb]              money NOT NULL ,
 [total]            money NOT NULL ,
 [idproducto]       char(10) NOT NULL ,


 CONSTRAINT [PK_detfacturacomp] PRIMARY KEY CLUSTERED ([iddetfacturacomp] ASC),
 CONSTRAINT [FK_329] FOREIGN KEY ([idproducto])  REFERENCES [Producto]([idproducto])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_330] ON [DetFacturaComp] 
 (
  [idproducto] ASC
 )

GO



-- ************************************** [FacturaComp]
CREATE TABLE [FacturaComp]
(
 [idfacturacomp]    char(8) NOT NULL ,
 [idproveedor]      char(10) NOT NULL ,
 [fecha]            date NOT NULL ,
 [iddetfacturacomp] char(8) NOT NULL ,


 CONSTRAINT [PK_facturacomp] PRIMARY KEY CLUSTERED ([idfacturacomp] ASC),
 CONSTRAINT [FK_268] FOREIGN KEY ([iddetfacturacomp])  REFERENCES [DetFacturaComp]([iddetfacturacomp]),
 CONSTRAINT [FK_338] FOREIGN KEY ([idproveedor])  REFERENCES [Proveedor]([idproveedor])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_269] ON [FacturaComp] 
 (
  [iddetfacturacomp] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_339] ON [FacturaComp] 
 (
  [idproveedor] ASC
 )

GO


-- ************************************** [DetPedidoComp]
CREATE TABLE [DetPedidoComp]
(
 [iddetpedidocomp] char(8) NOT NULL ,
 [cantidad]        int NOT NULL ,
 [idproducto]      char(10) NOT NULL ,


 CONSTRAINT [PK_detpedidocomp] PRIMARY KEY CLUSTERED ([iddetpedidocomp] ASC),
 CONSTRAINT [FK_326] FOREIGN KEY ([idproducto])  REFERENCES [Producto]([idproducto])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_327] ON [DetPedidoComp] 
 (
  [idproducto] ASC
 )

GO


-- ************************************** [PedidoComp]
CREATE TABLE [PedidoComp]
(
 [idpedidocomp]        char(8) NOT NULL ,
 [idproveedor]         char(10) NOT NULL ,
 [fecha]               date NOT NULL ,
 [detalle_condiciones] varchar(50) NOT NULL ,
 [iddetpedidocomp]     char(8) NOT NULL ,


 CONSTRAINT [PK_pedidocomp] PRIMARY KEY CLUSTERED ([idpedidocomp] ASC),
 CONSTRAINT [FK_271] FOREIGN KEY ([iddetpedidocomp])  REFERENCES [DetPedidoComp]([iddetpedidocomp]),
 CONSTRAINT [FK_319] FOREIGN KEY ([idproveedor])  REFERENCES [Proveedor]([idproveedor])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_272] ON [PedidoComp] 
 (
  [iddetpedidocomp] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_320] ON [PedidoComp] 
 (
  [idproveedor] ASC
 )

GO


-- ************************************** [DetOrdenComp]
CREATE TABLE [DetOrdenComp]
(
 [iddetordencomp]  char(8) NOT NULL ,
 [cantidad]        int NOT NULL ,
 [cargo_adicional] money NOT NULL ,
 [total]           money NOT NULL ,
 [detalle]         varchar(50) NOT NULL ,
 [idproducto]      char(10) NOT NULL ,


 CONSTRAINT [PK_detordencomp] PRIMARY KEY CLUSTERED ([iddetordencomp] ASC),
 CONSTRAINT [FK_323] FOREIGN KEY ([idproducto])  REFERENCES [Producto]([idproducto])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_324] ON [DetOrdenComp] 
 (
  [idproducto] ASC
 )

GO



-- ************************************** [OrdenComp]
CREATE TABLE [OrdenComp]
(
 [idordencomp]     char(8) NOT NULL ,
 [idproveedor]     char(10) NOT NULL ,
 [fecha_requerida] date NOT NULL ,
 [lugar_entrega]   varchar(24) NOT NULL ,
 [iddetordencomp]  char(8) NOT NULL ,


 CONSTRAINT [PK_ordencomp] PRIMARY KEY CLUSTERED ([idordencomp] ASC),
 CONSTRAINT [FK_274] FOREIGN KEY ([iddetordencomp])  REFERENCES [DetOrdenComp]([iddetordencomp]),
 CONSTRAINT [FK_316] FOREIGN KEY ([idproveedor])  REFERENCES [Proveedor]([idproveedor])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_275] ON [OrdenComp] 
 (
  [iddetordencomp] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_317] ON [OrdenComp] 
 (
  [idproveedor] ASC
 )

GO


---------------------------------------------------------------COMPRAS

---------------------------------------------------------------VENTAS



-- ************************************** [DetDocVenta]
CREATE TABLE [DetDocVenta]
(
 [iddetdocventa] char(8) NOT NULL ,
 [idproducto]    char(10) NOT NULL ,
 [cantidad]      int NOT NULL ,
 [igb]           money NOT NULL ,
 [total]         money NOT NULL ,


 CONSTRAINT [PK_detdocventa] PRIMARY KEY CLUSTERED ([iddetdocventa] ASC),
 CONSTRAINT [FK_292] FOREIGN KEY ([idproducto])  REFERENCES [Producto]([idproducto])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_293] ON [DetDocVenta] 
 (
  [idproducto] ASC
 )

GO




CREATE TABLE [DetGuiaSalida]
(
 [iddetguiasalida] char(8) NOT NULL ,
 [descripcion]     varchar(24) NOT NULL ,
 [cantidad]        int NOT NULL ,
 [idproducto]      char(10) NOT NULL ,


 CONSTRAINT [PK_detguiasalida] PRIMARY KEY CLUSTERED ([iddetguiasalida] ASC),
 CONSTRAINT [FK_295] FOREIGN KEY ([idproducto])  REFERENCES [Producto]([idproducto])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_296] ON [DetGuiaSalida] 
 (
  [idproducto] ASC
 )

GO


-- ************************************** [GuiaSalida]
CREATE TABLE [GuiaSalida]
(
 [idguiasalida]       char(8) NOT NULL ,
 [fecha]              date NOT NULL ,
 [moneda]             varchar(24) NOT NULL ,
 [nombre_autorizante] varchar(24) NOT NULL ,
 [iddetguiasalida]    char(8) NOT NULL ,
 [idcliente]          char(10) NOT NULL ,


 CONSTRAINT [PK_guiasalida] PRIMARY KEY CLUSTERED ([idguiasalida] ASC),
 CONSTRAINT [FK_253] FOREIGN KEY ([iddetguiasalida])  REFERENCES [DetGuiaSalida]([iddetguiasalida]),
 CONSTRAINT [FK_298] FOREIGN KEY ([idcliente])  REFERENCES [Cliente]([idcliente])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_254] ON [GuiaSalida] 
 (
  [iddetguiasalida] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_299] ON [GuiaSalida] 
 (
  [idcliente] ASC
 )

GO



-- ************************************** [DocVenta]
CREATE TABLE [DocVenta]
(
 [iddocventa]    char(8) NOT NULL ,
 [fecha]         date NOT NULL ,
 [iddetdocventa] char(8) NOT NULL ,
 [idboleta]      char(8) NOT NULL ,
 [idfactura]     char(8) NOT NULL ,
 [idcliente]     char(10) NOT NULL ,


 CONSTRAINT [PK_docventa] PRIMARY KEY CLUSTERED ([iddocventa] ASC),
 CONSTRAINT [FK_250] FOREIGN KEY ([iddetdocventa])  REFERENCES [DetDocVenta]([iddetdocventa]),
 CONSTRAINT [FK_256] FOREIGN KEY ([idboleta])  REFERENCES [boleta]([idboleta]),
 CONSTRAINT [FK_259] FOREIGN KEY ([idfactura])  REFERENCES [factura]([idfactura]),
 CONSTRAINT [FK_289] FOREIGN KEY ([idcliente])  REFERENCES [Cliente]([idcliente])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_251] ON [DocVenta] 
 (
  [iddetdocventa] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_257] ON [DocVenta] 
 (
  [idboleta] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_260] ON [DocVenta] 
 (
  [idfactura] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_290] ON [DocVenta] 
 (
  [idcliente] ASC
 )

GO

-----------------------------------------------------------------  VENTAS

------------------------------------------------------------------ ALMACEN

-- ************************************** [DetInventario]
CREATE TABLE [DetInventario]
(
 [iddetinventario] char(8) NOT NULL ,
 [cantidad]        int NOT NULL ,
 [idproducto]      char(10) NOT NULL ,


 CONSTRAINT [PK_detinventario] PRIMARY KEY CLUSTERED ([iddetinventario] ASC),
 CONSTRAINT [FK_283] FOREIGN KEY ([idproducto])  REFERENCES [Producto]([idproducto])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_284] ON [DetInventario] 
 (
  [idproducto] ASC
 )

GO



-- ************************************** [DetProdFaltantes]
CREATE TABLE [DetProdFaltantes]
(
 [iddetprodfaltantes] char(8) NOT NULL ,
 [cantidad]           int NOT NULL ,
 [detalle]            varchar(50) NOT NULL ,
 [idproducto]         char(10) NOT NULL ,


 CONSTRAINT [PK_detprodfaltantes] PRIMARY KEY CLUSTERED ([iddetprodfaltantes] ASC),
 CONSTRAINT [FK_280] FOREIGN KEY ([idproducto])  REFERENCES [Producto]([idproducto])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_281] ON [DetProdFaltantes] 
 (
  [idproducto] ASC
 )

GO



-- ************************************** [DetGuiaEntrada]
CREATE TABLE [DetGuiaEntrada]
(
 [iddetguiaentrada] char(8) NOT NULL ,
 [cantidad]         int NOT NULL ,
 [descripcion]      varchar(24) NOT NULL ,
 [idproducto]       char(10) NOT NULL ,


 CONSTRAINT [PK_detguiaentrada] PRIMARY KEY CLUSTERED ([iddetguiaentrada] ASC),
 CONSTRAINT [FK_277] FOREIGN KEY ([idproducto])  REFERENCES [Producto]([idproducto])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_278] ON [DetGuiaEntrada] 
 (
  [idproducto] ASC
 )
GO

-- ************************************** [GuiaEntrada]
CREATE TABLE [GuiaEntrada]
(
 [idguiaentrada]      char(8) NOT NULL ,
 [fecha]              date NOT NULL ,
 [moneda]             varchar(24) NOT NULL ,
 [estatus]            varchar(24) NOT NULL ,
 [origen]             varchar(24) NOT NULL ,
 [destino]            varchar(24) NOT NULL ,
 [observacion]        varchar(50) NOT NULL ,
 [nombre_autorizante] varchar(24) NOT NULL ,
 [iddetguiaentrada]   char(8) NOT NULL ,


 CONSTRAINT [PK_guiaentrada] PRIMARY KEY CLUSTERED ([idguiaentrada] ASC),
 CONSTRAINT [FK_241] FOREIGN KEY ([iddetguiaentrada])  REFERENCES [DetGuiaEntrada]([iddetguiaentrada])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_242] ON [GuiaEntrada] 
 (
  [iddetguiaentrada] ASC
 )
GO




-- ************************************** [ProdFaltantes]
CREATE TABLE [ProdFaltantes]
(
 [idprodfaltantes]    char(8) NOT NULL ,
 [fecha]              date NOT NULL ,
 [cantidad]           int NOT NULL ,
 [condiciones]        varchar(50) NOT NULL ,
 [iddetprodfaltantes] char(8) NOT NULL ,
 [idproveedor]        char(10) NOT NULL ,


 CONSTRAINT [PK_prodfaltantes] PRIMARY KEY CLUSTERED ([idprodfaltantes] ASC),
 CONSTRAINT [FK_244] FOREIGN KEY ([iddetprodfaltantes])  REFERENCES [DetProdFaltantes]([iddetprodfaltantes]),
 CONSTRAINT [FK_286] FOREIGN KEY ([idproveedor])  REFERENCES [Proveedor]([idproveedor])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_245] ON [ProdFaltantes] 
 (
  [iddetprodfaltantes] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_287] ON [ProdFaltantes] 
 (
  [idproveedor] ASC
 )

GO



-- ************************************** [Inventario]
CREATE TABLE [Inventario]
(
 [idcabinventario] char(8) NOT NULL ,
 [fecha]           date NOT NULL ,
 [motivo]          varchar(50) NOT NULL ,
 [entrada_total]   money NOT NULL ,
 [salida_total]    money NOT NULL ,
 [total]           money NOT NULL ,
 [iddetinventario] char(8) NOT NULL ,


 CONSTRAINT [PK_cabinventario] PRIMARY KEY CLUSTERED ([idcabinventario] ASC),
 CONSTRAINT [FK_247] FOREIGN KEY ([iddetinventario])  REFERENCES [DetInventario]([iddetinventario])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_248] ON [Inventario] 
 (
  [iddetinventario] ASC
 )

GO





-- ************************************** [Trabajador]
CREATE TABLE [Trabajador]
(
 [idtrabajador]   char(8) NOT NULL ,
 [id_usuario]     nvarchar(8) NOT NULL ,
 [telefono]       varchar(9) NOT NULL ,
 [edad]           varchar(2) NOT NULL ,
 [direccion]      varchar(25) NOT NULL ,
 [idtipoempleado] char(8) NOT NULL ,


 CONSTRAINT [PK_empleado] PRIMARY KEY CLUSTERED ([idtrabajador] ASC, [id_usuario] ASC),
 CONSTRAINT [FK_227] FOREIGN KEY ([id_usuario])  REFERENCES [Usuario]([id_usuario]),
 CONSTRAINT [FK_238] FOREIGN KEY ([idtipoempleado])  REFERENCES [TipoEmpleado]([idtipoempleado])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_228] ON [Trabajador] 
 (
  [id_usuario] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_239] ON [Trabajador] 
 (
  [idtipoempleado] ASC
 )

GO






select * from INFORMATION_SCHEMA.TABLES;