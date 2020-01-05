using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using APIProdutos.Models;
using APIProdutos.Repository;

namespace APIProdutos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            return ProdutosRepository.Listar();
        }
    }
}