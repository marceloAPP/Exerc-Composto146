using System;
using System.Globalization;
using ExercPoposto_146.Exceptions;

namespace ExercPoposto_146.Entities
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Conta()
        {
        }

        public Conta(int numero, string titular, double saldo, double limiteSaque)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double valorDeposito)
        {
            Saldo += valorDeposito;
        }

        public void Saque(double valorSaque)
        {
            if (valorSaque > Saldo)
            {
                throw new DomainException(
                    "\n=============================\n" +
                    "Saldo insuficiente para saque!" +
                    "\n=============================\n");
            }
            else if (valorSaque > LimiteSaque)
            {
                throw new DomainException(
                    "\n================================\n" +
                    "Limite de saque diário excedido!" +
                    "\n================================\n"
                    );
            }

            Saldo -= valorSaque;
        }

        public override string ToString()
        {
            return "\nSaldo atual: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
