using System;

namespace PrimeiroProjeto {
    internal class Quartos {

        public string Name { get; set; }
        public string Email { get; set; }
        public int quartoHospede { get; set; }

        //public string quartoHospede;

        //CONSTRUTOR
        public Quartos(string name, string email, int quartoHospede) {
            Name = name;
            Email = email;
        }

        //TOSTRING
        /*override public string ToString() {
           return "Rent #" + quartoHospede + ": " +
                    "Name: " + Name +
                    "Email: " + Email +
                    "Room: " + quartoHospede;
        }*/

    }
}
