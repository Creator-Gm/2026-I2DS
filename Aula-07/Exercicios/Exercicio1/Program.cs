internal class Program
{
     public class cadfruta
    {
        public string? Nome {get;set;}
    }
    private static void Main(string[] args)
    {
        string nome;
      Console.WriteLine("=== TRABALHANDO COM frutas ===");

        // 1 - Iniciar um nova lista
        List<cadfruta> listaAlunos = new List<cadfruta>();

        cadfruta fruta1 = new cadfruta{ 
         Nome = "goiaba"};
        cadfruta fruta2 = new cadfruta{ 
            Nome = "banana"};
        cadfruta fruta3 = new cadfruta{ 
           Nome = "maça"};
        cadfruta fruta4 = new cadfruta{ 
           Nome = "abacaxi"};
        cadfruta fruta5 = new cadfruta{ 
           Nome = "tomate"};
        cadfruta fruta6 = new cadfruta{ 
           Nome = " "};
        // 2 - Incluir elementos em uma lista
        listaAlunos.Add(fruta1);
    listaAlunos.Add(fruta2);
        listaAlunos.Add(fruta3);
            listaAlunos.Add(fruta4);
                listaAlunos.Add(fruta5);
                        listaAlunos.Add(fruta6);

        // 3 - Percorrer todos os elementos de uma lista     
        foreach (var item in listaAlunos)
        {
            Console.WriteLine($"{item.Nome}");
        }
       Console.Write("Digite o sua fruta: ");
         nome = Console.ReadLine();
        // 4 - Alterar um elemento da lista
        Console.WriteLine("");
        listaAlunos[5].Nome = nome;
                foreach (var item in listaAlunos)
        {
            Console.WriteLine($"{item.Nome}");
        }
    }
}