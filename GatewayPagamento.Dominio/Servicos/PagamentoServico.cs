﻿using GatewayPagamento.Dominio.Entidades;
using GatewayPagamento.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayPagamento.Dominio.Servicos
{
    public class PagamentoServico 
    {
        private readonly ICartaoRepositorio cartaoRepositorio;
        private readonly IPagamentoRepositorio pagamentoRepositorio;

        public PagamentoServico(ICartaoRepositorio cartaoRepositorio, IPagamentoRepositorio pagamentoRepositorio)
        {
            this.cartaoRepositorio = cartaoRepositorio;
            this.pagamentoRepositorio = pagamentoRepositorio;
        }


        public void Inserir(Pagamento pagamento)
        {
            var cartao = cartaoRepositorio.Selecionar(pagamento.Cartao.Numero);

            if (cartao == null)
            {
                pagamento.Status = StatusPagamento.CartaoInexistente;
                
            }

            var pagamentosExistentes = pagamentoRepositorio.Selecionar(p => p.NumeroPedido == pagamento.NumeroPedido);

            if (pagamentosExistentes.Any())
            {
                pagamento.Status = StatusPagamento.PedidoJaPago;
            }

            if (pagamento.Valor > cartao?.Limite)
            {
                pagamento.Status = StatusPagamento.LimiteInsuficiente;
            }

            if (pagamento.Status == StatusPagamento.NaoDefinido)
            {
                pagamento.Status = StatusPagamento.PagamentoOK;

                pagamentoRepositorio.Inserir(pagamento); 
            }

            //return StatusPagamento.PagamentoOK;
        }
    }
}
