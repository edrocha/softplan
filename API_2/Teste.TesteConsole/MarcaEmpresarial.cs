using Teste.Dominio.Entidades;
using Teste.Infra.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Teste.TesteConsole
{
    public class MarcaTeste
    {
        public void Marcas()
        {
            //var list = new List<MarcaEmpresa>();
            //var data = new ClienteData().Obter();

            //var columns = data.Columns.Cast<DataColumn>();

            /*list = data.AsEnumerable().Select(item => new MarcaEmpresa
            {
                Id = Convert.ToInt64(item.Field<object>("ID_MRC")),
                Descricao = item.Field<String>("DC_MRC"),
                CorPrimaria = item.Field<String>("CD_COLOR"),
                DataInclusao = Convert.ToDateTime(item.Field<DateTime>("DT_INC")),
                DataAlteracao = Convert.ToDateTime(item.Field<DateTime?>("DT_ALT")),
                DesconsiderarCortesia = ConversorSimNao(item.Field<string>("IC_DSC_CRT")),
                DesconsiderarSemContasAReceber = ConversorSimNao(item.Field<string>("IC_DSC_OFP_NAO_GER_CTA_REC")),
                DesconsiderTaxaEntrega = ConversorSimNao(item.Field<string>("IC_DSC_TXA_ETG")),
                DesconsiderarGorjeta = ConversorSimNao(item.Field<string>("IC_DSC_GRJ")),
                Facebook = item.Field<string>("NM_FACEBOOK"),
                Instagram = item.Field<string>("NM_INSTAGRAM"),
                Twitter = item.Field<string>("NM_TWITTER"),
                Logo = item.Field<string>("NM_IMG_APP"),

            }).ToList();*/

        }

        public bool ConversorSimNao(string SimNao)
        {
            if (SimNao == "S")  return true;
            else return false;
        }
    }
}
