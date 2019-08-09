using System;
using System.Collections.Generic;
using System.Text;

namespace Card
{
    class SpecialCard
    {
        // Atributos
        private string name;
        private string type;
        private string buffType;
        private string effect;

        // Constructor

        public SpecialCard() { }

        // Getters y setters
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string BuffType { get => buffType; set => buffType = value; }
        public string Effect { get => effect; set => effect = value; }
    }
}
