using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using SocialMedia.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Repositories
{
   public  class PedidosRepository: IPedidosRepository
    {
        private readonly Estado_PedidosContext _context;

        public PedidosRepository(Estado_PedidosContext context)
        {
            _context = context;
        }
        public  IQueryable<PedidosEntity> GetAllPedidos()
        {
            IQueryable<PedidosEntity> list = _context.Pedidos;
            

            return list;
        }

        public async Task<PedidosEntity> GetPedido(int id)
        {
            var pedido = await _context.Pedidos.FirstOrDefaultAsync(x => x.IdPedido == id);
            return pedido;
        }

        public async Task PostPedido(PedidosEntity pedido)
        {
            _context.Pedidos.Add(pedido);
            await _context.SaveChangesAsync();
        }


    }
}
