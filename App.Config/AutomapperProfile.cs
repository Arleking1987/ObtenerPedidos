using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using SocialMedia.Core.DTOs;
using SocialMedia.Core.Entities;

namespace App.Config
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<PedidosEntity, PedidosDTO>()
                .ReverseMap();
        }
    }
}
