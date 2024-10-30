using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AkhmedullovRR.Sprint3.Task3.V4.Lib
{
    public class DataService : ISprint3Task3V4
    {
        public string DeleteCharInString(string value, char item)
        {
            
            foreach (char c in value)
            {
                if (c == item)
                {
                    value = value.Replace(item, '\0');
                }
            }
            return value;
        }
    }
}