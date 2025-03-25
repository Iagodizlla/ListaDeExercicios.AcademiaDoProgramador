namespace Exercicio09
{
    internal class Program
    {
        /*A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um
        terreno e depois exibir a área do terreno.*/
        static void Main(string[] args)
        {
            Console.Write("Qual o comprimento do terreno(metros): ");
            double comprimento = double.Parse(Console.ReadLine()!);
            Console.Write("Qual a largura do terreno(metros): ");
            double largura = double.Parse(Console.ReadLine()!);

            double area = largura * comprimento;
            Console.WriteLine($"Area do terreno: {area:F2} metros quadrados");
        }
    }
}