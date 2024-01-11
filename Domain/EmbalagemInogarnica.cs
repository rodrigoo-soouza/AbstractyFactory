using AbstractyFactory.Domain.Base;

namespace AbstractyFactory.Domain;

public class EmbalagemInogarnica : Embalagem
{
    public EmbalagemInogarnica() : base(TipoProduto.Inogarnico) { }

    public override List<Embalagem> BuscaEmbalagem()
    {
        return new List<Embalagem>()
        {
            new EmbalagemInogarnica() {Nome = "Embalagem Inogarnica 01"},
            new EmbalagemInogarnica() {Nome = "Embalagem Inogarnica 02"},
            new EmbalagemInogarnica() {Nome = "Embalagem Inogarnica 03"}
        };
    }
}
