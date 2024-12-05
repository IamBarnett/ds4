-- Crear Base de Datos
CREATE DATABASE SoporteTecnicoDB
GO

USE SoporteTecnicoDB
GO

-- Tabla de Usuarios
CREATE TABLE Usuarios (
    UsuarioID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Email NVARCHAR(200) NOT NULL,
    Contrasena NVARCHAR(200) NOT NULL, -- Para hash de contraseña
    Rol NVARCHAR(50) NOT NULL -- 'Empleado', 'Tecnico', 'Administrador'
)

-- Tabla de Tickets
CREATE TABLE Tickets (
    TicketID INT PRIMARY KEY IDENTITY(1,1),
    Titulo NVARCHAR(200) NOT NULL,
    Descripcion NVARCHAR(MAX) NOT NULL,
    Estado NVARCHAR(50) NOT NULL, -- 'Nuevo', 'En Progreso', 'Resuelto', 'Cerrado'
    FechaCreacion DATETIME DEFAULT GETDATE(),
    FechaUltimaActualizacion DATETIME,
    UsuarioID INT FOREIGN KEY REFERENCES Usuarios(UsuarioID),
    TecnicoAsignadoID INT FOREIGN KEY REFERENCES Usuarios(UsuarioID)
)

-- Tabla de Historial de Tickets
CREATE TABLE HistorialTickets (
    HistorialID INT PRIMARY KEY IDENTITY(1,1),
    TicketID INT FOREIGN KEY REFERENCES Tickets(TicketID),
    Descripcion NVARCHAR(MAX) NOT NULL,
    FechaActualizacion DATETIME DEFAULT GETDATE(),
    UsuarioID INT FOREIGN KEY REFERENCES Usuarios(UsuarioID)
)

-- Insertar usuarios de prueba
INSERT INTO Usuarios (Nombre, Email, Contrasena, Rol) VALUES 
('Admin', 'admin@empresa.com', 'passwordhash', 'Administrador'),
('Tecnico1', 'tecnico1@empresa.com', 'passwordhash', 'Tecnico'),
('Empleado1', 'empleado1@empresa.com', 'passwordhash', 'Empleado')
