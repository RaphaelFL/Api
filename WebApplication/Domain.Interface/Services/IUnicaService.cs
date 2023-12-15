using Domain.Model.ValueObjects;

namespace Domain.Interface.Services
{
    public interface IUnicaService
    {
        Task<ResultadoPaginado<DadosModel>> ObterDados(string nomeDados, int pagina, int quantidadePorPagina);
    }
}
