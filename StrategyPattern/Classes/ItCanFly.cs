using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ItCanFly : IFlys
    {
        public string Fly()
        {
            return "I can Fly";
        }
    }
}
