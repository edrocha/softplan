using System.Collections.Generic;

namespace Teste.Dominio.Interfaces
{
    public interface IBase<T> where T : class
    {
        T Obter();
    }
}
