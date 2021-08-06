using Dapper;
using Microsoft.Extensions.Configuration;
using Teste.CrossCutting.Log;
using Teste.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Teste.Infra.Data
{
    public class TaxasJurosData
    {
        IConfiguration _configuration;

        public TaxasJurosData(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnection()
        {
            var connection = _configuration.GetSection("ConnectionStrings").
            GetSection("DefaultConnection").Value;
            return connection;
        }
        public virtual TaxasJuros ObterJuros()
        {
            try
            {
                List<TaxasJuros> lista = new List<TaxasJuros>();
                TaxasJuros model = new TaxasJuros();
                model.ValorTaxa = 0.01m;
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }
    }



}
         
