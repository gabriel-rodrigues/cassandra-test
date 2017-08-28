using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Domain;

namespace Core.Repository
{
    public interface IRepository
    {
        Task DeleteAsync(int id);
        Task<Empregado> GetAsync(int id);
        void AddAsync(Empregado empregado);
        ICollection<Empregado> GetAll();
        
        string KeySpace { get; }
    }
}