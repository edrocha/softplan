using Teste.Aplicacao.Interfaces;
using Teste.CrossCutting.Log;
using Teste.Dominio.Entidades;
using Teste.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Teste.Aplicacao
{
    public class ShowTheCodeAplicacao : IShowTheCodeAplicacao
    {
        public Interfaces.IShowTheCodeAplicacao _ShowTheCodeRepositorio { get; set; }


        public ShowTheCodeAplicacao( IShowTheCodeAplicacao ShowTheCodeRepositorio)
        {
            _ShowTheCodeRepositorio = ShowTheCodeRepositorio;
        }

        public string Obter()
        {
            try
            {
                return _ShowTheCodeRepositorio.Obter();
            }
            catch (Exception ex)
            {
                Logger.Error("ShowthecodeAplicacao", ex);
                throw;
            }
        }
        
    }
}
