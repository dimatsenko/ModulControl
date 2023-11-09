using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulControl
{
    public class Knights : IUnit
    {
        private const double MaintenanceCost = 2;
        private const double Feed = 1;

        public double GetFeed()
        {
            return Feed;
        }
        public double GetCost()
        {
            return MaintenanceCost;
        }

        public double GetSpeed()
        {
            return 15;
        }
    }
}
