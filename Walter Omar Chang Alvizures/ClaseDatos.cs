using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walter_Omar_Chang_Alvizures
{
    class ClaseDatos
    {
        public string NomFig { get; set; }
        public double bTriangulo { get; set; }//Base del Triangulo  
        public double aTriangulo { get; set; }//Altura del Triangulo
        public double ArTriangulo { get; set; }//Area del Triangulo
        public double bRectangulo { get; set; }//Base del Rectangulo
        public double aRectangulo { get; set; }//Altura del Rectangulo
        public double ArRectangulo { get; set; }//Area del Rectangulo
        public double RadioCir { get; set; }//Radio del Circulo
        public double AreaCir { get; set; }//Area del Circulo

        public virtual void DatosFiguras()
        {
            Console.WriteLine("MOSTRAR LOS DATOS");
        }
    }

    class Triangulo : ClaseDatos
    {
        public override void DatosFiguras()
        {
            Console.WriteLine();
            Console.WriteLine("INGRESE EL NOMBRE DE LA FIGURA");
            base.NomFig = Console.ReadLine();
            Console.WriteLine("INGRESE LOS VALORES DEL RADIO:");
            base.bTriangulo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INGRESE LOS VALORES DE LA ALTURA:");
            base.aTriangulo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INGRESE LOS VALORES DEL AREA:");
            base.ArTriangulo = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Rectangulo : ClaseDatos
    {
        public override void DatosFiguras()
        {
            Console.WriteLine();
            Console.WriteLine("INGRESE EL NOMBRE DE LA FIGURA");
            base.NomFig = Console.ReadLine();
            Console.WriteLine("INGRESE LOS VALORES DEL RADIO:");
            base.bRectangulo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INGRESE LOS VALORES DE LA ALTURA:");
            base.aRectangulo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INGRESE LOS VALORES DEL AREA:");
            base.ArRectangulo = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Circulo : ClaseDatos
    {
        public override void DatosFiguras()
        {
            Console.WriteLine();
            Console.WriteLine("INGRESE EL NOMBRE DE LA FIGURA");
            base.NomFig = Console.ReadLine();
            Console.WriteLine("INGRESE LOS VALORES DEL RADIO:");
            base.RadioCir = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INGRESE LOS VALORES DEL AREA:");
            base.AreaCir = Convert.ToInt16(Console.ReadLine());

        }
    }
}
