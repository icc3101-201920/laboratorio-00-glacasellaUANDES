using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_glacasella.Game
{
    class Game
    {
        // Atributos

        private Player[] players;
        private Board boardGame;
        private Player activePlayer;
        private bool endgame;

        // Constructor

        public Game() { }


        // Getters y setters
        public Player[] Players { get => players; set => players = value; }
        public Board BoardGame { get => boardGame; set => boardGame = value; }
        public Player ActivePlayer { get => activePlayer; set => activePlayer = value; }
        public bool Endgame { get => endgame; set => endgame = value; }

        // Metodos

        public bool CheckIfEndGame()
        {
            throw new NotImplementedException();
        }

        public int GetWinner()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

    }
}
