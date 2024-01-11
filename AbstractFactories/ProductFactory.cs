using AbstractyFactory.Domain.Base;

namespace AbstractyFactory.AbstractFactories;

public abstract class ProductFactory
{
    public abstract Comida CreateComida();
    public abstract Embalagem CreateEmbalagem();
}
