namespace MeuWebApi.ViewModels;

public class DadosViewModel
{
    public Guid Id { get; set; }
    public Guid IdCategoria { get; set; }
    public string Nome { get; set; }
    public bool Ativo { get; set; }
    public int Ordem { get; set; }
    public IFormFile ImagemHeader { get; set; }
    public DateTime DataCadastro { get; set; }
    public DateTime? DataAlteracao { get; set; }
}
