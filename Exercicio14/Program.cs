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

            if (v1 > v2 && v1 > v3)
            {
                if(v2 > v3)
                {
                    Console.WriteLine($"{v3}, {v2}, {v1}");
                }
                else
                {
                    Console.WriteLine($"{v2}, {v3}, {v1}");
                }
            }
            else if (v2 > v1 && v2 > v3)
            {
                if (v1 > v3)
                {
                    Console.WriteLine($"{v3}, {v1}, {v2}");
                }
                else
                {
                    Console.WriteLine($"{v1}, {v3}, {v2}");
                }
            }
            else
            {
                if( v1 > v2)
                {
                    Console.WriteLine($"{v2}, {v1}, {v3}");
                }
                else
                {
                    Console.WriteLine($"{v1}, {v2}, {v3}");
                }
            }
            Console.ReadLine();
        }
    }
}