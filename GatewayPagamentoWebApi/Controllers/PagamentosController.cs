using GatewayPagamento.Apoio;
using GatewayPagamento.Dominio.Entidades;
using GatewayPagamento.Dominio.Servicos;
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
        private readonly PagamentoServico pagamentoServico; //= new PagamentoServico();

        public PagamentosController()
        {
            pagamentoServico = new PagamentoServico(cartaoRepositorio, pagamentoRepositorio);
        }
        
        // GET api/<controller>


        //[HttpGet]
        [Route("api/pagamentos/cartao/{idCartao}")]
        public IEnumerable<PagamentoGetViewModel> Get(int idCartao)
        {
            return PagamentoGetViewModel.Mapear(pagamentoRepositorio.Selecionar(p => p.Cartao.Id == idCartao));
        }

        // GET api/<controller>/5
        /*public string Get(int id)
        {
            return "teste";
        }*/

        // POST api/<controller>
        //public IHttpActionResult Post([FromBody] string value, [FromUri] queryString);
        public IHttpActionResult Post(PagamentoPostViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pagamento = PagamentoPostViewModel.Mapear(viewModel);

            pagamentoServico.Inserir(pagamento);

            var responseViewModel = PagamentoGetViewModel.Mapear(pagamento);

            switch (pagamento.Status)
            {
                case StatusPagamento.LimiteInsuficiente:
                case StatusPagamento.PedidoJaPago:
                case StatusPagamento.CartaoInexistente:

                    return Content(HttpStatusCode.BadRequest, responseViewModel);
                    
                case StatusPagamento.PagamentoOK:
                    //return Ok(responseViewModel);
                    return CreatedAtRoute("DefaultApi", new { id = responseViewModel.Id }, responseViewModel);
            }
            return InternalServerError(new ArgumentOutOfRangeException(nameof(pagamento.Status)));
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