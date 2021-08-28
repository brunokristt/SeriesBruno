using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Series.Interfaces;

namespace Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {

        private List<Serie> listaSerie = new List<Serie>();

        public void Atualiza(int ID, Serie objeto)
        {
            listaSerie[ID] = objeto;
        }

        public void Exclui(int Id)
        {
            if (listaSerie[Id] != null)
            {
                listaSerie[Id].Excluir();
            }

            else
            {
                throw new ArgumentOutOfRangeException("Opção inválida - Nenhuma série cadastrada!");
                Console.WriteLine();
                
            }

        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }

        internal void Atualizar(int indiceSerie, Serie atualizarSerie)
        {
            throw new NotImplementedException();
        }
    }
}
