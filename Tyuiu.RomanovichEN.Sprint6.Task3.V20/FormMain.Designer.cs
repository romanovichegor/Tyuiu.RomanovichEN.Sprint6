namespace Tyuiu.RomanovichEN.Sprint6.Task3.V20
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
            groupBoxOne_REN = new GroupBox();
            dataGridViewData_REN = new DataGridView();
            textBoxData_REN = new TextBox();
            groupBoxTwo_REN = new GroupBox();
            textBoxResult_REN = new TextBox();
            dataGridViewResult_REN = new DataGridView();
            buttonDone_REN = new Button();
            buttonHelp_REN = new Button();
            groupBoxOne_REN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData_REN).BeginInit();
            groupBoxTwo_REN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_REN).BeginInit();
            SuspendLayout();
            // 
            // groupBoxOne_REN
            // 
            groupBoxOne_REN.Controls.Add(dataGridViewData_REN);
            groupBoxOne_REN.Controls.Add(textBoxData_REN);
            groupBoxOne_REN.Location = new Point(12, 12);
            groupBoxOne_REN.Name = "groupBoxOne_REN";
            groupBoxOne_REN.Size = new Size(367, 278);
            groupBoxOne_REN.TabIndex = 0;
            groupBoxOne_REN.TabStop = false;
            groupBoxOne_REN.Text = "Условие";
            // 
            // dataGridViewData_REN
            // 
            dataGridViewData_REN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData_REN.ColumnHeadersVisible = false;
            dataGridViewData_REN.Location = new Point(6, 108);
            dataGridViewData_REN.Name = "dataGridViewData_REN";
            dataGridViewData_REN.RowHeadersVisible = false;
            dataGridViewData_REN.Size = new Size(130, 128);
            dataGridViewData_REN.TabIndex = 2;
            // 
            // textBoxData_REN
            // 
            textBoxData_REN.Location = new Point(6, 22);
            textBoxData_REN.Multiline = true;
            textBoxData_REN.Name = "textBoxData_REN";
            textBoxData_REN.ReadOnly = true;
            textBoxData_REN.Size = new Size(355, 71);
            textBoxData_REN.TabIndex = 0;
            textBoxData_REN.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в пятой строке на 0.";
            // 
            // groupBoxTwo_REN
            // 
            groupBoxTwo_REN.Controls.Add(textBoxResult_REN);
            groupBoxTwo_REN.Controls.Add(dataGridViewResult_REN);
            groupBoxTwo_REN.Location = new Point(385, 12);
            groupBoxTwo_REN.Name = "groupBoxTwo_REN";
            groupBoxTwo_REN.Size = new Size(344, 278);
            groupBoxTwo_REN.TabIndex = 1;
            groupBoxTwo_REN.TabStop = false;
            groupBoxTwo_REN.Text = "Вывод данных";
            // 
            // textBoxResult_REN
            // 
            textBoxResult_REN.Location = new Point(6, 22);
            textBoxResult_REN.Multiline = true;
            textBoxResult_REN.Name = "textBoxResult_REN";
            textBoxResult_REN.ReadOnly = true;
            textBoxResult_REN.Size = new Size(332, 71);
            textBoxResult_REN.TabIndex = 3;
            textBoxResult_REN.Text = "Результат";
            // 
            // dataGridViewResult_REN
            // 
            dataGridViewResult_REN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_REN.ColumnHeadersVisible = false;
            dataGridViewResult_REN.Location = new Point(0, 99);
            dataGridViewResult_REN.Name = "dataGridViewResult_REN";
            dataGridViewResult_REN.RowHeadersVisible = false;
            dataGridViewResult_REN.Size = new Size(140, 137);
            dataGridViewResult_REN.TabIndex = 3;
            // 
            // buttonDone_REN
            // 
            buttonDone_REN.Location = new Point(624, 296);
            buttonDone_REN.Name = "buttonDone_REN";
            buttonDone_REN.Size = new Size(99, 41);
            buttonDone_REN.TabIndex = 4;
            buttonDone_REN.Text = "Выполнить";
            buttonDone_REN.UseVisualStyleBackColor = true;
            buttonDone_REN.Click += buttonDone_REN_Click;
            // 
            // buttonHelp_REN
            // 
            buttonHelp_REN.Location = new Point(575, 296);
            buttonHelp_REN.Name = "buttonHelp_REN";
            buttonHelp_REN.Size = new Size(43, 41);
            buttonHelp_REN.TabIndex = 5;
            buttonHelp_REN.Text = "?";
            buttonHelp_REN.UseVisualStyleBackColor = true;
            buttonHelp_REN.Click += buttonHelp_REN_Click;
            // 
            // FormMain_REN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 349);
            Controls.Add(buttonHelp_REN);
            Controls.Add(buttonDone_REN);
            Controls.Add(groupBoxTwo_REN);
            Controls.Add(groupBoxOne_REN);
            MaximizeBox = false;
            Name = "FormMain_REN";
            Text = "Romanovich E. N. | Sprint 6 | Task 3 | V 20";
            Load += FormMain_REN_Load;
            groupBoxOne_REN.ResumeLayout(false);
            groupBoxOne_REN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData_REN).EndInit();
            groupBoxTwo_REN.ResumeLayout(false);
            groupBoxTwo_REN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_REN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOne_REN;
        private GroupBox groupBoxTwo_REN;
        private DataGridView dataGridViewData_REN;
        private TextBox textBoxData_REN;
        private TextBox textBoxResult_REN;
        private DataGridView dataGridViewResult_REN;
        private Button buttonDone_REN;
        private Button buttonHelp_REN;
    }
}
