using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_1Investigacion_de_Arbol
{
    public class Arbol
    {
        //Cordenadas para la impresion
        int x = 0, y = 2;

        public void Add(Vector nodo, string nombre, string[] nombres)//Aqui añadimos uniones a lo que serian las hojas del arbol para convertirlas en ramas
        {//Le ingresamos el nodo raiz, nombre del nodo que buscamos y los nombres de las uniones que vamos a crear en ese nodo(uno por nodo)
            if (nodo.next != null)//Si el nodo no es nulo
            {
                foreach (Vector item in nodo.next)//Por cada nodo union dentro del nodo original
                {
                    Add(item, nombre, nombres);//Aplicamos recursividad del mismo metodo
                }
            }
            else//Si no tienen uniones
            {
                if (nodo.name == nombre)//Checamos si es el nombre que buscamos y si lo es
                {
                    nodo.next = new Vector[nombres.Length];//Creamos las uniones equivalente al numero de nombres que ingresamos
                    for (int i = 0; i < nombres.Length; i++)
                    {
                        nodo.next[i] = new Vector(nombres[i]);//Y les creamos los nodos a las uniones con su nombre
                    }
                }
            }
        }

        public void Print(Vector nodo)//Imprime el digrama de todas las uniones
        {
            if (nodo.next != null)//Si no es nulo
            {
                Console.SetCursorPosition(x, y);//colocamos el cursor en las cordenada x,y
                Console.Write(nodo.name);//Y escribimos el nombre de la rama
                x = x + 5;//Como sabemos que es una rama pues la diferenciamos un un cambio de posicion en x y sumamos uno en y
                ++y;
                for (int i = 0; i < nodo.next.Length; i++)//Por cada union vamos a llamar el mismo metodo para asi llegar a todas partes del diagrama
                {
                    Print(nodo.next[i]);
                }
                x = x - 5;
            }
            else//Si no es nulo significa que llegamos a una hoja y ya no hay a donde ir
            {
                Console.SetCursorPosition(x, y);//Colocamos de nuevo el cursor en las cordenadas que llevamos
                Console.Write(nodo.name);//Escribimos el nombre de la hoja
                ++y;//Y agregamos una posicion en y
            }
        }
    }
}
