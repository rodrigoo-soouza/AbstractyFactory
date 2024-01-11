using AbstractyFactory.Domain.Base;

namespace AbstractyFactory.Domain;

public class EmbalagemOrganica : Embalagem
{
    public EmbalagemOrganica() : base(TipoProduto.Organico) { }

    public override List<Embalagem> BuscaEmbalagem()
    {
        return new List<Embalagem>()
        {
            new EmbalagemOrganica() {Nome = "Embalagem Organico 01"},
            new EmbalagemOrganica() {Nome = "Embalagem Organico 02"},
            new EmbalagemOrganica() {Nome = "Embalagem Organico 03"}
        };
    }
}
