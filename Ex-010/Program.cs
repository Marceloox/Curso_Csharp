namespace Ex_010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, aumento;

            Console.Write("Digite seu salário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            if (salario > 2500)
            {
                aumento = (salario * 0.05) + salario;
                
                Console.WriteLine("O aumento será de: {0}", aumento);
            }
            if ((salario > 1250) && (salario < 2501))
            {
                aumento = (salario * 0.1) + salario;

                Console.WriteLine("O aumento será de: {0}", aumento);
            }
            else if (salario <= 1250)
            {
                aumento = (salario * 0.15) + salario;

                Console.WriteLine("O aumento será de: {0}", aumento);
            }
        }
    }
}
