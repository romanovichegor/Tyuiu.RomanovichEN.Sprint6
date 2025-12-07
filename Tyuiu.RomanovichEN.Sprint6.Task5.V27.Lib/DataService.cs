using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RomanovichEN.Sprint6.Task5.V27.Lib
{
    public class DataService : ISprint6Task5V27
    {
        public double[] LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            strx = strx.Replace('.', ','); 

            string[] strings = strx.Split(new char[] { ' ', '\t', '\r', '\n' },
                                         StringSplitOptions.RemoveEmptyEntries);

            List<double> resultList = new List<double>();

            foreach (string s in strings)
            {
                if (double.TryParse(s, out double x))
                {
                    if ((x % 5) != 0)
                    {
                        resultList.Add(x); 
                    }
                }
                
            }

            return resultList.ToArray();
        }
    }
}
