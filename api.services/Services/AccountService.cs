using api.models.DataModels;
using api.models.DTOs;
using api.repositories.IRepositories;
using api.services.IServices;
using AutoMapper;
using Common;
using Common.Utils.Models;
using Microsoft.Extensions.Configuration;

namespace api.services.Services
{
    public class AccountService :GenericServices<User> ,IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public AccountService(IUnitOfWork unitOfWork, IConfiguration configuration, IMapper mapper) : base(unitOfWork.UserRepository)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
            _mapper = mapper;
        }
        public TokenDTO Login(LoginDTO dto)
        {
            User user = _unitOfWork.UserRepository.GetByEmail(dto.Email) ?? throw new Exception("Invalid credentials");

            if(!varifyUser(dto, user))
            {
                throw new Exception("Invalid credentials");
            }
            JwtSetting jwtSetting = GetJwtSetting();
            SessionUserModel currentUser = _mapper.Map<SessionUserModel>(user);

            return new TokenDTO()
            {
                Token = JwtHelper.GenerateToken(jwtSetting, currentUser),
                UserRole = user.Role
            };


        }

        private static bool varifyUser(LoginDTO dto, User user)
        {
            return dto.Password == user.Password;

           
        }

        private JwtSetting GetJwtSetting()
        {
            JwtSetting jwtSetting = new();
            _configuration.GetSection("JwtSetting").Bind(jwtSetting);
            return jwtSetting;
        }
    }
}
