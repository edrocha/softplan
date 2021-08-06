using Teste.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Teste.Infra.Data;

namespace Teste.TesteConsole
{
    public class UnidadeTeste
    {
       /* public void Unidades()
        {
            var list = new List<Unidade>();
            //var data = new UnidadeData().Obter();

            var columns = data.Columns.Cast<DataColumn>();


            list = data.AsEnumerable().Select(item => new Unidade()
            {
                Id = Convert.ToInt64(item.Field<int>("ID_ETB")),
                Nome = item.Field<string>("NOMEREDUZIDO"),
                Sigla = item.Field<string>("SIGLA"),
                Cnpj = item.Field<long>("CNPJ").ToString(),
                MarcaId = Convert.ToInt64(item.Field<decimal>("ID_MRC")),
                DataInclusao = Convert.ToDateTime(item.Field<DateTime>("DATACRIACAO"))
            }).ToList();


            var aaaa = data.Columns.Cast<DataColumn>();

        }*/

        public bool ConversorSimNao(string SimNao)
        {
            if (SimNao == "S") return true;
            else return false;
        }
    }
}
