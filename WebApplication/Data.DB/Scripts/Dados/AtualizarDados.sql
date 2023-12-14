UPDATE
	[dbo].[Dados]
SET
    [IdCategoria] = @IdCategoria,
    [Nome] = @Nome,
    [IdentificadorTpClient] = @Identificador,
    [Localidade] = @Localidade,
    [Ordem] = @Ordem,
    [DataAlteracao] = GETDATE()
WHERE
	[Id] = @Id