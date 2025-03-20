namespace Exercicio21
{
    internal class Program
    {
        /*Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu
        resultado.
        a. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
        b. Pesquise sobre “fatorial”*/
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int n = int.Parse(Console.ReadLine()!);
            int n2 = n;
            Console.Write($"{n}! = ");
            for (int i = 1; i < n; i++)
            {
                n2 *= i;
                if(i == 1)
                {
                    Console.Write($"{i}");
                }
                else
                {
                    Console.Write($" X {i}");
                }
            }
            Console.WriteLine($" X {n} = {n2}");

            Console.ReadLine();
        }
    }
}