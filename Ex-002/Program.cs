namespace Ex_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 2;
            float num = 2.35f;
            char letra = 'c';
            string nome = "Marcelo";

            Console.WriteLine("O número é {0}.",numero);
            Console.WriteLine("O valor é R${0}.",num);
            Console.WriteLine("A letra é {0}.",letra);
            Console.WriteLine("Meu nome é {0}.",nome);

            Console.WriteLine("O número é  {0}, o valor é {1}, A letra é ({2}) e o Meu nome é {3}.", numero, num, letra, nome);
        }
    }
}
