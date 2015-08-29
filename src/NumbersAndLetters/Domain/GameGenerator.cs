using System;
using NumbersAndLetters.Domain;
using NumbersAndLetters.Domain.Interfaces;

namespace NumberAndLetters.UnitTest.Domain
{
    internal class GameGenerator : IGameGenerator
    {
        public GameGenerator()
        {
        }

        public Game Get(int bigs, int smalls)
        {
            throw new NotImplementedException();
        }
    }
}