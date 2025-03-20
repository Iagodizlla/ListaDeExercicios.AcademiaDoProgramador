namespace Exercicio07
{
    internal class Program
    {
        //Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a nota do aluno e seu peso?");
            double n1 = double.Parse(Console.ReadLine()!);
            int p1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Qual a segunda nota do aluno e seu peso?");
            double n2 = double.Parse(Console.ReadLine()!);
            int p2 = int.Parse(Console.ReadLine()!);

            double MP = (p1 * n1 + p2 * n2) / p1 + p2;
            Console.WriteLine($"Media Ponderada: {MP}");
            Console.ReadLine();
        }
    }
}