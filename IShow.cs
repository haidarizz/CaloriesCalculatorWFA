using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCWFA
{
    public interface IShow
    {
        string ShowActivity(string name, double velo);
        string ShowRecommendation(double CaloriesBurned);
    }
}
