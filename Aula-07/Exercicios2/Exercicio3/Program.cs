internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Cardapio ===");
        // Sintaxe Dictonary<chave, valor>
        //                  <key, value>
        
        // 1 - Criar um dicionário vazio
        Dictionary<int, string> Listatelefonica = new Dictionary<int, string>();
        
        // 2 - Adicionar elementos no Listatelefonica
        Listatelefonica.Add(20,"macarrao");
        Listatelefonica.Add(10,"pudim");
        Listatelefonica.Add(100,"carne");
        Listatelefonica.Add(30,"frango");

     
        // 3 - Percorrer todos os elemetos de um Listatelefonica
        Console.WriteLine();
        foreach (var item in Listatelefonica)
        {
            Console.WriteLine($"R${item.Key} - {item.Value}");
        }
               Console.WriteLine();
    }
}