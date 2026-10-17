# ecommerce-checkout-xunit

Lista de Exercícios — Garantia da Qualidade de Software (Gestão e Qualidade de Software).

**Aluno:** Patrick Oliveira Rabelo de Brito — RA 4251923386

## Propósito do sistema

Aplicação console .NET 10 que representa o checkout de uma loja online. A classe `PedidoService` (em `EcommerceCheckout.App`) implementa três regras de negócio:

1. `GerarCodigoRastreio(string regiao, int numeroPedido)` (string) — monta o código de rastreio unindo a região em maiúsculas ao número do pedido com 4 dígitos. Ex.: `"sudeste"`, `42` → `"SUDESTE-0042"`.
2. `CalcularPontosFidelidade(int valorTotal)` (int) — concede 2 pontos de fidelidade a cada R$ 10 de compra. Ex.: `150` → `30`.
3. `TemDireitoAFreteGratis(int valorTotal, bool eClienteVIP)` (bool) — `true` quando o total é maior ou igual a R$ 200 **ou** quando o cliente é VIP.

## Tipos de testes unitários (xUnit)

- **Teste de string:** valida a máscara do código com `Assert.Equal("SUDESTE-0042", resultado)`.
- **Teste de int:** valida o cálculo dos pontos com `Assert.Equal(30, resultado)`.
- **Teste de bool:** valida as regras de frete grátis com `Assert.True(...)` (VIP abaixo de R$ 200) e `Assert.False(...)` (não VIP abaixo de R$ 200).

## Estrutura

```
EcommerceCheckout.slnx
EcommerceCheckout.App/     # Projeto console (código de produção)
EcommerceCheckout.Tests/   # Projeto de testes xUnit
```

## Como rodar a aplicação

```bash
dotnet run --project EcommerceCheckout.App
```

## Como executar os testes

```bash
dotnet test
```

## Licença

MIT — veja [LICENSE](LICENSE).
