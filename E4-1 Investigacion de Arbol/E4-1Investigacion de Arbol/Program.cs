using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_1Investigacion_de_Arbol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diagrama de la compañia de Coca Cola");

            Vector empresa = new Vector("Presidente");//Creamos nuestro nodo raiz llamado empresa

            Arbol Instancia = new Arbol();//Instanciamos nuestra clase TreeDiagrams

            //Colocamos el nodo raiz, nombre del nodo que buscamos y los nombres de los nodos que vamos a agregar en forma de array
            Instancia.Add(empresa, "Presidente", new string[] { "Vicepresidente General" });

            //Y repetimos hasta que quede el diagrama como quedamos
            Instancia.Add(empresa, "Vicepresidente General", new string[]
            { "Vicepresidente Marketing","Vicepresidente Produccion","Vicepresidente Financiero" });
            Instancia.Add(empresa, "Vicepresidente Marketing", new string[]
            { "Gerente de Ventas","Gerente de Publicidad","Gerente de Segmentacion del mercado" });
            Instancia.Add(empresa, "Vicepresidente Produccion", new string[]
            { "Gerente de Ingenieria", "Gerente de Industrial", "Gerente de Control de Calidad" });
            Instancia.Add(empresa, "Gerente de Ingenieria", new string[]
            { "Jefe de Mantenimiento Mecanico", "Jefe de Recursos e Insumos", "Supervisor de Laboratorio" });
            Instancia.Add(empresa, "Gerente de Industrial", new string[]
            {"Supervisor de Procesos" });
            Instancia.Add(empresa, "Gerente de Control de Calidad", new string[]
            {"Supervisor de Calidad" });
            Instancia.Add(empresa, "Supervisor de Calidad", new string[]
            {"Tecnicos","Catadores" });
            Instancia.Add(empresa, "Vicepresidente Financiero", new string[]
            {"Gerente de Contabilidad","Gerente de Tesoreria" });

            //Luego nadamas imprimimos el diagrama a partir del nodo raiz empresa
            Instancia.Print(empresa);
            Console.ReadKey();
        }
    }
}
