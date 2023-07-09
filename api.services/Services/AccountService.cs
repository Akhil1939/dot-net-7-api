using api.models.DataModels;
using api.models.DTOs;
using api.repositories.IRepositories;
using api.services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.services.Services
{
    public class AccountService :GenericServices<User> ,IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AccountService(IUnitOfWork unitOfWork) : base(unitOfWork.UserRepository)
        {
            _unitOfWork = unitOfWork;
        }
        public TokenDTO Login(LoginDTO dto)
        {
            User user = _unitOfWork.UserRepository.GetByEmail(dto.Email) ?? throw new Exception("Invalid credentials");

            if(!varifyUser(dto, user))
            {
                throw new Exception("Invalid credentials");
            }

            return new TokenDTO()
            {
                Token = "token",
                UserRole = user.Role
            };


        }

        private static bool varifyUser(LoginDTO dto, User user)
        {
            return dto.Password == user.Password;

           
        }
    }
}
