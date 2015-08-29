using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumbersAndLetters.Domain.Interfaces
{
    public interface IGameGenerator
    {
        Game Get(int bigs, int smalls);
    }
}
