using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Core.Entities;

namespace SocialMedia.Infrastructure.Data.Configurations
{
    public class PedidosConfiguration : IEntityTypeConfiguration<Pedidos>
    {
        public void Configure(EntityTypeBuilder<Pedidos> builder)
        {
            builder.HasKey(e => e.IdPedido)
                    .HasName("PK_Pedido");

            builder.ToTable("Pedidos", "Pedido");

            builder.Property(e => e.IdPedido)
                .HasColumnName("id_pedido")
                .ValueGeneratedNever();

            builder.Property(e => e.Estado)
                .IsRequired()
                .HasColumnName("estado")
                .HasMaxLength(50)
                .IsFixedLength();

            builder.Property(e => e.FechaEntrega)
                .HasColumnName("fecha_Entrega")
                .HasColumnType("datetime");

            builder.Property(e => e.FechaPedido)
                .HasColumnName("fecha_pedido")
                .HasColumnType("datetime");

            builder.Property(e => e.NombreCliente)
                .IsRequired()
                .HasColumnName("nombre_Cliente")
                .HasMaxLength(100)
                .IsFixedLength();
        }
    }
}
