using System;


namespace PrimeiroProjeto {
    internal class Conta {

        public string Titular;
        private double _deposito;
        public double Saldo;


        public Conta() { 
       }
        public Conta(string titular, double deposito, double saldo) {
            Titular = titular;
            _deposito = deposito;
            Saldo = saldo;
        }


        public double Deposito { 
            get { return _deposito;  }
            set {
                if (value > 0) {
                    _deposito = value;
                } 
            }
        }
        
        public void NovoSaldo (double saldo){
            Saldo += saldo;
        }
    }
}
