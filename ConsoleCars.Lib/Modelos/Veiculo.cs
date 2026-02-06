namespace ConsoleCars.Lib.Modelos;

using ConsoleCars.Lib.Enums;

public class Veiculo
{
    public Veiculo() { }
    
    public string Placa { get; set; }
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public int Ano { get; set; }
    public int Quilometragem { get; set; }
    public Cores Cor { get; set; }
    public Carrocerias Carroceria { get; set; }
    public Cambios Cambio { get; set; }
    public Combustiveis Combustivel { get; set; }
    public decimal PrecoCompra { get; set; }
    public decimal PrecoAnuncio { get; set; }
    public DateTime DataEntrada { get; set; }
    public DateTime? DataVenda { get; set; }
    public decimal? PrecoVenda { get; set; }
    public string? Atualizacao { get; set; }
}
