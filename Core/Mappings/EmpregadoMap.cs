using Core.Domain;

namespace Core.Mappings
{
    public class EmpregadoMap : Cassandra.Mapping.Mappings
    {
        public EmpregadoMap()
        {
			For<Empregado>()
				.TableName("emp")
				.PartitionKey(empregado => empregado.Id)
				.Column(empregado => empregado.Id, cm => cm.WithName("emp_id"))
				.Column(empregado => empregado.Nome, cm => cm.WithName("emp_name"))
				.Column(empregado => empregado.Cidade, cm => cm.WithName("emp_city"))
				.Column(empregado => empregado.Telefone, cm => cm.WithName("emp_phone"))
				.Column(empregado => empregado.Salario, cm => cm.WithName("emp_sal"));
        }
    }
}
