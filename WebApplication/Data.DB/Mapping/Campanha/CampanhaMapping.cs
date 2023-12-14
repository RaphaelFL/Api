using Dapper.FluentMap.Mapping;
using Domain.Model.ValueObjects;

namespace Data.DB.Mapping.Campanha
{
    public class CampanhaMapping : EntityMap<DadosModel>
    {
        public CampanhaMapping() 
        { 
            Map(campo => campo.Id).ToColumn("DD_ID");
            Map(campo => campo.Nome).ToColumn("DD_NOME");
            Map(campo => campo.DataCadastro).ToColumn("DD_DATACADASTRO");
            Map(campo => campo.DataAlteracao).ToColumn("DD_DATAALTERACAO");
            Map(campo => campo.Ativo).ToColumn("DD_ATIVO");
        }
    }
}
