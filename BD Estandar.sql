/*|==============================ESTRUCTURA==============================|*/
CREATE DATABASE Acuario
GO

USE Acuario
GO

DECLARE @DATOS_PRUEBA BIT = 0;
DECLARE @DATOS_PRODUCCION BIT = 0;

CREATE TABLE Precios(
	ID_Precio INT PRIMARY KEY IDENTITY,
	Precio_Minorista DECIMAL(10, 2) NOT NULL,
	Precio_Mayorista DECIMAL(10, 2) NOT NULL,
	Precio_Oferta DECIMAL(10, 2) NOT NULL,
	Precio_Distribuidor DECIMAL(10, 2) NOT NULL
)
GO

CREATE TABLE Pez_Especies(
	ID_Pez_Especie INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR(20) NOT NULL
)
GO

CREATE TABLE Pez_Variedades(
	ID_Pez_Variedad INT PRIMARY KEY IDENTITY,
	ID_Pez_Especie INT NOT NULL,
	Nombre VARCHAR(20) NOT NULL,
	Es_Default BIT NOT NULL DEFAULT 0
)
GO

CREATE TABLE Pez_Tamaños(
	ID_Pez_Tamaño INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR(30) NOT NULL
)
GO

CREATE TABLE Peces(
	ID_Pez INT PRIMARY KEY IDENTITY,
	ID_Pez_Variedad INT,
	ID_Pez_Tamaño INT FOREIGN KEY REFERENCES Pez_Tamaños(ID_Pez_Tamaño),
	ID_Precio INT,
	Nombre VARCHAR(50) NOT NULL,
	Stock INT DEFAULT 0
)
GO

CREATE TABLE Peces_Movimientos(
	ID_Pez_Movimiento INT PRIMARY KEY IDENTITY,
	ID_Pez INT FOREIGN KEY REFERENCES Peces (ID_PEZ) NOT NULL,
	Cantidad INT NOT NULL,
	Fecha_Hora DATETIME NOT NULL
)
GO

CREATE TABLE Clientes(
	ID_Cliente INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR(50),
	Cuit VARCHAR(15),
	Mail VARCHAR(50),
	Telefono_1 VARCHAR(20),
	Telefono_2 VARCHAR(20),
	Telefono_3 VARCHAR(20)
)
GO

CREATE TABLE Cuentas(
	ID_Cuenta INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR(20) NOT NULL,
	Balance DECIMAL(17, 2) NOT NULL,
)
GO

CREATE TABLE Tipo_Transacciones(
	ID_Tipo_Transaccion INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR(30) UNIQUE NOT NULL
)
GO

CREATE TABLE Transacciones(
	ID_Transaccion INT PRIMARY KEY IDENTITY,
	ID_Cuenta INT,
	ID_Tipo_Transaccion INT NOT NULL,
	Monto DECIMAL (17, 2) NOT NULL,
	Fecha_Hora DATETIME
)
GO

CREATE TABLE Compras(
	ID_Compra INT PRIMARY KEY IDENTITY,
	ID_Transaccion INT FOREIGN KEY REFERENCES Transacciones (ID_Transaccion),
	ID_Cuenta INT,
	Cuenta VARCHAR(20) NOT NULL,
	Total DECIMAL(17, 2) NOT NULL,
	Fecha_Hora DATETIME	NOT NULL
)

CREATE TABLE Compra_Items(
	ID_Compra_Item INT PRIMARY KEY IDENTITY,
	ID_Compra INT FOREIGN KEY REFERENCES Compras(ID_Compra),
	ID_Pez INT NOT NULL,
	Nombre_Pez VARCHAR(50) NOT NULL,
	Cantidad INT NOT NULL,
	Subtotal DECIMAL(17, 2) NOT NULL
)
GO

CREATE TABLE Ventas(
	ID_Venta INT PRIMARY KEY IDENTITY,
	ID_Transaccion INT FOREIGN KEY REFERENCES Transacciones (ID_Transaccion),
	ID_Cuenta INT,
	ID_Cliente INT,
	Cuenta VARCHAR(20) NOT NULL,
	Cliente VARCHAR(50) NOT NULL,
	Total DECIMAL(17, 2) NOT NULL,
	Fecha_Hora DATETIME	NOT NULL
)
GO

CREATE TABLE Venta_Items(
	ID_Venta_Item INT PRIMARY KEY IDENTITY,
	ID_Venta INT FOREIGN KEY REFERENCES Ventas(ID_Venta),
	ID_Pez INT NOT NULL,
	Nombre_Pez VARCHAR(50) NOT NULL,
	Monto_Unitario DECIMAL(17, 2) NOT NULL,
	Cantidad INT NOT NULL,
	Subtotal DECIMAL(17, 2) NOT NULL
)
GO

