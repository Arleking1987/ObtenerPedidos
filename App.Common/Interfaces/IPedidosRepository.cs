using SocialMedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Interfaces
{
   public  interface IPedidosRepository
    {
        Task<IEnumerable<Pedidos>> GetAllPedidos();
        Task<Pedidos> GetPedido(int id);

        Task PostPedido(Pedidos pedido);

    }
}
