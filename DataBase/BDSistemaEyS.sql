/*
 * ER/Studio Data Architect SQL Code Generation
 * Project :      SystemaEyS.DM1
 *
 * Date Created : Saturday, May 21, 2022 16:53:30
 * Target DBMS : Microsoft SQL Server 2017
 */

USE master
go
CREATE DATABASE BDSistemaEyS
go
USE BDSistemaEyS
go
/* 
 * TABLE: Asistencia 
 */

CREATE TABLE Asistencia(
    idAsistencia       int        IDENTITY(1,1),
    fechaAsistencia    date       NOT NULL,
    HoraEntrada        time(7)    NULL,
    HoraSalida         time(7)    NULL,
    idEmpleado         int        NULL,
    CONSTRAINT PK4 PRIMARY KEY NONCLUSTERED (idAsistencia)
)
go



IF OBJECT_ID('Asistencia') IS NOT NULL
    PRINT '<<< CREATED TABLE Asistencia >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Asistencia >>>'
go

/* 
 * TABLE: Cargo 
 */

CREATE TABLE Cargo(
    idCargo             int              IDENTITY(1,1),
    nombreCargo         nvarchar(25)     NOT NULL,
    descripcionCargo    nvarchar(100)    NOT NULL,
    CONSTRAINT PK2 PRIMARY KEY NONCLUSTERED (idCargo)
)
go



IF OBJECT_ID('Cargo') IS NOT NULL
    PRINT '<<< CREATED TABLE Cargo >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Cargo >>>'
go

/* 
 * TABLE: Departamento 
 */

CREATE TABLE Departamento(
    idDepartamento             int              IDENTITY(1,1),
    nombreDepartamento         nvarchar(25)     NOT NULL,
    descripcionDepartamento    nvarchar(100)    NOT NULL,
    extensionDepartamento      nvarchar(5)      NOT NULL,
    CONSTRAINT PK3 PRIMARY KEY NONCLUSTERED (idDepartamento)
)
go



IF OBJECT_ID('Departamento') IS NOT NULL
    PRINT '<<< CREATED TABLE Departamento >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Departamento >>>'
go

/* 
 * TABLE: Empleado 
 */

CREATE TABLE Empleado(
    idEmpleado         int             IDENTITY(1,1),
    primerNombre       nvarchar(25)    NOT NULL,
    segundoNombre      nvarchar(25)    NOT NULL,
    primerApellido     nvarchar(25)    NOT NULL,
    segundoApellido    nvarchar(25)    NOT NULL,
    fechaIngreso       datetime        DEFAULT NULL NULL,
    cedulaEmpleado     varchar(14)     NULL,
    pinEmpleado        varchar(30)     NULL,
    idCargo            int             NULL,
    idDepartamento     int             NULL,
    idHorario          int             NULL,
    CONSTRAINT PK1 PRIMARY KEY NONCLUSTERED (idEmpleado)
)
go



IF OBJECT_ID('Empleado') IS NOT NULL
    PRINT '<<< CREATED TABLE Empleado >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Empleado >>>'
go

/* 
 * TABLE: Horario 
 */

CREATE TABLE Horario(
    idHorario          int        IDENTITY(1,1),
    lunesInicio        time(7)    NULL,
    lunesSalida        time(7)    NULL,
    martesInicio       time(7)    NULL,
    martesSalida       time(7)    NULL,
    miercolesInicio    time(7)    NULL,
    miercolesSalida    time(7)    NULL,
    juevesInicio       time(7)    NULL,
    juevesSalida       time(7)    NULL,
    viernesInicio      time(7)    NULL,
    viernesSalida      time(7)    NULL,
    sabadoInicio       time(7)    NULL,
    sabadoSalida       time(7)    NULL,
    domingoInicio      time(7)    NULL,
    domingoSalida      time(7)    NULL,
    CONSTRAINT PK5 PRIMARY KEY NONCLUSTERED (idHorario)
)
go



IF OBJECT_ID('Horario') IS NOT NULL
    PRINT '<<< CREATED TABLE Horario >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Horario >>>'
go

/* 
 * TABLE: SolVacaciones 
 */

CREATE TABLE SolVacaciones(
    idSolVacaciones    int              IDENTITY(1,1),
    fechaSol           datetime         NULL,
    descripcionSol     nvarchar(100)    NOT NULL,
    fechaHoraInicio    datetime         NULL,
    fechaHoraFin       datetime         NULL,
    idEmpleado         int              NULL,
    CONSTRAINT PK7 PRIMARY KEY NONCLUSTERED (idSolVacaciones)
)
go



IF OBJECT_ID('SolVacaciones') IS NOT NULL
    PRINT '<<< CREATED TABLE SolVacaciones >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE SolVacaciones >>>'
go

/* 
 * TABLE: Asistencia 
 */

ALTER TABLE Asistencia ADD CONSTRAINT RefEmpleado5 
    FOREIGN KEY (idEmpleado)
    REFERENCES Empleado(idEmpleado)
go


/* 
 * TABLE: Empleado 
 */

ALTER TABLE Empleado ADD CONSTRAINT RefCargo3 
    FOREIGN KEY (idCargo)
    REFERENCES Cargo(idCargo)
go

ALTER TABLE Empleado ADD CONSTRAINT RefDepartamento4 
    FOREIGN KEY (idDepartamento)
    REFERENCES Departamento(idDepartamento)
go

ALTER TABLE Empleado ADD CONSTRAINT RefHorario6 
    FOREIGN KEY (idHorario)
    REFERENCES Horario(idHorario)
go


/* 
 * TABLE: SolVacaciones 
 */

ALTER TABLE SolVacaciones ADD CONSTRAINT RefEmpleado8 
    FOREIGN KEY (idEmpleado)
    REFERENCES Empleado(idEmpleado)
go


