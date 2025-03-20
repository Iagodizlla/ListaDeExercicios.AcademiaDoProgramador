namespace Exercicio16
{
    internal class Program
    {
        //Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            double n = int.Parse(Console.ReadLine()!);

            if (n % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
            Console.ReadLine();
        }
    }
}