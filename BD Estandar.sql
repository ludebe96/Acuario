/*|==============================ESTRUCTURA==============================|*/
CREATE DATABASE Acuario
GO

USE Acuario
GO

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
	Es_Default BIT NOT NULL
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
	ID_Pez_Tamaño INT,
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
VALUES('AHORROS', 0), ('CAJA', 0), ('BANCO', 0), ('CHEQUES', 0)
GO

INSERT INTO Tipo_Transacciones
VALUES('AJUSTE'), ('INGRESO'), ('EGRESO')
GO

INSERT INTO Gasto_Categorias(Nombre)
VALUES('COMPRAS'), ('COMIDA'), ('SUELDOS'),
('RETIROS'), ('SERVICIOS E IMPUESTOS')
GO

INSERT INTO Pez_Tamaños(Nombre)
VALUES('MUY CHICO'), ('CHICO'), ('MEDIANO'),
('GRANDE'), ('MUY GRANDE')
GO


/*|==============================DEVELOPMENT==============================|*/

INSERT [dbo].[Clientes] ([Nombre], [Cuit], [Mail], [Telefono_1], [Telefono_2], [Telefono_3]) VALUES (N'Lucio', N'20-39462685-7', N'luciodebella@gmail.com', N'1161074253', N'', N'')
INSERT [dbo].[Clientes] ([Nombre], [Cuit], [Mail], [Telefono_1], [Telefono_2], [Telefono_3]) VALUES (N'Pepe', N'20-20125896-7', N'pepe@gmail.com', N'1525256112', N'', N'')
INSERT [dbo].[Clientes] ([Nombre], [Cuit], [Mail], [Telefono_1], [Telefono_2], [Telefono_3]) VALUES (N'Claudio', N'20-20202020-7', N'claudio@gmail.com', N'1554451568', N'', N'')

INSERT [dbo].[Precios] ([Precio_Minorista], [Precio_Mayorista], [Precio_Oferta], [Precio_Distribuidor]) VALUES (CAST(10.00 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)))
INSERT [dbo].[Precios] ([Precio_Minorista], [Precio_Mayorista], [Precio_Oferta], [Precio_Distribuidor]) VALUES (CAST(11.00 AS Decimal(10, 2)), CAST(11.00 AS Decimal(10, 2)), CAST(11.00 AS Decimal(10, 2)), CAST(11.00 AS Decimal(10, 2)))
INSERT [dbo].[Precios] ([Precio_Minorista], [Precio_Mayorista], [Precio_Oferta], [Precio_Distribuidor]) VALUES (CAST(12.00 AS Decimal(10, 2)), CAST(12.00 AS Decimal(10, 2)), CAST(12.00 AS Decimal(10, 2)), CAST(12.00 AS Decimal(10, 2)))
INSERT [dbo].[Precios] ([Precio_Minorista], [Precio_Mayorista], [Precio_Oferta], [Precio_Distribuidor]) VALUES (CAST(13.00 AS Decimal(10, 2)), CAST(13.00 AS Decimal(10, 2)), CAST(13.00 AS Decimal(10, 2)), CAST(13.00 AS Decimal(10, 2)))
INSERT [dbo].[Precios] ([Precio_Minorista], [Precio_Mayorista], [Precio_Oferta], [Precio_Distribuidor]) VALUES (CAST(14.00 AS Decimal(10, 2)), CAST(14.00 AS Decimal(10, 2)), CAST(14.00 AS Decimal(10, 2)), CAST(14.00 AS Decimal(10, 2)))
INSERT [dbo].[Precios] ([Precio_Minorista], [Precio_Mayorista], [Precio_Oferta], [Precio_Distribuidor]) VALUES (CAST(15.00 AS Decimal(10, 2)), CAST(15.00 AS Decimal(10, 2)), CAST(15.00 AS Decimal(10, 2)), CAST(15.00 AS Decimal(10, 2)))
INSERT [dbo].[Precios] ([Precio_Minorista], [Precio_Mayorista], [Precio_Oferta], [Precio_Distribuidor]) VALUES (CAST(16.00 AS Decimal(10, 2)), CAST(16.00 AS Decimal(10, 2)), CAST(16.00 AS Decimal(10, 2)), CAST(16.00 AS Decimal(10, 2)))

INSERT [dbo].[Peces] ([ID_Pez_Variedad], [ID_Pez_Tamaño], [ID_Precio], [Nombre], [Stock]) VALUES (4, 1, 1, N'Beta Alfa', 10)
INSERT [dbo].[Peces] ([ID_Pez_Variedad], [ID_Pez_Tamaño], [ID_Precio], [Nombre], [Stock]) VALUES (5, 2, 2, N'Beta Tita', 11)
INSERT [dbo].[Peces] ([ID_Pez_Variedad], [ID_Pez_Tamaño], [ID_Precio], [Nombre], [Stock]) VALUES (6, 3, 3, N'Carpa Carpota', 12)
INSERT [dbo].[Peces] ([ID_Pez_Variedad], [ID_Pez_Tamaño], [ID_Precio], [Nombre], [Stock]) VALUES (7, 4, 4, N'Carpa Carpita', 13)
INSERT [dbo].[Peces] ([ID_Pez_Variedad], [ID_Pez_Tamaño], [ID_Precio], [Nombre], [Stock]) VALUES (8, 1, 5, N'Dorado Amarillo', 15)
INSERT [dbo].[Peces] ([ID_Pez_Variedad], [ID_Pez_Tamaño], [ID_Precio], [Nombre], [Stock]) VALUES (9, 3, 6, N'Dorado Verde', 16)
INSERT [dbo].[Peces] ([ID_Pez_Variedad], [ID_Pez_Tamaño], [ID_Precio], [Nombre], [Stock]) VALUES (10, 2, 7, N'Dorado Azul', 17)

INSERT [dbo].[Pez_Especies] ([Nombre]) VALUES (N'Beta')
INSERT [dbo].[Pez_Especies] ([Nombre]) VALUES (N'Carpa')
INSERT [dbo].[Pez_Especies] ([Nombre]) VALUES (N'Dorado')

INSERT [dbo].[Pez_Variedades] ([ID_Pez_Especie], [Nombre], [Es_Default]) VALUES (1, N'-', 1)
INSERT [dbo].[Pez_Variedades] ([ID_Pez_Especie], [Nombre], [Es_Default]) VALUES (2, N'-', 1)
INSERT [dbo].[Pez_Variedades] ([ID_Pez_Especie], [Nombre], [Es_Default]) VALUES (3, N'-', 1)
INSERT [dbo].[Pez_Variedades] ([ID_Pez_Especie], [Nombre], [Es_Default]) VALUES (1, N'Alfa', 0)
INSERT [dbo].[Pez_Variedades] ([ID_Pez_Especie], [Nombre], [Es_Default]) VALUES (1, N'Tita', 0)
INSERT [dbo].[Pez_Variedades] ([ID_Pez_Especie], [Nombre], [Es_Default]) VALUES (2, N'Carpota', 0)
INSERT [dbo].[Pez_Variedades] ([ID_Pez_Especie], [Nombre], [Es_Default]) VALUES (2, N'Carpita', 0)
INSERT [dbo].[Pez_Variedades] ([ID_Pez_Especie], [Nombre], [Es_Default]) VALUES (3, N'Amarillo', 0)
INSERT [dbo].[Pez_Variedades] ([ID_Pez_Especie], [Nombre], [Es_Default]) VALUES (3, N'Verde', 0)
INSERT [dbo].[Pez_Variedades] ([ID_Pez_Especie], [Nombre], [Es_Default]) VALUES (3, N'Azul', 0)