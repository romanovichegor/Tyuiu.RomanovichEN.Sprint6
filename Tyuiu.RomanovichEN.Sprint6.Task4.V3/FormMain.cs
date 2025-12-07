using Tyuiu.RomanovichEN.Sprint6.Task4.V3.Lib;
namespace Tyuiu.RomanovichEN.Sprint6.Task4.V3
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
                int len = stop - start + 1;
                double[] array = new double[len];
                array = ds.GetMassFunction(start, stop);
                textBoxResult_REN.Text = "";
                for (int i = 0; i < len; i++)
                {
                    textBoxResult_REN.AppendText(array[i] + Environment.NewLine);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_REN_Click(object sender, EventArgs e)
        {
            string pathout = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V3.txt");
            File.WriteAllText(pathout, textBoxResult_REN.Text);
            DialogResult dialogResult = MessageBox.Show("Файл" + pathout + "сохранен успешно!\n Открыть его?");
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = pathout;
                txt.Start();
            }
        }

        private void buttonHelp_REN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил студент группы ПКТб-25-1 Романович Егор Николаевич", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
