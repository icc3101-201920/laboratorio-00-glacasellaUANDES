using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_glacasella.Board
{
    class Board
    {
        // Atributos
        private List<CombatCard>[] meleeCards;
        private List<CombatCard>[] rangeCards;
        private List<CombatCard>[] longRangeCards;
        private SpecialCard[] specialMeleeCards;
        private SpecialCard[] specialRangeCards;
        private SpecialCard[] specialLongRangeCards;
        private List<SpecialCard> captainCards;
        private List<SpecialCard> weatherCards;

        // Constructor

        public Board() { }

        // Getters y setters
        public List<CombatCard>[] MeleeCards { get => meleeCards; set => meleeCards = value; }
        public List<CombatCard>[] RangeCards { get => rangeCards; set => rangeCards = value; }
        public List<CombatCard>[] LongRangeCards { get => longRangeCards; set => longRangeCards = value; }
        public SpecialCard[] SpecialMeleeCards { get => specialMeleeCards; set => specialMeleeCards = value; }
        public SpecialCard[] SpecialRangeCards { get => specialRangeCards; set => specialRangeCards = value; }
        public SpecialCard[] SpecialLongRangeCards { get => specialLongRangeCards; set => specialLongRangeCards = value; }
        public List<SpecialCard> CaptainCards { get => captainCards; set => captainCards = value; }
        public List<SpecialCard> WeatherCards { get => weatherCards; set => weatherCards = value; }

        // Metodos 

        public void AddCombatCard(int playerId, CombatCard combatCard)
        {
            throw new NotImplementedException();
        }

        public void AddSpecialCard(int playerId, SpecialCard specialCard)
        {
            throw new NotImplementedException();   
        }

        public void DestroyCombatCards()
        {
            throw new NotImplementedException();
        }

        public void DestroySpecialCards()
        {
            throw new NotImplementedException();
        }

        public int[] GetMeleeAttackPoints()
        {
            throw new NotImplementedException();
        }

        public int[] GetRangeAttackPoints()
        {
            throw new NotImplementedException();
        }

        public int[] GetLongRangeAttackPoints()
        {
            throw new NotImplementedException();
        }
    }
}
