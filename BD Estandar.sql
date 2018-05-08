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

/*|==============================INSERTS==============================|*/

INSERT INTO Cuentas VALUES('AHORROS', 0), ('CAJA', 0), ('BANCO', 0), ('CHEQUES', 0)
GO

INSERT INTO Tipo_Transacciones VALUES('AJUSTE'), ('COMPRA'), ('VENTA')
GO