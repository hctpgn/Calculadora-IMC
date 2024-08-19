using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de IMC");

            Console.Write("Digite seu peso em kg: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua altura em metros: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = CalculaIMC(peso, altura);

            Console.WriteLine($"\nSeu IMC é: {imc:F2}");
            ExibeClassificacaoIMC(imc);

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        static double CalculaIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        static void ExibeClassificacaoIMC(double imc)
        {
            if (imc < 18.5)
            {
                Console.WriteLine("Classificação: Abaixo do peso");
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                Console.WriteLine("Classificação: Peso normal");
            }
            else if (imc >= 25 && imc < 29.9)
            {
                Console.WriteLine("Classificação: Sobrepeso");
            }
            else
            {
                Console.WriteLine("Classificação: Obesidade");
            }
        }
    }
}