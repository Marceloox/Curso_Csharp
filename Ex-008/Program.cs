namespace Ex_008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string resultado;

            numero = Convert.ToInt32(Console.ReadLine());

            if(numero % 2 == 0)
            {
                resultado = "Par";
            }
            else
            {
                resultado = "ímpar";
            }

            Console.WriteLine("O número é {0}", resultado);
        }
    }
}
