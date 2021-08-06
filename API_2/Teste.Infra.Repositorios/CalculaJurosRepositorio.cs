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
    public class CalculaJurosRepositorio : ICalculaJuros
    {
        
        IConfiguration _configuration;

        public CalculaJurosRepositorio(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Obter(decimal valor_inicial, Int32 tempo)
        {

            try
            {
                var data = new TaxasJurosData(_configuration).ObterCalculoJuros(valor_inicial, tempo);
                return data;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Logger.Error("Contexto/ErroObterCalculaJuros", ex);
                return "0";
            }
            
        }

    }
}




