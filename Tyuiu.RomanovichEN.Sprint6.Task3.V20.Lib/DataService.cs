using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RomanovichEN.Sprint6.Task3.V20.Lib
{
    public class DataService : ISprint6Task3V20
    {
        public int[,] Calculate(int[,] array)
        {
            int columns = array.GetUpperBound(1)+ 1;
            for (int j = 0; j < columns; j++)
            {
                if (array[4, j] % 2 == 0)
                {
                    array[4, j] = 0;
                }
            }
            return array;
        }
    }
}
