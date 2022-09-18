using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Common;
using DAL_Repositories.Models;

namespace App_Services.Profiles
{
    public class HousekeeperProfile:Profile
    {
        public HousekeeperProfile()
        {
            CreateMap<HousekeeperViewModel, Housekeeper>()
            .ForMember(
                dest => dest.IdNavigation,
                opt => opt.MapFrom(src => $"{src.IdNavigation}")
            )
            .ForMember(
                dest => dest.Id,
                opt => opt.MapFrom(src => $"{src.Id}")
            ).ReverseMap();
        }
    }
}
