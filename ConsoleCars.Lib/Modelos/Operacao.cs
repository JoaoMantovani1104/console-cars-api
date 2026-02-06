namespace ConsoleCars.Lib.Modelos;

public class Operacao
{
    private List<Veiculo> veiculosOperados = [];

    public Operacao() { }

    public Operacao(List<Veiculo> veiculosIniciais)
    {
        veiculosOperados.AddRange(veiculosIniciais);
    }

    public void RegistrarOperacao(Veiculo veiculo) => veiculosOperados.Add(veiculo);

    public List<Veiculo> LerVeiculosOperados() => veiculosOperados;
}
