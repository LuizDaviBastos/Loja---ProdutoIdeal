using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProdutoIdeal.Dominio.Contratos;
using ProdutoIdeal.Dominio.Entidades;
using ProdutoIdeal.Repositorio.Repositorios;

namespace ProdutoIdeal.Web.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            this._usuarioRepositorio = usuarioRepositorio;
        }
        
        [HttpGet]
        public IEnumerable<string> Get()
        {
            throw new Exception();
            
        }


        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        [HttpPost("VerificaUsuario")]
        public IActionResult VerificaUsuario([FromBody] Usuario usuario)
        {
            try
            {
                Usuario resultUsuario = _usuarioRepositorio.Obter(usuario.Email, usuario.Senha);

                if(resultUsuario != null)
                {
                    return Ok(resultUsuario);
                }

                else return BadRequest(new { msg = "E-mail ou senha inválido" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }


        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
