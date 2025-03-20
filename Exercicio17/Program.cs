namespace Exercicio17
{
    internal class Program
    {
        /*Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso
        contrário multiplique A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
        variável C e mostrar seu conteúdo na tela.*/
        static void Main(string[] args)
        {
            Console.Write("Valor A: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Valor B: ");
            int b = int.Parse(Console.ReadLine()!);
            int c;

            if (a == b)
            {
                c = a + b;
            }
            else
            {
                c = a * b;
            }
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}