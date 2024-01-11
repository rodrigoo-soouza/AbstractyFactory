using AbstractyFactory.Domain.Base;

namespace AbstractyFactory.Domain;

public class ComidaInogarnica :Comida
{
    public ComidaInogarnica() : base(TipoProduto.Inogarnico) { }
    
    public override List<Comida> BuscaComida()
    {
        return new List<Comida>()
        {
            new ComidaInogarnica() {Nome = "Comida Inogarnica 01"},
            new ComidaInogarnica() {Nome = "Comida Inogarnica 02"},
            new ComidaInogarnica() {Nome = "Comida Inogarnica 03"}
        };
    }
        
    
}
