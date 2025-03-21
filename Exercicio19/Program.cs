namespace Exercicio19
{
    internal class Program
    {
        /*Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e que se
        encontram no conjunto dos números de 1 até 500.*/
        static void Main(string[] args)
        {
            int n = 0;
            for (int i = 1; i < 500; i++)
            {
                if (i % 2 == 1 && i % 3 == 0)
                {
                    n+= i;
                }
            }
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}