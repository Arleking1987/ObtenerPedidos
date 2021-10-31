using SocialMedia.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialMedia.Infrastructure.Services
{
    public interface IDetallePedidoService
    {
        public List<DetallePedidoDTO> GetAllDetallePedidos();
    }
}
