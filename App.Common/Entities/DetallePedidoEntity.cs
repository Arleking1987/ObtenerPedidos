using System;
using System.Collections.Generic;

namespace SocialMedia.Core.Entities
{
    public partial class DetallePedidoEntity
    {
        public int IdDetalle { get; set; }
        public string Tipo { get; set; }
        public string Medidas { get; set; }
        public string Detalle { get; set; }
        public int IdPedido { get; set; }

        public virtual PedidosEntity IdPedidoNavigation { get; set; }
    }
}
