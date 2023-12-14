using Domain.Model.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.Services
{
    public interface IUnicaService
    {
        Task<ResultadoPaginado<DadosModel>> ObterDados(string nomeDados, int pagina, int quantidadePorPagina);
    }
}
