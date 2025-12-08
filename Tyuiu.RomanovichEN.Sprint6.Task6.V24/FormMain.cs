using Tyuiu.RomanovichEN.Sprint6.Task6.V24.Lib;

namespace Tyuiu.RomanovichEN.Sprint6.Task6.V24
{
    public partial class FormMain_REN : Form
    {
        public FormMain_REN()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_REN_Click(object sender, EventArgs e)
        {
            openFileDialogTask_REN.ShowDialog();
            openFilePath = openFileDialogTask_REN.FileName;
            textBoxLoadFromFile_REN.Text = File.ReadAllText(openFilePath);
            buttonDone_REN.Enabled = true;
        }

        private void buttonHelp_REN_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        private void buttonDone_REN_Click(object sender, EventArgs e)
        {
            textBoxResult_REN.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}
