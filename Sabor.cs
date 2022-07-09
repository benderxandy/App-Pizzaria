
// Pizzaria
// Pedir pizza

public class Sabor
{
    public int Numero { get; set; }
    public string Nome { get; set; }

    public override string ToString()
    {
        return $"{Numero} - {Nome}";
    }
}
