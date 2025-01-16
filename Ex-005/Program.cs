namespace Ex_005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;

            Console.WriteLine("Digite um número:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um número:");
            num2 = Convert.ToInt32(Console.ReadLine());

            num3 = num1 + num2;
            num4 = num3 / 2;
            Console.WriteLine("A média é {0}", num4);
        }
    }
}
