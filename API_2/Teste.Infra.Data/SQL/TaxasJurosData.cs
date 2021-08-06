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
        public virtual string ObterCalculoJuros(decimal valor_inicial, Int32 tempo)
        {
            string json = "";
            try
            {
                List<CalculaJuros> lista = new List<CalculaJuros>();
                TaxasJuros modelTaxas = new TaxasJuros();
                CalculaJuros modelCalc = new CalculaJuros();

                var url = "https://localhost:44324";
                var client = new RestClient(url + "/Api/CalculaJuros");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", json, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

               var Taxa_Resposta = response.Content;
                var objeto = JsonConvert.DeserializeObject<TaxasJuros>(Taxa_Resposta);
                var valor_final = valor_inicial * (1 + objeto.ValorTaxa)*tempo;
                 
                return  valor_final.ToString("###.##");
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
         
