﻿namespace Exercicio04
{
    internal class Program
    {
        //Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
        static void Main(string[] args)
        {
            Console.Write("Quantos Gruas Celsius: ");
            double GC = double.Parse(Console.ReadLine()!);

            double GF = GC * 1.8 + 32;
            Console.WriteLine($"Isso equivale a {GF:F2} Graus Fahrenheit");
            Console.ReadLine();
        }
    }
}