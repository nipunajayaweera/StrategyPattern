using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IFlys FlyingType { get; set; }

        public string TryToFly()
        {
            return FlyingType.Fly();
        }

        public void SetFlyingType(IFlys newFlyingType)
        {
            FlyingType = newFlyingType;
        }
    }
}
