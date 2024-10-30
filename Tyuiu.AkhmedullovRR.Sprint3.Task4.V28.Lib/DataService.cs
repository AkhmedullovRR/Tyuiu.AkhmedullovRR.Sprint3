using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AkhmedullovRR.Sprint3.Task4.V28.Lib
{
    public class DataService : ISprint3Task4V28
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            double x;
            stopValue = 5;
            for (x = -5; x <= stopValue; x++)
            {
                
                if (x == 0)
                {
                    break;
                }
                else
                {
                    res = res * ((Math.Cos(x)) + (Math.Sin(x))) / (x);
                }
            }
            return Math.Round(res, 3);
        }
    }
}