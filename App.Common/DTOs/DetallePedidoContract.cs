using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMedia.Core.DTOs
{
    public class DetallePedidoContract
    {
        public int IdPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string NombreCliente { get; set; }
        public string Estado { get; set; }
        public string Tipo { get; set; }
        public string Medidas { get; set; }
        public string Detalle { get; set; }
        
    }
}
