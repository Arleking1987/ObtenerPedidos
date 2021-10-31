using SocialMedia.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Services
{
    public interface IPedidosService
    {
        List<PedidosDTO> GetAllPedidos();

        public List<DetallePedidoContract> GetPedidoById(int id);
    }
}
