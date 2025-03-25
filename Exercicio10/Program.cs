namespace Exercicio10
{
    internal class Program
    {
        /*A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
        pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a
        venda dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado).
        Você foi contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as
        quantidades de pães e de broas, e depois calcular os dados solicitados.*/
        static void Main(string[] args)
        {
            Console.Write("Qunatos pães foram vendidos: ");
            double qp = double.Parse(Console.ReadLine()!);
            Console.Write("Qunatas broas foram vendidas: ");
            double qb = double.Parse(Console.ReadLine()!);

            qp *= 0.12;
            qb *= 1.5;
            double gp = (double)(qp + qb) * 0.1;
            Console.WriteLine("----------------------------");
            Console.WriteLine("Arrecadacao");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Pães: R${qp:F2}");
            Console.WriteLine($"Broas: R${qb:F2}");
            Console.WriteLine($"Guardar na poupanca: R${gp:F2}");
            Console.ReadLine();
        }
    }
}