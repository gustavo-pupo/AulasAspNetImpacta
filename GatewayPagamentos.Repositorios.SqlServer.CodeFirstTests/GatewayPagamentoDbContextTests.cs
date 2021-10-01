using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatewayPagamento.Dominio.Entidades;

namespace GatewayPagamentos.Repositorios.SqlServer.CodeFirst.Tests
{
    [TestClass()]
    public class GatewayPagamentoDbContextTests
    {
        private readonly GatewayPagamentoDbContext contexto = new GatewayPagamentoDbContext();

        [TestMethod()]
        public void InserirCartaoTeste()
        {
            contexto.Cartoes.Add(new Cartao { Limite = 1000, Numero = "1234123412341234" });
            contexto.SaveChanges();
        }
    }
}