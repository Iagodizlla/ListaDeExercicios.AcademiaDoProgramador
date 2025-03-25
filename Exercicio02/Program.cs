namespace Exercicio02
{
    internal class Program
    {
        //Crie um programa para calcular o volume de um Cilindro
        static void Main(string[] args)
        {
            Console.Write("Qual o raio da base do cilindro: ");
            double raio = double.Parse(Console.ReadLine()!);
            Console.Write("Qual a altura do cilindro:");
            double altura = double.Parse(Console.ReadLine()!);

            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            Console.WriteLine($"Volume do colindro: {volume:F2}");
            Console.ReadLine();
        }
    }
}