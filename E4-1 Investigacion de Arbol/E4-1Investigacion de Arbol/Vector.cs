using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_1Investigacion_de_Arbol
{
    public class Vector//Clase nodo para cada vertice del arbol
    {
        public string name;//Nombre del nodo
        public Vector[] next;//Uniones a otros nodos
        public Vector(string nombre)//Un constructor donde se le tenga que introducir el nombre del nodo a crear
        {
            name = nombre;
        }
    }
}
