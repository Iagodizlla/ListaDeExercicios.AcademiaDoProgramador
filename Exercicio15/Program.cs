namespace Exercicio15
{
    internal class Program
    {
        /*O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre
        a condição de peso de uma pessoa adulta. A fórmula é IMC = peso / (altura) ². Elabore um algoritmo que leia o
        peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
        ● IMC em adultos Condição
        ● Abaixo de 18,5
        ● Abaixo do peso
        ● Entre 18,5 e 25 Peso normal
        ● Entre 25 e 30
        ● Acima do peso
        ● Acima de 30 obeso*/
        static void Main(string[] args)
        {
            Console.Write("Qual seu peso: ");
            double peso = double.Parse(Console.ReadLine()!);
            Console.Write("Qual sua altura(cm): ");
            double altura = double.Parse(Console.ReadLine()!);

            double IMC = Math.Pow(peso / altura, 2)*100;


            if(IMC < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (IMC >= 18.5 && IMC < 25)
            {
                Console.WriteLine("Peso nroaml");
            }
            else if (IMC >= 25 && IMC < 30)
            {
                Console.WriteLine("Acima do peso");
            }
            else
            {
                Console.WriteLine("Obeso");
            }
            Console.ReadLine();
        }
    }
}