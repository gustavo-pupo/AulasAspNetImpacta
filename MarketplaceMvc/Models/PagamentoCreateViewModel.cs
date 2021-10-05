using MarketplaceRepositorios.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarketplaceMvc.Models
{
    public class PagamentoCreateViewModel
    {
        [Required]
        [Display(Name = "Cartão")]
        public string NumeroCartao { get; set; }
        [Required]
        [DisplayName("Pedido")]
        public string NumeroPedido { get; set; }
        [Required]
        public decimal Valor { get; set; }

        internal static PagamentoRequest Mapear(PagamentoCreateViewModel viewModel)
        {
            var request = new PagamentoRequest();

            request.numeroCartao = viewModel.NumeroCartao;
            request.numeroPedido = viewModel.NumeroPedido;
            request.valor = viewModel.Valor;

            return request;
        }
    }
}