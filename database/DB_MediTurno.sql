-- Script para crear la DB MediTurno

USE Master;
CREATE DATABASE MediTurno;
GO
USE MediTurno;



-- TipoUsuario
CREATE TABLE [dbo].[TipoUsuario] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Descripcion] NVARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [AK_TipoUsuario_Descripcion] UNIQUE NONCLUSTERED ([Descripcion] ASC)
);

SET IDENTITY_INSERT [dbo].[TipoUsuario] ON
INSERT INTO [dbo].[TipoUsuario] ([Id], [Descripcion]) VALUES (1, N'Administrador')
INSERT INTO [dbo].[TipoUsuario] ([Id], [Descripcion]) VALUES (2, N'Gerente')
INSERT INTO [dbo].[TipoUsuario] ([Id], [Descripcion]) VALUES (3, N'Medico')
INSERT INTO [dbo].[TipoUsuario] ([Id], [Descripcion]) VALUES (4, N'Secretario')
INSERT INTO [dbo].[TipoUsuario] ([Id], [Descripcion]) VALUES (0, N'SuperAdministrador')
SET IDENTITY_INSERT [dbo].[TipoUsuario] OFF



-- Persona
CREATE TABLE [dbo].[Persona] (
    [Id]                INT           IDENTITY (1, 1) NOT NULL,
    [Dni]               NVARCHAR (10) NOT NULL,
    [Apellidos]         NVARCHAR (30) NOT NULL,
    [Nombres]           NVARCHAR (30) NOT NULL,
    [FechaNacimiento]   DATETIME      NOT NULL,
    [Sexo]              NVARCHAR (2)  NOT NULL,
    [CorreoElectronico] NVARCHAR (30) NULL,
    [Telefono]          NVARCHAR (15) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [AK_Persona_CorreoElectronico] UNIQUE NONCLUSTERED ([CorreoElectronico] ASC),
    CONSTRAINT [AK_Persona_Dni] UNIQUE NONCLUSTERED ([Dni] ASC)
);

SET IDENTITY_INSERT [dbo].[Persona] ON
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (34, N'36294815', N'Aguirre', N'Gonzalo', N'1990-10-27 00:00:00', N'M', N'ag@mediturno.com', N'011946205')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (35, N'34882204', N'Carrillo', N'Sol', N'1972-02-12 02:31:55', N'F', N'carrillo.sol@mediturno.com', N'292964607')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (36, N'44525247', N'Pereyra', N'Itati', N'1998-10-16 02:35:45', N'F', N'pereyra.itati@gmail.com', N'342969995')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (37, N'33231984', N'Espinoza', N'Jesus', N'1991-05-20 02:38:36', N'M', N'espinoza.jesus@outlook.com', N'260648671')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (38, N'32957282', N'Breard', N'Laura', N'1982-10-08 02:41:16', N'F', N'breard.laura@gmail.com', N'3794462477')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (39, N'42665025', N'Soria', N'Esteban', N'1989-06-28 02:44:34', N'M', N'soria.esteban@mediturno.com', N'3794442498')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (40, N'38621413', N'Lukaszuck', N'Victor', N'1985-11-04 02:46:32', N'M', N'lukaszuck@arnet.com.ar', N'3794423819')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (41, N'39585469', N'Albornoz', N'Fatima', N'1975-05-13 02:48:40', N'F', N'albornoz.fatima@mediturno.com', N'3795059252')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (42, N'32282327', N'De Langhe', N'Valeria', N'2010-10-31 02:50:17', N'F', N'de_langhe.valeria@gmail.com', N'3794230106')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (43, N'37601110', N'Salas', N'Elisa', N'2010-12-01 02:52:05', N'F', N'salas.elisa@outlook.com', N'3794431310')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (44, N'34156605', N'Cruz', N'Hector', N'1984-02-07 02:56:54', N'M', N'cruz.hector@gmail.com', N'37945042832')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (45, N'30187248', N'Lopez', N'Jose', N'1974-08-17 03:00:44', N'M', N'lopez.jose@gmail.com', N'3794427518')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (46, N'28233075', N'Koci', N'Leonardo', N'1983-05-08 03:02:53', N'M', N'koci.leonardo@gmail.com', N'011859509')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (47, N'24564964', N'Gomez', N'Gabriela', N'1979-05-31 03:04:32', N'F', N'gomez.gabriela@mediturno.com', N'364748387')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (48, N'20427173', N'De Robertis', N'Gustavo', N'2043-11-19 03:05:58', N'M', N'de_robertis.gustavo@yahoo.com', N'370822070')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (49, N'26753099', N'Gonzalez', N'Ruben', N'1993-05-12 03:07:47', N'M', N'gonzalez.ruben@gmail.com', N'469644741')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (50, N'25036267', N'Barrios', N'Javier', N'1999-10-12 03:19:14', N'M', N'barrios.javier@outlook.com', N'458666435')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (51, N'16290344', N'Flores', N'Antonio', N'2000-06-11 03:20:13', N'M', N'flores.antonio@yahoo.com', N'008655803')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (52, N'28401719', N'Scassa', N'Ramon', N'2044-10-24 03:21:09', N'M', N'scassa.ramon@arnet.com.ar', N'257755877')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (53, N'37594819', N'Contreras', N'Soledad', N'1973-06-28 03:21:51', N'F', N'contreras.soledad@outlook.com', N'642709559')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (54, N'44945985', N'Rios', N'Alejandro', N'1999-05-30 03:22:46', N'M', N'rios.alejandro@gmail.com', N'662766388')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (55, N'43347993', N'Chamorro', N'Edith', N'1993-09-27 03:31:35', N'F', N'chamorro.edith@gigared.com', N'123747655')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (56, N'12348535', N'Martin', N'Alejandra', N'1993-10-03 03:32:19', N'F', N'martin.alejandra@gigared.com', N'765674885')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (57, N'45237796', N'Gallego', N'Gonzalo', N'1985-05-04 03:33:04', N'M', N'gallego.gonzalo@gmail.com', N'828726375')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (58, N'45745054', N'Zabala', N'Oscar', N'2005-05-08 03:34:23', N'M', N'zabala.oscar@outlook.com', N'055771440')
INSERT INTO [dbo].[Persona] ([Id], [Dni], [Apellidos], [Nombres], [FechaNacimiento], [Sexo], [CorreoElectronico], [Telefono]) VALUES (59, N'45452079', N'Lopez', N'Victoria', N'1993-05-09 03:35:17', N'F', N'lopez.victoria@gmail.com', N'3794462477')
SET IDENTITY_INSERT [dbo].[Persona] OFF



