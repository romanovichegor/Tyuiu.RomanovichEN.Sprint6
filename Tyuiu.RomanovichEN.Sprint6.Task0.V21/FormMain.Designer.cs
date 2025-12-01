namespace Tyuiu.RomanovichEN.Sprint6.Task0.V21
{
    partial class MainFormOne_REN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormOne_REN));
            groupBoxOne_REN = new GroupBox();
            textBoxOne_REN = new TextBox();
            pictureBoxOne_REN = new PictureBox();
            groupBoxTwo_REN = new GroupBox();
            textBoxIntA_REN = new TextBox();
            textBoxA_REN = new TextBox();
            groupBoxThree_REN = new GroupBox();
            textBoxFinalResult_REN = new TextBox();
            checkBox1 = new CheckBox();
            textBoxRes_REN = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBoxOne_REN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOne_REN).BeginInit();
            groupBoxTwo_REN.SuspendLayout();
            groupBoxThree_REN.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOne_REN
            // 
            groupBoxOne_REN.Controls.Add(textBoxOne_REN);
            groupBoxOne_REN.Font = new Font("Segoe UI", 10F);
            groupBoxOne_REN.Location = new Point(27, 28);
            groupBoxOne_REN.Name = "groupBoxOne_REN";
            groupBoxOne_REN.Size = new Size(457, 213);
            groupBoxOne_REN.TabIndex = 0;
            groupBoxOne_REN.TabStop = false;
            groupBoxOne_REN.Text = "Условие";
            // 
            // textBoxOne_REN
            // 
            textBoxOne_REN.Font = new Font("Segoe UI", 10F);
            textBoxOne_REN.Location = new Point(6, 22);
            textBoxOne_REN.Multiline = true;
            textBoxOne_REN.Name = "textBoxOne_REN";
            textBoxOne_REN.ReadOnly = true;
            textBoxOne_REN.Size = new Size(445, 183);
            textBoxOne_REN.TabIndex = 1;
            textBoxOne_REN.Text = "Вычислить выражение по формуле:";
            // 
            // pictureBoxOne_REN
            // 
            pictureBoxOne_REN.Image = (Image)resources.GetObject("pictureBoxOne_REN.Image");
            pictureBoxOne_REN.Location = new Point(490, 50);
            pictureBoxOne_REN.Name = "pictureBoxOne_REN";
            pictureBoxOne_REN.Size = new Size(298, 54);
            pictureBoxOne_REN.TabIndex = 1;
            pictureBoxOne_REN.TabStop = false;
            pictureBoxOne_REN.Click += pictureBox1_Click;
            // 
            // groupBoxTwo_REN
            // 
            groupBoxTwo_REN.Controls.Add(textBoxIntA_REN);
            groupBoxTwo_REN.Controls.Add(textBoxA_REN);
            groupBoxTwo_REN.Font = new Font("Segoe UI", 10F);
            groupBoxTwo_REN.Location = new Point(27, 267);
            groupBoxTwo_REN.Name = "groupBoxTwo_REN";
            groupBoxTwo_REN.Size = new Size(457, 103);
            groupBoxTwo_REN.TabIndex = 2;
            groupBoxTwo_REN.TabStop = false;
            groupBoxTwo_REN.Text = "Ввод данных";
            groupBoxTwo_REN.Enter += groupBox1_Enter;
            // 
            // textBoxIntA_REN
            // 
            textBoxIntA_REN.Location = new Point(33, 59);
            textBoxIntA_REN.Name = "textBoxIntA_REN";
            textBoxIntA_REN.Size = new Size(88, 25);
            textBoxIntA_REN.TabIndex = 6;
            // 
            // textBoxA_REN
            // 
            textBoxA_REN.BorderStyle = BorderStyle.None;
            textBoxA_REN.Location = new Point(33, 24);
            textBoxA_REN.Name = "textBoxA_REN";
            textBoxA_REN.ReadOnly = true;
            textBoxA_REN.Size = new Size(100, 18);
            textBoxA_REN.TabIndex = 3;
            textBoxA_REN.Text = "Переменная X";
            // 
            // groupBoxThree_REN
            // 
            groupBoxThree_REN.Controls.Add(textBoxFinalResult_REN);
            groupBoxThree_REN.Controls.Add(checkBox1);
            groupBoxThree_REN.Controls.Add(textBoxRes_REN);
            groupBoxThree_REN.Font = new Font("Segoe UI", 10F);
            groupBoxThree_REN.Location = new Point(514, 267);
            groupBoxThree_REN.Name = "groupBoxThree_REN";
            groupBoxThree_REN.Size = new Size(274, 100);
            groupBoxThree_REN.TabIndex = 3;
            groupBoxThree_REN.TabStop = false;
            groupBoxThree_REN.Text = "Вывод данных";
            // 
            // textBoxFinalResult_REN
            // 
            textBoxFinalResult_REN.Location = new Point(6, 59);
            textBoxFinalResult_REN.Name = "textBoxFinalResult_REN";
            textBoxFinalResult_REN.ReadOnly = true;
            textBoxFinalResult_REN.Size = new Size(100, 25);
            textBoxFinalResult_REN.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(35, 99);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(92, 23);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxRes_REN
            // 
            textBoxRes_REN.BorderStyle = BorderStyle.None;
            textBoxRes_REN.Location = new Point(6, 24);
            textBoxRes_REN.Name = "textBoxRes_REN";
            textBoxRes_REN.ReadOnly = true;
            textBoxRes_REN.Size = new Size(100, 18);
            textBoxRes_REN.TabIndex = 6;
            textBoxRes_REN.Text = "Результат:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonHelp.Location = new Point(572, 395);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(48, 43);
            buttonHelp.TabIndex = 7;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonDone
            // 
            buttonDone.Font = new Font("Segoe UI", 10F);
            buttonDone.Location = new Point(639, 395);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(128, 43);
            buttonDone.TabIndex = 8;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // MainFormOne_REN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxThree_REN);
            Controls.Add(groupBoxTwo_REN);
            Controls.Add(pictureBoxOne_REN);
            Controls.Add(groupBoxOne_REN);
            MaximizeBox = false;
            Name = "MainFormOne_REN";
            Text = "Sprint 6 | Task 0 | V 21 | Romanovich E. N.";
            Load += Form1_Load;
            groupBoxOne_REN.ResumeLayout(false);
            groupBoxOne_REN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOne_REN).EndInit();
            groupBoxTwo_REN.ResumeLayout(false);
            groupBoxTwo_REN.PerformLayout();
            groupBoxThree_REN.ResumeLayout(false);
            groupBoxThree_REN.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOne_REN;
        private TextBox textBoxOne_REN;
        private PictureBox pictureBoxOne_REN;
        private GroupBox groupBoxTwo_REN;
        private TextBox textBoxA_REN;
        private GroupBox groupBoxThree_REN;
        private TextBox textBoxRes_REN;
        private CheckBox checkBox1;
        private TextBox textBoxIntA_REN;
        private TextBox textBoxFinalResult_REN;
        private ContextMenuStrip contextMenuStrip1;
        private Button buttonHelp;
        private Button buttonDone;
    }
}
