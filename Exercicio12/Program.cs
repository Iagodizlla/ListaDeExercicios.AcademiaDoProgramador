namespace Exercicio12
{
    internal class Program
    {
        /*Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
        impostos. Imprima o salário inicial, o salário com o aumento e o salário final.*/
        static void Main(string[] args)
        {
            Console.Write("Qual o salario? ");
            double sa = double.Parse(Console.ReadLine()!);

            double au = sa * 1.15;
            double de = au * 0.92;

            Console.WriteLine("---------------");
            Console.WriteLine($"Salario inicial: {sa}");
            Console.WriteLine($"Salario com aumento: {au:F2}");
            Console.WriteLine($"Salario final: {de:F2}");
            Console.ReadLine();
        }
    }
}