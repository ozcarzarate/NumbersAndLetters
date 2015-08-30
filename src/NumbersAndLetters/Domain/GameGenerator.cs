using System;
using NumbersAndLetters.Domain;
using NumbersAndLetters.Domain.Interfaces;
using System.Collections.Generic;

namespace NumberAndLetters.Domain
{
    internal class GameGenerator : IGameGenerator
    {
        private List<int> _smalls = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private List<int> _bigs = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        public GameGenerator()
        {
        }

        public Game Get(int bigs, int smalls)
        {
            var listOfBigs = GetBigs(bigs);
            var listOfSmalls = GetSmalls(smalls);
            var result = new Game
            {
                Bigs = listOfBigs,
                Smalls = listOfSmalls,
                Result = GetResult(listOfBigs, listOfSmalls),
                Sample = "(20 * 50) - (2 * 5 * 7) + 1"
            };

            return result;
        }

        private int GetResult(List<int> listOfBigs, List<int> listOfSmalls)
        {
            var result = 1;
            listOfBigs.ForEach(x => result *= x);
            for (int i = 0; i < listOfSmalls.Count-1; i++)
            {
                result -= listOfSmalls[i];
            }
            result += listOfSmalls[listOfSmalls.Count - 1];
            return result;
        }

        private List<int> GetSmalls(int howMany)
        {
            var result = new List<int>();
            var rnd = new Random();
            for (int i = 0; i < howMany; i++)
            {
                result.Add(_smalls[rnd.Next(0, 8)]);
            }
            return result;
        }

        private List<int> GetBigs(int howMany)
        {
            var result = new List<int>();
            var rnd = new Random();
            for (int i = 0; i < howMany; i++)
            {
                result.Add(_bigs[rnd.Next(0, 9)]);
            }
            return result;
        }
    }
}