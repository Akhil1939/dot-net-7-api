using api.models.DataModels;
using api.repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.repositories.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LearningDataContext _context;
        private readonly IUserRepository _userRepository;
        public UnitOfWork(LearningDataContext context)
        {
            _context = context;
            
        }

        

        public IGenericRepository<T> Repository<T>() where T : class
        {
           return new GenericRepository<T>(_context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public IUserRepository UserRepository
        {
            get { return _userRepository ?? new UserRepository(_context); }
        }
    }
}
