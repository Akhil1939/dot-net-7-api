using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.models.DataModels;
using api.services.Services;
using api.services.IServices;
using api.models.DTOs;
using API.Response;
using API.Utils;
using System.Net;

namespace A_P_I.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;


        public UsersController(IUserService service)
        {
            _service = service;
        }

        // GET: api/Users
        [HttpGet]
        public IActionResult GetUsers([FromQuery]UserListRequestDTO requestParams)
        {

            PageListResponseDTO<UserDTO> response = _service.GetAll(requestParams);

            return new SuccessResponseHelper<PageListResponseDTO<UserDTO>>().GetSuccessResponse((int)HttpStatusCode.OK, response);
        }

        [HttpPost]
        public IActionResult Create(RegisterDTO user)
        {
            _service.Create(user);
            return new SuccessResponseHelper<object>().GetSuccessResponse((int)HttpStatusCode.Created, "User created successfully", null);
        }
    }
}