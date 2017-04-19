using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Plane : IAccelerate, IRise
    {
        private int acceleration;
        private int level;

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

        public int Level
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
            }
        }

        public void Accelerate(int change)
        {
            acceleration += change;
        }

        public void Rise(int change)
        {
            level += change;
        }

        public int GetRise()
        {
            return level;
        }

        public int GetAcceleration()
        {
            return acceleration;
        }
    }
}
