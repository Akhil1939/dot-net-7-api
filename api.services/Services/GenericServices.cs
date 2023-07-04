using api.repositories.IRepositories;
using api.repositories.Repositories;
using api.services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.services.Services
{
    public class GenericServices<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> repository;

        public GenericServices(IGenericRepository<T> repository)
        {
            this.repository = repository;
        }

        
    }
}
