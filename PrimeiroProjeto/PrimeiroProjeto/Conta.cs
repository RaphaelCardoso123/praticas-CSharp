using System;


namespace PrimeiroProjeto {
    internal class Conta {

        public int NumeroConta { get; private set; }
        public string TitularConta { get; set; }
        public double Saldo { get; private set; }

        //private string _depositoConta;

        //----------------------------------------------------------------

        public Conta(int numeroConta, string titularConta) {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
        }
        public Conta(int numeroConta, string titularConta, double saldo) : this(numeroConta, titularConta) {
            Saldo = saldo;
        }


        //----------------------------------------------------------------
        //public void Depositar(double saldo) {
        //    Saldo += saldo;
        //}
        //public void Sacar(double saldo) {
        //    Saldo -= saldo;
        //}

        //----------------------------------------------------------------
        public override string ToString() { 
            return "Conta: " + NumeroConta + ", Titular: " 
                   + TitularConta + ", Saldo: $" + Saldo.ToString("F2");

        }
        //----------------------------------------------------------------
    }
}