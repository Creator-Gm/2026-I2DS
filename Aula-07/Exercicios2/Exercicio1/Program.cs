internal class Program
{
public class cidade
    {
public string? Nome {get;set;}

    }
    private static void Main(string[] args)
    {
        string nome;
      Console.WriteLine("=== TRABALHANDO COM frutas ===");

        // 1 - Iniciar um nova lista
        List<cidade> listaAlunos = new List<cidade>();

        cidade fruta1 = new cidade{ 
         Nome = "iguaraçu"};
        cidade fruta2 = new cidade{ 
            Nome = "barra bonita"};
        cidade fruta3 = new cidade{ 
           Nome = "sao paulo"};
        cidade fruta4 = new cidade{ 
           Nome = "jau"};
        cidade fruta5 = new cidade{Nome = "bahia"};


    listaAlunos.Add(fruta1);
    listaAlunos.Add(fruta2);
    listaAlunos.Add(fruta3);
    listaAlunos.Add(fruta4);
    listaAlunos.Add(fruta5);

        // 3 - Percorrer todos os elementos de uma lista     
        foreach (var item in listaAlunos)
        {
            Console.WriteLine($"{item.Nome}");
        }
    }
}