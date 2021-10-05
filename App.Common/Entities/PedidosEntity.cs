using System;
using System.Collections.Generic;

namespace SocialMedia.Core.Entities
{
    public partial class PedidosEntity
    {
        public PedidosEntity()
        {
            DetallePedido = new HashSet<DetallePedidoEntity>();
        }

        public int IdPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string NombreCliente { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<DetallePedidoEntity> DetallePedido { get; set; }
    }
}
