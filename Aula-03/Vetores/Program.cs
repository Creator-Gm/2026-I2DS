internal class Program
{
    private static void Main(string[] args)
    {
     /* vetores 4e matrizes
     vetor => e uma estrutura de dados ultilizando para armazenar 
     varios valores de um mes o tipo dentro de uam unica variavel 
    Sintaxe: tipo [] nome_vetor = new tipo[tamanho];
    
    iniciar um vetor -->lista de frutas 
    */
    string[] listafrutas = {"Maça","manga","morango","melancia","melão"};
        Console.WriteLine("acessar o terceiro elemento de lista: ");
        Console.WriteLine(listafrutas[2]);
               Console.WriteLine("alterar o segundo elemnto da lista: ");
        listafrutas[1] = "Banana";
        foreach (string fruta in listafrutas)
        {
                     Console.WriteLine(fruta); 
        }




    }
}