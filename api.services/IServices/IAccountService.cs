using api.models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.services.IServices
{
    public interface IAccountService
    {
        TokenDTO Login(LoginDTO dto);

    }
}
