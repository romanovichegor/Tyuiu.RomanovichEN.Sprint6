
using Tyuiu.RomanovichEN.Sprint6.Task2.V27.Lib;
namespace Tyuiu.RomanovichEN.Sprint6.Task2.V27
{
    public partial class FormMain_REN : Form
    {
        public FormMain_REN()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_REN_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxInputStart_REN.Text);
                int stop = Convert.ToInt32(textBoxInputStop_REN.Text);
                int len = ds.GetMassFunction(start, stop).Length;
                double[] array = new double[len];
                array = ds.GetMassFunction(start, stop);
                //this.chartFunction.Titles.Add("График функции");
                //this.chartFunction.ChartAreas[0].AxisX.Title = "Ось Х";
                //this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len; i++)
                {
                    this.dataGridViewFunction_REN.Rows.Add(Convert.ToString(start), Convert.ToString(array[i]));

                    //                    this.chartFunction.Series[0].Points.AddXY(start, array[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_REN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ПКТб-25-1 Романович Егор Николаевич", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
