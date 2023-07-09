using api.models.DTOs;
using api.services.IServices;
using API.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace A_P_I.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _service;
        public AccountController(IAccountService service)
        {
            _service = service;
        }
        //login
        [HttpPost]
        public IActionResult Login(LoginDTO login)
        {
            var token = _service.Login(login);
            if (token == null)
            {
                return new SuccessResponseHelper<object>().GetSuccessResponse((int)HttpStatusCode.BadRequest, "Invalid username or password", null);
            }
            return new SuccessResponseHelper<TokenDTO>().GetSuccessResponse((int)HttpStatusCode.OK, token);
        }
    }
}
