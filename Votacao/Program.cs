﻿namespace Votacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Em qual ano vc nasceu? ");
            int nasc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(voto(nasc));
        }   

        static string voto(int ano)
        {
            DateTime dataAtual = DateTime.Now;
            int anoAtual = dataAtual.Year;
          /*int mes = dataAtual.Month;
            int dia = dataAtual.Day;
            int hora = dataAtual.Hour;
            int minuto = dataAtual.Minute;
            int segundo = dataAtual.Second;*/
            int idade = anoAtual - ano;

            if (idade < 16)
            {
                return $"Com {idade} ano(s): você não vota.";
            }
            else if (idade >= 18 && idade <= 70)
            {
                return $"Com {idade} ano(s): você vota.";
            }
            else
            {
                return $"Com {idade} ano(s): seu voto é opcional.";
            }
        }
    }
}
