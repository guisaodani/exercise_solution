using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPerimetro
{
    internal class Cuadrado
    {
        //properties
        public double Side { get; set; }


        //methods
        public Cuadrado()
        {
            Console.WriteLine("Ingrese el valor del lado del cuadrado");
            Side = Convert.ToDouble(Console.ReadLine());
           
        }
        public double CalculatePerimeter() 
        {
            return 4*Side;
        }
        public double CalculateArea()
        { 
            return Side*Side;
        
        }


    }
}
