using SocialMedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Interfaces
{
   public  interface IPedidosRepository
    {
        public Task<IEnumerable<PedidosEntity>> GetAllPedidos();
        Task<PedidosEntity> GetPedido(int id);

        Task PostPedido(PedidosEntity pedido);

    }
}
