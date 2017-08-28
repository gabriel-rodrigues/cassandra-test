using System;
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
        private readonly Mapper _mapper;

        public Repository()
        {
            var cassandra = new CassandraSessionCache();
			var session = cassandra.GetSession(this.KeySpace);
			_mapper     = new Mapper(session, MappingConfiguration.Global.Define<EmpregadoMap>());
        }

        public async Task DeleteAsync(Guid id)
        {
            await _mapper.DeleteAsync<Empregado>("WHERE emp_id = ?", id);
        }

        public async Task<Empregado> GetAsync(Guid id)
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