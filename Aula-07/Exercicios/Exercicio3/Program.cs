internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM DICIONARIOS ===");
        // Sintaxe Dictonary<chave, valor>
        //                  <key, value>
        
        // 1 - Criar um dicionário vazio
        Dictionary<string, string> Listatelefonica = new Dictionary<string, string>();
        
        // 2 - Adicionar elementos no Listatelefonica
        Listatelefonica.Add("jerson","jerson (11)9999-999");
        Listatelefonica.Add("jerson2","jerson2 (11)9995-999");
        Listatelefonica.Add("jerson3","jerson3 (11)9949-999");
        Listatelefonica.Add("jerson4","jerson4 (11)9996-999");

     
        // 3 - Percorrer todos os elemetos de um Listatelefonica
        Console.WriteLine();
        foreach (var item in Listatelefonica)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
       Listatelefonica.Add("jerson5","(11)000-0000");
               Console.WriteLine();
        foreach (var item in Listatelefonica)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
        // 4 - Alterar um elemento do Listatelefonica
        Listatelefonica["jerson"] = "jerson (11)4956-4444";
        Console.WriteLine();
        foreach (var item in Listatelefonica)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        string nome;
         Console.Write("Digite o nome do seu contato: ");
         nome = Console.ReadLine();
        string termo;
        bool chaveExiste = Listatelefonica.TryGetValue(nome, out termo);
        Console.WriteLine();
        if (chaveExiste)
        {
            Console.WriteLine($"O nome possui contato foi encontrada: {termo}");
        }
        else
        {
            Console.WriteLine("Esse nome não foi encontrada na lista");
        }
                Listatelefonica.Remove("jerson");
        Console.WriteLine();
        foreach (var item in Listatelefonica)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}