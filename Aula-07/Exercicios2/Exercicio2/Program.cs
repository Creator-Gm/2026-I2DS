internal class Program
{
public class cidade
    {
public int Nome {get;set;}

    }
    private static void Main(string[] args)
    {
        string nome;
      Console.WriteLine("=== TRABALHANDO COM frutas ===");

        // 1 - Iniciar um nova lista
        List<int>valores=[15,25,8,42,15,30];

        // 3 - Percorrer todos os elementos de uma lista     
        foreach (var item in 
        valores)
        {
            Console.WriteLine(item);
        }
         Console.WriteLine("");

        valores.Insert(2,100);
        valores.RemoveAt(valores.Count() - 1);
        valores.RemoveAt(3);
                foreach (var item in 
        valores)
        {
            Console.WriteLine(item);
        }
         Console.WriteLine("");

    }
}