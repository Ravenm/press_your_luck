///Filename:Player.cs
/// Class that defines data that corresponds to a player
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyluck
{
    class Player
    {
        //each player has spins and a score
        private int spins;
        private int score;
        private int whammy;

        public Player()
        {
            spins = 0;
            score = 0;
            whammy = 0;
        }

        public int getSpins()
        {
            return spins;
        }

        public int getScore()
        {
            return score;
        }

        public int getWhammy()
        {
            return whammy;
        }

        public void addSpins(int n)
        {
            spins = spins + n;
        }

        public void addScore(int n)
        {
            score = score + n;
        }

        public void addWhammy(int n)
        {
            whammy = whammy + n;
        }
    }
}