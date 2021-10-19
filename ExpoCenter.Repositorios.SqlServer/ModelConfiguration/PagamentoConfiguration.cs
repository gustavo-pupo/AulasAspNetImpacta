using ExpoCenter.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpoCenter.Repositorios.SqlServer.ModelConfiguration
{
    internal class PagamentoConfiguration : IEntityTypeConfiguration<Pagamento> /*internal é opcional*/
    {
        
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.ToTable("Pagamento");

            builder
                .Property(e => e.Valor)
                .HasPrecision(11, 2); //999 999 999 99

            //builder
                //.Property(p => p.Status)
                //.Ignore();

        }
    }
}
