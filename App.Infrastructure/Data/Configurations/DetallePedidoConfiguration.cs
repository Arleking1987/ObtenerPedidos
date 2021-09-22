using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Core.Entities;

namespace SocialMedia.Infrastructure.Data.Configurations
{
    public class DetallePedidoConfiguration : IEntityTypeConfiguration<DetallePedido>
    {
        public void Configure(EntityTypeBuilder<DetallePedido> builder)
        {
            builder.HasKey(e => e.IdDetalle);

            builder.ToTable("detalle_pedido", "Pedido");

            builder.Property(e => e.IdDetalle).HasColumnName("id_detalle");

            builder.Property(e => e.Detalle)
                .IsRequired()
                .HasColumnName("detalle");

            builder.Property(e => e.IdPedido).HasColumnName("id_pedido");

            builder.Property(e => e.Medidas)
                .IsRequired()
                .HasColumnName("medidas")
                .HasMaxLength(100);

            builder.Property(e => e.Tipo)
                .IsRequired()
                .HasColumnName("tipo")
                .HasMaxLength(100);

            builder.HasOne(d => d.IdPedidoNavigation)
                .WithMany(p => p.DetallePedido)
                .HasForeignKey(d => d.IdPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_detalle_pedido_Pedido");
        }
    }
}
