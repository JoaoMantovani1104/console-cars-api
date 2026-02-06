using ConsoleCars.Lib.Enums;
using System.ComponentModel.DataAnnotations;

namespace ConsoleCars.API.Data.Dtos;

public class CreateVeiculoDTO
{
    [Required]
    [StringLength(8, MinimumLength = 8)]
    public string Placa { get; set; }

    [Required]
    public string Modelo { get; set; }

    [Required]
    public string Marca { get; set; }

    public int Ano { get; set; }
    public int Quilometragem { get; set; }

    [Required]
    public decimal PrecoCompra { get; set; }
    public decimal PrecoAnuncio { get; set; }

    public Cores Cor { get; set; }
    public Carrocerias Carroceria { get; set; }
    public Cambios Cambio { get; set; }
    public Combustiveis Combustivel { get; set; }
}

