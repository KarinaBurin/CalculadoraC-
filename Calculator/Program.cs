using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja Fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");

            Console.WriteLine("----------------------");
            Console.WriteLine("Selecione uma das opões:");
            Console.WriteLine("");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Divisao();
                    break;
                case 4:
                    Multiplicacao();
                    break;
                default:
                    Menu();
                    break;
            }
        }

        static void retornarMenu()
        {
            Console.WriteLine("Deseja retornar ao menu? ");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            short res = short.Parse(Console.ReadLine());
            switch (res)
            {
                case 1:
                    Menu();
                    break;
                case 2:
                    Encerrar();
                    break;
                default:
                    retornarMenu();
                    break;
            }
        }

        static void Encerrar()
        {
            Console.WriteLine("");
            Console.WriteLine("Obrigada por utilizar esta aplicação!! até mais.");
            System.Environment.Exit(0);
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Você escolheu opção Soma ");
            Console.WriteLine("Insira o Primeiro Valor: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Insira o Segundo Valor: ");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float resultado = num1 + num2;
            Console.WriteLine($"A soma é: {resultado} ");

            Console.WriteLine("----------------------");

            retornarMenu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Você escolheu opção Subtração ");
            Console.WriteLine("Insira o Primeiro Valor:: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Insira o Segundo Valor: ");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float resultado = num1 - num2;
            Console.WriteLine($"A resultado da subtração é: {resultado} ");

            Console.WriteLine("----------------------");
            retornarMenu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Você escolheu opção Divisão ");
            Console.WriteLine("Insira o Primeiro Valor:");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Insira o Segundo Valor:");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float resultado = num1 / num2;
            Console.WriteLine($"A resultado da divisão é: {resultado} ");

            Console.WriteLine("----------------------");
            retornarMenu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Você escolheu opção Multiplicação ");
            Console.WriteLine("Insira o Primeiro Valor:");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Insira o Segundo Valor:");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float resultado = num1 * num2;
            Console.WriteLine($"A resultado da multiplicação é: {resultado} ");
            Console.WriteLine("----------------------");

            retornarMenu();
        }
    }
}