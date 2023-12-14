using Domain.Interface.Services;
using Domain.Model.ValueObjects;

namespace Domain.Business.Service
{
    public class UnicaService : IUnicaService
    {
        public Task<ResultadoPaginado<DadosModel>> ObterDados(string nomeBaneficio, int pagina, int quantidadePorPagina)
        {
            throw new NotImplementedException();
        }
    }
}
