using Domain.Model.ValueObjects;


namespace Domain.Interface.Repositories
{
    public interface IUnicaRepository
    {
        Task<ResultadoPaginado<DadosModel>> ObterDados(string nomeDados, int pagina, int quantidadePorPagina);
    }
}
