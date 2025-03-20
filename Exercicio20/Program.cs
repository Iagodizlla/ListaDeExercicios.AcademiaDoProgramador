namespace Exercicio20
{
    internal class Program
    {/*Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N. Mostre a
        tabuada na forma:
        ● 0 x N = 0,
        ● 1 x N = 1N,
        ● 2 x N = 2N,
        .
        .
        .
        ● 10 x N = 10N.*/
        static void Main(string[] args)
        {
            Console.Write("Digite o numero: ");
            int n = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Tabuada do {n}\n");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} X {n} = {n*i}");
            }
            Console.ReadLine();
        }
    }
}