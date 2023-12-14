using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MeuWebApi.ViewModels;

public class PaginacaoViewModel
{
    [JsonProperty("start")]
    [FromQuery(Name = "start")]
    public int Start { get; set; }

    [JsonProperty("length")]
    [FromQuery(Name = "length")]
    public int Length { get; set; }

    [JsonProperty("pageNumber")]
    [FromQuery(Name = "pageNumber")]
    public int PageNumber { get; set; }

    [JsonProperty("qtdPage")]
    [FromQuery(Name = "qtdPage")]
    public int QtdPage { get; set; }

    [JsonProperty("search[value]")]
    [FromQuery(Name = "search[value]")]
    public string SearchTerms { get; set; }
}
