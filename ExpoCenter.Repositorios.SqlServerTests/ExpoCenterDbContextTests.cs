using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpoCenter.Repositorios.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using ExpoCenter.Dominio.Entidades;

namespace ExpoCenter.Repositorios.SqlServer.Tests
{
    [TestClass()]
    public class ExpoCenterDbContextTests
    {
        private readonly ExpoCenterDbContext dbContext;// = new ExpoCenterDbContext();

        public ExpoCenterDbContextTests()
        {
            var dbContextOptions = new DbContextOptionsBuilder<ExpoCenterDbContext>()
                .UseSqlServer(new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExpoCenter;Integrated Security=True"))
                .LogTo(ExibirQuery, LogLevel.Information)
                .Options;

            dbContext = new ExpoCenterDbContext(dbContextOptions);
        }

        private void ExibirQuery(string query)
        {
            Console.WriteLine(query);
        }

        [TestMethod()]
        public void InserirEventoTeste()
        {
            var evento = new Evento();
            evento.Data = DateTime.Now;
            evento.Descricao = "BGS 2021";
            evento.Local = "São Paulo/SP";
            evento.Preco = 65.00m;

            dbContext.Eventos.Add(evento);
            dbContext.SaveChanges();
        }

        [TestMethod]
        public void InserirParticipanteTeste()
        {
            var participante = new Participante();
            participante.Cpf = "12345678910";
            participante.DataNascimento = new DateTime(2003, 2, 24);
            participante.Email = "dummy@gmail.com";
            participante.Nome = "Zé";

            participante.Eventos = new List<Evento> { dbContext.Eventos.Single(e => e.Descricao == "BGS 2021") };

            dbContext.Participantes.Add(participante);
            dbContext.SaveChanges();
        }

        [TestMethod]
        public void SelecionarParticipantesTeste()
        {
            foreach (var participante in dbContext.Participantes.OrderBy(p => p.Nome))
            {
                Console.WriteLine(participante.Nome);
            }
        }
        [TestMethod]
        public void InserirPagamentoTeste()
        {
            var pagamento = new Pagamento();
            pagamento.IdCartao = Guid.NewGuid();
            pagamento.IdProduto = Guid.NewGuid();
            pagamento.Valor = 20.23m;

            dbContext.Add(pagamento);
            dbContext.SaveChanges();
        }
    }
}