-- ObraSocial
CREATE TABLE [dbo].[ObraSocial] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Nombre] NVARCHAR (30) NOT NULL,
    [Estado] BIT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [AK_ObraSocial_Nombre] UNIQUE NONCLUSTERED ([Nombre] ASC)
);

SET IDENTITY_INSERT [dbo].[ObraSocial] ON
INSERT INTO [dbo].[ObraSocial] ([Id], [Nombre], [Estado]) VALUES (6, N'OSDE', 1)
INSERT INTO [dbo].[ObraSocial] ([Id], [Nombre], [Estado]) VALUES (7, N'Ninguna', 1)
INSERT INTO [dbo].[ObraSocial] ([Id], [Nombre], [Estado]) VALUES (8, N'Accord Salud', 1)
INSERT INTO [dbo].[ObraSocial] ([Id], [Nombre], [Estado]) VALUES (9, N'Galeno', 1)
INSERT INTO [dbo].[ObraSocial] ([Id], [Nombre], [Estado]) VALUES (10, N'Medicus', 1)
INSERT INTO [dbo].[ObraSocial] ([Id], [Nombre], [Estado]) VALUES (11, N'Medifé', 1)
INSERT INTO [dbo].[ObraSocial] ([Id], [Nombre], [Estado]) VALUES (12, N'Sancor Salud', 1)
INSERT INTO [dbo].[ObraSocial] ([Id], [Nombre], [Estado]) VALUES (13, N'Swiss Medical', 1)
SET IDENTITY_INSERT [dbo].[ObraSocial] OFF



-- Especialidad
CREATE TABLE [dbo].[Especialidad] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Descripcion] NVARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [AK_Especialidad_Descripcion] UNIQUE NONCLUSTERED ([Descripcion] ASC)
);