CREATE TABLE Gasto_Categorias(
	ID_Gasto_Categoria INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR(30) UNIQUE NOT NULL
)
GO

CREATE TABLE Gastos(
	ID_Gasto INT PRIMARY KEY IDENTITY,
	ID_Transaccion INT NOT NULL,
	ID_Gasto_Categoria INT NOT NULL,
	ID_Cuenta INT,
	Descripcion VARCHAR(30) NOT NULL,
	Monto DECIMAL (17, 2) NOT NULL,
	Fecha_Hora DATETIME
)
GO

/*|==============================INSERTS==============================|*/

INSERT INTO Cuentas
VALUES('AHORROS', 0), ('EFECTIVO', 0), ('BANCO', 0), ('CHEQUES', 0)
GO

INSERT INTO Tipo_Transacciones
VALUES('AJUSTE'), ('TRANSFERENCIA'), ('INGRESO'), ('EGRESO')
GO

INSERT INTO Gasto_Categorias(Nombre)
VALUES('COMPRAS'), ('COMIDA'), ('SUELDOS'),
('RETIROS'), ('SERVICIOS E IMPUESTOS')
GO

INSERT INTO Pez_Tamaños(Nombre)
VALUES('-'), ('MUY CHICO'), ('CHICO'), ('MEDIANO'),
('GRANDE'), ('MUY GRANDE')
GO

/*|==============================PRODUCCIÓN==============================|*/

INSERT Clientes (Nombre)
VALUES ('Avila'),
('Marcovich Nestor'),
('Aguinaga'),
('Alberto'),
('Bianchi'),
('Marcos Luciano'),
('Andres'),
('Bortolazzi'),
('Bruno'),
('Carlos Moro'),
('Daniel Decorpez'),
('Del Nono Pablo'),
('Maru Gustavo'),
('Distribuidora SyM'),
('Eduardo'),
('Eduardo Feria'),
('Fernando Palomar'),
('Fornaro'),
('German Montegrande'),
('German River King'),
('Gimenez Marti'),
('Gonzalo Kenyi Fish'),
('Gregorio'),
('Griselda Cordoba'),
('Horacio Romero Perez'),
('Pez Baires'),
('Izzo'),
('Javier Arnaiz'),
('Juan Pablo'),
('Leonardo Mote'),
('Lozupone Ariel'),
('Jacobo'),
('Miguel Aguilar'),
('Mongiardo Alejandro'),
('Musco'),
('Oliveto Marcelo'),
('Pablo Capra'),
('Pablo Japones'),
('Platero'),
('Ramiro'),
('Ricardo Acuarimba'),
('Rogelio'),
('Sebastian Luja'),
('Serassio Rolando'),
('Simo'),
('Spinacci Luis'),
('Tejedor'),
('Vago Carlos'),
('Gustavo Cella'),
('Ana'),
('Tranz Pez'),
('Fernandez Santos'),
('Arcon Claudio'),
('Arcon Gustavo'),
('Roberto Mundopez'),
('Julio'),
('Alfonso Ramos Mejia'),
('Cataneo'),
('Oscar'),
('Casal'),
('Leandro'),
('Juan Castro'),
('Miguel Moreno'),
('Alejandro Luciano'),
('Antonio Frutos'),
('Babenko'),
('Sergio'),
('Miguel Feriante'),
('Daniels Gabriel Alanis'),
('Bocha'),
('Daniel Nautilus'),
('Cristian Starnari'),
('Diego'),
('Salteno'),
('Luis'),
('Bombazaro'),
('Rabino Eduardo'),
('Marcelo'),
('Agostinelli Leonidas'),
('Marcelito'),
('Acuamanus'),
('Corralero Daniel'),
('Sandro'),
('Barco Gustavo'),
('Juan Manuel'),
('Walter'),
('Roberto Simo'),
('Plantas Mauri'),
('Hernan Moro'),
('Colella Nestor'),
('Sanders Mirna'),
('Cristian Moro'),
('Mauro'),
('Juan Carlos'),
('Miguel Canoso Berizo'),
('Marino'),
('Pepe'),
('Ernesto Ocampo'),
('El Faro Javier'),
('Juan Milillo'),
('Pio Ca'),
('Pablo Sueta'),
('Foguel Diego'),
('Jesus'),
('Hector Moro'),
('Claudio'),
('Dan Diego'),
('Jonatha'),
('Matias'),
('Juan Vacherand'),
('Cid Pablo'),
('Daniels'),
('Ichthys'),
('Jua'),
('Claudia'),
('Iva')
GO

