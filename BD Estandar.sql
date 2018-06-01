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
	Monto DECIMAL (17, 5) NOT NULL,
	Fecha_Hora DATETIME
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
	Monto DECIMAL (17, 5) NOT NULL,
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