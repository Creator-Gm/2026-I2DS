using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //comentario de linha
        /*comentarios de varias linhas
        bloco
        */


        // escrfeve uma linha de texto na tela
        Console.WriteLine("Programaçao Orienta a objetos\n");
                Console.WriteLine("Abstração - 1.º pilar da POO");
  /*criar um classe em C#sswdw 
  a classe deve ser declarada fora dos blocos de programa */
/*cria um objeto a partir de uma classe*/
Pet pet1 = new Pet();
pet1.nome = "Totó";
pet1.tipo = "Cachorro";
pet1.idade = 3;
pet1.MostrarNome();    

Pet pet2 = new Pet();
pet2.nome = "Mingau";
pet2.tipo = "Gato";
pet2.idade = 8;
pet2.MostrarNome();    
}
public class Pet // nome da classe sempre inicia com letras MAIUSCULAS
    {
        //Declaração dos atributos 
public string nome;
public string tipo;
public int idade;
//declaração dos metodos 
public void MostrarNome()
        {
            Console.WriteLine("Meu nome é " + this.nome);
        }
    }
}   