using EcommerceCheckout.App;

namespace EcommerceCheckout.Tests;

public class PedidoServiceTests
{
    [Fact]
    public void GerarCodigoRastreio_DeveMontarMascaraComRegiaoENumero()
    {
        var service = new PedidoService();

        var resultado = service.GerarCodigoRastreio("sudeste", 42);

        Assert.Equal("SUDESTE-0042", resultado);
    }

    [Fact]
    public void CalcularPontosFidelidade_DoisPontosACadaDezReais()
    {
        var service = new PedidoService();

        var resultado = service.CalcularPontosFidelidade(150);

        Assert.Equal(30, resultado);
    }

    [Fact]
    public void TemDireitoAFreteGratis_ClienteVipAbaixoDeDuzentos_DeveRetornarTrue()
    {
        var service = new PedidoService();

        Assert.True(service.TemDireitoAFreteGratis(150, true));
    }

    [Fact]
    public void TemDireitoAFreteGratis_NaoVipAbaixoDeDuzentos_DeveRetornarFalse()
    {
        var service = new PedidoService();

        Assert.False(service.TemDireitoAFreteGratis(150, false));
    }
}
