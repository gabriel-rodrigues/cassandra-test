using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Domain;

namespace Core.Repository
{
    public interface IRepository
    {
        Task DeleteAsync(Guid id);
        Task<Empregado> GetAsync(Guid id);
        void AddAsync(Empregado empregado);
        ICollection<Empregado> GetAll();
        
        string KeySpace { get; }
    }
}