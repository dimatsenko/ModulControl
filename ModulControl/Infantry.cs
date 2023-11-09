using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulControl
{
    public class Infantry : IUnit
    {
        private const double MaintenanceCost = 1;
        private const double Feed = 0;

        public double GetCost()
        {
            return MaintenanceCost;
        }

        public double GetSpeed()
        {
            return 3; // км на годину
        }

        public double GetFeed()
        {
            return Feed;
        }
    }
}
