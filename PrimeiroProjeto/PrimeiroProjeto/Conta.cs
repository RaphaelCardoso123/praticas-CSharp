using System;


namespace PrimeiroProjeto {
    internal class Conta {


        public int NumeroConta;
        public string TitularConta;
        public double Saldo;
        private string _depositoConta;

        //----------------------------------------------------------------
        public void Depositar(double saldo) {
            Saldo += saldo;
        }
        public void Sacar(double saldo) {
            Saldo -= saldo;
        }

        //----------------------------------------------------------------
        public override string ToString() { 
            return "Conta: " + NumeroConta + ", Titular: " 
                   + TitularConta + ", Saldo: $" + Saldo.ToString("F2");

        }
        //----------------------------------------------------------------
    }
}