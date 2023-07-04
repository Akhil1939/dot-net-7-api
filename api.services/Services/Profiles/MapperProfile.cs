using api.models.DataModels;
using api.models.DTOs;
using AutoMapper;
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
            CreateMap<User, UserDTO>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username))
                .ForMember(dest => dest.Email, opt => opt.MapFrom<string>(src => src.Email))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom<string>(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role))
                .ReverseMap();
        }
    }
}
