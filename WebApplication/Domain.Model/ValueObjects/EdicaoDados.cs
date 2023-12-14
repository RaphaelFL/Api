using System.Collections.Generic;

namespace Domain.Model.ValueObjects
{
    public class EdicaoDados
    {
        public IEnumerable<int> EdicaoDadosMenorOuIgual { get; set; }
        public IEnumerable<int> EdicaoDadosMaior { get; set; }
    }
}
