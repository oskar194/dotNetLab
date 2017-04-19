using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Car : IAccelerate
    {
        private int acceleration;

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

        public void Accelerate(int change)
        {
            acceleration += change;
        }
        public int GetAcceleration()
        {
            return acceleration;
        }
    }
}
