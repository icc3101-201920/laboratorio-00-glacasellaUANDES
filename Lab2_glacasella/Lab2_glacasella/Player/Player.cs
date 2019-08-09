using Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card
{
    class Player
    {
        // Atributos
        private int lifePoints;
        private int attackPoints;
        private Deck deck;
        private Hand hand;
        private Board board;
        private SpecialCard captain;

        // Constructor

        public Player() { }

        // Getters y setters

        public int LifePoints { get => lifePoints; set => lifePoints = value; }
        public int AttackPoints { get => attackPoints; set => attackPoints = value; }
        public Deck Deck { get => deck; set => deck = value; }
        public Hand Hand { get => hand; set => hand = value; }
        public Board Board { get => board; set => board = value; }
        public SpecialCard Captain { get => captain; set => captain = value; }

        // Metodos
        public void DrawCard()
        {
            throw new NotImplementedException();
        }

        public void PlayCard(int cardID)
        {
            throw new NotImplementedException();
        }

        public void ChangeCard(int cardID)
        {
            throw new NotImplementedException();
        }

        public void FirstHand()
        {
            throw new NotImplementedException();
        }

        public void ChooseCaptainCard(SpecialCard captainCard)
        {
            throw new NotImplementedException();
        }

    }
}
