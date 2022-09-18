using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using DAL_Repositories.Models;

namespace App_Services.Profiles
{
    public class CleanerProfile:Profile
    {
        public CleanerProfile()
        {
            CreateMap<CleanerViewModel, Cleaner>()


               .ForMember(
                   dest => dest.CleanerBankDetail,
                   opt => opt.MapFrom(src => $"{src.CleanerBankDetail}")
               ).ForMember(
                   dest => dest.CleanerBankDetail,
                   opt => opt.MapFrom(src => $"{src.IdNavigation}")
               )
               .ForMember(
                   dest => dest.Perfectionism,
                   opt => opt.MapFrom(src => $"{src.Perfectionism}")
               )
               .ForMember(
                   dest => dest.Efficiency,
                   opt => opt.MapFrom(src => $"{src.Efficiency}"))
               .ForMember(
                   dest => dest.Price,
                   opt => opt.MapFrom(src => $"{src.Price}")
               ).ReverseMap();

        }
    }
}
