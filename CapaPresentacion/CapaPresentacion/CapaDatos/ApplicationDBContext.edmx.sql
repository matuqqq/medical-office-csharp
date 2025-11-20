
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/19/2025 22:40:14
-- Generated from EDMX file: D:\PROGRAMACION\medical-office-csharp\CapaPresentacion\CapaPresentacion\CapaDatos\ApplicationDBContext.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ConsultorioV2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EspecialidadMedico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonaSet_Medico] DROP CONSTRAINT [FK_EspecialidadMedico];
GO
IF OBJECT_ID(N'[dbo].[FK_HistoriaClinicaConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConsultaSet] DROP CONSTRAINT [FK_HistoriaClinicaConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_HistoriaClinicaPaciente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonaSet_Paciente] DROP CONSTRAINT [FK_HistoriaClinicaPaciente];
GO
IF OBJECT_ID(N'[dbo].[FK_Medico_inherits_Personal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonaSet_Medico] DROP CONSTRAINT [FK_Medico_inherits_Personal];
GO
IF OBJECT_ID(N'[dbo].[FK_Paciente_inherits_Persona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonaSet_Paciente] DROP CONSTRAINT [FK_Paciente_inherits_Persona];
GO
IF OBJECT_ID(N'[dbo].[FK_Personal_inherits_Persona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonaSet_Personal] DROP CONSTRAINT [FK_Personal_inherits_Persona];
GO
IF OBJECT_ID(N'[dbo].[FK_Secretario_inherits_Personal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonaSet_Secretario] DROP CONSTRAINT [FK_Secretario_inherits_Personal];
GO
IF OBJECT_ID(N'[dbo].[FK_TurnoConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConsultaSet] DROP CONSTRAINT [FK_TurnoConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_TurnoMedico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TurnoSet] DROP CONSTRAINT [FK_TurnoMedico];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioMedico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsuarioSet] DROP CONSTRAINT [FK_UsuarioMedico];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioPermiso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PermisoSet] DROP CONSTRAINT [FK_UsuarioPermiso];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioSecretario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsuarioSet] DROP CONSTRAINT [FK_UsuarioSecretario];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ConsultaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConsultaSet];
GO
IF OBJECT_ID(N'[dbo].[EspecialidadSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EspecialidadSet];
GO
IF OBJECT_ID(N'[dbo].[HistoriaClinicaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HistoriaClinicaSet];
GO
IF OBJECT_ID(N'[dbo].[PermisoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PermisoSet];
GO
IF OBJECT_ID(N'[dbo].[PersonaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonaSet];
GO
IF OBJECT_ID(N'[dbo].[PersonaSet_Medico]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonaSet_Medico];
GO
IF OBJECT_ID(N'[dbo].[PersonaSet_Paciente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonaSet_Paciente];
GO
IF OBJECT_ID(N'[dbo].[PersonaSet_Personal]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonaSet_Personal];
GO
IF OBJECT_ID(N'[dbo].[PersonaSet_Secretario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonaSet_Secretario];
GO
IF OBJECT_ID(N'[dbo].[TurnoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TurnoSet];
GO
IF OBJECT_ID(N'[dbo].[UsuarioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsuarioSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EspecialidadSet'
CREATE TABLE [dbo].[EspecialidadSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NombreEspecialidad] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TurnoSet'
CREATE TABLE [dbo].[TurnoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Hora] nvarchar(max)  NOT NULL,
    [Estado] int  NOT NULL,
    [PacienteId] int  NOT NULL,
    [MedicoId] int  NOT NULL,
    [Medico_Id] int  NOT NULL
);
GO

-- Creating table 'ConsultaSet'
CREATE TABLE [dbo].[ConsultaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [HistoriaClinicaId] int  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Diagnostico] nvarchar(max)  NOT NULL,
    [Tratamiento] nvarchar(max)  NOT NULL,
    [TurnoId] int  NOT NULL
);
GO

-- Creating table 'HistoriaClinicaSet'
CREATE TABLE [dbo].[HistoriaClinicaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FechaCreacion] datetime  NOT NULL,
    [PacienteId] int  NOT NULL,
    [Paciente1_Id] int  NOT NULL
);
GO

-- Creating table 'UsuarioSet'
CREATE TABLE [dbo].[UsuarioSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NombreUsuario] nvarchar(max)  NOT NULL,
    [PasswordHash] nvarchar(max)  NOT NULL,
    [Rol] bit  NOT NULL,
    [Medico_Id] int  NULL,
    [Secretario_Id] int  NULL
);
GO

-- Creating table 'PermisoSet'
CREATE TABLE [dbo].[PermisoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NombrePermiso] nvarchar(max)  NOT NULL,
    [RolAsociado] bit  NOT NULL,
    [Usuario_Id] int  NOT NULL
);
GO

-- Creating table 'PersonaSet'
CREATE TABLE [dbo].[PersonaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [DNI] int  NOT NULL,
    [FechaNacimiento] datetime  NOT NULL
);
GO

-- Creating table 'PersonaSet_Personal'
CREATE TABLE [dbo].[PersonaSet_Personal] (
    [Legajo] int  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Telefono] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'PersonaSet_Medico'
CREATE TABLE [dbo].[PersonaSet_Medico] (
    [EspecialidadId] int  NOT NULL,
    [Matricula] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'PersonaSet_Secretario'
CREATE TABLE [dbo].[PersonaSet_Secretario] (
    [HorarioEntrada] datetime  NOT NULL,
    [HorarioSalida] datetime  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'PersonaSet_Paciente'
CREATE TABLE [dbo].[PersonaSet_Paciente] (
    [HistoriaClinicaId] int  NOT NULL,
    [ObraSocial] nvarchar(max)  NOT NULL,
    [NumeroAfiliado] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EspecialidadSet'
ALTER TABLE [dbo].[EspecialidadSet]
ADD CONSTRAINT [PK_EspecialidadSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TurnoSet'
ALTER TABLE [dbo].[TurnoSet]
ADD CONSTRAINT [PK_TurnoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ConsultaSet'
ALTER TABLE [dbo].[ConsultaSet]
ADD CONSTRAINT [PK_ConsultaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HistoriaClinicaSet'
ALTER TABLE [dbo].[HistoriaClinicaSet]
ADD CONSTRAINT [PK_HistoriaClinicaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [PK_UsuarioSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PermisoSet'
ALTER TABLE [dbo].[PermisoSet]
ADD CONSTRAINT [PK_PermisoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PersonaSet'
ALTER TABLE [dbo].[PersonaSet]
ADD CONSTRAINT [PK_PersonaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PersonaSet_Personal'
ALTER TABLE [dbo].[PersonaSet_Personal]
ADD CONSTRAINT [PK_PersonaSet_Personal]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PersonaSet_Medico'
ALTER TABLE [dbo].[PersonaSet_Medico]
ADD CONSTRAINT [PK_PersonaSet_Medico]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PersonaSet_Secretario'
ALTER TABLE [dbo].[PersonaSet_Secretario]
ADD CONSTRAINT [PK_PersonaSet_Secretario]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PersonaSet_Paciente'
ALTER TABLE [dbo].[PersonaSet_Paciente]
ADD CONSTRAINT [PK_PersonaSet_Paciente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EspecialidadId] in table 'PersonaSet_Medico'
ALTER TABLE [dbo].[PersonaSet_Medico]
ADD CONSTRAINT [FK_EspecialidadMedico]
    FOREIGN KEY ([EspecialidadId])
    REFERENCES [dbo].[EspecialidadSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EspecialidadMedico'
CREATE INDEX [IX_FK_EspecialidadMedico]
ON [dbo].[PersonaSet_Medico]
    ([EspecialidadId]);
GO

-- Creating foreign key on [Medico_Id] in table 'TurnoSet'
ALTER TABLE [dbo].[TurnoSet]
ADD CONSTRAINT [FK_TurnoMedico]
    FOREIGN KEY ([Medico_Id])
    REFERENCES [dbo].[PersonaSet_Medico]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TurnoMedico'
CREATE INDEX [IX_FK_TurnoMedico]
ON [dbo].[TurnoSet]
    ([Medico_Id]);
GO

-- Creating foreign key on [HistoriaClinicaId] in table 'ConsultaSet'
ALTER TABLE [dbo].[ConsultaSet]
ADD CONSTRAINT [FK_HistoriaClinicaConsulta]
    FOREIGN KEY ([HistoriaClinicaId])
    REFERENCES [dbo].[HistoriaClinicaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HistoriaClinicaConsulta'
CREATE INDEX [IX_FK_HistoriaClinicaConsulta]
ON [dbo].[ConsultaSet]
    ([HistoriaClinicaId]);
GO

-- Creating foreign key on [TurnoId] in table 'ConsultaSet'
ALTER TABLE [dbo].[ConsultaSet]
ADD CONSTRAINT [FK_TurnoConsulta]
    FOREIGN KEY ([TurnoId])
    REFERENCES [dbo].[TurnoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TurnoConsulta'
CREATE INDEX [IX_FK_TurnoConsulta]
ON [dbo].[ConsultaSet]
    ([TurnoId]);
GO

-- Creating foreign key on [Usuario_Id] in table 'PermisoSet'
ALTER TABLE [dbo].[PermisoSet]
ADD CONSTRAINT [FK_UsuarioPermiso]
    FOREIGN KEY ([Usuario_Id])
    REFERENCES [dbo].[UsuarioSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioPermiso'
CREATE INDEX [IX_FK_UsuarioPermiso]
ON [dbo].[PermisoSet]
    ([Usuario_Id]);
GO

-- Creating foreign key on [Medico_Id] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [FK_UsuarioMedico]
    FOREIGN KEY ([Medico_Id])
    REFERENCES [dbo].[PersonaSet_Medico]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioMedico'
CREATE INDEX [IX_FK_UsuarioMedico]
ON [dbo].[UsuarioSet]
    ([Medico_Id]);
GO

-- Creating foreign key on [Secretario_Id] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [FK_UsuarioSecretario]
    FOREIGN KEY ([Secretario_Id])
    REFERENCES [dbo].[PersonaSet_Secretario]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioSecretario'
CREATE INDEX [IX_FK_UsuarioSecretario]
ON [dbo].[UsuarioSet]
    ([Secretario_Id]);
GO

-- Creating foreign key on [Paciente1_Id] in table 'HistoriaClinicaSet'
ALTER TABLE [dbo].[HistoriaClinicaSet]
ADD CONSTRAINT [FK_HistoriaClinicaPaciente1]
    FOREIGN KEY ([Paciente1_Id])
    REFERENCES [dbo].[PersonaSet_Paciente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HistoriaClinicaPaciente1'
CREATE INDEX [IX_FK_HistoriaClinicaPaciente1]
ON [dbo].[HistoriaClinicaSet]
    ([Paciente1_Id]);
GO

-- Creating foreign key on [Id] in table 'PersonaSet_Personal'
ALTER TABLE [dbo].[PersonaSet_Personal]
ADD CONSTRAINT [FK_Personal_inherits_Persona]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[PersonaSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'PersonaSet_Medico'
ALTER TABLE [dbo].[PersonaSet_Medico]
ADD CONSTRAINT [FK_Medico_inherits_Personal]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[PersonaSet_Personal]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'PersonaSet_Secretario'
ALTER TABLE [dbo].[PersonaSet_Secretario]
ADD CONSTRAINT [FK_Secretario_inherits_Personal]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[PersonaSet_Personal]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'PersonaSet_Paciente'
ALTER TABLE [dbo].[PersonaSet_Paciente]
ADD CONSTRAINT [FK_Paciente_inherits_Persona]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[PersonaSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------