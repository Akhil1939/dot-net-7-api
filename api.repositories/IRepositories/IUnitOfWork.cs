using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.repositories.IRepositories
{
    public interface IUnitOfWork
    {
        void Save();
        IGenericRepository<T> Repository<T>() where T : class;

        IUserRepository UserRepository { get; }
        
    }
}
