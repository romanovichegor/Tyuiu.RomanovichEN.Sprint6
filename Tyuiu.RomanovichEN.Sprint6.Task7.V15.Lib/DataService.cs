using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RomanovichEN.Sprint6.Task7.V15.Lib
{
    public class DataService : ISprint6Task7V15
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int rowCount = lines.Length;
            int colCount = 0;
            for (int i = 0; i < rowCount; i++)
            {
                if (!string.IsNullOrWhiteSpace(lines[i]))
                {
                    colCount = lines[i].Split(',').Length;
                    break;
                }
            }
            int[,] matrix = new int[rowCount, colCount];
            for (int row = 0; row < rowCount; row++)
            {
                string[] parts = lines[row].Split(',');

                for (int col = 0; col < colCount; col++)
                {
                    if (col < parts.Length && int.TryParse(parts[col], out int value))
                    {
                        if (col == 6 && value < 10 && value % 3 == 0)
                        {
                            matrix[row, col] = 3;
                        }
                        else
                        {
                            matrix[row, col] = value;
                        }
                    }
                    else
                    {
                        matrix[row, col] = 0;
                    }
                }
            }

            return matrix;
        }
    }
}
