using System.Collections.Generic;
using Teste.Aplicacao.Interfaces;
using Teste.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Teste.Servico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        public ITaxasJurosAplicacao _CalculaJurosAplicacao { get; set; }

        public CalculaJurosController(ITaxasJurosAplicacao CalculaJurosAplicacao)
        {
            _CalculaJurosAplicacao = CalculaJurosAplicacao;
        }
        // GET: api/MarcaEmpresa
        [HttpGet]
        public TaxasJuros ObterCalculoJuros()
        {
            return _CalculaJurosAplicacao.Obter();
        }

       
    }
}
