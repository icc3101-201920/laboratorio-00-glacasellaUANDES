using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_glacasella.Deck
{
    class Deck
    {
        // Atributos
        private List<CombatCard> combatCards;
        private List<SpecialCard> specialCards;

        // Constructor

        public Deck() { }

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

        public void DestroyCombatCard(int cardID)
        {
            throw new NotImplementedException();
        }

        public void DestroySpecialCard(int cardID)
        {
            throw new NotImplementedException();
        }

        public void Shuffle()
        {
            throw new NotImplementedException();
        }

    }
}
