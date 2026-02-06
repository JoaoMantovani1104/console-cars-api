using AutoMapper;

namespace ConsoleCars.API.Profiles;

public class VeiculoProfile : Profile
{
    public VeiculoProfile()
    {
        CreateMap<Data.Dtos.CreateVeiculoDTO, Lib.Modelos.Veiculo>();
        CreateMap<Data.Dtos.UpdateVeiculoDTO, Lib.Modelos.Veiculo>();
        CreateMap<Lib.Modelos.Veiculo, Data.Dtos.ReadVeiculoDTO>();
        CreateMap<Lib.Modelos.Veiculo, Data.Dtos.UpdateVeiculoDTO>();
    }
}
