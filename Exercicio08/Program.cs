namespace Exercicio08
{
    internal class Program
    {
        //Crie um programa para verificar se um número é primo.
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int n = int.Parse(Console.ReadLine()!);
            int cont = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    cont++;

                }
            }

            if(cont == 1 || n == 1)
            {
                Console.WriteLine("E um numero primo!");
            }
            else
            {
                Console.WriteLine("Nao e um numero primo!");
            }
            Console.ReadLine();
        }
    }
}