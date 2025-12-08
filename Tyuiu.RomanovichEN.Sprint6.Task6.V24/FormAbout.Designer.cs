namespace Tyuiu.RomanovichEN.Sprint6.Task6.V24
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxHelp_REN = new TextBox();
            SuspendLayout();
            // 
            // textBoxHelp_REN
            // 
            textBoxHelp_REN.Location = new Point(108, 46);
            textBoxHelp_REN.Multiline = true;
            textBoxHelp_REN.Name = "textBoxHelp_REN";
            textBoxHelp_REN.ReadOnly = true;
            textBoxHelp_REN.Size = new Size(308, 89);
            textBoxHelp_REN.TabIndex = 0;
            textBoxHelp_REN.Text = "Выполнил студент группы ПКТб-25-1\r\nРоманович Егор Николаевич";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 213);
            Controls.Add(textBoxHelp_REN);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "FormAbout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxHelp_REN;
    }
}