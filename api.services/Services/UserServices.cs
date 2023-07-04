using api.models.DataModels;
using api.models.DTOs;
using api.repositories.IRepositories;
using api.repositories.Repositories;
using api.services.IServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.services.Services
{
    public class UserService : GenericServices<User>, IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository repository, ) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<UserDTO> GetAll()
        {
            List<User> result = _repository.GetAll().ToList();
            List<UserDTO> users = 


        }
    }
}
