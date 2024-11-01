﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AkhmedullovRR.Sprint3.Task6.V18.Lib
{
    public class DataService : ISprint3Task6V18
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j < 10 && i % j == 0) sum += j;
                }
            }
            return sum;
        }
    }
}