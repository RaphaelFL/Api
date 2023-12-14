namespace Domain.Model.ValueObjects;

public class ResultadoPaginado<T>
{
    public long TotalRegistros { get; set; }
    public IEnumerable<T> Resultados { get; set; }
}
