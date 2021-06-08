using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCWFA
{
    public abstract class Sport
    {
        protected string when;
        protected int time;

        public Sport(string when, int time)
        {
            this.when = when;
            this.time = time;
        }

        public abstract double CalculateCaloriesBurned(double BMI, double time, double velocity);
    }
}
