internal class Program
{
    public class Aluno
    {
        public string? Nome {get; set;}
        public string? Idade {get; set;}
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM LISTAS ===");

        // 1 - Iniciar um nova lista
        List<Aluno> listaAlunos = new List<Aluno>();

        Aluno aluno1 = new Aluno{ 
          Nome = "Zuleika",Idade = "12"};
        Aluno Pafúncio = new Aluno{ 
            Nome = "Pafúncio",Idade = "25"};
        Aluno aluno3 = new Aluno{ 
            Nome = "Asdrúbal",Idade = "85"};
        Aluno aluno4 = new Aluno{ 
          Nome = "Pazuzu",Idade = "52"};
        Aluno aluno5 = new Aluno{ 
            Nome = "Úncio",Idade = "34"};

        // 2 - Incluir elementos em uma lista
        listaAlunos.Add(aluno1);
        listaAlunos.Add(Pafúncio); 
        listaAlunos.Add(aluno3);
        listaAlunos.Add(aluno4);
        listaAlunos.Add(aluno5); 

        // 3 - Percorrer todos os elementos de uma lista     
        foreach (var item in listaAlunos)
        {
            Console.WriteLine($"{item.Nome} - {item.Idade}");
        }

        // 4 - Alterar um elemento da lista
        listaAlunos[1].Idade = "55";
        
        Console.WriteLine();
        foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Idade}");
        }
        // 7 - Remover um elemento da lista por objeto 
        listaAlunos.Remove(Pafúncio);
        Console.WriteLine();
        foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Idade}");
        }
      

    }}