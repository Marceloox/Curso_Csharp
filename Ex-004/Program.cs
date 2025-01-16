namespace Ex_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12;

            Console.WriteLine("Digite um número:");
            num1 = Convert.ToInt32(Console.ReadLine());

            num2 = 1;
            num3 = 2;
            num4 = 3;
            num5 = 4;
            num6 = 5;
            num7 = 6;
            num8 = 7;
            num9 = 8;
            num10 = 9;
            num11 = 10;

            num12 = num1 * num2;
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num12);
            
            num12 = num1 * num3;
            Console.WriteLine("{0} * {1} = {2}", num1 ,num3,num12);

            num12 = num1 * num4;
            Console.WriteLine("{0} * {1} = {2}", num1 ,num4, num12);

            num12 = num1 * num5;
            Console.WriteLine("{0} * {1} = {2}", num1, num5, num12);

            num12 = num1 * num6;
            Console.WriteLine("{0} * {1} = {2}", num1, num6,num12);

            num12 = num1 * num7;
            Console.WriteLine("{0} * {1} = {2}", num1, num7,num12);

            num12 = num1 * num8;
            Console.WriteLine("{0} * {1} = {2}", num1, num8,num12);

            num12 = num1 * num9;
            Console.WriteLine("{0} * {1} = {2}", num1, num9, num12);    

            num12 = num1 * num10;
            Console.WriteLine("{0} * {1} = {2}", num1, num10, num12);

            num12 = num1 * num11;
            Console.WriteLine("{0} * {1} = {2}", num1, num11, num12);
        }

    }
}
