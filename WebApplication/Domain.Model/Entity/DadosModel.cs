namespace Domain.Model.ValueObjects;

public class DadosModel
{
    public Guid Id { get; set; }
    public CategoriaDadosModel CategoriaDados { get; set; }
    public string Nome { get; set; }
    public string Localidade { get; set; }
    public bool Ativo { get; set; }
    public string ImagemHeader { get; set; }
    public int Ordem { get; set; }
    public DateTime DataCadastro { get; set; }
    public DateTime? DataAlteracao { get; set; }
}