SET IDENTITY_INSERT [dbo].[Especialidad] ON
INSERT INTO [dbo].[Especialidad] ([Id], [Descripcion]) VALUES (7, N'Cardiología')
INSERT INTO [dbo].[Especialidad] ([Id], [Descripcion]) VALUES (8, N'Dermatología')
INSERT INTO [dbo].[Especialidad] ([Id], [Descripcion]) VALUES (9, N'Ginecología')
INSERT INTO [dbo].[Especialidad] ([Id], [Descripcion]) VALUES (10, N'Kinesiología')
INSERT INTO [dbo].[Especialidad] ([Id], [Descripcion]) VALUES (12, N'Neurología')
INSERT INTO [dbo].[Especialidad] ([Id], [Descripcion]) VALUES (13, N'Nutrición')
INSERT INTO [dbo].[Especialidad] ([Id], [Descripcion]) VALUES (11, N'Odontología')
INSERT INTO [dbo].[Especialidad] ([Id], [Descripcion]) VALUES (14, N'Oftalmología')
INSERT INTO [dbo].[Especialidad] ([Id], [Descripcion]) VALUES (15, N'Pediatría')
INSERT INTO [dbo].[Especialidad] ([Id], [Descripcion]) VALUES (16, N'Psicología')
SET IDENTITY_INSERT [dbo].[Especialidad] OFF



-- TurnoEstado
CREATE TABLE [dbo].[TurnoEstado] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Descripcion] NVARCHAR (15) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [AK_TurnoEstado_Descripcion] UNIQUE NONCLUSTERED ([Descripcion] ASC)
);

SET IDENTITY_INSERT [dbo].[TurnoEstado] ON
INSERT INTO [dbo].[TurnoEstado] ([Id], [Descripcion]) VALUES (4, N'Cancelado')
INSERT INTO [dbo].[TurnoEstado] ([Id], [Descripcion]) VALUES (2, N'En Espera')
INSERT INTO [dbo].[TurnoEstado] ([Id], [Descripcion]) VALUES (3, N'Finalizado')
INSERT INTO [dbo].[TurnoEstado] ([Id], [Descripcion]) VALUES (1, N'Reservado')
SET IDENTITY_INSERT [dbo].[TurnoEstado] OFF



-- Empleado
CREATE TABLE [dbo].[Empleado] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [PersonaId]     INT           NOT NULL,
    [Cuil]          NVARCHAR (15) NOT NULL,
    [Usuario]       NVARCHAR (15) NOT NULL,
    [Contraseña]    NVARCHAR (50) NOT NULL,
    [FechaIngreso]  DATETIME      NOT NULL,
    [TipoUsuarioId] INT           NOT NULL,
    [Activo]        BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [AK_Empleado_Cuil] UNIQUE NONCLUSTERED ([Cuil] ASC),
    CONSTRAINT [AK_Empleado_Usuario] UNIQUE NONCLUSTERED ([Usuario] ASC),
    CONSTRAINT [FK_Empleado_TipoUsuario] FOREIGN KEY ([TipoUsuarioId]) REFERENCES [dbo].[TipoUsuario] ([Id]),
    CONSTRAINT [FK_Empleado_Persona] FOREIGN KEY ([PersonaId]) REFERENCES [dbo].[Persona] ([Id])
);

