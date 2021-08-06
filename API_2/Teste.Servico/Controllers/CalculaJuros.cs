using System.Collections.Generic;
using Teste.Aplicacao.Interfaces;
using Teste.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Teste.Servico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        public ICalculaJurosAplicacao _CalculaJurosAplicacao { get; set; }

        public CalculaJurosController(ICalculaJurosAplicacao CalculaJurosAplicacao)
        {
            _CalculaJurosAplicacao = CalculaJurosAplicacao;
        }
        // GET: api/MarcaEmpresa
        [HttpGet]
        public string ObterCalculoJuros(decimal valor_inicial, Int32 tempo)
        {
            return _CalculaJurosAplicacao.Obter(valor_inicial, tempo);
        }

       
    }
}
