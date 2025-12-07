using Tyuiu.RomanovichEN.Sprint6.Task3.V20.Lib;
namespace Tyuiu.RomanovichEN.Sprint6.Task3.V20
{
    public partial class FormMain_REN : Form
    {
        public FormMain_REN()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] array = new int[5, 5] { { -14, 17, -19, 3, 2 }, { -4, -14, -19, -9, -1 }, { 1, 0, 13, 14, 8 }, { 13, 7, 8, -3, -15 }, { 2, -20, 12, -14, 4 } };
        private void FormMain_REN_Load(object sender, EventArgs e)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            dataGridViewData_REN.ColumnCount = columns;
            dataGridViewData_REN.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewData_REN.Columns[i].Width = 25;
            }
            for (int i = 0; i <rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewData_REN.Rows[i].Cells[j].Value = Convert.ToString(array[i, j]);
                }
            }
        }
        private void buttonDone_REN_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] calculatedArray = ds.Calculate(array);
                DisplayArray(dataGridViewResult_REN, calculatedArray);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при расчёте: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplayArray(DataGridView dgv, int[,] data)
        {
            if (data == null || data.Length == 0)
            {
                dgv.RowCount = 0;
                dgv.ColumnCount = 0;
                return;
            }

            int rows = data.GetUpperBound(0) + 1;
            int columns = data.GetUpperBound(1) + 1;

            dgv.ColumnCount = columns;
            dgv.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dgv.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dgv.Rows[i].Cells[j].Value = data[i, j].ToString();
                }
            }
        }
        private void buttonHelp_REN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил студент группы ПКТб-25-1 Романович Егор Николаевич", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
