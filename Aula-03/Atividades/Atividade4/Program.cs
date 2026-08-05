using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite o valor: ");
        int valor = int.Parse(Console.ReadLine());

        int i = 0;
        int notas100 = 0, notas50 = 0, notas20 = 0, notas10 = 0, notas5 = 0, notas2 = 0, notas1 = 0;

        while (i < valor)
        {
            int colocar = valor - i;

            if (colocar >= 100)
            {
                i += 100;
                notas100++;
            }
            else if (colocar >= 50)
            {
                i += 50;
                notas50++;
            }
            else if (colocar >= 20)
            {
                i += 20;
                notas20++;
            }
            else if (colocar >= 10)
            {
                i += 10;
                notas10++;
            }
            else if (colocar >= 5)
            {
                i += 5;
                notas5++;
            }
            else if (colocar >= 2)
            {
                i += 2;
                notas2++;
            }
            else if (colocar >= 1)
            {
                i += 1;
                notas1++;
            }
            else
            {
                break;
            }
        }

        
    Console.WriteLine();
        Console.Write("Notas de 100: ");
        Console.WriteLine(notas100);
        Console.Write("Notas de 50: ");
        Console.WriteLine(notas50);
        Console.Write("Notas de 20: ");
        Console.WriteLine(notas20);
        Console.Write("Notas de 10: ");
        Console.WriteLine(notas10);
        Console.Write("Notas de 5: ");
        Console.WriteLine(notas5);
        Console.Write("Notas de 2: ");
        Console.WriteLine(notas2);
        Console.Write("Notas de 1: ");
        Console.WriteLine(notas1);
    }
}
