using AbstractyFactory.AbstractFactories;
using AbstractyFactory.Domain;
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

    public static ProdutoCliente CreateProdutoCliente(TipoProduto tipo)
    {
        switch (tipo)
        {
            case TipoProduto.Organico:
                return new ProdutoCliente(new ProdutoOrganicoFabrica());
            case TipoProduto.Inogarnico:
                return new ProdutoCliente(new ProdutoInogarnicoFabrica());
            default:
                throw new Exception("Not found");
        }
    }   
}

