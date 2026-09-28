namespace Sinav_Formu
{
    partial class Form1
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
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            OgrenciAdi = new Label();
            SınıfMevcud = new Button();
            button2 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            numericUpDown1.Location = new Point(346, 5);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(46, 39);
            numericUpDown1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Miriam CLM", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 177);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(1, 9);
            label1.Name = "label1";
            label1.Size = new Size(339, 32);
            label1.TabIndex = 1;
            label1.Text = "Sınıf Mevcudunu Giriniz -->";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(1, 245);
            button1.Name = "button1";
            button1.Size = new Size(253, 44);
            button1.TabIndex = 2;
            button1.Text = "Listeye Aktar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(listBox1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.PeachPuff;
            groupBox1.Location = new Point(435, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 406);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenciler";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(6, 28);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(327, 361);
            listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(1, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 33);
            textBox1.TabIndex = 4;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // OgrenciAdi
            // 
            OgrenciAdi.AutoSize = true;
            OgrenciAdi.Font = new Font("Miriam CLM", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 177);
            OgrenciAdi.ForeColor = Color.Blue;
            OgrenciAdi.Location = new Point(1, 121);
            OgrenciAdi.Name = "OgrenciAdi";
            OgrenciAdi.Size = new Size(268, 32);
            OgrenciAdi.TabIndex = 5;
            OgrenciAdi.Text = "Öğrenci Adını Giriniz ";
            OgrenciAdi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SınıfMevcud
            // 
            SınıfMevcud.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            SınıfMevcud.Location = new Point(12, 44);
            SınıfMevcud.Name = "SınıfMevcud";
            SınıfMevcud.Size = new Size(179, 37);
            SınıfMevcud.TabIndex = 6;
            SınıfMevcud.Text = "Mevcudu Onayla";
            SınıfMevcud.UseVisualStyleBackColor = true;
            SınıfMevcud.Click += SınıfMevcud_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1, 415);
            button2.Name = "button2";
            button2.Size = new Size(141, 34);
            button2.TabIndex = 7;
            button2.Text = "Yeniden Başlat";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Segoe UI", 21.75F);
            radioButton1.Location = new Point(1, 195);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(103, 44);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Erkek";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 21.75F);
            radioButton2.Location = new Point(147, 195);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(107, 44);
            radioButton2.TabIndex = 9;
            radioButton2.Text = "Kadın";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button2);
            Controls.Add(SınıfMevcud);
            Controls.Add(OgrenciAdi);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenci Sınav Formu";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label label1;
        private Button button1;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private TextBox textBox1;
        private Label OgrenciAdi;
        private Button SınıfMevcud;
        private Button button2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}
