using AbstractyFactory.Clients;
using AbstractyFactory.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AbstractyFactory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        [HttpGet("comida")]

        public ActionResult BuscaComida([FromQuery] TipoProduto tipoProduto)
        {
            var produtoCliente = ProdutoCliente.CreateProdutoCliente(tipoProduto);

            var comidas = produtoCliente.BuscaComida();
            
            if (comidas == null) 
            {
                return BadRequest();
            }
            
            return Ok(comidas);
        }

        [HttpGet("embalagem")]

        public ActionResult BuscaEmbalagem([FromQuery] TipoProduto tipoProduto) 
        {
            var produtoCliente = ProdutoCliente.CreateProdutoCliente(tipoProduto);

            var embalagem = produtoCliente.BuscaComida();

            if (embalagem == null)
            {
                return BadRequest();
            }
        
            return Ok(embalagem);
        }
    
    }
}
