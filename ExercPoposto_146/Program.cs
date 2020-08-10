using System;
using System.Globalization;
using ExercPoposto_146.Entities;
using ExercPoposto_146.Exceptions;

namespace ExercPoposto_146
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nEntre com os dados da conta: ");
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Titular: ");
            string nome = Console.ReadLine();

            Console.Write("Saldo inicial: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Limite para Saque: ");
            double limiteSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conta contas = new Conta(numero, nome, valor, limiteSaque);
            double valorSalque;

            try
            {
                Console.Write("\nInsira o valor para saque: ");
                valorSalque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contas.Saque(valorSalque);
                Console.WriteLine(contas.ToString());
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
