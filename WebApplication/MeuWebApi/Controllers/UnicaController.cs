using Domain.Interface.Services;
using MeuWebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MeuWebApi.Controllers
{
    public class UnicaController : Controller
    {
        private readonly ILogger<UnicaController> _logger;
        IUnicaService _unicaService;
        public UnicaController(ILogger<UnicaController> logger, IUnicaService unicaService)
        {
            _logger = logger;
            _unicaService = unicaService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ObterDadosPaginados(PesquisarDadosViewModel paginacao)
        {
            try { 
            paginacao.QtdPage = Convert.ToInt32(paginacao.Length);
            paginacao.PageNumber = Convert.ToInt32(paginacao.Start) > 0 ? (Convert.ToInt32(paginacao.Start) / paginacao.QtdPage) + 1 : 1;

            var resultados = await _unicaService.ObterDados(paginacao.NomeDados, paginacao.PageNumber, 10);

                return Json(
                new
                {
                    data = resultados.Resultados,
                    recordsFiltered = resultados.TotalRegistros,
                    recordsTotal = resultados.TotalRegistros
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ocorreu um erro ao consultar os Dados.");
                return StatusCode(500, Json(new { Mensagem = "Ocorreu um erro ao consultar os Dados." }));
            }

        }
    }
}
