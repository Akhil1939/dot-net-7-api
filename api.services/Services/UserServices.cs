using api.models.DataModels;
using api.models.DTOs;
using api.repositories.IRepositories;
using api.repositories.Repositories;
using api.services.IServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace api.services.Services
{
    public class UserService : GenericServices<User>, IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repository, IMapper mapper ) : base(repository)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public PageListResponseDTO<UserDTO> GetAll(UserListRequestDTO requestParams)
        {
            IQueryable<User> result = _repository.GetAll();
            if(!string.IsNullOrEmpty(requestParams.SearchQuery))
            {
                result = result.Where(User => User.Username.Contains(requestParams.SearchQuery));
            }
            IEnumerable<UserDTO> users = _mapper.Map<IEnumerable<UserDTO>>(result);
            PageListResponseDTO<UserDTO> pageListResponseDTO = new PageListResponseDTO<UserDTO>(1, 10, users.Count(), users.ToList());

            return pageListResponseDTO;

        }
        public void Create(RegisterDTO user)
        {
            User newUser = new User
            {
                Username = user.Username,
                Email = user.Email,
                Password = user.Password,
                PhoneNumber = user.PhoneNumber,
                Role = 1
                
            };

            _repository.Create(newUser);
        }

        public UserDTO getUserByEmail(string email)
        {
            User user = _repository.GetByEmail(email);
            UserDTO userDTO = _mapper.Map<UserDTO>(user);
            return userDTO;
        }
    }
}
