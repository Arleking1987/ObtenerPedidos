using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SocialMedia.Core.Entities;
using SocialMedia.Infrastructure.Data.Configurations;

namespace SocialMedia.Infrastructure.Data
{
    public partial class Estado_PedidosContext : DbContext
    {
        public Estado_PedidosContext()
        {
        }

        public Estado_PedidosContext(DbContextOptions<Estado_PedidosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DetallePedidoEntity> DetallePedido { get; set; }
        public virtual DbSet<PedidosEntity> Pedidos { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DetallePedidoConfiguration());

            modelBuilder.ApplyConfiguration(new PedidosConfiguration());
        }
    }
}
