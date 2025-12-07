using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RomanovichEN.Sprint6.Task5.V27.Lib
{
    public class DataService : ISprint6Task5V27
    {
        public double[] LoadFromDataFile(string path)
        {
            double[] res = null;
            string strx = File.ReadAllText(path);
            strx = strx.Replace('.', ',');
            string[] strings = strx.Split(' ');
            foreach (string s in strings)
            {
                double x = Math.Round(double.Parse(s),3);
                if (x % 5 != 0)
                {
                    res.Append(x);
                }
            }
            return res;
        }
    }
}
