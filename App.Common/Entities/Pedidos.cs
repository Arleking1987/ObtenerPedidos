using System;
using System.Collections.Generic;

namespace SocialMedia.Core.Entities
{
    public partial class Pedidos
    {
        public Pedidos()
        {
            DetallePedido = new HashSet<DetallePedido>();
        }

        public int IdPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string NombreCliente { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<DetallePedido> DetallePedido { get; set; }
    }
}
