
using Teste.Dominio.Entidades;
using System.Collections.Generic;
using System;

namespace Teste.Aplicacao.Interfaces
{
    public interface ICalculaJurosAplicacao
    {
        string  Obter(decimal valor_inicial, Int32 tempo);
        
    }
}
