using AutoMapper;
using ConsoleCars.API.Data;
using ConsoleCars.Lib.Modelos;
using Microsoft.AspNetCore.Mvc;
using ConsoleCars.API.Data.Dtos;
using Microsoft.AspNetCore.JsonPatch;

namespace ConsoleCars.API.Controllers;

[ApiController]
[Route("/Veiculos")]
public class VeiculosController : ControllerBase
{
    private VeiculoContext context;
    private IMapper mapper;

    public VeiculosController(VeiculoContext context, IMapper mapper)
    {
        this.context = context;
        this.mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetVeiculos()
    {
        var listaVeiculos = mapper.Map<List<ReadVeiculoDTO>>(context.Veiculos.ToList());

        return Ok(listaVeiculos);
    }

    [HttpGet("{placa}")]
    public IActionResult GetVeiculoByPlaca(string placa)
    {
        var veiculo = context.Veiculos.FirstOrDefault(v => v.Placa == placa);
        if (veiculo == null) return NotFound();

        var veiculoDTO = mapper.Map<ReadVeiculoDTO>(veiculo);

        return Ok(veiculoDTO);
    }

    [HttpPost]
    public IActionResult CadastrarVeiculo([FromBody] CreateVeiculoDTO createVeiculoDto)
    {
        Veiculo veiculo = mapper.Map<Veiculo>(createVeiculoDto);
        context.Veiculos.Add(veiculo);
        context.SaveChanges();

        return CreatedAtAction(nameof(GetVeiculoByPlaca), new { placa = veiculo.Placa }, veiculo);
    }

    [HttpPut("{placa}")]
    public IActionResult AtualizarVeiculo(string placa, [FromBody] UpdateVeiculoDTO updateVeiculoDto)
    {
        var veiculo = context.Veiculos.FirstOrDefault(v => v.Placa == placa);

        if (veiculo == null) return NotFound();

        mapper.Map(updateVeiculoDto, veiculo);
        context.SaveChanges();

        return NoContent();
    }

    [HttpPatch("{placa}")]
    public IActionResult AtualizaCampoVeiculo(string placa, JsonPatchDocument<UpdateVeiculoDTO> patch)
    {
        var veiculo = context.Veiculos.FirstOrDefault(v => v.Placa == placa);

        if (veiculo == null) return NotFound();

        var veiculoParaAtualizar = mapper.Map<UpdateVeiculoDTO>(veiculo);
        patch.ApplyTo(veiculoParaAtualizar, ModelState);

        mapper.Map(veiculoParaAtualizar, veiculo);
        context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{placa}")]
    public IActionResult DeletarVeiculo(string placa)
    {
        var veiculo = context.Veiculos.FirstOrDefault(v => v.Placa == placa);

        if (veiculo == null) return NotFound();

        context.Veiculos.Remove(veiculo);
        context.SaveChanges();

        return NoContent();
    }
}
