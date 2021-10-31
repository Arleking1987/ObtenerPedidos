using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMedia.Core.DTOs
{
    public class DetallePedidoDTO
    {
        public int IdDetalle { get; set; }
        public string Tipo { get; set; }
        public string Medidas { get; set; }
        public string Detalle { get; set; }
        public int IdPedido { get; set; }
    }
}
