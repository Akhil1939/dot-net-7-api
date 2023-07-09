using api.models.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.repositories.IRepositories
{

    public interface IGenericRepository <T> where T : class
    {
        //getAll
        IQueryable<T> GetAll();
        public void Create(T entity);

    }
}
