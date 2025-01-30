namespace Datas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", " Setembro", "Outubro", "Novembro", "Dezembro"};

            int[] dias = {  31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

            for (int i = 0; i < meses.Length; i++)
            {
                Console.WriteLine("O mês de " + meses[i] + " tem " + dias[i] + " dias.");
            }

            string[] semana = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };

            foreach(string dia in semana)
            {
                Console.WriteLine(dia);
            }
            

            int[] numeros = { 10, 45, 22, 50, 6, -84, -2, 91, -23};

            Console.WriteLine(numeros.First());
            Console.WriteLine(numeros.Last());
            Console.WriteLine();
            Console.WriteLine(numeros.Max());
            Console.WriteLine(numeros.Min());
            Console.WriteLine(numeros.Average());
            */

            string[] frutas = { "Uva", "Pêra", "Banana", "Morango", "Melancia", "Carambola", "Abacate", "Mamão", "Acabaxi", "Cereja" };
            double[] preços = { 8, 7, 7.50, 11, 23, 12, 10, 5, 17, 9 };

            for (int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine("O preço da " + frutas[i] + " é " + preços[i].ToString("C2") + ".");
            }
            
            Console.WriteLine();
            Console.WriteLine("O maior preço das frutas é: {0}", preços.Max().ToString("C2"));
            Console.WriteLine("O menor preço das frutas é: {0}", preços.Min().ToString("C2"));

            double media = preços.Average();
            Console.WriteLine("A Média dos preços das frutas é: {0}", preços.Average().ToString("C2"));

        }
    }
}
