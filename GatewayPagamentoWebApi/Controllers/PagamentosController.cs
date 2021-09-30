using GatewayPagamentos.Repositorios.SqlServer.CodeFirst;
using GatewayPagamentoWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GatewayPagamentoWebApi.Controllers
{
    public class PagamentosController : ApiController
    {

        private readonly PagamentoRepositorio pagamentoRepositorio = new PagamentoRepositorio();
        private readonly CartaoRepositorio cartaoRepositorio = new CartaoRepositorio();
        
        // GET api/<controller>


        //[HttpGet]
        public IEnumerable<PagamentoViewModel> Get(int idCartao)
        {
            

                
            return PagamentoViewModel.Mapear(pagamentoRepositorio.Selecionar(p => p.Cartao.Id == idCartao));
        }

        // GET api/<controller>/5
        /*public string Get(int id)
        {
            return "teste";
        }*/

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}