namespace Exercicio22
{
    internal class Program
    {
        //Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int n = int.Parse(Console.ReadLine()!);
            int a = 1, b = 1, c = 1;
            Console.Write("0, 1, 1");
            while (true)
            {
                b = c + b;
                c = a;
                if (b >= n)
                {
                    break;
                }
                Console.Write($", {b}");
                a = b;
            }
            Console.ReadLine();
        }
    }
}