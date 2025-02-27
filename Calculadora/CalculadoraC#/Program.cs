using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora Simples");
        Console.WriteLine("Escolha uma operação:");
        Console.WriteLine("1. Adição");
        Console.WriteLine("2. Subtração");
        Console.WriteLine("3. Multiplicação");
        Console.WriteLine("4. Divisão");
        Console.Write("Digite o número da operação desejada: ");

        int operacao = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = 0;

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
                if (num2 == 0)
                {
                    Console.WriteLine("Erro: Não é possível dividir por zero.");
                    return;
                }
                resultado = num1 / num2;
                break;
            default:
                Console.WriteLine("Operação inválida.");
                return;
        }

        Console.WriteLine($"Resultado: {resultado}");
