using api.models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.repositories.IRepositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User GetByEmail(string email);
        
    }
}
