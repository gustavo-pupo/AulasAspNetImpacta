using System.ComponentModel;

namespace GatewayPagamento.Dominio.Entidades
{
    public enum StatusPagamento
    {
        [Description("Saldo Indisponível")]
        LimiteInsuficiente = 1,

        [Description("Pedido já pago")]
        PedidoJaPago = 2,

        [Description("O cartão informado não existe")]
        CartaoInexistente = 3,

        [Description("CERTIN")]
        PagamentoOK = 4,

        Quinto = 5

    }
}