INSERT INTO Pez_Especies(Nombre) -- ESPECIES OK
VALUES('Albonubes'),
('Ansistrus'),
('Artemia'),
('Astronotus'),
('Axolotes'),
('Barbus'),
('Beta'),
('Caracol'),
('Cebritas'),
('Colisas'),
('Corydora'),
('Dempsey'),
('Discus'),
('Espada'),
('Kerri'),
('Lebistes'),
('Melanotaenia'),
('Moly'),
('Monjita'),
('Neon'),
('Platys'),
('Rana'),
('Scalar'),
('Serpae'),
('Trichos'),
('Vieja')

-- Crea las variedades default para cada especie
INSERT INTO Pez_Variedades(ID_Pez_Especie, Nombre, Es_Default)
VALUES(1, '-', 1),
(2, '-', 1),
(3, '-', 1),
(4, '-', 1),
(5, '-', 1),
(6, '-', 1),
(7, '-', 1),
(8, '-', 1),
(9, '-', 1),
(10, '-', 1),
(11, '-', 1),
(12, '-', 1),
(13, '-', 1),
(14, '-', 1),
(15, '-', 1),
(16, '-', 1),
(17, '-', 1),
(18, '-', 1),
(19, '-', 1),
(20, '-', 1),
(21, '-', 1),
(22, '-', 1),
(23, '-', 1),
(24, '-', 1),
(25, '-', 1),
(26, '-', 1)
GO

INSERT INTO Pez_Variedades(ID_Pez_Especie, Nombre) -- VARIEDADES OK
VALUES(6, 'Blushing'),
(6, 'Conchonius'),
(6, 'Shuberti'),
(6, 'Tetrazona'),
(6, 'Titeya'),
(6, 'Titeya Albino'),
(6, 'Verde'),
(7, 'Hembra'),
(7, 'Macho'),
(9, 'Fluo'),
(9, 'Rojas'),
(11, 'Albina'),
(12, 'Blue'),
(14, 'Berlines'),
(14, 'Lira'),
(14, 'Rojo'),
(14, 'Variedad'),
(14, 'Wactail'),
(15, 'Blue'),
(16, 'Cobra'),
(16, 'Negro'),
(18, 'Albina'),
(18, 'Balon'),
(18, 'Bandera'),
(18, 'Bandera Lira'),
(18, 'Chocolate'),
(18, 'Golden'),
(18, 'Manchada'),
(18, 'Negra'),
(18, 'Negra Lira'),
(18, 'Perlada'),
(18, 'Perlada Lira'),
(18, 'Pico'),
(18, 'Pico Lira'),
(18, 'Platino Lira'),
(18, 'Surtida'),
(18, 'Surtida Lira'),
(19, 'Blanca'),
(19, 'Negra'),
(20, 'Cardenal'),
(20, 'Negro'),
(22, 'Albina'),
(24, 'Velifero'),
(26, 'Real')
GO

