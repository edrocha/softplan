using Dapper;
using Microsoft.Extensions.Configuration;
using Teste.CrossCutting.Log;
using Teste.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web.Helpers;

namespace Teste.Infra.Data
{
    public class ShowTheCodeData
    {
        IConfiguration _configuration;

        public ShowTheCodeData(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnection()
        {
            var connection = _configuration.GetSection("ConnectionStrings").
            GetSection("DefaultConnection").Value;
            return connection;
        }
        public virtual string ShowTheCode()
        {
            try { 
            string url = "https://github.com/edrocha//softplan.git";
            return url;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }

        }

        public virtual string showmethecode()
        {
            return "https://github.com/edrocha/softplan.git";
        }

    }
}

