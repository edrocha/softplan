using Teste.Aplicacao.Interfaces;
using Teste.CrossCutting.Log;
using Teste.Dominio.Entidades;
using Teste.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Teste.Aplicacao
{
    public class CalculaJurosAplicacao : ICalculaJurosAplicacao
    {
        public ICalculaJuros _CalculaJurosRepositorio { get; set; }


        public CalculaJurosAplicacao(ICalculaJuros ICalculaJurosRepositorio)
        {
            _CalculaJurosRepositorio = ICalculaJurosRepositorio;
        }

        public string Obter(decimal valor_inicial, Int32 tempo)
        {
            try
            {
                return _CalculaJurosRepositorio.Obter(valor_inicial, tempo);
            }
            catch (Exception ex)
            {
                Logger.Error("CalculaJurosAplicacao", ex);
                throw;
            }
        }

      
    }
}