SET IDENTITY_INSERT [dbo].[Empleado] ON
INSERT INTO [dbo].[Empleado] ([Id], [PersonaId], [Cuil], [Usuario], [Contraseña], [FechaIngreso], [TipoUsuarioId], [Activo]) VALUES (12, 34, N'20362948157', N'sup', N'12345678', N'2020-08-12 17:00:00', 0, 1)
INSERT INTO [dbo].[Empleado] ([Id], [PersonaId], [Cuil], [Usuario], [Contraseña], [FechaIngreso], [TipoUsuarioId], [Activo]) VALUES (13, 35, N'27348822042', N'adm', N'12345678', N'2000-07-10 02:31:55', 1, 1)
INSERT INTO [dbo].[Empleado] ([Id], [PersonaId], [Cuil], [Usuario], [Contraseña], [FechaIngreso], [TipoUsuarioId], [Activo]) VALUES (14, 36, N'27445252471', N'ger', N'12345678', N'2015-05-23 02:35:45', 2, 1)
INSERT INTO [dbo].[Empleado] ([Id], [PersonaId], [Cuil], [Usuario], [Contraseña], [FechaIngreso], [TipoUsuarioId], [Activo]) VALUES (15, 37, N'20332319842', N'sec', N'12345678', N'2019-07-27 02:38:36', 4, 1)
INSERT INTO [dbo].[Empleado] ([Id], [PersonaId], [Cuil], [Usuario], [Contraseña], [FechaIngreso], [TipoUsuarioId], [Activo]) VALUES (16, 38, N'27329572825', N'med', N'12345678', N'2013-01-14 02:41:16', 3, 1)
INSERT INTO [dbo].[Empleado] ([Id], [PersonaId], [Cuil], [Usuario], [Contraseña], [FechaIngreso], [TipoUsuarioId], [Activo]) VALUES (17, 39, N'20426650259', N'soria', N'12345678', N'1993-05-11 02:44:34', 3, 1)
INSERT INTO [dbo].[Empleado] ([Id], [PersonaId], [Cuil], [Usuario], [Contraseña], [FechaIngreso], [TipoUsuarioId], [Activo]) VALUES (18, 40, N'20386214135', N'lukaszuck', N'12345678', N'2020-06-16 02:46:32', 3, 1)
INSERT INTO [dbo].[Empleado] ([Id], [PersonaId], [Cuil], [Usuario], [Contraseña], [FechaIngreso], [TipoUsuarioId], [Activo]) VALUES (19, 41, N'20395854694', N'albornoz', N'12345678', N'2020-01-01 02:48:40', 3, 1)
INSERT INTO [dbo].[Empleado] ([Id], [PersonaId], [Cuil], [Usuario], [Contraseña], [FechaIngreso], [TipoUsuarioId], [Activo]) VALUES (20, 42, N'20322823277', N'de_langhe', N'12345678', N'2019-07-14 02:50:17', 3, 1)
INSERT INTO [dbo].[Empleado] ([Id], [PersonaId], [Cuil], [Usuario], [Contraseña], [FechaIngreso], [TipoUsuarioId], [Activo]) VALUES (21, 43, N'20376011101', N'salas', N'12345678', N'2018-01-22 02:52:05', 3, 1)
INSERT INTO [dbo].[Empleado] ([Id], [PersonaId], [Cuil], [Usuario], [Contraseña], [FechaIngreso], [TipoUsuarioId], [Activo]) VALUES (22, 44, N'20341566055', N'cruz', N'12345678', N'2020-05-01 02:56:55', 3, 1)
INSERT INTO [dbo].[Empleado] ([Id], [PersonaId], [Cuil], [Usuario], [Contraseña], [FechaIngreso], [TipoUsuarioId], [Activo]) VALUES (23, 45, N'20301872480', N'lopez', N'12345678', N'2008-11-30 03:00:44', 1, 0)
INSERT INTO [dbo].[Empleado] ([Id], [PersonaId], [Cuil], [Usuario], [Contraseña], [FechaIngreso], [TipoUsuarioId], [Activo]) VALUES (24, 46, N'20282330759', N'koci', N'12345678', N'2019-01-01 03:02:53', 2, 1)
INSERT INTO [dbo].[Empleado] ([Id], [PersonaId], [Cuil], [Usuario], [Contraseña], [FechaIngreso], [TipoUsuarioId], [Activo]) VALUES (25, 47, N'21245649646', N'gomez', N'12345678', N'2020-10-01 03:04:32', 2, 1)
INSERT INTO [dbo].[Empleado] ([Id], [PersonaId], [Cuil], [Usuario], [Contraseña], [FechaIngreso], [TipoUsuarioId], [Activo]) VALUES (26, 48, N'23204271739', N'de_robertis', N'12345678', N'2020-02-25 03:05:58', 4, 0)
INSERT INTO [dbo].[Empleado] ([Id], [PersonaId], [Cuil], [Usuario], [Contraseña], [FechaIngreso], [TipoUsuarioId], [Activo]) VALUES (27, 49, N'20267530999', N'gonzalez', N'12345678', N'2019-05-23 03:07:47', 4, 1)
SET IDENTITY_INSERT [dbo].[Empleado] OFF



-- Cobertura
CREATE TABLE [dbo].[Cobertura] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [ObraSocialId] INT           NOT NULL,
    [Descripcion]  NVARCHAR (30) NOT NULL,
    [Estado]       BIT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Cobertura_ObraSocial] FOREIGN KEY ([ObraSocialId]) REFERENCES [dbo].[ObraSocial] ([Id])
);

