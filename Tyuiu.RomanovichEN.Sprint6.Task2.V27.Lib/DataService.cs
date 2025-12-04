using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RomanovichEN.Sprint6.Task2.V27.Lib
{
    public class DataService : ISprint6Task2V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int p = 0;
            double[] array = new double[stopValue - startValue + 1];
            for (int x = startValue; x <= stopValue; x++)
            {                
                double cosx = Math.Cos(x);
                double sinx = Math.Sin(x);
                if (cosx - 2 * x == 0)
                {
                    array[p] = 0;
                }
                else
                {
                    double f = (2 * x - 3) / (cosx - 2 * x) + 5 * x - sinx;
                    array[p] = Math.Round(f,2);
                }
                p++;
            }
            return array;
        }
    }
}
