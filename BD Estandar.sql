/*|==============================ESTRUCTURA==============================|*/
CREATE DATABASE Acuario
GO

USE Acuario
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
	ID_Cuenta INT FOREIGN KEY REFERENCES Cuentas (ID_Cuenta),
	ID_Tipo_Transaccion INT FOREIGN KEY REFERENCES Tipo_Transacciones (ID_Tipo_Transaccion) NOT NULL,
	Monto DECIMAL (17, 5) NOT NULL,
	Fecha_Hora DATETIME
)
GO

CREATE TABLE Gasto_Categorias(
	ID_Gasto_Categoria INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR(30) UNIQUE NOT NULL
)
GO

CREATE TABLE Gastos(
	ID_Gasto INT PRIMARY KEY IDENTITY,
	ID_Transaccion INT FOREIGN KEY REFERENCES Transacciones (ID_Transaccion) NOT NULL,
	ID_Gasto_Categoria INT FOREIGN KEY REFERENCES Gasto_Categorias (ID_Gasto_Categoria) NOT NULL,
	ID_Cuenta INT FOREIGN KEY REFERENCES Cuentas (ID_Cuenta),
	Descripcion VARCHAR(30) NOT NULL,
	Monto DECIMAL (17, 5) NOT NULL,
	Fecha_Hora DATETIME
)
GO

/*|==============================INSERTS==============================|*/

INSERT INTO Cuentas VALUES('AHORROS', 0), ('CAJA', 0), ('BANCO', 0), ('CHEQUES', 0)
GO

INSERT INTO Tipo_Transacciones VALUES('AJUSTE'), ('INGRESO'), ('EGRESO')
GO

INSERT INTO Gasto_Categorias(Nombre) VALUES('COMPRAS'), ('COMIDA'), ('SUELDOS'),
('RETIROS'), ('SERVICIOS E IMPUESTOS')
GO