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
        public async Task<IEnumerable<Pedidos>> GetAllPedidos()
        {

            var pedidos = await _context.Pedidos.ToListAsync();

            return pedidos;
        }

        public async Task<Pedidos> GetPedido(int id)
        {
            var pedido = await _context.Pedidos.FirstOrDefaultAsync(x => x.IdPedido == id);
            return pedido;
        }
    }
}
