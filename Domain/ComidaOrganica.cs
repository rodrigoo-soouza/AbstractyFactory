using AbstractyFactory.Domain.Base;

namespace AbstractyFactory.Domain;

public class ComidaOrganica : Comida
{
    public ComidaOrganica() : base(TipoProduto.Organico) { }
    
    public override List<Comida> BuscaComida()
    {
        return new List<Comida>()
        {
            new ComidaOrganica(){Nome = "Comida Organica 01"},
            new ComidaOrganica(){Nome = "Comida Organica 02"},
            new ComidaOrganica(){Nome = "Comida Organica 03"}
        };
    }
}
