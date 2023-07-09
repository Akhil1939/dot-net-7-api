using api.models.DataModels;
using api.models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.services.IServices
{
    public interface IUserService : IGenericService<User>
    {
        PageListResponseDTO<UserDTO> GetAll(UserListRequestDTO requestParams);

        void Create(RegisterDTO user);

        UserDTO getUserByEmail(string email);
    }
}
