﻿using MarketplaceRepositorios.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Marketplace.Mvc.Models
{
    public class PagamentoIndexViewModel
    {
        public int Id { get; set; }
        
        [DisplayName("Cartão")]
        public string MascaraCartao { get; set; }

        [DisplayName("Número do Pedido")]
        public string NumeroPedido { get; set; }
        
        public DateTime Data { get; set; }
        
        public decimal Valor { get; set; }

        internal static List<PagamentoIndexViewModel> Mapear(List<PagamentoResponse> pagamentos)
        {
            var viewModels = new List<PagamentoIndexViewModel>();

            foreach (var pagamento in pagamentos)
            {
                viewModels.Add(Mapear(pagamento));
            }

            return viewModels;
        }

        private static PagamentoIndexViewModel Mapear(PagamentoResponse pagamento)
        {
            var viewModel = new PagamentoIndexViewModel();

            viewModel.MascaraCartao = pagamento.MascaraCartao;
            viewModel.Id = pagamento.Id;
            //viewModel.Data = pagamento.Data;
            viewModel.NumeroPedido = pagamento.NumeroPedido;
            viewModel.Valor = pagamento.Valor;

            return viewModel;
        }
    }
}