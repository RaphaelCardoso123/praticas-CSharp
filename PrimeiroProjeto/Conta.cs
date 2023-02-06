using System;
using System.Globalization;

namespace PrimeiroProjeto {
    internal class Conta {

        public int NumeroConta { get; private set; }
        public string TitularConta { get; set; }
        public double Saldo { get; private set; }
        //----------------------------------------------------------------
        public Conta(int numeroConta, string titularConta) {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
        }
        public Conta(int numeroConta, string titularConta, double depositoInicial) : this(numeroConta, titularConta) {
            Depositar(depositoInicial);
        }
        //----------------------------------------------------------------
        public void Depositar(double saldo) {
            Saldo += saldo;
        }
        public void Sacar(double saldo) {
            Saldo -= saldo;
            Saldo -= 5.00;
        }
        //----------------------------------------------------------------
        public override string ToString() { 
            return "Conta: " + NumeroConta + ", Titular: " 
                   + TitularConta + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InstalledUICulture);
        }
        //----------------------------------------------------------------
    }
}