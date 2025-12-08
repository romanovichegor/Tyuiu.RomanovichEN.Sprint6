namespace Tyuiu.RomanovichEN.Sprint6.Task6.V24
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
            openFileDialogTask_REN = new OpenFileDialog();
            toolTipOne_REN = new ToolTip(components);
            buttonHelp_REN = new Button();
            textBoxLoadFromFile_REN = new TextBox();
            textBoxResult_REN = new TextBox();
            SuspendLayout();
            // 
            // buttonOpenFile_REN
            // 
            buttonOpenFile_REN.Location = new Point(12, 12);
            buttonOpenFile_REN.Name = "buttonOpenFile_REN";
            buttonOpenFile_REN.Size = new Size(61, 60);
            buttonOpenFile_REN.TabIndex = 0;
            toolTipOne_REN.SetToolTip(buttonOpenFile_REN, "Открыть файл");
            buttonOpenFile_REN.UseVisualStyleBackColor = true;
            buttonOpenFile_REN.Click += buttonOpenFile_REN_Click;
            // 
            // buttonDone_REN
            // 
            buttonDone_REN.Enabled = false;
            buttonDone_REN.Location = new Point(79, 12);
            buttonDone_REN.Name = "buttonDone_REN";
            buttonDone_REN.Size = new Size(61, 60);
            buttonDone_REN.TabIndex = 1;
            toolTipOne_REN.SetToolTip(buttonDone_REN, "Выполнить");
            buttonDone_REN.UseVisualStyleBackColor = true;
            buttonDone_REN.Click += buttonDone_REN_Click;
            // 
            // openFileDialogTask_REN
            // 
            openFileDialogTask_REN.FileName = "openFileDialogTask_REN";
            // 
            // toolTipOne_REN
            // 
            toolTipOne_REN.ToolTipIcon = ToolTipIcon.Info;
            toolTipOne_REN.ToolTipTitle = "Подсказка";
            // 
            // buttonHelp_REN
            // 
            buttonHelp_REN.Location = new Point(699, 12);
            buttonHelp_REN.Name = "buttonHelp_REN";
            buttonHelp_REN.Size = new Size(56, 60);
            buttonHelp_REN.TabIndex = 2;
            buttonHelp_REN.UseVisualStyleBackColor = true;
            buttonHelp_REN.Click += buttonHelp_REN_Click;
            // 
            // textBoxLoadFromFile_REN
            // 
            textBoxLoadFromFile_REN.Location = new Point(12, 133);
            textBoxLoadFromFile_REN.Multiline = true;
            textBoxLoadFromFile_REN.Name = "textBoxLoadFromFile_REN";
            textBoxLoadFromFile_REN.ReadOnly = true;
            textBoxLoadFromFile_REN.Size = new Size(352, 238);
            textBoxLoadFromFile_REN.TabIndex = 3;
            // 
            // textBoxResult_REN
            // 
            textBoxResult_REN.Location = new Point(403, 133);
            textBoxResult_REN.Multiline = true;
            textBoxResult_REN.Name = "textBoxResult_REN";
            textBoxResult_REN.ReadOnly = true;
            textBoxResult_REN.Size = new Size(352, 238);
            textBoxResult_REN.TabIndex = 4;
            // 
            // FormMain_REN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxResult_REN);
            Controls.Add(textBoxLoadFromFile_REN);
            Controls.Add(buttonHelp_REN);
            Controls.Add(buttonDone_REN);
            Controls.Add(buttonOpenFile_REN);
            Name = "FormMain_REN";
            Text = "Sprint 6 | Task 6 | V 24 | Romanovich E N";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOpenFile_REN;
        private Button buttonDone_REN;
        private OpenFileDialog openFileDialogTask_REN;
        private ToolTip toolTipOne_REN;
        private Button buttonHelp_REN;
        private TextBox textBoxLoadFromFile_REN;
        private TextBox textBoxResult_REN;
    }
}
