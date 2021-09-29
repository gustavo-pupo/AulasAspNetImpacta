﻿using GatewayPagamento.Dominio;
using GatewayPagamentos.Repositorios.SqlServer.CodeFirst.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayPagamentos.Repositorios.SqlServer.CodeFirst
{
    public class GatewayPagamentoDbContext : DbContext
    {
        public GatewayPagamentoDbContext() : base("GatewayPagamentoConnection")
        {

        }

        public DbSet<Cartao> Cartoes { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new CartaoConfiguration());
            modelBuilder.Configurations.Add(new PagamentoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
