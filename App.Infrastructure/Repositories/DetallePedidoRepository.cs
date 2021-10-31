using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using SocialMedia.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialMedia.Infrastructure.Repositories
{
    public class DetallePedidoRepository : IDetallePedidoRepository
    {
        private readonly Estado_PedidosContext _context;

        public DetallePedidoRepository(Estado_PedidosContext context)
        {
            _context = context;
        }
        public IQueryable<DetallePedidoEntity> GetAllDetallePedidos()
        {
            IQueryable<DetallePedidoEntity> list = _context.DetallePedido;

            return list;
        }
    }
}
