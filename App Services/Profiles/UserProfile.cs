using AutoMapper;
using Common;
using DAL_Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Services.Profiles
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<UserViewModel, User>()
               .ForMember(
                   dest => dest.FirstName,
                   opt => opt.MapFrom(src => $"{src.FirstName}")
               )
               .ForMember(
                   dest => dest.LastName,
                   opt => opt.MapFrom(src => $"{src.LastName}")
               )
               .ForMember(
                   dest => dest.UserId,
                   opt => opt.MapFrom(src => $"{src.UserId}")
               ).ForMember(
                   dest => dest.Gender,
                   opt => opt.MapFrom(src => $"{src.Gender}")
               )
               .ForMember(
                   dest => dest.Email,
                   opt => opt.MapFrom(src => $"{src.Email}")
               ).ReverseMap();

        }
    }
}
