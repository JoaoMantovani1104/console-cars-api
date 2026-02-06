using ConsoleCars.Lib.Enums;

namespace ConsoleCars.Lib.Modelos;

public class Filtro
{
    public string? Modelo { get; set; }
    public string? Marca { get; set; }
    public int? AnoMinimo { get; set; }
    public int? AnoMaximo { get; set; }
    public int? QuilometragemMinima { get; set; }
    public int? QuilometragemMaxima { get; set; }
    public Cores? Cor { get; set; }
    public Carrocerias? Carroceria { get; set; }
    public Cambios? Cambio { get; set; }
    public Combustiveis? Combustivel { get; set; }
    public decimal? PrecoMinimo { get; set; }
    public decimal? PrecoMaximo { get; set; }
}
