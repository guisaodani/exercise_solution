using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPerimetro
{
    internal class Rectangulo
    {
        public double Side1{ get; set; }
        public double Side2{ get; set; }

        public Rectangulo()
        {
            Console.WriteLine("Ingrese el valor del Lado1:");
            Side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del Lado2:");
            Side1 = Convert.ToDouble(Console.ReadLine());
        }
        public double CalculatePerimeter()
        {
            return ((Side1 * 2) + (Side2 * 2));      
        }
        public double CalculateArea()
        {
            return (Side1 * Side2);
        }
    }
}
