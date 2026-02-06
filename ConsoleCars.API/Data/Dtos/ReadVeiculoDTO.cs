using ConsoleCars.Lib.Enums;

namespace ConsoleCars.API.Data.Dtos;

public class ReadVeiculoDTO
{
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
}
