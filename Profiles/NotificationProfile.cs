using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using nexus_connect.Data;
using nexus_connect.Data.Entities;
using nexus_connect.ViewModels;

namespace nexus_connect.Profiles
{
    public class NotificationProfile : Profile
    {
        public NotificationProfile()
        {
            CreateMap<Notification, NotificationViewModel>();
        }
    }
}