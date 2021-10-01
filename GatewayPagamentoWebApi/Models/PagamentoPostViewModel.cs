﻿using GatewayPagamento.Dominio;
using GatewayPagamento.Dominio.Entidades;
using System.ComponentModel.DataAnnotations;

namespace GatewayPagamentoWebApi.Models
{
    public class PagamentoPostViewModel
    {
        [Required]
        public string NumeroCartao { get; set; }
        [Required]
        public string NumeroPedido { get; set; }
        [Required]
        public decimal Valor { get; set; }

        internal static Pagamento Mapear(PagamentoPostViewModel viewModel)
        {
            var pagamento = new Pagamento();

            pagamento.NumeroPedido = viewModel.NumeroPedido;
            pagamento.Valor = viewModel.Valor;
            pagamento.Cartao = new Cartao { Numero = viewModel.NumeroCartao };

            return pagamento;

        }
    }
}