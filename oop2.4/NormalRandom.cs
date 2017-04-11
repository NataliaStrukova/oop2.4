using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop2._4
{
    class NormalRandom: Random
    {
        double prevSample = double.NaN;//представляет значение, не являющееся числом (NaN). Это поле является константой.

        protected override double Sample()
        {
            if (!double.IsNaN(prevSample))//Возвращает значение, показывающее, что указанное значение не является числом (NaN)
            {
                double result = prevSample;
                prevSample = double.NaN;
                return result;
            }

            double u, v, s;// мат ожидание, дисперсия, выборка
            do
            {
                u = 2 * base.Sample() - 1;
                v = 2 * base.Sample() - 1; // [-1, 1)
                s = u * u + v * v;
            }
            while (s >= 1 || s == 0);
            double r = Math.Sqrt(-2 * Math.Log(s) / s);//среднеквадратичное отклонение

            prevSample = r * v;
            return r * u;
        }

        public override int Next(int mean, int variance)//среднее, дисперсия
        {
            int result;
            do
                result = (int)(mean + variance * Sample());
            while (result < 0);
            return result;
        }
    }
}
