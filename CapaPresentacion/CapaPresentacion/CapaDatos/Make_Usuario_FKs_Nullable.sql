-- Hacer NULLABLE las FK Medico_Id y Secretario_Id en UsuarioSet
-- Back up recomendado antes de ejecutar.
SET QUOTED_IDENTIFIER OFF;
GO

BEGIN TRY
    BEGIN TRANSACTION;

    -- Dropar FKs si existen
    IF OBJECT_ID(N'[dbo].[FK_UsuarioMedico]', 'F') IS NOT NULL
        ALTER TABLE [dbo].[UsuarioSet] DROP CONSTRAINT [FK_UsuarioMedico];

    IF OBJECT_ID(N'[dbo].[FK_UsuarioSecretario]', 'F') IS NOT NULL
        ALTER TABLE [dbo].[UsuarioSet] DROP CONSTRAINT [FK_UsuarioSecretario];

    -- Alterar columnas a NULLABLE
    ALTER TABLE [dbo].[UsuarioSet] ALTER COLUMN Medico_Id INT NULL;
    ALTER TABLE [dbo].[UsuarioSet] ALTER COLUMN Secretario_Id INT NULL;

    -- Recrear FKs (permitiendo NULLs en las columnas)
    ALTER TABLE [dbo].[UsuarioSet]
        ADD CONSTRAINT [FK_UsuarioMedico]
        FOREIGN KEY ([Medico_Id]) REFERENCES [dbo].[PersonaSet_Medico]([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

    -- Crear índice si no existe
    IF NOT EXISTS (
        SELECT 1 FROM sys.indexes
        WHERE name = N'IX_FK_UsuarioMedico' AND object_id = OBJECT_ID(N'[dbo].[UsuarioSet]')
    )
    BEGIN
        CREATE INDEX [IX_FK_UsuarioMedico] ON [dbo].[UsuarioSet] ([Medico_Id]);
    END

    ALTER TABLE [dbo].[UsuarioSet]
        ADD CONSTRAINT [FK_UsuarioSecretario]
        FOREIGN KEY ([Secretario_Id]) REFERENCES [dbo].[PersonaSet_Secretario]([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

    IF NOT EXISTS (
        SELECT 1 FROM sys.indexes
        WHERE name = N'IX_FK_UsuarioSecretario' AND object_id = OBJECT_ID(N'[dbo].[UsuarioSet]')
    )
    BEGIN
        CREATE INDEX [IX_FK_UsuarioSecretario] ON [dbo].[UsuarioSet] ([Secretario_Id]);
    END

    COMMIT TRANSACTION;
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
    DECLARE @ErrMsg NVARCHAR(4000) = ERROR_MESSAGE();
    RAISERROR('Error aplicando cambios: %s', 16, 1, @ErrMsg);
END CATCH;
GO