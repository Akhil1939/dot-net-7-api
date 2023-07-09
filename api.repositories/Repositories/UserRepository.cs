using api.models.DataModels;
using api.repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace api.repositories.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly DbSet<User> _users;

        public UserRepository(LearningDataContext context) : base(context)
        {
            _users = context.Set<User>();
        }

        public User GetByEmail(string email)
        {
            User user = _users.FirstOrDefault(u => u.Email == email) ?? throw new AuthenticationException("User not Found");
            return user;
        }
    }
}
