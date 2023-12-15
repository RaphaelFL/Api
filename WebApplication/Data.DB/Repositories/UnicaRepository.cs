using Dapper;
using Data.DB.Scripts.Beneficio;
using Domain.Interface.Extensions;
using Domain.Interface.Repositories;
using Domain.Model.ValueObjects;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace Data.DB.Repositories
{
    public class UnicaRepository : IUnicaRepository
    {
        private readonly ConnectionStrings _connectionStrings;

        public UnicaRepository(
            IOptions<ConnectionStrings> options)
        {
            _connectionStrings = options.Value;
        }

        public async Task<ResultadoPaginado<DadosModel>> ObterDados(string nomeDados, int pagina, int quantidadePorPagina)
        {
            var resultado = new ResultadoPaginado<DadosModel>();
            await using var connection = new SqlConnection(_connectionStrings.MySql);
            resultado.Resultados = await connection.QueryAsync<DadosModel>(
                await GetType().GetContentAsync(DadosSqlConstants.ObterDadosPaginadoCount),
                new Dapper.DynamicParameters(nomeDados));
            resultado.TotalRegistros = await ObterTotalDadosAsync(nomeDados);
            return resultado;
        }

        public async Task<int> ObterTotalDadosAsync(string nomeDados)
        {
            await using var connection = new SqlConnection(_connectionStrings.MySql);
            return await connection.QueryFirstOrDefaultAsync<int>(
                await GetType().GetContentAsync(DadosSqlConstants.ObterDadosPaginadoCount),
                new
                {
                    NomeBeneficio = nomeDados
                });
        }
    }
}
