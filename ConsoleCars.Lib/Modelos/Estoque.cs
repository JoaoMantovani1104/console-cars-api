namespace ConsoleCars.Lib.Modelos;

public class Estoque
{
    public Dictionary<string, Veiculo> veiculos = new();

    public void AdicionarVeiculo(string placa, Veiculo veiculo) => veiculos.TryAdd(placa, veiculo);

    public ICollection<Veiculo> LerEstoque() => veiculos.Values;

    public void RemoverVeiculo(string placa) => veiculos.Remove(placa);

    public Veiculo? ObterVeiculo(string placa) => veiculos.GetValueOrDefault(placa);
}
