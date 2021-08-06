using System.Collections.Generic;
using Teste.Aplicacao.Interfaces;
using Teste.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Teste.Servico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowthecodeController : ControllerBase
    {
        public IShowTheCodeAplicacao  _ShowthecodeAplicacao { get; set; }

        public ShowthecodeController(IShowTheCodeAplicacao ShowthecodeAplicacao)
        {
            _ShowthecodeAplicacao = ShowthecodeAplicacao;
        }
        // GET: api/MarcaEmpresa
        [HttpGet]
        public string Showthecode()
        {
            return _ShowthecodeAplicacao.Obter();
        }


    }
}
