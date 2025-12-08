using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RomanovichEN.Sprint6.Task6.V24.Lib
{
    public class DataService : ISprint6Task6V24
    {
        public string CollectTextFromFile(string path)
        {
            var resStr = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Match match = Regex.Match(line, @"^\S+");
                    if (match.Success)
                    {
                        resStr.Add(match.Value);
                    }
                }
            }
            return string.Join(" ", resStr);
        }
        
    }
}
