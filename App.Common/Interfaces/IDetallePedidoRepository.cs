using SocialMedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialMedia.Core.Interfaces
{
   public interface IDetallePedidoRepository
    {
        public IQueryable<DetallePedidoEntity> GetAllDetallePedidos();
    }
}
