internal class Program
{
    private static void Main(string[] args)
    {
        Ola("cristiano");
                Ola("Maria");
        Ola("Joao");
  Console.WriteLine("A soma de 5 e 3 é: "+ Calcular(5,3,"+"));
        Console.WriteLine("A subtração de 5 e 3 é: " + Calcular(5, 3, "-"));
        Console.WriteLine("[teste com uso de símbolo inválido] A subtração de 5 e 3 é: " + Calcular(5, 3, "#"));
    }
   /* public static void Ola()
    {
        Console.WriteLine("Ola, seja bem vindo");
    }
*/
public static void Ola(string nome)
    {
        Console.WriteLine("ola "+ nome + ", seja bem vindo!!");

    }
 public static double Calcular(double num1, double num2, string operador)
    {
                double resultado=0;
 
        switch (operador)
        {
            case "+": 
                resultado = num1 + num2;
                break;
            case "-": 
                resultado = num1 - num2;
                break;
            case "*": 
                resultado = num1 * num2;
                break;
            case "/": 
                resultado = num1 / num2;
                break;
            default:
                Console.WriteLine("Operador informado não é válido.");
                break;
        }
        return resultado;

    }
}