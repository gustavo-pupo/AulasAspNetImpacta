﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayPagamento.Dominio.Entidades
{
    public class Pagamento
    {
        public int Id { get; set; }
        public Cartao Cartao { get; set; }
        public string NumeroPedido { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        public StatusPagamento Status { get; set; }
    }
}
