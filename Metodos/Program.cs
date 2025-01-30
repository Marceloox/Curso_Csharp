namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saudacao("Marcelo"); // Olá Marcelo, seja bem-vindo!
            soma(30, 50); // A soma de 10 + 20 é igual a 30
        }

        // Método Saudacao
        static void Saudacao(string nome)
        {
            // Exibe uma mensagem de saudação
            Console.WriteLine($"Olá {nome}, seja bem-vindo!");// Olá Marcelo, seja bem-vindo!
        }
        // Método soma
        static void soma(int a, int b)
        {
            // Exibe a soma de dois números
            int resultado = a + b;
            Console.WriteLine($"A soma de {a} + {b} é igual a {resultado}");
            Console.WriteLine("A soma de {0} + {1} é igual a {3}", a, b, resultado);
            Console.WriteLine("A soma de " + a + " + " + b + " é igual a " + resultado);
        }
    }        
}
