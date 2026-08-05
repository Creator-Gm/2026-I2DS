internal class Program
{
    private static void Main(string[] args)
    {
        string nome;
        int num1;
        int num2;
        int num3;
    
   Console.Write("Digite o seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Digite o Primeira Nota: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o Segunda Nota: ");
        num2 = int.Parse(Console.ReadLine());
        
        Console.Write("Digite o terceira Nota: ");
        num3 = int.Parse(Console.ReadLine());


Console.WriteLine("Aluno: "+ nome);
Console.WriteLine("A media é "+ (num1 + num2 + num3) / 3);
        int nota = (num1 + num2 + num3) / 3;

        if(nota >= 7)
        {
            Console.WriteLine("Aprovado");
        }
        else if(nota >= 5 )
        {
            Console.WriteLine("Recuperação");
        }
        else
        {
                    Console.WriteLine("Reprovado");
        }

    }
}