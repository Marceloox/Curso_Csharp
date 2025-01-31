namespace Ex_020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Calcule a área do triângulo.");
            Console.WriteLine();

            Console.Write("Digite a base do triângulo (m): ");
            double largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            AreaTriangulo(largura, 5);
        }

        static void AreaTriangulo(double b, double h)
        {
            double a = (b * h) / 2;
            Console.WriteLine($"A área do triângulo é de {b}m x {h}m é de {a:f2}m².");
        }
    }
}
