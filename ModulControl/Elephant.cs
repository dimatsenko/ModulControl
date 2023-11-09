using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulControl
{
    public class Elephant : IUnit
    {
        private const double MaintenanceCost = 0;
        private const double Feed = 1;

        public double GetCost()
        {
            return MaintenanceCost;
        }

        public double GetFeed()
        {
            return Feed;
        }

        public double GetSpeed()
        {
            return 30;
        }
    }

}