INSERT Peces (ID_Pez_Variedad, ID_Pez_Tamaño, ID_Precio, Nombre, Stock)
VALUES (1, 1, 1, 'Albonubes', 999999),
(2, 1, 2, 'Ansistrus', 999999),
(3, 1, 3, 'Artemia', 999999),
(4, 1, 4, 'Astronotus', 999999),
(5, 1, 5, 'Axolotes', 999999),
(27, 1, 6, 'Barbus Blushing', 999999),
(28, 1, 7, 'Barbus Conchonius', 999999),
(29, 1, 8, 'Barbus Shuberti', 999999),
(30, 1, 9, 'Barbus Tetrazona', 999999),
(31, 1, 10, 'Barbus Titeya', 999999),
(32, 1, 11, 'Barbus Titeya Albino', 999999),
(33, 1, 12, 'Barbus Verde', 999999),
(34, 1, 13, 'Beta Hembra', 999999),
(35, 1, 14, 'Beta Macho', 999999),
(8, 1, 15, 'Caracol', 999999),
(36, 1, 16, 'CebritFluo', 999999),
(37, 1, 17, 'CebritRojas', 999999),
(10, 1, 18, 'Colisas', 999999),
(38, 1, 19, 'Corydora Albina', 999999),
(39, 1, 20, 'Dempsey Blue', 999999),
(13, 1, 21, 'Discus', 999999),
(40, 1, 22, 'Espada Berlines', 999999),
(41, 1, 23, 'Espada Lira', 999999),
(42, 1, 24, 'Espada Rojo', 999999),
(43, 1, 25, 'Espada Variedad', 999999),
(44, 1, 26, 'Espada Wactail', 999999),
(45, 1, 27, 'Kerri Blue', 999999),
(16, 1, 28, 'Lebistes', 999999),
(46, 1, 29, 'Lebistes Cobra', 999999),
(47, 1, 30, 'Lebistes Negro', 999999),
(17, 1, 31, 'Melanotaenia', 999999),
(48, 1, 32, 'Moly Albina', 999999),
(49, 1, 33, 'Moly Balon', 999999),
(50, 1, 34, 'Moly Bandera', 999999),
(51, 1, 35, 'Moly Bandera Lira', 999999),
(52, 1, 36, 'Moly Chocolate', 999999),
(53, 1, 37, 'Moly Golden', 999999),
(54, 1, 38, 'Moly Manchada', 999999),
(55, 1, 39, 'Moly Negra', 999999),
(56, 1, 40, 'Moly Negra Lira', 999999),
(57, 1, 41, 'Moly Perlada', 999999),
(58, 1, 42, 'Moly Perlada Lira', 999999),
(59, 1, 43, 'Moly Pico', 999999),
(60, 1, 44, 'Moly Pico Lira', 999999),
(61, 1, 45, 'Moly Platino Lira', 999999),
(62, 1, 46, 'Moly Surtida', 999999),
(63, 1, 47, 'Moly Surtida Lira', 999999),
(64, 1, 48, 'Monjita Blanca', 999999),
(65, 1, 49, 'Monjita Negra', 999999),
(66, 1, 50, 'Neon Cardenal', 999999),
(67, 1, 51, 'Neon Negro', 999999),
(21, 1, 52, 'Platys', 999999),
(68, 1, 53, 'Rana Albina', 999999),
(23, 1, 54, 'Scalar', 999999),
(69, 1, 55, 'Serpae Velifero', 999999),
(25, 1, 56, 'Trichos', 999999),
(70, 1, 57, 'Vieja Real', 999999)
GO

INSERT Precios (Precio_Minorista, Precio_Mayorista, Precio_Oferta, Precio_Distribuidor)
VALUES (25, 18.9, 0, 0),
(38, 27.1, 0, 0),
(0, 0, 0, 0),
(40, 43, 0, 0),
(35, 30, 0, 0),
(11, 9.8, 0, 0),
(11, 9.8, 7.50, 0),
(11, 9.8, 0, 0),
(11, 9.8, 6.30, 0),
(17, 18, 0, 0),
(20, 18, 0, 0),
(16, 15.5, 12.1, 0),
(30, 31, 0, 0),
(40, 40.5, 0, 0),
(25, 22.7, 0, 0),
(9, 9.3, 0, 0),
(7.50, 7.1, 0, 0),
(25, 21.4, 0, 0),
(13, 11, 0, 0),
(36, 29, 0, 0),
(350, 336, 0, 0),
(11.00, 10.70, 0.00, 0.00),
(16.50, 20.20, 16.30, 0.00),
(10.00, 8.90, 0.00, 0.00),
(9.00, 8.40, 6.20, 0.00),
(11.00, 9.80, 7.50, 0.00),
(26.00, 23.40, 0.00, 0.00),
(24.00, 21.20, 0.00, 0.00),
(33.00, 30.00, 0.00, 0.00),
(30.00, 28.00, 0.00, 0.00),
(21.00, 18.30, 14.00, 0.00),
(20.00, 19.40, 14.00, 0.00),
(24.00, 19.40, 21.00, 0.00),
(0.00, 21.00, 0.00, 0.00),
(0.00, 23.70, 0.00, 0.00),
(14.50, 21.00, 0.00, 0.00),
(14.50, 19.40, 0.00, 0.00),
(23.00, 19.40, 0.00, 0.00),
(22.00, 19.40, 0.00, 0.00),
(23.00, 21.00, 0.00, 0.00),
(23.00, 19.50, 0.00, 0.00),
(25.00, 23.70, 0.00, 0.00),
(22.00, 19.40, 0.00, 0.00),
(23.00, 21.00, 0.00, 0.00),
(15.00, 21.00, 0.00, 0.00),
(22.00, 19.40, 0.00, 0.00),
(23.00, 21.00, 0.00, 0.00),
(11.00, 9.80, 7.40, 0.00),
(11.00, 9.80, 7.40, 0.00),
(26.00, 26.70, 0.00, 0.00),
(19.00, 18.40, 0.00, 0.00),
(20.00, 19.40, 0.00, 0.00),
(21.40, 17.10, 0.00, 0.00),
(15.00, 14.50, 12.00, 0.00),
(17.00, 15.90, 0.00, 0.00),
(12.00, 10.80, 8.90, 0.00),
(35.00, 32.00, 0.00, 0.00)

