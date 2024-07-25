using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPerimetro
{
    internal class Triangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double L1 { get; set; }
        public double L2 { get; set; }

        public Triangulo()
        {
            Console.WriteLine("Ingrese el valor de la Base: ");
            Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la Altura: ");
            Altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la Lado 1: ");
            L1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la Lado 2: ");
            L2 = Convert.ToDouble(Console.ReadLine());
        }
        public double CalcularPerimetro()
        { 
            return Base+L1+L2;       
        }
        public double CalcularArea()
        {
            return Base * Altura/2;
        }

    }
}
