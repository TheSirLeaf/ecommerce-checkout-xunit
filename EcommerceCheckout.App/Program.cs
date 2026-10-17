using EcommerceCheckout.App;

var service = new PedidoService();

Console.WriteLine($"Codigo de rastreio: {service.GerarCodigoRastreio("sudeste", 42)}");
Console.WriteLine($"Pontos de fidelidade: {service.CalcularPontosFidelidade(150)}");
Console.WriteLine($"Frete gratis (VIP): {service.TemDireitoAFreteGratis(150, true)}");
Console.WriteLine($"Frete gratis (nao VIP): {service.TemDireitoAFreteGratis(150, false)}");
