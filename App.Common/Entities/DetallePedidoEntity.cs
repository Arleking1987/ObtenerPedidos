using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMedia.Core.Entities
{
    [Table("detalle_pedido", Schema = "Pedido")]
    public  class DetallePedidoEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDetalle { get; set; }
        public string Tipo { get; set; }
        public string Medidas { get; set; }
        public string Detalle { get; set; }
        public int IdPedido { get; set; }

       
    }
}
