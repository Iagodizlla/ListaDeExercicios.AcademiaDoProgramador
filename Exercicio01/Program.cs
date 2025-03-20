namespace Exercicio01
{
    internal class Program
    {
        //Crie um programa para calcular o volume de uma caixa retangular
        static void Main(string[] args)
        {
            Console.Write("Qual a altura da caixa: ");
            double altura = double.Parse(Console.ReadLine()!);
            Console.Write("Qual a largura da caixa: ");
            double largura = double.Parse(Console.ReadLine()!);
            Console.Write("Qual o comprimento da caixa: ");
            double comprimento = double.Parse(Console.ReadLine()!);

            double volume = altura * largura * comprimento;
            Console.WriteLine($"Volume: {volume}(cm cubinos)");
            Console.ReadLine();
        }
    }
}