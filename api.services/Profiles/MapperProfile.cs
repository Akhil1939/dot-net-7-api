using api.models.DataModels;
using api.models.DTOs;
using AutoMapper;
using Common.Utils.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.services.Services.Profiles
{
    public class MapperProfile :Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, SessionUserModel>().ReverseMap();

            
        }
    }
}
