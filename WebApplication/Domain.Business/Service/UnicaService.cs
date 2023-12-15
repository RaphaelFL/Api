using Domain.Interface.Repositories;
using Domain.Interface.Services;
using Domain.Model.ValueObjects;

namespace Domain.Business.Service
{
    public class UnicaService : IUnicaService
    {

        private readonly IUnicaRepository _unicaRepository;
        public UnicaService(IUnicaRepository unicaRepository)
        {
            _unicaRepository = unicaRepository;
        }

        public async Task<ResultadoPaginado<DadosModel>> ObterDados(string nomeDados, int pagina, int quantidadePorPagina)
        {
            return await _unicaRepository.ObterDados(nomeDados, pagina, quantidadePorPagina);
        }
    }
}
