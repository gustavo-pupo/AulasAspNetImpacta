﻿using GatewayPagamento.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayPagamentos.Repositorios.SqlServer.CodeFirst
{
    public class CartaoRepositorio
    {
        public Cartao Selecionar(string numeroCartao)
        {
            using (var contexto = new GatewayPagamentoDbContext())
            {
                return contexto.Cartoes.SingleOrDefault(c => c.Numero == numeroCartao);
            }
        }
    }
}
