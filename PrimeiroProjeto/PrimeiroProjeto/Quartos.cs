using System;

namespace PrimeiroProjeto {
    internal class Quartos {

        public string Name { get; set; }
        public string Email { get; set; }

        //CONSTRUTOR
        public Quartos(string name, string email) {
            Name = name;
            Email = email;
        }

        //TOSTRING
        override public string ToString() {
           return Name + ", " + Email;
        }

    }
}
