using api.models.DataModels;
using api.repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.repositories.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T: class
    {

        private readonly LearningDataContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(LearningDataContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
           return  _dbSet.AsQueryable();
        }
    }
}