/*|==============================DEVELOPMENT==============================|*/

/*INSERT Clientes (Nombre, Cuit, Mail, Telefono_1_1, Telefono_1_2, Telefono_1_3) VALUES ('Lucio', '20-39462685-7', 'luciodebella@gmail.com', '1161074253', '')
INSERT Clientes (Nombre, Cuit, Mail, Telefono_1_1, Telefono_1_2, Telefono_1_3) VALUES ('Pepe', '20-20125896-7', 'pepe@gmail.com', '1525256112', '')
INSERT Clientes (Nombre, Cuit, Mail, Telefono_1_1, Telefono_1_2, Telefono_1_3) VALUES ('Claudio', '20-20202020-7', 'claudio@gmail.com', '1554451568', '')

INSERT Precios (Precio_Minorista, Precio_Mayorista, Precio_Oferta, Precio_Distribuidor) VALUES (10.00, 10.00, 10.00, 10.00)
INSERT Precios (Precio_Minorista, Precio_Mayorista, Precio_Oferta, Precio_Distribuidor) VALUES (11.00, 11.00, 11.00, 11.00)
INSERT Precios (Precio_Minorista, Precio_Mayorista, Precio_Oferta, Precio_Distribuidor) VALUES (12.00, 12.00, 12.00, 12.00)
INSERT Precios (Precio_Minorista, Precio_Mayorista, Precio_Oferta, Precio_Distribuidor) VALUES (13.00, 13.00, 13.00, 13.00)
INSERT Precios (Precio_Minorista, Precio_Mayorista, Precio_Oferta, Precio_Distribuidor) VALUES (14.00, 14.00, 14.00, 14.00)
INSERT Precios (Precio_Minorista, Precio_Mayorista, Precio_Oferta, Precio_Distribuidor) VALUES (15.00, 15.00, 15.00, 15.00)
INSERT Precios (Precio_Minorista, Precio_Mayorista, Precio_Oferta, Precio_Distribuidor) VALUES (16.00, 16.00, 16.00, 16.00)

INSERT Peces (ID_Pez_Variedad, ID_Pez_Tamaño, ID_Precio, Nombre, Stock) VALUES (4, 1, 1, 'Beta Alfa', 10)
INSERT Peces (ID_Pez_Variedad, ID_Pez_Tamaño, ID_Precio, Nombre, Stock) VALUES (5, 2, 2, 'Beta Tita', 11)
INSERT Peces (ID_Pez_Variedad, ID_Pez_Tamaño, ID_Precio, Nombre, Stock) VALUES (6, 3, 3, 'Carpa Carpota', 12)
INSERT Peces (ID_Pez_Variedad, ID_Pez_Tamaño, ID_Precio, Nombre, Stock) VALUES (7, 4, 4, 'Carpa Carpita', 13)
INSERT Peces (ID_Pez_Variedad, ID_Pez_Tamaño, ID_Precio, Nombre, Stock) VALUES (8, 1, 5, 'Dorado Amarillo', 15)
INSERT Peces (ID_Pez_Variedad, ID_Pez_Tamaño, ID_Precio, Nombre, Stock) VALUES (9, 3, 6, 'Dorado Verde', 16)
INSERT Peces (ID_Pez_Variedad, ID_Pez_Tamaño, ID_Precio, Nombre, Stock) VALUES (10, 2, 7, 'Dorado Azul', 17)

INSERT Pez_Especies (Nombre) VALUES ('Beta')
INSERT Pez_Especies (Nombre) VALUES ('Carpa')
INSERT Pez_Especies (Nombre) VALUES ('Dorado')

INSERT Pez_Variedades (ID_Pez_Especie, Nombre, Es_Default) VALUES (1, 'Alfa', 0)
INSERT Pez_Variedades (ID_Pez_Especie, Nombre, Es_Default) VALUES (1, 'Tita', 0)
INSERT Pez_Variedades (ID_Pez_Especie, Nombre, Es_Default) VALUES (2, 'Carpota', 0)
INSERT Pez_Variedades (ID_Pez_Especie, Nombre, Es_Default) VALUES (2, 'Carpita', 0)
INSERT Pez_Variedades (ID_Pez_Especie, Nombre, Es_Default) VALUES (3, 'Amarillo', 0)
INSERT Pez_Variedades (ID_Pez_Especie, Nombre, Es_Default) VALUES (3, 'Verde', 0)
INSERT Pez_Variedades (ID_Pez_Especie, Nombre, Es_Default) VALUES (3, 'Azul', 0)
*/