namespace Ex_007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final = 50;
            string resultado;

            if (nota_final >= 60){
                if (nota_final >= 90){
                    resultado = "Aprovado com louvor";
                }
                else{
                    resultado = "aprovado";
                }
            }else {
                if (nota_final >= 40){
                    resultado = "Recuperação";
                }
                else{
                    resultado = "Reprovado";
                }
            }

            Console.WriteLine("O aluno foi {0}.", resultado);   

            
        }
    }
}
