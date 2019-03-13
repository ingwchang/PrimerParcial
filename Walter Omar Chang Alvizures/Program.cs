using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walter_Omar_Chang_Alvizures
{
    class Program
    {
        static void Main(string[] args)
        {
            var Figura1 = new Triangulo();  //Figura1 es Triangulo.
            Figura1.DatosFiguras();
            Console.WriteLine();
            Console.WriteLine("NOMBRE DE LA FIGURA:{0}", Figura1.NomFig);
            Console.WriteLine("EL TAMAÑO DE LA BASE DEL {0} ES DE:{1}",Figura1.NomFig , Figura1.bTriangulo);
            Console.WriteLine("LA ALTURA DEL {0} ES DE:{1}",Figura1.NomFig , Figura1.aTriangulo);
            Console.WriteLine("EL TAMAÑO DEL AREA DE {0} ES DE:{1}",Figura1.NomFig , Figura1.ArTriangulo);

            var Figura2 = new Rectangulo(); //Figura2 es Rectangulo.
            Figura2.DatosFiguras();
            Console.WriteLine();
            Console.WriteLine("NOMBRE DE LA FIGURA:{0}", Figura2.NomFig);
            Console.WriteLine("EL TAMAÑO DE LA BASE DEL {0} ES DE:{1}",Figura2.NomFig , Figura2.bRectangulo);
            Console.WriteLine("LA ALTURA DEL {0} ES DE:{1}",Figura2.NomFig , Figura2.aRectangulo);
            Console.WriteLine("EL TAMAÑO DEL AREA DE {0} ES DE:{1}",Figura2.NomFig , Figura2.ArRectangulo);

            var Figura3 = new Circulo(); //Figura3 es Circulo.
            Figura3.DatosFiguras();
            Console.WriteLine();
            Console.WriteLine("NOMBRE DE LA FIGURA:{0}", Figura3.NomFig);
            Console.WriteLine("EL TAMAÑO DEL RADIO DEL {0} ES DE:{1}",Figura3.NomFig , Figura3.RadioCir);
            Console.WriteLine("EL TAMAÑO DEL AREA DEL {0} ES DE:{1}",Figura3.NomFig , Figura3.AreaCir);
            Console.ReadKey();
        }
    }
}
