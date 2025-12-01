using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RomanovichEN.Sprint6.Task1.V16.Lib
{
    public class DataService : ISprint6Task1V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] array = new double[stopValue - startValue+1];
            int i = 0;
            for (int x = startValue; x <= stopValue ; x++)
            {
                if (x == -1.2)
                {
                    array[i] = 0;
                }
                else
                {
                    double sinx = Math.Sin(x);
                    double cosx = Math.Cos(x);
                    double res = (sinx / (x + 1.2)) + cosx * 7 * x - 2;
                    array[i] = Math.Round(res,2);
                }
                i++;
            }
            return array;
        }
    }
}
