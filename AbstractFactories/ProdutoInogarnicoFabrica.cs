using AbstractyFactory.Domain;
using AbstractyFactory.Domain.Base;

namespace AbstractyFactory.AbstractFactories
{
    public class ProdutoInogarnicoFabrica : ProductFactory
    {
        public override Comida CreateComida()
        {
            return new ComidaInogarnica();
        }

        public override Embalagem CreateEmbalagem()
        {
            return new EmbalagemInogarnica();
        }
    }
}
