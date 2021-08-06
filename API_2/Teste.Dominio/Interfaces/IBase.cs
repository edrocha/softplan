using System;
using System.Collections.Generic;

namespace Teste.Dominio.Interfaces
{
    public interface IBase<T> where T : class
    {
        string  Obter(decimal valor_inicial, Int32 tempo);
    }
}
