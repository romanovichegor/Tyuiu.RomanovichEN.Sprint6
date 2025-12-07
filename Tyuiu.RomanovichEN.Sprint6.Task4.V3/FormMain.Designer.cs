namespace Tyuiu.RomanovichEN.Sprint6.Task4.V3
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
            textBoxOne_REN = new TextBox();
            textBoxTwo_REN = new TextBox();
            textBoxInputStart_REN = new TextBox();
            textBoxInputStop_REN = new TextBox();
            textBoxThree_REN = new TextBox();
            groupBoxOne_REN = new GroupBox();
            pictureBoxOne_REN = new PictureBox();
            groupBoxTwo_REN = new GroupBox();
            textBoxResult_REN = new TextBox();
            buttonDone_REN = new Button();
            buttonSave_REN = new Button();
            buttonHelp_REN = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOne_REN).BeginInit();
            groupBoxTwo_REN.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxOne_REN
            // 
            textBoxOne_REN.BorderStyle = BorderStyle.None;
            textBoxOne_REN.Location = new Point(206, 12);
            textBoxOne_REN.Name = "textBoxOne_REN";
            textBoxOne_REN.ReadOnly = true;
            textBoxOne_REN.Size = new Size(100, 16);
            textBoxOne_REN.TabIndex = 0;
            textBoxOne_REN.Text = "Старт шага";
            // 
            // textBoxTwo_REN
            // 
            textBoxTwo_REN.BorderStyle = BorderStyle.None;
            textBoxTwo_REN.Location = new Point(349, 12);
            textBoxTwo_REN.Name = "textBoxTwo_REN";
            textBoxTwo_REN.ReadOnly = true;
            textBoxTwo_REN.Size = new Size(100, 16);
            textBoxTwo_REN.TabIndex = 1;
            textBoxTwo_REN.Text = "Конец шага";
            // 
            // textBoxInputStart_REN
            // 
            textBoxInputStart_REN.Location = new Point(206, 34);
            textBoxInputStart_REN.Name = "textBoxInputStart_REN";
            textBoxInputStart_REN.Size = new Size(100, 23);
            textBoxInputStart_REN.TabIndex = 2;
            // 
            // textBoxInputStop_REN
            // 
            textBoxInputStop_REN.Location = new Point(349, 34);
            textBoxInputStop_REN.Name = "textBoxInputStop_REN";
            textBoxInputStop_REN.Size = new Size(100, 23);
            textBoxInputStop_REN.TabIndex = 3;
            // 
            // textBoxThree_REN
            // 
            textBoxThree_REN.BorderStyle = BorderStyle.None;
            textBoxThree_REN.Location = new Point(12, 24);
            textBoxThree_REN.Name = "textBoxThree_REN";
            textBoxThree_REN.ReadOnly = true;
            textBoxThree_REN.Size = new Size(174, 16);
            textBoxThree_REN.TabIndex = 4;
            textBoxThree_REN.Text = "Произвести табулирование";
            // 
            // groupBoxOne_REN
            // 
            groupBoxOne_REN.Location = new Point(0, 3);
            groupBoxOne_REN.Name = "groupBoxOne_REN";
            groupBoxOne_REN.Size = new Size(489, 89);
            groupBoxOne_REN.TabIndex = 5;
            groupBoxOne_REN.TabStop = false;
            groupBoxOne_REN.Text = "Условие";
            // 
            // pictureBoxOne_REN
            // 
            pictureBoxOne_REN.Image = (Image)resources.GetObject("pictureBoxOne_REN.Image");
            pictureBoxOne_REN.Location = new Point(12, 98);
            pictureBoxOne_REN.Name = "pictureBoxOne_REN";
            pictureBoxOne_REN.Size = new Size(221, 50);
            pictureBoxOne_REN.TabIndex = 6;
            pictureBoxOne_REN.TabStop = false;
            // 
            // groupBoxTwo_REN
            // 
            groupBoxTwo_REN.Controls.Add(textBoxResult_REN);
            groupBoxTwo_REN.Location = new Point(495, 3);
            groupBoxTwo_REN.Name = "groupBoxTwo_REN";
            groupBoxTwo_REN.Size = new Size(293, 435);
            groupBoxTwo_REN.TabIndex = 7;
            groupBoxTwo_REN.TabStop = false;
            groupBoxTwo_REN.Text = "Вывод";
            // 
            // textBoxResult_REN
            // 
            textBoxResult_REN.Location = new Point(6, 22);
            textBoxResult_REN.Multiline = true;
            textBoxResult_REN.Name = "textBoxResult_REN";
            textBoxResult_REN.ReadOnly = true;
            textBoxResult_REN.Size = new Size(281, 407);
            textBoxResult_REN.TabIndex = 11;
            // 
            // buttonDone_REN
            // 
            buttonDone_REN.Location = new Point(12, 388);
            buttonDone_REN.Name = "buttonDone_REN";
            buttonDone_REN.Size = new Size(95, 50);
            buttonDone_REN.TabIndex = 8;
            buttonDone_REN.Text = "Выполнить";
            buttonDone_REN.UseVisualStyleBackColor = true;
            buttonDone_REN.Click += buttonDone_REN_Click;
            // 
            // buttonSave_REN
            // 
            buttonSave_REN.Location = new Point(138, 388);
            buttonSave_REN.Name = "buttonSave_REN";
            buttonSave_REN.Size = new Size(95, 50);
            buttonSave_REN.TabIndex = 9;
            buttonSave_REN.Text = "Сохранить";
            buttonSave_REN.UseVisualStyleBackColor = true;
            buttonSave_REN.Click += buttonSave_REN_Click;
            // 
            // buttonHelp_REN
            // 
            buttonHelp_REN.Location = new Point(267, 388);
            buttonHelp_REN.Name = "buttonHelp_REN";
            buttonHelp_REN.Size = new Size(95, 50);
            buttonHelp_REN.TabIndex = 10;
            buttonHelp_REN.Text = "Справка";
            buttonHelp_REN.UseVisualStyleBackColor = true;
            buttonHelp_REN.Click += buttonHelp_REN_Click;
            // 
            // FormMain_REN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_REN);
            Controls.Add(buttonSave_REN);
            Controls.Add(buttonDone_REN);
            Controls.Add(groupBoxTwo_REN);
            Controls.Add(pictureBoxOne_REN);
            Controls.Add(textBoxThree_REN);
            Controls.Add(textBoxInputStop_REN);
            Controls.Add(textBoxInputStart_REN);
            Controls.Add(textBoxTwo_REN);
            Controls.Add(textBoxOne_REN);
            Controls.Add(groupBoxOne_REN);
            MaximizeBox = false;
            Name = "FormMain_REN";
            Text = "Sprint 6 | Task 4 | V 3 | REN";
            ((System.ComponentModel.ISupportInitialize)pictureBoxOne_REN).EndInit();
            groupBoxTwo_REN.ResumeLayout(false);
            groupBoxTwo_REN.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxOne_REN;
        private TextBox textBoxTwo_REN;
        private TextBox textBoxInputStart_REN;
        private TextBox textBoxInputStop_REN;
        private TextBox textBoxThree_REN;
        private GroupBox groupBoxOne_REN;
        private PictureBox pictureBoxOne_REN;
        private GroupBox groupBoxTwo_REN;
        private TextBox textBoxResult_REN;
        private Button buttonDone_REN;
        private Button buttonSave_REN;
        private Button buttonHelp_REN;
    }
}
