using System;

namespace PrimeiroProjeto {
    internal class Aluno {
        
        public string Nome;
        public double N1;
        public double N2;
        public double N3;
 
    
        public double ResultadoFinal() {
            return N1 + N2 + N3;
        }
        public bool Aprovado() {
            if (ResultadoFinal() >= 60.0) {
                return true;
            }
            else {
                return false;
            }
        }

        public double NotaRestante() {
            if(Aprovado()) {
                return 0.0;
            } else {
                return 60.0 - ResultadoFinal();
            }
        }

    }
}
