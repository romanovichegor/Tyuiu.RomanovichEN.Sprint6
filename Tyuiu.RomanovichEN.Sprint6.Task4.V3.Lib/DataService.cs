using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RomanovichEN.Sprint6.Task4.V3.Lib
{
    public class DataService : ISprint6Task4V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int lenght = stopValue - startValue + 1;
            double[] res =new double[lenght];
            int i = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double sinx = Math.Sin(x);
                if (sinx - 3 + x == 0)
                {
                    res[i] = 0;
                }
                else
                {
                    res[i] = Math.Round((3 * x - 1.5) / (sinx - 3 + x) + 2, 2);
                }
                i++;
            }
            return res;
        }
    }
}
