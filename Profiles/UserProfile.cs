using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using nexus_connect.Data.Entities;
using nexus_connect.ViewModels;

namespace nexus_connect.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<StoreUser, MyAccountViewModel>();
            CreateMap<SignUpViewModel, StoreUser>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Username))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Username));
        }
    }
}