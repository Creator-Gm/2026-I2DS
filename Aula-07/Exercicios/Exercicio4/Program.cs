internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM FILAS (FIFO) ===");

        // 1 - Cria um nova fila vazia
        Queue<string> filadeatendimento = new Queue<string>();

        filadeatendimento.Enqueue("João");           // 0
        filadeatendimento.Enqueue("Maria");          // 1
        filadeatendimento.Enqueue("Carlos");          // 2
        filadeatendimento.Enqueue("Ana");       // 3   
          filadeatendimento.Enqueue("Pedro");  
        Console.WriteLine();
        foreach (var pessoa in filadeatendimento)
        {
            Console.WriteLine(pessoa);
        }
        string ando = "João";
        bool atendimento = filadeatendimento.Contains(ando);
        Console.WriteLine();
        if (atendimento)
        {
            Console.WriteLine($"{ando} esta sendo atendido");
        }
        else
        {
            Console.WriteLine($"{ando} NÃO está na fila!");
        }
        // 4 - Retirar um elemento da lista
        string pessoaRetirada = filadeatendimento.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"O {pessoaRetirada}foi atendido");

        Console.WriteLine();
        foreach (var pessoa in filadeatendimento)
        {
            Console.WriteLine(pessoa);
        }
         string nome;
         Console.Write("adcione um novo cliente: ");
         nome = Console.ReadLine();
              filadeatendimento.Enqueue(nome);
        Console.WriteLine();
        foreach (var pessoa in filadeatendimento)
        {
            Console.WriteLine(pessoa);
        }
    }
}