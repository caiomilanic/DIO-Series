using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {   
        //Sendo T um objeto que assumirá o valor de Série
        List<T> Lista();
         T RetornaPorId(int id);
         void Insere(T objeto);
         void Exclui(int id);
         void Atualiza(int id, T objeto);
         int ProximoId();

    }
}