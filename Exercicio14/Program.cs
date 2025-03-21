namespace Exercicio14
{
    internal class Program
    {
        //Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
        static void Main(string[] args)
        {
            Console.Write("Valor 1: ");
            int v1 = int.Parse(Console.ReadLine()!);
            Console.Write("Valor 2: ");
            int v2 = int.Parse(Console.ReadLine()!);
            Console.Write("Valor 3: ");
            int v3 = int.Parse(Console.ReadLine()!);

            int[] v4 = { v1, v2, v3};
            Array.Sort(v4);
            Array.Reverse(v4);

            for (int i = 0; i < v4.Length;i++)
            {
                Console.Write($" {v4[i]}");
            }
            Console.ReadLine();
        }
    }
}