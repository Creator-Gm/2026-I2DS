internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== fila ===");

        // 1 - Cria um nova fila vazia
        Queue<string> filaBanco = new Queue<string>();

        // 2 - Adicionar elementos na fila
        filaBanco.Enqueue("Zuleika");           // 0
        filaBanco.Enqueue("Asdrúbal");          // 1
        filaBanco.Enqueue("Pafúncio");          // 2
        filaBanco.Enqueue("Epaminondas");       // 3   

        // 3 - Percorrer elementos de uma fila
        Console.WriteLine();
        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        // 4 - Retirar um elemento da lista
        string pessoaRetirada = filaBanco.Dequeue();
                string pessoaRetirada2 = filaBanco.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"O Nome chamado foi: {pessoaRetirada}");
        Console.WriteLine();
        Console.WriteLine($"O Nome chamado foi: {pessoaRetirada2}");
        Console.WriteLine();
        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }


    }
}