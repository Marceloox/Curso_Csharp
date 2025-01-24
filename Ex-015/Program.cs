namespace Ex_015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;

            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                resultado = numero * i;
               Console.WriteLine("{0} x {1} = {2}.", numero, i, resultado);
              
            }
        }
    }
}
