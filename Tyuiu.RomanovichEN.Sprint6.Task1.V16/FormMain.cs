using Tyuiu.RomanovichEN.Sprint6.Task1.V16.Lib;

namespace Tyuiu.RomanovichEN.Sprint6.Task1.V16
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
                int startstep = Convert.ToInt32(textBoxInputStart_REN.Text);
                int stopstep = Convert.ToInt32(textBoxInputStop_REN.Text);
                string strLine;
                int len = ds.GetMassFunction(startstep, stopstep).Length;
                double[] array;
                array = new double[len];
                array = ds.GetMassFunction(startstep, stopstep);

                textBoxResult_REN.Text = "";
                textBoxResult_REN.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_REN.AppendText("|    X     +   f(x)   |" + Environment.NewLine);
                textBoxResult_REN.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |   {1,5:f2}  | ", startstep, array[i]);
                    textBoxResult_REN.AppendText(strLine + Environment.NewLine);
                    startstep++;
                }
                textBoxResult_REN.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonHelp_REN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ПКТб-25-1 Романович Егор Николаевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
