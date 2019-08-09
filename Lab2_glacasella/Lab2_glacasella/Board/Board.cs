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
        public List<CombatCard>[] MeleeCards { get => meleeCards;}
        public List<CombatCard>[] RangeCards { get => rangeCards;}
        public List<CombatCard>[] LongRangeCards { get => longRangeCards;}
        public SpecialCard[] SpecialMeleeCards { get => specialMeleeCards;}
        public SpecialCard[] SpecialRangeCards { get => specialRangeCards;}
        public SpecialCard[] SpecialLongRangeCards { get => specialLongRangeCards;}
        public List<SpecialCard> CaptainCards { get => captainCards;}
        public List<SpecialCard> WeatherCards { get => weatherCards;}

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
