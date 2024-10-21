using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Nodo
    {
        public int Valor { get; set; }
        public Nodo ValorSiguiente { get; set; }

        public Nodo(int valor)
        {
            Valor = valor;
            ValorSiguiente = null;
        }
    }
}
