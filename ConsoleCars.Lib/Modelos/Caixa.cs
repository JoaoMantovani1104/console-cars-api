namespace ConsoleCars.Lib.Modelos;

public class Caixa
{
    public decimal Saldo { get; private set; }

    Estoque estoque;

    public Caixa(Estoque estoque)
    {
        Saldo = 500000m;
        this.estoque = estoque;
    }

    public void SubtrairAoSaldo(decimal valorCompra) => Saldo -= valorCompra;

    public void AdicionarAoSaldo(decimal valorVenda) => Saldo += valorVenda;

    public decimal TotalInvestido() => estoque.LerEstoque().Sum(v => v.PrecoCompra);

    public decimal TotalAnunciado() => estoque.LerEstoque().Sum(v => v.PrecoAnuncio);

    public decimal LucroProjetado() => TotalAnunciado() - TotalInvestido();

    public int QuantidadeVeiculos() => estoque.LerEstoque().Count;
}
