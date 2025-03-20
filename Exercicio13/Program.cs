namespace Exercicio13
{
    internal class Program
    {
        //Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
        static void Main(string[] args)
        {
            Console.Write("Valor A: ");
            double A = double.Parse(Console.ReadLine()!);
            Console.Write("Valor B: ");
            double B = double.Parse(Console.ReadLine()!);
            Console.Write("Valor C: ");
            double C = double.Parse(Console.ReadLine()!);

            if(A+B > C)
            {
                Console.WriteLine("A + B e maior que C");
            }
            else
            {
                Console.WriteLine("A + B nao e maior que C");
            }
            Console.ReadLine();
        }
    }
}