using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Series.Interfaces;

namespace Series.Interfaces
{
   public interface IRepositorio <T>
    {
        List<T> Lista();

        T RetornaPorId(int id);

        void Insere(T entidade);

        void Exclui(int Id);

        void Atualiza(int ID, T entidade);

        int ProximoId();
    }
}
