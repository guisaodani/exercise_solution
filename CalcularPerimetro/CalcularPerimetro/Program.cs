using CalcularPerimetro;

internal class Program
{
    private static void Main(string[] args)
    {
        //4.	Realizar un algoritmo con C# donde me permita calcular el perímetro/circunferencia y área de las siguientes figuras geométricas: cuadrado, rectángulo, triángulo y círculo. Mostrar en pantalla los valores calculados por cada figura geométrica.

        Console.WriteLine("*********************************************");
        Console.WriteLine("*****QUE TIPO DE FIGURA DESEA CONSULTAR:*****");
        Console.WriteLine("*********************************************");
        Console.WriteLine("1. Para un Cuadrado--------------------------");
        Console.WriteLine("2. Para un Rectangulo------------------------");
        Console.WriteLine("*********************************************");

        double Option = Convert.ToDouble(Console.ReadLine());

        switch (Option)
        {
            case 1:
               Cuadrado cuadrado = new Cuadrado();
               Console.WriteLine($"Perimetro del cuadrado {cuadrado.CalculatePerimeter()}");
               Console.WriteLine($"Area del Cuadradro {cuadrado.CalculateArea()}");
                break;

            case 2:
                Rectangulo rectangulo = new Rectangulo();
                Console.WriteLine($"Perimetro del Rectangulo {rectangulo.CalculatePerimeter()}");
                Console.WriteLine($"Area del Rectangulo {rectangulo.CalculateArea()}");

                break;
        }                    
    }
}