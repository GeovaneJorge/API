using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController :ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult obterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };
            return Ok(obj);
        }

        [HttpGet("Apresentar/{texto}")]
        public IActionResult Apresentar(string texto)
        {
            var mensagem = $"Olá, {texto} seja bem vindo! ";
            return Ok(new {texto});
        }
    }
}