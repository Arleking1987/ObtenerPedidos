﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMedia.Core.Entities
{
    [Table("[Pedidos]", Schema = "Pedido")]
    public partial class PedidosEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string NombreCliente { get; set; }
        public string Estado { get; set; }

       
    }
}
