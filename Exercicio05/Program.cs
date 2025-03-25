namespace Exercicio05
{
    internal class Program
    {
        /*Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
        vendas.A comissão é calculada com um percentual(informado pelo usuário) sobre o total de vendas.*/
        static void Main(string[] args)
        {
            Console.Write("Salario base: ");
            double SB = double.Parse(Console.ReadLine()!);
            Console.Write("Total de vendas: ");
            double TV = double.Parse(Console.ReadLine()!);
            Console.Write("Percentual da comissao(%): ");
            double PC = double.Parse(Console.ReadLine()!);

            double SF = SB + ((PC / 100) * TV);
            Console.WriteLine($"Salario Final {SF:F2}");
            Console.ReadLine();
        }
    }
}