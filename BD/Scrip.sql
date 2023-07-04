create database if not exists tienda_conveniencia;
use tienda_conveniencia;

-- -------------------------------------------------
-- Table 'Usuarios' 'tbl_usuarios'
-- -------------------------------------------------
create table IF NOT EXISTS tbl_usuarios (
	Codigo int auto_increment NOT NULL,
    Usuario varchar (50) NOT NULL,
    Contraseña varchar (50) NOT NULL,
    Nombre varchar (50) NOT NULL,
    Id_Tipo int NOT NULL,
    primary key (Codigo)
);

-- -------------------------------------------------
-- Table 'Tipo de Usuario' 'tbl_tipo_usuarios'
-- -------------------------------------------------
create table IF NOT EXISTS tbl_tipo_usuario(
	Id INT auto_increment NOT NULL,
    Nombre VARCHAR (50) NOT NULL,
    primary key (Id)
); 

-- -------------------------------------------------
-- Table 'Productos' 'tbl_producto'
-- -------------------------------------------------
create table IF NOT EXISTS tbl_producto  (
	Codigo INT NOT NULL ,
    Descripcion VARCHAR ( 150 ) NOT NULL ,
    Categoria VARCHAR ( 50 ) NOT NULL ,
    Almacen VARCHAR ( 50 ) NOT NULL ,
    primary key (Codigo)
);

-- -------------------------------------------------
-- Table 'Almacenes' 'tbl_almacen'
-- -------------------------------------------------
create table IF NOT EXISTS tbl_almacen (
    Codigo int auto_increment NOT NULL,
	Almacen varchar (50) NOT NULL,
	primary key (Codigo)
);

-- -------------------------------------------------
-- Table 'Proveedores' 'tbl_proveedores'
-- -------------------------------------------------
create table IF NOT EXISTS tbl_proveedores(
	Codigo int auto_increment NOT NULL,
	Nombre varchar (50) NOT NULL,
    Telefono varchar(50) NOT NULL,
	primary key (Codigo)
);

-- -------------------------------------------------
-- Table 'Compras' 'tbl_compra'
-- -------------------------------------------------
create table IF NOT EXISTS tbl_compra (
	Fecha_Compra date,
	Codigo int auto_increment NOT NULL,
    IdProducto int NOT NULL,
    Producto varchar (150) NOT NULL,
    Cantidad int NOT NULL,
    Estado int NOT NULL,
    primary key (Codigo)
);

-- -------------------------------------------------
-- Table 'Entradas' 'tbl_entradas'
-- -------------------------------------------------
create table IF NOT EXISTS tbl_entradas (
	Fecha date,
	Codigo int auto_increment NOT NULL,
    IdProveedores int NOT NULL,
    Proveedores varchar (50) NOT NULL,
    IdProducto int NOT NULL,
    Producto varchar (150) NOT NULL,
    Precio_Compra varchar (50) NOT NULL,
    Precio_Venta varchar (50) NOT NULL,
    Cantidad int NOT NULL,
    primary key (Codigo)
);

-- -------------------------------------------------
-- Table 'Salidas' 'tbl_salidas'
-- -------------------------------------------------
create table IF NOT EXISTS tbl_salidas (
	Fecha date,
	Codigo int auto_increment NOT NULL,
    IdAlmacen int NOT NULL,
    Almacen varchar (50) NOT NULL,
    IdProducto int NOT NULL,
	Descripcion varchar (150) NOT NULL,
	Cantidad int NOT NULL,
    primary key (Codigo)
);

-- -------------------------------------------------
-- Table 'Inventarios' 'tbl_inventario'
-- -------------------------------------------------
create table IF NOT EXISTS tbl_inventario(
	Fecha date,
    Codigo int NOT NULL,
    Descripcion varchar (150) NOT NULL,
    Categoria varchar (50) NOT NULL,
    Almacen varchar (50) NOT NULL,
    Entradas int NOT NULL,
	Salidas int NOT NULL,
    Stock int NOT NULL,
    primary key (Codigo)
);		

-- -------------------------------------------------
-- Table 'Categorias' 'tbl_categoria'
-- -------------------------------------------------
create table IF NOT EXISTS tbl_categoria(
	Codigo int auto_increment NOT NULL,
    Categoria varchar (25) NOT NULL,
    primary key (Codigo)
);

-- -------------------------------------------------
-- Table 'Historial' 'tbl_productos_populares'
-- -------------------------------------------------
create table IF NOT EXISTS tbl_productos_populares(
	id int auto_increment NOT NULL,
    Fecha date,
    Codigo int NOT NULL,
    Descripcion varchar (50) NOT NULL,
    Cantidad int NOT NULL,
    primary key (Id)
);

create table IF NOT EXISTS tbl_ingresos(
	Fecha date,
    Codigo int auto_increment NOT NULL,
    Total float(15,2),
    primary key (Codigo)
);

-- -------------------------------------------------
-- Table 'Bitacora de Login' 'tbl_bitacora_login'
-- -------------------------------------------------
create table IF NOT EXISTS tbl_bitacora_login(
	Fecha date,
    Hora varchar (25) NOT NULL,
    Nombre varchar (50) NOT NULL,
    Estado varchar (50) NOT NULL
);

-- -------------------------------------------------
-- Table 'Bitacora de Salidas' 'tbl_bitacora_salidas'
-- -------------------------------------------------
create table IF NOT EXISTS tbl_bitacora_salidas(
	Fecha date,
    Hora varchar (25) NOT NULL,
    Nombre varchar (50) NOT NULL,
    IdSalida int auto_increment NOT NULL,
    primary key (IdSalida)
); 

-- -------------------------------------------------
-- Table 'Bitacora de Entradas' 'tbl_bitacora_entradas'
-- -------------------------------------------------
create table IF NOT EXISTS tbl_bitacora_entradas(
	Fecha date,
    Hora varchar (25) NOT NULL,
    Nombre varchar (50) NOT NULL,
    IdEntrada int auto_increment NOT NULL,
    primary key (IdEntrada)
); 

-- -------------------------------------------------
-- Table 'Bitacora de Compra' 'tbl_bitacora_compras'
-- -------------------------------------------------
create table IF NOT EXISTS tbl_bitacora_compras(
	Fecha date,
    Hora varchar (25) NOT NULL,
    Nombre varchar (50) NOT NULL,
    IdCompra int auto_increment NOT NULL,
    primary key (IdCompra)
);

