using AbstractyFactory.AbstractFactories;
using AbstractyFactory.Domain.Base;

namespace AbstractyFactory.Clients;

public class ProdutoCliente
{
    private readonly Comida _comida;
    private readonly Embalagem _ebalagem;

    public ProdutoCliente(ProductFactory productFactory)
    {
        _comida = productFactory.CreateComida();
        _ebalagem = productFactory.CreateEmbalagem();
    }

    public List<Comida> BuscaComida()
    {
        return _comida.BuscaComida();
    }

    public List<Embalagem> BuscaEmbalagem()
    {
        return _ebalagem.BuscaEmbalagem();
    }   
}