SET IDENTITY_INSERT [dbo].[Cobertura] ON
INSERT INTO [dbo].[Cobertura] ([Id], [ObraSocialId], [Descripcion], [Estado]) VALUES (10, 7, N'Ninguna', 1)
INSERT INTO [dbo].[Cobertura] ([Id], [ObraSocialId], [Descripcion], [Estado]) VALUES (11, 6, N'210', 1)
INSERT INTO [dbo].[Cobertura] ([Id], [ObraSocialId], [Descripcion], [Estado]) VALUES (12, 6, N'310', 0)
INSERT INTO [dbo].[Cobertura] ([Id], [ObraSocialId], [Descripcion], [Estado]) VALUES (13, 6, N'410', 0)
INSERT INTO [dbo].[Cobertura] ([Id], [ObraSocialId], [Descripcion], [Estado]) VALUES (14, 6, N'510', 1)
INSERT INTO [dbo].[Cobertura] ([Id], [ObraSocialId], [Descripcion], [Estado]) VALUES (15, 8, N'Accord 110', 1)
INSERT INTO [dbo].[Cobertura] ([Id], [ObraSocialId], [Descripcion], [Estado]) VALUES (16, 8, N'Accord 210', 1)
INSERT INTO [dbo].[Cobertura] ([Id], [ObraSocialId], [Descripcion], [Estado]) VALUES (17, 8, N'Accord 310', 1)
INSERT INTO [dbo].[Cobertura] ([Id], [ObraSocialId], [Descripcion], [Estado]) VALUES (18, 9, N'Plan 220', 1)
INSERT INTO [dbo].[Cobertura] ([Id], [ObraSocialId], [Descripcion], [Estado]) VALUES (19, 9, N'Plan 330', 1)
INSERT INTO [dbo].[Cobertura] ([Id], [ObraSocialId], [Descripcion], [Estado]) VALUES (20, 10, N'Integra 2', 1)
INSERT INTO [dbo].[Cobertura] ([Id], [ObraSocialId], [Descripcion], [Estado]) VALUES (21, 10, N'Family', 1)
INSERT INTO [dbo].[Cobertura] ([Id], [ObraSocialId], [Descripcion], [Estado]) VALUES (22, 11, N'Bronce', 1)
INSERT INTO [dbo].[Cobertura] ([Id], [ObraSocialId], [Descripcion], [Estado]) VALUES (23, 11, N'Plata', 1)
INSERT INTO [dbo].[Cobertura] ([Id], [ObraSocialId], [Descripcion], [Estado]) VALUES (24, 11, N'Oro', 1)
INSERT INTO [dbo].[Cobertura] ([Id], [ObraSocialId], [Descripcion], [Estado]) VALUES (25, 12, N'Sancor 500', 1)
INSERT INTO [dbo].[Cobertura] ([Id], [ObraSocialId], [Descripcion], [Estado]) VALUES (26, 12, N'Sancor 5000 Ex', 1)
INSERT INTO [dbo].[Cobertura] ([Id], [ObraSocialId], [Descripcion], [Estado]) VALUES (27, 13, N'SMG01', 1)
INSERT INTO [dbo].[Cobertura] ([Id], [ObraSocialId], [Descripcion], [Estado]) VALUES (28, 13, N'SMG02', 1)
INSERT INTO [dbo].[Cobertura] ([Id], [ObraSocialId], [Descripcion], [Estado]) VALUES (29, 13, N'SMG10', 1)
SET IDENTITY_INSERT [dbo].[Cobertura] OFF



-- Paciente
CREATE TABLE [dbo].[Paciente] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [PersonaId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [AK_Paciente_Persona] UNIQUE NONCLUSTERED ([PersonaId] ASC),
    CONSTRAINT [FK_Paciente_Persona] FOREIGN KEY ([PersonaId]) REFERENCES [dbo].[Persona] ([Id])
);

SET IDENTITY_INSERT [dbo].[Paciente] ON
INSERT INTO [dbo].[Paciente] ([Id], [PersonaId]) VALUES (13, 50)
INSERT INTO [dbo].[Paciente] ([Id], [PersonaId]) VALUES (14, 51)
INSERT INTO [dbo].[Paciente] ([Id], [PersonaId]) VALUES (15, 52)
INSERT INTO [dbo].[Paciente] ([Id], [PersonaId]) VALUES (16, 53)
INSERT INTO [dbo].[Paciente] ([Id], [PersonaId]) VALUES (17, 54)
INSERT INTO [dbo].[Paciente] ([Id], [PersonaId]) VALUES (18, 55)
INSERT INTO [dbo].[Paciente] ([Id], [PersonaId]) VALUES (19, 56)
INSERT INTO [dbo].[Paciente] ([Id], [PersonaId]) VALUES (20, 57)
INSERT INTO [dbo].[Paciente] ([Id], [PersonaId]) VALUES (21, 58)
INSERT INTO [dbo].[Paciente] ([Id], [PersonaId]) VALUES (22, 59)
SET IDENTITY_INSERT [dbo].[Paciente] OFF



