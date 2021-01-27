using System;

namespace LaberintoRecursividad
{
    class Program
    {
        static int Recursividad(int[,] laberinto, int i, int j)
        {
            if ((i - 1) <= 7 && (i - 1) >= 0 && laberinto[i - 1, j] == 0) //arriba
            {

                laberinto[i - 1, j] = 9;
                return Recursividad(laberinto, i - 1, j);
            }
           
            if ( j-1 >= 0&&laberinto[i, j-1] == 0)//izquierda
            {
                
                laberinto[i, j - 1] = 9;
                return Recursividad(laberinto, i, j - 1);
            }
            if ((j + 1) <= 7 && (j + 1) >= 0 && laberinto[i, j + 1] == 0)//derecha
            {
                laberinto[i, j + 1] = 9;
                return Recursividad(laberinto, i, j + 1);
            }
            if (i + 1 <= 7 && laberinto[i + 1, j] == 0)//abajo
            {
                Console.WriteLine("No1");
                Console.ForegroundColor = ConsoleColor.Magenta;
                laberinto[i + 1, j] = 9;
                Console.ResetColor();
                return Recursividad(laberinto, i + 1, j);
            }
            if (i==2&&j==7)
            {
                return 0;
            }
            else 
            { 
                return 1; 
            }
            
        }
        static void Imprimir(int[,] laberinto)
        {
            for (int i = 0; i < Math.Sqrt(laberinto.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(laberinto.Length); j++)
                {
                    if (i == 7 && j == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(laberinto[i, j] + " ");
                        Console.ResetColor();
                    }
                    else if (laberinto[i, j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(laberinto[i, j] + " ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(laberinto[i, j] + " ");
                        Console.ResetColor();
                    }

                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int ing=8;
            int[,] laberinto;
            Console.WriteLine("La matriz del laberinto es de 8*8");
            Console.WriteLine("Los digitos 1 de color verde son las paredes del laberinto");
            Console.WriteLine("Los digitos 0 de color azul son los posibles caminos del laberinto");
            Console.WriteLine("El color rojo es donde comienza el laberinto");
            laberinto = new int[ing, ing];
            for (int i = 0; i < ing; i++)
            {
                for (int j = 0; j < ing; j++)
                {
                    if ((i == 1 && (j == 7 || j == 6 || j == 5)) || ((i == 2 || i == 3) && j == 5) || (i == 4 && (j == 1 || j == 2 || j == 3 || j == 4 || j == 5)) || ((i == 5 || i == 6) && j == 4) || ((i == 5 || i == 6 || i == 7) && j == 2))
                        laberinto[i, j] = 0;
                    else
                        laberinto[i, j] = 1;
                }
            }
            Imprimir(laberinto);
            Recursividad(laberinto, 7, 2);
            Imprimir(laberinto);
        }
    }
}
