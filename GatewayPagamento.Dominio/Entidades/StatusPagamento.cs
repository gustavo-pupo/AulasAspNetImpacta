namespace GatewayPagamento.Dominio
{
    public enum StatusPagamento
    {
        LimiteInsuficiente = 1,
        PedidoJaPago = 2,
        CartaoInexistente = 3,
        PagamentoOK = 4 
    }
}