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
    public class AddressProfile: Profile
    {
        public AddressProfile()
        {
            CreateMap<AddressViewModel, Address>()
               .ForMember(
                   dest => dest.Country,
                   opt => opt.MapFrom(src => $"{src.Country}")
               )
               .ForMember(
                   dest => dest.City,
                   opt => opt.MapFrom(src => $"{src.City}")
               )
               .ForMember(
                   dest => dest.State,
                   opt => opt.MapFrom(src => $"{src.State}")
               )
               .ForMember(
                   dest => dest.AddressLine1,
                   opt => opt.MapFrom(src => $"{src.AddressLine1}")
               )
               .ForMember(
                   dest => dest.AddressLine2,
                   opt => opt.MapFrom(src => $"{src.AddressLine2}")
               )
               .ForMember(
                   dest => dest.Zip,
                   opt => opt.MapFrom(src => $"{src.Zip}")
               ).ReverseMap();
              
        }
    }
}
