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
        private int _spins;
        private int _score;
        private int _whammy;
        private int _prize;

        public Player()
        {
            _spins = 0;
            _score = 0;
            _prize = 0;
            _whammy = 0;
        }

        public int GetSpins()
        {
            return _spins;
        }

        public int GetPize()
        {
            return _prize;
        }

        public int GetScore()
        {
            return _score;
        }

        public int GetWhammy()
        {
            return _whammy;
        }

        public void AddSpins(int n =1)
        {
            _spins = _spins + n;
        }

        public void AddScore(int n = 1)
        {
            _score = _score + n;
        }

        public void AddPrize(int n =1)
        {
            _prize = _prize + n;
        }

        public void AddWhammy(int n = 1)
        {
            _whammy = _whammy + n;
            _prize = 0;
        }

    }
}