using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Submarine : IDive, IAccelerate
    {
        private int acceleration;
        private int depth;

        public int Acceleration
        {
            get
            {
                return acceleration;
            }

            set
            {
                acceleration = value;
            }
        }

        public int Depth
        {
            get
            {
                return depth;
            }

            set
            {
                depth = value;
            }
        }

        public void Dive(int change)
        {
            depth += change;
        
        }

        public void Accelerate(int change)
        {
            acceleration += change;
        }
    }
}
