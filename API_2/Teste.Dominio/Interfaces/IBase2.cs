using System;
using System.Collections.Generic;

namespace Teste.Dominio.Interfaces
{
    public interface IBase2<T> where T : class
    {
        string  Obter();
    }
}
