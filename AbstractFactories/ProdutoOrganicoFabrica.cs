using AbstractyFactory.Domain;
using AbstractyFactory.Domain.Base;

namespace AbstractyFactory.AbstractFactories;

public class ProdutoOrganicoFabrica : ProductFactory
{
    public override Comida CreateComida()
    {
        return new ComidaOrganica();
    }

    public override Embalagem CreateEmbalagem()
    {
        return new EmbalagemOrganica();
    }
}
