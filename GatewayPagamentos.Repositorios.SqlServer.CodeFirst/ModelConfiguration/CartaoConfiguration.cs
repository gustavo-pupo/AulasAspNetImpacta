using GatewayPagamento.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace GatewayPagamentos.Repositorios.SqlServer.CodeFirst.ModelConfiguration
{
    internal class CartaoConfiguration : EntityTypeConfiguration<Cartao>
    {
        public CartaoConfiguration()
        {
            Property(c => c.Numero)
            .IsRequired()
            .HasMaxLength(20);

            Property(c => c.Limite)
            .IsRequired()
            .HasPrecision(11,2);
        }
    }
}