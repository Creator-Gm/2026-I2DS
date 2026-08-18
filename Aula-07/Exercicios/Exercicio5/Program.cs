
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM links ===");

        // 1 - Cria um nova fila vazia pop e para deletar
        Stack<string> historico = new Stack<string>();

        historico.Push("google.com");           // 0
        historico.Push("youtube.com");          // 1
        historico.Push("github.com");          // 2
        historico.Push("microsoft.com");       // 3   
   Console.WriteLine();
        foreach (var pessoa in historico)
        {
            Console.WriteLine(pessoa);
        }
          string pessoaRetirada = "google.com";
        Console.WriteLine();
        Console.WriteLine($"Voce esta no {pessoaRetirada}");

    }
}