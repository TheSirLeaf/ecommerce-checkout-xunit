namespace EcommerceCheckout.App;

public class PedidoService
{
    // Monta o codigo de rastreio: regiao em maiusculas + numero do pedido com 4 digitos.
    public string GerarCodigoRastreio(string regiao, int numeroPedido)
    {
        return $"{regiao.ToUpperInvariant()}-{numeroPedido:D4}";
    }

    // Concede 2 pontos de fidelidade a cada R$ 10 de compra.
    public int CalcularPontosFidelidade(int valorTotal)
    {
        return valorTotal / 10 * 2;
    }

    // Frete gratis quando o total e maior ou igual a R$ 200 OU o cliente e VIP.
    public bool TemDireitoAFreteGratis(int valorTotal, bool eClienteVIP)
    {
        return valorTotal >= 200 || eClienteVIP;
    }
}
