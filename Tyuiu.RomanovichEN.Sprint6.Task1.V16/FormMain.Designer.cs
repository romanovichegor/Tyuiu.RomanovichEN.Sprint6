namespace Tyuiu.RomanovichEN.Sprint6.Task1.V16
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
            groupBoxCondition_REN = new GroupBox();
            pictureBoxOne_REN = new PictureBox();
            textBoxOne_REN = new TextBox();
            groupBoxOutput_REN = new GroupBox();
            textBoxResult_REN = new TextBox();
            textBoxFour_REN = new TextBox();
            groupBoxInput_REN = new GroupBox();
            textBoxInputStop_REN = new TextBox();
            textBoxInputStart_REN = new TextBox();
            textBoxThree_REN = new TextBox();
            textBoxTwo_REN = new TextBox();
            buttonHelp_REN = new Button();
            buttonDone_REN = new Button();
            groupBoxCondition_REN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOne_REN).BeginInit();
            groupBoxOutput_REN.SuspendLayout();
            groupBoxInput_REN.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_REN
            // 
            groupBoxCondition_REN.Controls.Add(pictureBoxOne_REN);
            groupBoxCondition_REN.Controls.Add(textBoxOne_REN);
            groupBoxCondition_REN.Font = new Font("Segoe UI", 10F);
            groupBoxCondition_REN.Location = new Point(12, 12);
            groupBoxCondition_REN.Name = "groupBoxCondition_REN";
            groupBoxCondition_REN.Size = new Size(687, 309);
            groupBoxCondition_REN.TabIndex = 0;
            groupBoxCondition_REN.TabStop = false;
            groupBoxCondition_REN.Text = "Условие:";
            // 
            // pictureBoxOne_REN
            // 
            pictureBoxOne_REN.Image = (Image)resources.GetObject("pictureBoxOne_REN.Image");
            pictureBoxOne_REN.InitialImage = (Image)resources.GetObject("pictureBoxOne_REN.InitialImage");
            pictureBoxOne_REN.Location = new Point(6, 78);
            pictureBoxOne_REN.Name = "pictureBoxOne_REN";
            pictureBoxOne_REN.Size = new Size(328, 50);
            pictureBoxOne_REN.TabIndex = 2;
            pictureBoxOne_REN.TabStop = false;
            // 
            // textBoxOne_REN
            // 
            textBoxOne_REN.BackColor = SystemColors.Window;
            textBoxOne_REN.BorderStyle = BorderStyle.None;
            textBoxOne_REN.Location = new Point(6, 24);
            textBoxOne_REN.Multiline = true;
            textBoxOne_REN.Name = "textBoxOne_REN";
            textBoxOne_REN.ReadOnly = true;
            textBoxOne_REN.Size = new Size(675, 87);
            textBoxOne_REN.TabIndex = 0;
            textBoxOne_REN.Text = "Протабулировать функцию F(x) на заданном диапазоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBoxOutput_REN
            // 
            groupBoxOutput_REN.Controls.Add(textBoxResult_REN);
            groupBoxOutput_REN.Controls.Add(textBoxFour_REN);
            groupBoxOutput_REN.Font = new Font("Segoe UI", 10F);
            groupBoxOutput_REN.Location = new Point(705, 12);
            groupBoxOutput_REN.Name = "groupBoxOutput_REN";
            groupBoxOutput_REN.Size = new Size(316, 426);
            groupBoxOutput_REN.TabIndex = 0;
            groupBoxOutput_REN.TabStop = false;
            groupBoxOutput_REN.Text = "Вывод данных:";
            // 
            // textBoxResult_REN
            // 
            textBoxResult_REN.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_REN.Location = new Point(6, 48);
            textBoxResult_REN.Multiline = true;
            textBoxResult_REN.Name = "textBoxResult_REN";
            textBoxResult_REN.ReadOnly = true;
            textBoxResult_REN.ScrollBars = ScrollBars.Vertical;
            textBoxResult_REN.Size = new Size(304, 364);
            textBoxResult_REN.TabIndex = 4;
            // 
            // textBoxFour_REN
            // 
            textBoxFour_REN.BorderStyle = BorderStyle.None;
            textBoxFour_REN.Location = new Point(6, 24);
            textBoxFour_REN.Name = "textBoxFour_REN";
            textBoxFour_REN.ReadOnly = true;
            textBoxFour_REN.Size = new Size(100, 18);
            textBoxFour_REN.TabIndex = 4;
            textBoxFour_REN.Text = "Результат:";
            // 
            // groupBoxInput_REN
            // 
            groupBoxInput_REN.Controls.Add(textBoxInputStop_REN);
            groupBoxInput_REN.Controls.Add(textBoxInputStart_REN);
            groupBoxInput_REN.Controls.Add(textBoxThree_REN);
            groupBoxInput_REN.Controls.Add(textBoxTwo_REN);
            groupBoxInput_REN.Font = new Font("Segoe UI", 10F);
            groupBoxInput_REN.Location = new Point(12, 327);
            groupBoxInput_REN.Name = "groupBoxInput_REN";
            groupBoxInput_REN.Size = new Size(319, 111);
            groupBoxInput_REN.TabIndex = 1;
            groupBoxInput_REN.TabStop = false;
            groupBoxInput_REN.Text = "Ввод данных:";
            // 
            // textBoxInputStop_REN
            // 
            textBoxInputStop_REN.Location = new Point(161, 58);
            textBoxInputStop_REN.Name = "textBoxInputStop_REN";
            textBoxInputStop_REN.Size = new Size(149, 25);
            textBoxInputStop_REN.TabIndex = 6;
            // 
            // textBoxInputStart_REN
            // 
            textBoxInputStart_REN.Location = new Point(6, 58);
            textBoxInputStart_REN.Name = "textBoxInputStart_REN";
            textBoxInputStart_REN.Size = new Size(149, 25);
            textBoxInputStart_REN.TabIndex = 5;
            // 
            // textBoxThree_REN
            // 
            textBoxThree_REN.BorderStyle = BorderStyle.None;
            textBoxThree_REN.Location = new Point(161, 24);
            textBoxThree_REN.Name = "textBoxThree_REN";
            textBoxThree_REN.ReadOnly = true;
            textBoxThree_REN.Size = new Size(100, 18);
            textBoxThree_REN.TabIndex = 3;
            textBoxThree_REN.Text = "Конец шага:";
            // 
            // textBoxTwo_REN
            // 
            textBoxTwo_REN.BorderStyle = BorderStyle.None;
            textBoxTwo_REN.Location = new Point(6, 24);
            textBoxTwo_REN.Name = "textBoxTwo_REN";
            textBoxTwo_REN.ReadOnly = true;
            textBoxTwo_REN.Size = new Size(100, 18);
            textBoxTwo_REN.TabIndex = 2;
            textBoxTwo_REN.Text = "Старт шага:";
            // 
            // buttonHelp_REN
            // 
            buttonHelp_REN.BackColor = Color.PaleTurquoise;
            buttonHelp_REN.Font = new Font("Segoe UI", 12F);
            buttonHelp_REN.Location = new Point(372, 370);
            buttonHelp_REN.Name = "buttonHelp_REN";
            buttonHelp_REN.Size = new Size(85, 54);
            buttonHelp_REN.TabIndex = 2;
            buttonHelp_REN.Text = "Справка";
            buttonHelp_REN.UseVisualStyleBackColor = false;
            buttonHelp_REN.Click += buttonHelp_REN_Click;
            // 
            // buttonDone_REN
            // 
            buttonDone_REN.BackColor = Color.FromArgb(192, 255, 192);
            buttonDone_REN.Font = new Font("Segoe UI", 12F);
            buttonDone_REN.Location = new Point(484, 370);
            buttonDone_REN.Name = "buttonDone_REN";
            buttonDone_REN.Size = new Size(209, 54);
            buttonDone_REN.TabIndex = 3;
            buttonDone_REN.Text = "Выполнить";
            buttonDone_REN.UseVisualStyleBackColor = false;
            buttonDone_REN.Click += buttonDone_REN_Click;
            // 
            // FormMain_REN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 450);
            Controls.Add(buttonDone_REN);
            Controls.Add(buttonHelp_REN);
            Controls.Add(groupBoxInput_REN);
            Controls.Add(groupBoxOutput_REN);
            Controls.Add(groupBoxCondition_REN);
            HelpButton = true;
            MaximizeBox = false;
            Name = "FormMain_REN";
            Text = "Sprint 6 | Task 1 | V 16 | Romanovich E. N.";
            groupBoxCondition_REN.ResumeLayout(false);
            groupBoxCondition_REN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOne_REN).EndInit();
            groupBoxOutput_REN.ResumeLayout(false);
            groupBoxOutput_REN.PerformLayout();
            groupBoxInput_REN.ResumeLayout(false);
            groupBoxInput_REN.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_REN;
        private TextBox textBoxOne_REN;
        private GroupBox groupBoxOutput_REN;
        private GroupBox groupBoxInput_REN;
        private TextBox textBoxTwo_REN;
        private PictureBox pictureBoxOne_REN;
        private TextBox textBoxFour_REN;
        private TextBox textBoxInputStop_REN;
        private TextBox textBoxInputStart_REN;
        private TextBox textBoxThree_REN;
        private Button buttonHelp_REN;
        private Button buttonDone_REN;
        private TextBox textBoxResult_REN;
    }
}
