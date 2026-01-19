using System;

namespace CalculadoraSimples
{    
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Bem-vindo à Calculadora simples!");
            Console.WriteLine("Digite o primeiro número:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Selecione uma operação:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            int operacao = Convert.ToInt32(Console.ReadLine());
            int resultado = 0;

            switch (operacao)
        {
            case 1:
                resultado = num1 + num2;
                break;
            case 2:
                resultado = num1 - num2;
                break;
            case 3:
                resultado = num1 * num2;
                break;
            case 4:
                if (num2 != 0)
                    resultado = num1 / num2;
                else
                    Console.WriteLine("Erro: divisão por zero.");
                break;
            default:
                Console.WriteLine("Operação inválida.");
                break;
        }

            Console.WriteLine("O resultado é: " + resultado);
        }
    }           
}