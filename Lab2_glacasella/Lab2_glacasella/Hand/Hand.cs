using System;
using System.Collections.Generic;
using System.Text;

namespace Card
{
    class Hand
    {
        // Atributos
        private List<CombatCard> combatCards;
        private List<SpecialCard> specialCards;

        // Constructor

        public Hand() { }

        // getters y setters

        public List<CombatCard> CombatCards { get => combatCards; set => combatCards = value; }
        public List<SpecialCard> SpecialCards { get => specialCards; set => specialCards = value; }

        // Metodos


        public void AddCombatCard(CombatCard combatCard)
        {
            throw new NotImplementedException();
        }
        public void AddSpecialCard(SpecialCard specialCard)
        {
            throw new NotImplementedException();
        }

        public void DestroyCombatCard(int cardId)
        {
            throw new NotImplementedException();
        }

        public void DestroySpecialCard(int cardId)
        {
            throw new NotImplementedException();
        }

    }
}
