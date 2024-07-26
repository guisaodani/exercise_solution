internal class Program
{
    private static void Main(string[] args)
    {
        //48.	Crear un algoritmo en C# que me declare una matriz de dimensiones 4x4. El programa me debe llenar la primera fila con números naturales aleatorios entre 1 y 10, luego debe llenar la segunda fila con el triple del número ubicado en su misma posición de columna, pero de la primera fila. Mostrar la matriz de 4x4 en pantalla.

        //primero instanciar la matriz
        int[,] matrix= new int[4, 4];

        //crear objeto Random

        Random randon = new Random();
       
        //llenamos la primera fila de la matriz

        for (int i = 0; i < 4; i++)
        {
            matrix[0, i] = randon.Next(1,11);                                
        }
        for (int i = 0;i<4;i++) 
        {
            matrix[1,i]=randon.Next(1,11);
        }
        for (int i = 0; i < 4; i++)
        {
            matrix[2, i] = randon.Next(1, 11);           
        }
        for (int i = 0; i < 4; i++)
        {
            matrix[3, i] = randon.Next(1, 11);
        }

        //con otros for puedo mostrar la matriz f=fila c=columna
        Console.WriteLine("-----------Matriz 4x4-------------\n");
        for (int f = 0;f<4;f++) 
        {
            for (int c = 0; c < 4; c++)
            
            {
                Console.Write($"{matrix[f, c]}\t");
            }     
            Console.WriteLine();
        }

    }
}