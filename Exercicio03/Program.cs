namespace Exercicio03
{
    internal class Program
    {
        /*Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem. O
        programa deve solicitar ao usuário:
        ● A quilometragem inicial do veículo no início da viagem.
        ● A quilometragem final ao término da viagem.
        ● A quantidade de combustível consumida durante a viagem (em litros).*/
        static void Main(string[] args)
        {
            Console.Write("Qual o km inicial: ");
            double kmI = double.Parse(Console.ReadLine()!);
            Console.Write("Qual o km final: ");
            double kmF = double.Parse(Console.ReadLine()!);
            Console.Write("Quanto de conbustivel foi gasto(litros): ");
            double ComG = double.Parse(Console.ReadLine()!);

            double ComKm = (kmF - kmI) / ComG;
            Console.WriteLine($"O carro gasta {ComKm:F2} de combustivel por km");
            Console.ReadLine();
        }
    }
}