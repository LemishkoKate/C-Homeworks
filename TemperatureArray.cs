using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverflow
{
    internal class TemperatureArray
    {
        private double[] temps = new double[7];

        public double this[int index]
        {
            get { return temps[index]; }
            set { temps[index] = value; }
        }

        public double GetAverage()
        {
            double sum = 0;
            for (int i = 0; i < temps.Length; i++)
                sum += temps[i];

            return sum / temps.Length;
        }
    }
}
