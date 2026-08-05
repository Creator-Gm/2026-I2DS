using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
    /*
    sintaxe:
    enquanto uma condição for verdadeira
            execute um conjunto de comandos
        for --> quando sabemos a quantidede de repetições
        while -> quando a repetição depende de uma condição 
        */
        //laço for: imprimir números de 1 ate 18
        Console.WriteLine("imprimir contagem regressiva ");
        for (int numero = 100; numero <= 0; numero--)
        {
       Console.WriteLine(numero);
        }
        //-----------------------
        int contador = 1;
        while (contador <= 10)
        {
                Console.WriteLine(contador);
                contador++;
        }
        //laço while: solicitar a senha e acertar 
        string senha = "";
        while(senha != "1234")
        {
            Console.Write("digite a senha: ");
            senha = Console.ReadLine();
        }
        Console.WriteLine("Acesso permitido!");
        //---------------------------------------
       int num;
        do
        {
            Console.Write("Digite um numero positivo");
            num = int.Parse(Console.ReadLine());

        } while (num <= 0);





    }
}