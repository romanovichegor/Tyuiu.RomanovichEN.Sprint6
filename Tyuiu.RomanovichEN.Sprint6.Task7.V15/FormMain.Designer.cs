namespace Tyuiu.RomanovichEN.Sprint6.Task7.V15
{
    partial class FormMain_REN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonOpenFile_REN = new Button();
            buttonDone_REN = new Button();
            buttonSave_REN = new Button();
            buttonHelp_REN = new Button();
            toolTipOne_REN = new ToolTip(components);
            openFileDialog_REN = new OpenFileDialog();
            saveFileDialogMatrix = new SaveFileDialog();
            dataGridViewInMatrix = new DataGridView();
            dataGridViewOutMatrix = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix).BeginInit();
            SuspendLayout();
            // 
            // buttonOpenFile_REN
            // 
            buttonOpenFile_REN.Location = new Point(12, 12);
            buttonOpenFile_REN.Name = "buttonOpenFile_REN";
            buttonOpenFile_REN.Size = new Size(64, 61);
            buttonOpenFile_REN.TabIndex = 0;
            buttonOpenFile_REN.Text = "button1";
            buttonOpenFile_REN.UseVisualStyleBackColor = true;
            buttonOpenFile_REN.Click += buttonOpenFile_REN_Click;
            // 
            // buttonDone_REN
            // 
            buttonDone_REN.Enabled = false;
            buttonDone_REN.Location = new Point(100, 12);
            buttonDone_REN.Name = "buttonDone_REN";
            buttonDone_REN.Size = new Size(64, 61);
            buttonDone_REN.TabIndex = 1;
            buttonDone_REN.Text = "button1";
            buttonDone_REN.UseVisualStyleBackColor = true;
            buttonDone_REN.Click += buttonDone_REN_Click;
            // 
            // buttonSave_REN
            // 
            buttonSave_REN.Enabled = false;
            buttonSave_REN.Location = new Point(188, 12);
            buttonSave_REN.Name = "buttonSave_REN";
            buttonSave_REN.Size = new Size(64, 61);
            buttonSave_REN.TabIndex = 2;
            buttonSave_REN.Text = "button1";
            buttonSave_REN.UseVisualStyleBackColor = true;
            buttonSave_REN.Click += buttonSave_REN_Click;
            // 
            // buttonHelp_REN
            // 
            buttonHelp_REN.Location = new Point(994, 12);
            buttonHelp_REN.Name = "buttonHelp_REN";
            buttonHelp_REN.Size = new Size(64, 61);
            buttonHelp_REN.TabIndex = 3;
            buttonHelp_REN.Text = "button1";
            buttonHelp_REN.UseVisualStyleBackColor = true;
            buttonHelp_REN.Click += buttonHelp_REN_Click;
            // 
            // openFileDialog_REN
            // 
            openFileDialog_REN.FileName = "openFileDialog1";
            // 
            // dataGridViewInMatrix
            // 
            dataGridViewInMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix.Location = new Point(12, 169);
            dataGridViewInMatrix.Name = "dataGridViewInMatrix";
            dataGridViewInMatrix.Size = new Size(488, 374);
            dataGridViewInMatrix.TabIndex = 4;
            // 
            // dataGridViewOutMatrix
            // 
            dataGridViewOutMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix.Location = new Point(559, 169);
            dataGridViewOutMatrix.Name = "dataGridViewOutMatrix";
            dataGridViewOutMatrix.Size = new Size(499, 374);
            dataGridViewOutMatrix.TabIndex = 5;
            // 
            // FormMain_REN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 576);
            Controls.Add(dataGridViewOutMatrix);
            Controls.Add(dataGridViewInMatrix);
            Controls.Add(buttonHelp_REN);
            Controls.Add(buttonSave_REN);
            Controls.Add(buttonDone_REN);
            Controls.Add(buttonOpenFile_REN);
            Name = "FormMain_REN";
            Text = "Sprint 6 | Task 7 | V 15 | REN";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpenFile_REN;
        private Button buttonDone_REN;
        private Button buttonSave_REN;
        private Button buttonHelp_REN;
        private ToolTip toolTipOne_REN;
        private OpenFileDialog openFileDialog_REN;
        private SaveFileDialog saveFileDialogMatrix;
        private DataGridView dataGridViewInMatrix;
        private DataGridView dataGridViewOutMatrix;
    }
}