-- Medico
CREATE TABLE [dbo].[Medico] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [EmpleadoId]     INT           NOT NULL,
    [Matricula]      NVARCHAR (10) NOT NULL,
    [EspecialidadId] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [AK_Medico_Empleado] UNIQUE NONCLUSTERED ([EmpleadoId] ASC),
    CONSTRAINT [AK_Medico_Matricula] UNIQUE NONCLUSTERED ([Matricula] ASC),
    CONSTRAINT [FK_Medico_Empleado] FOREIGN KEY ([EmpleadoId]) REFERENCES [dbo].[Empleado] ([Id]),
    CONSTRAINT [FK_Medico_Especialidad] FOREIGN KEY ([EspecialidadId]) REFERENCES [dbo].[Especialidad] ([Id])
);

SET IDENTITY_INSERT [dbo].[Medico] ON
INSERT INTO [dbo].[Medico] ([Id], [EmpleadoId], [Matricula], [EspecialidadId]) VALUES (6, 16, N'SL856', 11)
INSERT INTO [dbo].[Medico] ([Id], [EmpleadoId], [Matricula], [EspecialidadId]) VALUES (7, 17, N'AC168', 8)
INSERT INTO [dbo].[Medico] ([Id], [EmpleadoId], [Matricula], [EspecialidadId]) VALUES (8, 18, N'CO955', 10)
INSERT INTO [dbo].[Medico] ([Id], [EmpleadoId], [Matricula], [EspecialidadId]) VALUES (9, 19, N'E1328', 7)
INSERT INTO [dbo].[Medico] ([Id], [EmpleadoId], [Matricula], [EspecialidadId]) VALUES (10, 20, N'T1089', 13)
INSERT INTO [dbo].[Medico] ([Id], [EmpleadoId], [Matricula], [EspecialidadId]) VALUES (11, 21, N'BR460', 13)
INSERT INTO [dbo].[Medico] ([Id], [EmpleadoId], [Matricula], [EspecialidadId]) VALUES (12, 22, N'S2501', 13)
SET IDENTITY_INSERT [dbo].[Medico] OFF



-- Turno
CREATE TABLE [dbo].[Turno] (
    [Id]          INT      IDENTITY (1, 1) NOT NULL,
    [MedicoId]    INT      NOT NULL,
    [PacienteId]  INT      NOT NULL,
    [FechaHora]   DATETIME NOT NULL,
    [CoberturaId] INT      NOT NULL,
    [EstadoId]    INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Turno_Cobertura] FOREIGN KEY ([CoberturaId]) REFERENCES [dbo].[Cobertura] ([Id]),
    CONSTRAINT [FK_Turno_Medico] FOREIGN KEY ([MedicoId]) REFERENCES [dbo].[Medico] ([Id]),
    CONSTRAINT [FK_Turno_Paciente] FOREIGN KEY ([PacienteId]) REFERENCES [dbo].[Paciente] ([Id]),
    CONSTRAINT [FK_Turno_Estado] FOREIGN KEY ([EstadoId]) REFERENCES [dbo].[TurnoEstado] ([Id])
);

