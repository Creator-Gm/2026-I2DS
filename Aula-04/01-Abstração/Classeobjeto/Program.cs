using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        classe -> e a abstração de um de objeto do mundo real 
        para o mundo computacional. 
        Objeto ->ea instacia de uma classe
        */

        // Instanciar um objeto do tipo Aluno 
        Aluno aluno01 = new Aluno();
        Aluno aluno02 = new Aluno();

        aluno01.Nome = "Jose da Silva";
        aluno01.RM = 2444;
        aluno01.DataNascimento = new DateOnly(2010,01,15);

        aluno02.Nome = "Jose do Santos";
        aluno02.RM = 1234;
        aluno02.DataNascimento = new DateOnly(2014,01,15);
        //Declaração de uma Classe 
        
        //executar os metodos
        aluno01.ApresentarSe();
        aluno02.ApresentarSe();
    }
public class Aluno // declaração de uma classe
    {
        //Atributos -> caracteristicas 
        public string Nome {get; set; }
        public int RM {get; set;}
        public DateOnly DataNascimento {get; set;}

        //Metodos -> a açãoes ou funncionalidades
public void ApresentarSe()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, meu RM é {RM}, eu nasci em {DataNascimento} ");
        }

        
    }
}