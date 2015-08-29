using System;
using NumbersAndLetters.Domain;
using NumbersAndLetters.Domain.Interfaces;
using System.Collections.Generic;

namespace NumberAndLetters.Domain
{
    internal class GameGenerator : IGameGenerator
    {
        public GameGenerator()
        {
        }

        public Game Get(int bigs, int smalls)
        {
            var result = new Game
            {
                Bigs = new List<int> { 50, 20 },
                Smalls = new List<int> { 2, 5, 7, 1 },
                Sample = "(20 * 50) - (2 * 5 * 7) + 1"
            };

            return result;
        }
    }
}