UPDATE
    Beneficio
SET
    Ativo = 0,
    DataAlteracao = GETDATE()
WHERE
    Id = @Id