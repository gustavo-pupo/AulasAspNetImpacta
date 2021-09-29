namespace GatewayPagamento.Dominio.Interfaces
{
    public interface ICartaoRepositorio
    {
        Cartao Selecionar(string numeroCartao);
    }
}