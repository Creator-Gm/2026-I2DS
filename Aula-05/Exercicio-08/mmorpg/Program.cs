internal class Program 
{ 
    private static void Main(string[] args) 
    { 
        Console.WriteLine("adicione seu nome: "); 
        string nomeDigitado = Console.ReadLine(); 
        
        Mago meuMago = new Mago(nomeDigitado, 1, 10, 5.5, 20, 100); 
        
        Console.WriteLine("\nMago Criado com Sucesso!"); 
        Console.WriteLine($"Nome: {meuMago.Nome}"); 
        Console.WriteLine($"Nivel: {meuMago.Nivel}"); 
        Console.WriteLine($"Inteligencia: {meuMago.Inteligencia}"); 
        Console.WriteLine($"Força: {meuMago.Força}"); 
        Console.WriteLine($"Agilidade: {meuMago.Agilidade}"); 
    } 

    public class Mago 
    { 
        public string Nome { get; private set; } 
        public int Nivel { get; private set; } 
        public int Força { get; private set; } 
        public double Agilidade { get; private set; } 
        public int Inteligencia { get; private set; } 
        public int Vida { get; private set; } 

        public Mago(int nivelInicial = 1) 
        { 
            Nivel = nivelInicial; 
        } 

        public Mago(int forçaini = 20) 
        { 
            Força = forçaini; 
        } 

        public Mago(string nome, int nivel, int força, double agilidade, int inteligencia, int vida) 
        { 
            Nome = nome; 
            Nivel = nivel; 
            Força = força; 
            Agilidade = agilidade; 
            Inteligencia = inteligencia; 
            Vida = vida; 
        } 
    } 
}
