using System.Collections.Generic;
using System.Threading.Tasks;
using Cassandra.Mapping;
using Core.CassandraConfig;
using Core.Domain;
using Core.Mappings;
using System.Linq;

namespace Core.Repository
{
    public class Repository : IRepository
    {
        private readonly CassandraSessionCache _cassandra;
		private Mapper _mapper;

        public Repository()
        {
            _cassandra  = new CassandraSessionCache();
			var session = _cassandra.GetSession(this.KeySpace);
			_mapper     = new Mapper(session, MappingConfiguration.Global.Define<EmpregadoMap>());
        }

        public async Task DeleteAsync(int id)
        {
            await _mapper.DeleteAsync<Empregado>("WHERE emp_id = ?", id);
        }

        public async Task<Empregado> GetAsync(int id)
        {
           return await _mapper.FirstOrDefaultAsync<Empregado>("WHERE emp_id = ? ", id);
        }

        public async void AddAsync(Empregado empregado)
        {
            await _mapper.InsertAsync(empregado);
        }

        public ICollection<Empregado> GetAll()
        {
            return _mapper.Fetch<Empregado>().ToList();
        }

        public string KeySpace => "teste";
    }
}