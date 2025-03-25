namespace Exercicio06
{
    internal class Program
    {
        //Crie um programa para calcular a média harmônica das notas de um Aluno
        static void Main(string[] args)
        {
            double[] nota = new double[99];
            double nota2 = 0;

            Console.Write("Quantas notas sao: ");
            double qn = double.Parse(Console.ReadLine()!);

            for (int i = 0;i < qn;i++)
            {
                Console.Write("Qual a nota do aluno: ");
                nota[i] = double.Parse(Console.ReadLine()!);
                nota2 += 1 / nota[i];
            }

            double MH = 4 / nota2;
            Console.WriteLine($"Media Harmonica: {MH:F2}");
            Console.ReadLine();
        }
    }
}