SET IDENTITY_INSERT [dbo].[Turno] ON
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (22, 12, 18, N'2020-11-02 09:00:00', 11, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (23, 6, 18, N'2020-11-01 22:00:00', 21, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (24, 6, 18, N'2020-11-02 08:00:00', 11, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (25, 11, 18, N'2020-11-02 09:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (26, 7, 17, N'2020-11-02 10:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (27, 9, 14, N'2020-11-02 08:00:00', 19, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (28, 8, 22, N'2020-11-02 08:00:00', 24, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (29, 6, 22, N'2020-11-02 09:00:00', 27, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (30, 12, 17, N'2020-11-02 10:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (31, 10, 15, N'2020-11-02 12:00:00', 26, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (32, 8, 13, N'2020-11-02 09:00:00', 19, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (33, 11, 16, N'2020-11-02 10:30:00', 29, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (34, 7, 21, N'2020-11-02 17:00:00', 20, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (35, 10, 14, N'2020-11-09 08:00:00', 15, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (36, 9, 20, N'2020-11-09 08:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (37, 6, 22, N'2020-11-09 08:00:00', 20, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (38, 9, 21, N'2020-11-09 09:00:00', 26, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (39, 9, 15, N'2020-11-10 08:30:00', 17, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (40, 6, 19, N'2020-11-10 09:00:00', 21, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (41, 12, 17, N'2020-11-09 09:00:00', 14, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (42, 10, 15, N'2020-11-10 09:00:00', 24, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (43, 8, 14, N'2020-11-09 11:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (44, 8, 14, N'2020-11-09 15:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (45, 11, 16, N'2020-11-09 10:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (46, 11, 14, N'2020-11-09 10:30:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (47, 7, 19, N'2020-11-10 11:30:00', 22, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (48, 6, 13, N'2020-11-04 15:00:00', 18, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (49, 6, 18, N'2020-11-04 16:00:00', 16, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (50, 6, 16, N'2020-11-04 18:00:00', 20, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (51, 6, 14, N'2020-11-05 08:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (52, 12, 18, N'2020-10-02 09:00:00', 11, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (53, 6, 18, N'2020-10-01 22:00:00', 21, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (54, 6, 18, N'2020-10-02 08:00:00', 11, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (55, 11, 18, N'2020-10-02 09:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (56, 7, 17, N'2020-10-02 10:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (57, 9, 14, N'2020-10-02 08:00:00', 19, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (58, 8, 22, N'2020-10-02 08:00:00', 24, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (59, 6, 22, N'2020-10-02 09:00:00', 27, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (60, 12, 17, N'2020-10-02 10:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (61, 10, 15, N'2020-10-02 12:00:00', 26, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (62, 8, 13, N'2020-10-02 09:00:00', 19, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (63, 11, 16, N'2020-10-02 10:30:00', 29, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (64, 7, 21, N'2020-10-02 17:00:00', 20, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (65, 10, 14, N'2020-10-09 08:00:00', 15, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (66, 9, 20, N'2020-10-09 08:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (67, 6, 22, N'2020-10-09 08:00:00', 20, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (68, 9, 21, N'2020-10-09 09:00:00', 26, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (69, 9, 15, N'2020-10-10 08:30:00', 17, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (70, 6, 19, N'2020-10-10 09:00:00', 21, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (71, 12, 17, N'2020-10-09 09:00:00', 14, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (72, 10, 15, N'2020-10-10 09:00:00', 24, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (73, 8, 14, N'2020-10-09 11:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (74, 8, 14, N'2020-10-09 15:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (75, 11, 16, N'2020-10-09 10:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (76, 11, 14, N'2020-10-09 10:30:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (77, 7, 19, N'2020-10-10 11:30:00', 22, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (78, 6, 13, N'2020-10-04 15:00:00', 18, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (79, 6, 18, N'2020-10-04 16:00:00', 16, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (80, 6, 16, N'2020-10-04 18:00:00', 20, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (81, 6, 14, N'2020-10-05 08:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (82, 12, 18, N'2020-09-02 09:00:00', 11, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (83, 6, 18, N'2020-09-01 22:00:00', 21, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (84, 6, 18, N'2020-09-02 08:00:00', 11, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (85, 11, 18, N'2020-09-02 09:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (86, 7, 17, N'2020-09-02 10:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (87, 9, 14, N'2020-09-02 08:00:00', 19, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (88, 8, 22, N'2020-09-02 08:00:00', 24, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (89, 6, 22, N'2020-09-02 09:00:00', 27, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (90, 12, 17, N'2020-09-02 10:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (91, 10, 15, N'2020-09-02 12:00:00', 26, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (92, 8, 13, N'2020-09-02 09:00:00', 19, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (93, 11, 16, N'2020-09-02 10:30:00', 29, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (94, 7, 21, N'2020-09-02 17:00:00', 20, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (95, 10, 14, N'2020-09-09 08:00:00', 15, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (96, 9, 20, N'2020-09-09 08:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (97, 6, 22, N'2020-09-09 08:00:00', 20, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (98, 9, 21, N'2020-09-09 09:00:00', 26, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (99, 9, 15, N'2020-09-10 08:30:00', 17, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (100, 6, 19, N'2020-09-10 09:00:00', 21, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (101, 12, 17, N'2020-09-09 09:00:00', 14, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (102, 10, 15, N'2020-09-10 09:00:00', 24, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (103, 8, 14, N'2020-09-09 11:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (104, 8, 14, N'2020-09-09 15:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (105, 11, 16, N'2020-09-09 10:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (106, 11, 14, N'2020-09-09 10:30:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (107, 7, 19, N'2020-09-10 11:30:00', 22, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (108, 6, 13, N'2020-09-04 15:00:00', 18, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (109, 6, 18, N'2020-09-04 16:00:00', 16, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (110, 6, 16, N'2020-09-04 18:00:00', 20, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (111, 6, 14, N'2020-09-05 08:00:00', 10, 1)
INSERT INTO [dbo].[Turno] ([Id], [MedicoId], [PacienteId], [FechaHora], [CoberturaId], [EstadoId]) VALUES (112, 11, 21, N'2020-11-04 17:00:00', 18, 1)
SET IDENTITY_INSERT [dbo].[Turno] OFF



-- HistoriaClinica
CREATE TABLE [dbo].[HistoriaClinica] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [TurnoId]     INT            NOT NULL,
    [Descripcion] NVARCHAR (150) NOT NULL,
    [Archivo]     NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_HistoriaClinica_Turno] FOREIGN KEY ([TurnoId]) REFERENCES [dbo].[Turno] ([Id])
);

SET IDENTITY_INSERT [dbo].[HistoriaClinica] ON
INSERT INTO [dbo].[HistoriaClinica] ([Id], [TurnoId], [Descripcion], [Archivo]) VALUES (1, 23, N'Paracetamol 600ml cada 12hs por 2 dias. Reposo 6hs', N'')
INSERT INTO [dbo].[HistoriaClinica] ([Id], [TurnoId], [Descripcion], [Archivo]) VALUES (2, 24, N'Ciriax 500 durante 5 dias tomando una cada 24hs', N'')
INSERT INTO [dbo].[HistoriaClinica] ([Id], [TurnoId], [Descripcion], [Archivo]) VALUES (3, 29, N'Desihidratación. Gatorade o 7up sin gas', N'')
INSERT INTO [dbo].[HistoriaClinica] ([Id], [TurnoId], [Descripcion], [Archivo]) VALUES (4, 100, N'Bebida líquida vitaminada 3 veces al día (Gatorade)', N'')
INSERT INTO [dbo].[HistoriaClinica] ([Id], [TurnoId], [Descripcion], [Archivo]) VALUES (5, 108, N'Pastilla de carbon cada vez que vaya de cuerpo.', N'')
INSERT INTO [dbo].[HistoriaClinica] ([Id], [TurnoId], [Descripcion], [Archivo]) VALUES (6, 78, N'Abciximab REOPRO cada 18hs durante una semana', N'')
INSERT INTO [dbo].[HistoriaClinica] ([Id], [TurnoId], [Descripcion], [Archivo]) VALUES (7, 84, N'Adefovir o similar para calmar el dolor', N'')
INSERT INTO [dbo].[HistoriaClinica] ([Id], [TurnoId], [Descripcion], [Archivo]) VALUES (8, 53, N'Etoposide 50ml 1 vez al dia. hasta la siguiente consulta', N'')
INSERT INTO [dbo].[HistoriaClinica] ([Id], [TurnoId], [Descripcion], [Archivo]) VALUES (9, 83, N'Reposo 3hs. Hidratarse mucho. ', N'')
INSERT INTO [dbo].[HistoriaClinica] ([Id], [TurnoId], [Descripcion], [Archivo]) VALUES (10, 54, N'Cualquier antifebril', N'')
INSERT INTO [dbo].[HistoriaClinica] ([Id], [TurnoId], [Descripcion], [Archivo]) VALUES (11, 109, N'Tomografia completa', N'')
INSERT INTO [dbo].[HistoriaClinica] ([Id], [TurnoId], [Descripcion], [Archivo]) VALUES (12, 110, N'Felodipino una capsula por 5 dias', N'')
SET IDENTITY_INSERT [dbo].[HistoriaClinica] OFF;