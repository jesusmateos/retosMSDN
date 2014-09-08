using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto1ClassLibrary
{
    public class Reto1
    {
        /// <summary>
        /// Recibe una lista de personas y que la devuelve ordenada por orden descendente de edad 
        /// (es decir, los recién nacidos aparecerían al final de la lista). 
        /// Si dos personas tienen la misma edad, aparecerán por orden alfabético
        /// </summary>
        /// <returns></returns>
        public static List<Persona> OrdenarLista(List<Persona> listaPersonas)
        {
            if (listaPersonas == null) return null;

            var personasOrdenadas = new List<Persona> (listaPersonas);

            personasOrdenadas.Sort();

            return personasOrdenadas;
        }

    }
}
