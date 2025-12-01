using Tyuiu.RomanovichEN.Sprint6.Task0.V21.Lib;
namespace Tyuiu.RomanovichEN.Sprint6.Task0.V21
{
    public partial class MainFormOne_REN : Form
    {
        public MainFormOne_REN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxFinalResult_REN.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxIntA_REN.Text)));
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные!", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}