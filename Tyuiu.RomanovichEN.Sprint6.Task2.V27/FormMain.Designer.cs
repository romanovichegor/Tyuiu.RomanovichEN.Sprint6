using Tyuiu.RomanovichEN.Sprint6.Task2.V27.Lib;
namespace Tyuiu.RomanovichEN.Sprint6.Task2.V27
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_REN));
            pictureBoxFormule_REN = new PictureBox();
            groupBoxOne_REN = new GroupBox();
            textBoxOne_REN = new TextBox();
            groupBoxTwo_REN = new GroupBox();
            dataGridViewFunction_REN = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            groupBoxThree_REN = new GroupBox();
            textBoxInputStop_REN = new TextBox();
            textBoxInputStart_REN = new TextBox();
            textBoxThree_REN = new TextBox();
            textBoxTwo_REN = new TextBox();
            buttonHelp_REN = new Button();
            buttonDone_REN = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormule_REN).BeginInit();
            groupBoxOne_REN.SuspendLayout();
            groupBoxTwo_REN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_REN).BeginInit();
            groupBoxThree_REN.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxFormule_REN
            // 
            pictureBoxFormule_REN.Image = (Image)resources.GetObject("pictureBoxFormule_REN.Image");
            pictureBoxFormule_REN.Location = new Point(6, 76);
            pictureBoxFormule_REN.Name = "pictureBoxFormule_REN";
            pictureBoxFormule_REN.Size = new Size(433, 50);
            pictureBoxFormule_REN.TabIndex = 0;
            pictureBoxFormule_REN.TabStop = false;
            // 
            // groupBoxOne_REN
            // 
            groupBoxOne_REN.Controls.Add(textBoxOne_REN);
            groupBoxOne_REN.Controls.Add(pictureBoxFormule_REN);
            groupBoxOne_REN.Location = new Point(12, 12);
            groupBoxOne_REN.Name = "groupBoxOne_REN";
            groupBoxOne_REN.Size = new Size(461, 289);
            groupBoxOne_REN.TabIndex = 1;
            groupBoxOne_REN.TabStop = false;
            groupBoxOne_REN.Text = "Условие";
            // 
            // textBoxOne_REN
            // 
            textBoxOne_REN.Location = new Point(6, 22);
            textBoxOne_REN.Multiline = true;
            textBoxOne_REN.Name = "textBoxOne_REN";
            textBoxOne_REN.ReadOnly = true;
            textBoxOne_REN.Size = new Size(433, 48);
            textBoxOne_REN.TabIndex = 1;
            textBoxOne_REN.Text = "Написать программу, которая выводит таблицу значений функции \r\n(произвести табулирование) f(x) на заданном диапазоне";
            // 
            // groupBoxTwo_REN
            // 
            groupBoxTwo_REN.Controls.Add(dataGridViewFunction_REN);
            groupBoxTwo_REN.Location = new Point(479, 12);
            groupBoxTwo_REN.Name = "groupBoxTwo_REN";
            groupBoxTwo_REN.Size = new Size(120, 357);
            groupBoxTwo_REN.TabIndex = 2;
            groupBoxTwo_REN.TabStop = false;
            groupBoxTwo_REN.Text = "Вывод данных:";
            // 
            // dataGridViewFunction_REN
            // 
            dataGridViewFunction_REN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_REN.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewFunction_REN.Location = new Point(6, 22);
            dataGridViewFunction_REN.Name = "dataGridViewFunction_REN";
            dataGridViewFunction_REN.ReadOnly = true;
            dataGridViewFunction_REN.RowHeadersVisible = false;
            dataGridViewFunction_REN.Size = new Size(103, 333);
            dataGridViewFunction_REN.TabIndex = 6;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.Name = "Y";
            Y.ReadOnly = true;
            Y.Width = 50;
            // 
            // groupBoxThree_REN
            // 
            groupBoxThree_REN.Controls.Add(textBoxInputStop_REN);
            groupBoxThree_REN.Controls.Add(textBoxInputStart_REN);
            groupBoxThree_REN.Controls.Add(textBoxThree_REN);
            groupBoxThree_REN.Controls.Add(textBoxTwo_REN);
            groupBoxThree_REN.Location = new Point(12, 317);
            groupBoxThree_REN.Name = "groupBoxThree_REN";
            groupBoxThree_REN.Size = new Size(222, 100);
            groupBoxThree_REN.TabIndex = 3;
            groupBoxThree_REN.TabStop = false;
            groupBoxThree_REN.Text = "Ввод данных:";
            // 
            // textBoxInputStop_REN
            // 
            textBoxInputStop_REN.Location = new Point(112, 59);
            textBoxInputStop_REN.Name = "textBoxInputStop_REN";
            textBoxInputStop_REN.Size = new Size(100, 23);
            textBoxInputStop_REN.TabIndex = 7;
            // 
            // textBoxInputStart_REN
            // 
            textBoxInputStart_REN.Location = new Point(0, 59);
            textBoxInputStart_REN.Name = "textBoxInputStart_REN";
            textBoxInputStart_REN.Size = new Size(100, 23);
            textBoxInputStart_REN.TabIndex = 6;
            // 
            // textBoxThree_REN
            // 
            textBoxThree_REN.BorderStyle = BorderStyle.None;
            textBoxThree_REN.ForeColor = SystemColors.InactiveCaption;
            textBoxThree_REN.Location = new Point(112, 22);
            textBoxThree_REN.Name = "textBoxThree_REN";
            textBoxThree_REN.ReadOnly = true;
            textBoxThree_REN.Size = new Size(100, 16);
            textBoxThree_REN.TabIndex = 5;
            textBoxThree_REN.Text = "Конец";
            // 
            // textBoxTwo_REN
            // 
            textBoxTwo_REN.BorderStyle = BorderStyle.None;
            textBoxTwo_REN.ForeColor = SystemColors.InactiveCaption;
            textBoxTwo_REN.Location = new Point(6, 22);
            textBoxTwo_REN.Name = "textBoxTwo_REN";
            textBoxTwo_REN.ReadOnly = true;
            textBoxTwo_REN.Size = new Size(100, 16);
            textBoxTwo_REN.TabIndex = 4;
            textBoxTwo_REN.Text = "Старт";
            // 
            // buttonHelp_REN
            // 
            buttonHelp_REN.BackColor = Color.PaleGreen;
            buttonHelp_REN.Location = new Point(253, 339);
            buttonHelp_REN.Name = "buttonHelp_REN";
            buttonHelp_REN.Size = new Size(79, 60);
            buttonHelp_REN.TabIndex = 4;
            buttonHelp_REN.Text = "Справка";
            buttonHelp_REN.UseVisualStyleBackColor = false;
            buttonHelp_REN.Click += buttonHelp_REN_Click;
            // 
            // buttonDone_REN
            // 
            buttonDone_REN.BackColor = Color.MediumTurquoise;
            buttonDone_REN.Location = new Point(338, 339);
            buttonDone_REN.Name = "buttonDone_REN";
            buttonDone_REN.Size = new Size(135, 60);
            buttonDone_REN.TabIndex = 5;
            buttonDone_REN.Text = "Выполнить";
            buttonDone_REN.UseVisualStyleBackColor = false;
            buttonDone_REN.Click += buttonDone_REN_Click;
            // 
            // FormMain_REN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 450);
            Controls.Add(buttonDone_REN);
            Controls.Add(buttonHelp_REN);
            Controls.Add(groupBoxThree_REN);
            Controls.Add(groupBoxOne_REN);
            Controls.Add(groupBoxTwo_REN);
            MaximizeBox = false;
            Name = "FormMain_REN";
            Text = "Sprint 6 | Task 2 | V 27 | Romanovich E. N.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormule_REN).EndInit();
            groupBoxOne_REN.ResumeLayout(false);
            groupBoxOne_REN.PerformLayout();
            groupBoxTwo_REN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_REN).EndInit();
            groupBoxThree_REN.ResumeLayout(false);
            groupBoxThree_REN.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxFormule_REN;
        private GroupBox groupBoxOne_REN;
        private GroupBox groupBoxTwo_REN;
        private TextBox textBoxOne_REN;
        private GroupBox groupBoxThree_REN;
        private TextBox textBoxInputStop_REN;
        private TextBox textBoxInputStart_REN;
        private TextBox textBoxThree_REN;
        private TextBox textBoxTwo_REN;
        private Button buttonHelp_REN;
        private Button buttonDone_REN;
        private DataGridView dataGridViewFunction_REN;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
    }
}
