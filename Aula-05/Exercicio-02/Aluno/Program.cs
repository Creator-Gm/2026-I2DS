internal class Program
{
    private static void Main(string[] args)
    {
        // primeiro aluno
        Livro aluno1 = new Livro();
        aluno1.nome = "Digo";
        aluno1.Email = "mendigo@gmail.com";
        aluno1.RM = 4445;
        aluno1.Nascimento = new DateOnly(2010,04,03);
        // segundo livro
        Livro aluno2 = new Livro();
        aluno2.nome = "Harry Potter";
        aluno2.Email = "pedra@gmail.com";
        aluno2.RM = 4566;
        aluno2.Nascimento = new DateOnly(2010,05,03);

        // terceiro livro
        Livro aluno3 = new Livro();
        aluno3.nome = "Dom Casmurro";
        aluno3.Email = "murro@gmail.com";
        aluno3.RM = 4467;
        aluno3.Nascimento = new DateOnly(2010,03,03);

        // exibindo os livros na tela
        Console.WriteLine("\n==== LIVROS ====");
        Console.WriteLine($"\n aluno 01: {aluno1.nome} | Email: {aluno1.Email} | RM: {aluno1.RM} | Nascimento: {aluno1.Nascimento}");
        Console.WriteLine($"\n aluno 02: {aluno2.nome} | Email: {aluno2.Email} | RM: {aluno2.RM} | Nascimento: {aluno2.Nascimento}");
        Console.WriteLine($"\n aluno 03: {aluno3.nome} | Email: {aluno3.Email} | RM: {aluno3.RM} | Nascimento: {aluno3.Nascimento}");
    }

    public class Livro
    {
        public string nome { get; set; }

        public string Email { get; set; }

        public int RM { get; set; }

        public DateOnly Nascimento { get; set; }
    }
}