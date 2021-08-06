using Teste.Aplicacao.Interfaces;
using Teste.CrossCutting.Log;
using Teste.Dominio.Entidades;
using Teste.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Teste.Aplicacao
{
    public class TaxasJurosAplicacao : ITaxasJurosAplicacao
    {
        public ITaxasJuros _CalculaJurosRepositorio { get; set; }


        public TaxasJurosAplicacao(ITaxasJuros ICalculaJurosRepositorio)
        {
            _CalculaJurosRepositorio = ICalculaJurosRepositorio;
        }

        public  TaxasJuros  Obter()
        {
            try
            {
                return _CalculaJurosRepositorio.Obter();
            }
            catch (Exception ex)
            {
                Logger.Error("CalculaJurosAplicacao", ex);
                throw;
            }
        }
        
    }
}
