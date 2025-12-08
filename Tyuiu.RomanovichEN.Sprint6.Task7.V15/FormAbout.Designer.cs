namespace Tyuiu.RomanovichEN.Sprint6.Task7.V15
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
            textBoxHElp_REN = new TextBox();
            SuspendLayout();
            // 
            // textBoxHElp_REN
            // 
            textBoxHElp_REN.Location = new Point(114, 28);
            textBoxHElp_REN.Multiline = true;
            textBoxHElp_REN.Name = "textBoxHElp_REN";
            textBoxHElp_REN.ReadOnly = true;
            textBoxHElp_REN.Size = new Size(274, 98);
            textBoxHElp_REN.TabIndex = 0;
            textBoxHElp_REN.Text = "ВЫполнил студент группы ПКТб-25-1\r\nРоманович Егор Николаевич";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 168);
            Controls.Add(textBoxHElp_REN);
            Name = "FormAbout";
            Text = "FormAbout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxHElp_REN;
    }
}