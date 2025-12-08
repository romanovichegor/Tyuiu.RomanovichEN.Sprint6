using System.IO;
using Tyuiu.RomanovichEN.Sprint6.Task7.V15.Lib;
namespace Tyuiu.RomanovichEN.Sprint6.Task7.V15
{
    public partial class FormMain_REN : Form
    {
        public FormMain_REN()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string openFilePath_REN;
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewInMatrix.ColumnCount = 50;
            dataGridViewInMatrix.RowCount = 50;
            dataGridViewOutMatrix.ColumnCount = 50;
            dataGridViewOutMatrix.ColumnCount = 50;   
        }
        public int[,] LoadFromFile(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);


            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }

        private void buttonHelp_REN_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        private void buttonOpenFile_REN_Click(object sender, EventArgs e)
        {
            openFileDialog_REN.ShowDialog();
            openFilePath_REN = openFileDialog_REN.FileName;
            int[,] array = new int[rows, columns];
            array = LoadFromFile(openFilePath_REN);
            dataGridViewInMatrix.ColumnCount = columns;
            dataGridViewInMatrix.RowCount = rows;
            dataGridViewOutMatrix.ColumnCount = columns;
            dataGridViewOutMatrix.ColumnCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewInMatrix.Columns[i].Width = 25;
                dataGridViewOutMatrix.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInMatrix.Rows[i].Cells[j].Value = array[i, j];
                }
            }
            array = ds.GetMatrix(openFilePath_REN);
            buttonDone_REN.Enabled = true;
        }

        private void buttonDone_REN_Click(object sender, EventArgs e)
        {
            int[,] array = new int[rows, columns];
            array = ds.GetMatrix(openFilePath_REN);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutMatrix.Rows[i].Cells[j].Value = array[i, j];
                }
            }
            buttonSave_REN.Enabled = true;
        }

        private void buttonSave_REN_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();
            string path = saveFileDialogMatrix.FileName;
            FileInfo file = new FileInfo(path);
            if (file.Exists) { File.Delete(path); }
            int rows = dataGridViewOutMatrix.RowCount;
            int cols = dataGridViewOutMatrix.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str = str + dataGridViewOutMatrix.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix.Rows[i].Cells[j].Value;
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
            }
        }
    }
}
