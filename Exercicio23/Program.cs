namespace Exercicio23
{
    internal class Program
    {
        /*Escreva um programa que imprima os números de 1 a 100 em ordem crescente, substituindo os números
        múltiplos de 3 pela palavra &quot;Fizz&quot; e os múltiplos de 5 pela palavra &quot;Buzz&quot;. Para números que são múltiplos de
        ambos, use &quot;FizzBuzz&quot;.*/
        static void Main(string[] args)
        {
            for (int i = 1;i <= 100;i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}