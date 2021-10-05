namespace MarketplaceRepositorios.Http
{
    public class PagamentoRequest
    {
        public string numeroCartao { get; set; }
        public string numeroPedido { get; set; }
        public decimal valor { get; set; }
    }
}