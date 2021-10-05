using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMedia.Core.DTOs
{
   public  class PedidosDTO
    {
        public int IdPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string NombreCliente { get; set; }
        public string Estado { get; set; }
    }
}
