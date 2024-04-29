public class Pizza {

    public int Id { get; set; }
    public string? tamanhoPizza { get; set; }
     public string? Sabores { get; set; }
    public double? Valor { get; set; }
    public override string ToString()
    {
        return $"Id: {Id}, Tamanho: {tamanhoPizza}, Sabor: {Sabores} Valor: {Valor}";
    }
}