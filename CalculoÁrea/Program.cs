namespace CalculoÁrea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Controle de Terrenos.");
            Console.WriteLine();

            Console.Write("Digite a largura do terreno (m): ");
            double largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o comprimento do terreno (m): ");
            double comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            AreaTerreno(largura, comprimento);
        }

        static void AreaTerreno(double l, double c)
        {
            double a = l * c;
            Console.WriteLine($"A área do terreno é de {l}m x {c}m é de {a:f2}m².");
        }
    }
}
