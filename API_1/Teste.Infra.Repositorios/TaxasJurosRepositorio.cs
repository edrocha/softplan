using Microsoft.Extensions.Configuration;
using Teste.CrossCutting.Log;
using Teste.Dominio.Entidades;
using Teste.Dominio.Interfaces;
using Teste.Infra.Data;
using System;
using System.Collections.Generic;
using System.Text;


namespace Teste.Infra.Repositorios
{
    public class TaxasJurosRepositorio : ITaxasJuros
    {
        
        IConfiguration _configuration;

        public TaxasJurosRepositorio(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public TaxasJuros Obter()
        {

            try
            {
                var data = new TaxasJurosData(_configuration).ObterJuros();
                return data;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Logger.Error("Contexto/ErroObterJuros", ex);
            }
            return null;
        }

    }
}




