using System.ComponentModel;

namespace GatewayPagamento.Dominio
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
        PagamentoOK = 4 
    }
}