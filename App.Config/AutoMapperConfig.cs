using AutoMapper;
using SocialMedia.Core.DTOs;
using SocialMedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Config
{
   public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<PedidosEntity, PedidosDTO>();
            CreateMap<DetallePedidoEntity, DetallePedidoDTO>();
        }
    }
}
