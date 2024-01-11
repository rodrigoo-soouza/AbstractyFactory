namespace AbstractyFactory.Domain.Base;

public abstract class Embalagem
{
    public Embalagem(TipoProduto tipo)
    {
        Tipo = tipo;
    }

    public string Nome { get; set; } = string.Empty;
    public TipoProduto Tipo { get; set; }

    public abstract List<Embalagem> BuscaEmbalagem();
}
