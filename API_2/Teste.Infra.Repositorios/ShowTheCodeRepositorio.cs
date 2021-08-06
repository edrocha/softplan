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
    public class ShowTheCodeRepositorio  :  IShowTheCode 
    {

        IConfiguration _configuration;

        public ShowTheCodeRepositorio(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string Obter()
        {
            try
            {

                return "https://github.com/edrocha/softplan.git";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Logger.Error("Contexto/Erroshowmethecode", ex);
                return "Erroshowmethecode";
            }

        }

    }
}




