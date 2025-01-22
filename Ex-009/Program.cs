using System.Diagnostics;

namespace Ex_009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;

            Console.WriteLine("*Programa para Testar Triângulos*");
            Console.WriteLine();

            Console.Write("Digite o valor do lado A: ");
            ladoA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado B: ");
            ladoB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado C: ");
            ladoC = Convert.ToInt32(Console.ReadLine());

            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoB))
            {
                Console.WriteLine("Os valore irformados formam um triângulo.");
                if((ladoA == ladoB) && (ladoB == ladoC))
                {
                    Console.WriteLine("E ele é um Triângulo Equilátero.");
                }
                else if((ladoA == ladoB) || (ladoA == ladoC) || (ladoB == ladoC))
                {
                    Console.WriteLine("E ele é um triângulo Isósceles.");
                }
                else
                {
                    Console.WriteLine("E ele é um triângulo Escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Os valores irformados não formam um triângulo.");
            }
        }
    }
}
