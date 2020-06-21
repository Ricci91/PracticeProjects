using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISingPatrol
{
    class Bee : IStingPatrol
    {
        public int AlertLevel
        {
            get
            {
                return AlertLevel;
            }
        }

        public int StingerLength
        {
            get
            {
                return StingerLength;
            }
            set
            {
                StingerLength = 4;
            }
        }

        public bool LookForEnemies()
        {
            return true;
        }

        public int SharpenStinger(int length)
        {
            return length;
        }
    }
}
