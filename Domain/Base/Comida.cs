namespace AbstractyFactory.Domain.Base;

public abstract class Comida
{
    public Comida(TipoProduto tipo) 
    {
        Tipo = tipo;
    }

    public string Nome { get; set; } = string.Empty;
    public TipoProduto Tipo  { get; set; }

    public abstract List<Comida> BuscaComida();
}
