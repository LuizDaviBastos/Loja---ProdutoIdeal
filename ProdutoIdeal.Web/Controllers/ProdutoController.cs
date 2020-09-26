using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProdutoIdeal.Dominio.Contratos;
using ProdutoIdeal.Dominio.Entidades;

namespace ProdutoIdeal.Web.Controllers
{
    [Route("api/[Controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            try
            {
                var list = _produtoRepositorio.BuscarTodos();
                return list.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IActionResult Post([FromBody]Produto produto)
        {
            try
            {
                _produtoRepositorio.Adicionar(produto);
                return Created("api/[Controller]",produto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
