namespace DataNilaiMahasiswa
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tbx_tugasabsen = new TextBox();
            tbx_uts = new TextBox();
            tbx_uas = new TextBox();
            tbx_nilaiakhir = new TextBox();
            tbx_grade = new TextBox();
            btn_proses = new Button();
            btn_clear = new Button();
            btn_keluar = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 20);
            label1.Name = "label1";
            label1.Size = new Size(304, 32);
            label1.TabIndex = 0;
            label1.Text = "DATA NILAI MAHASISWA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 40);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "INPUT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 144);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 2;
            label3.Text = "Tugas + Absen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 198);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 3;
            label4.Text = "UTS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 251);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 4;
            label5.Text = "UAS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(514, 40);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 5;
            label6.Text = "INPUT";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(515, 141);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 6;
            label7.Text = "Nilai Akhir";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(515, 195);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 7;
            label8.Text = "Grade";
            // 
            // tbx_tugasabsen
            // 
            tbx_tugasabsen.Location = new Point(172, 140);
            tbx_tugasabsen.Margin = new Padding(3, 4, 3, 4);
            tbx_tugasabsen.Name = "tbx_tugasabsen";
            tbx_tugasabsen.Size = new Size(228, 27);
            tbx_tugasabsen.TabIndex = 8;
            // 
            // tbx_uts
            // 
            tbx_uts.Location = new Point(172, 194);
            tbx_uts.Margin = new Padding(3, 4, 3, 4);
            tbx_uts.Name = "tbx_uts";
            tbx_uts.Size = new Size(228, 27);
            tbx_uts.TabIndex = 9;
            // 
            // tbx_uas
            // 
            tbx_uas.Location = new Point(172, 247);
            tbx_uas.Margin = new Padding(3, 4, 3, 4);
            tbx_uas.Name = "tbx_uas";
            tbx_uas.Size = new Size(228, 27);
            tbx_uas.TabIndex = 10;
            // 
            // tbx_nilaiakhir
            // 
            tbx_nilaiakhir.Location = new Point(607, 137);
            tbx_nilaiakhir.Margin = new Padding(3, 4, 3, 4);
            tbx_nilaiakhir.Name = "tbx_nilaiakhir";
            tbx_nilaiakhir.ReadOnly = true;
            tbx_nilaiakhir.Size = new Size(228, 27);
            tbx_nilaiakhir.TabIndex = 11;
            // 
            // tbx_grade
            // 
            tbx_grade.Location = new Point(607, 191);
            tbx_grade.Margin = new Padding(3, 4, 3, 4);
            tbx_grade.Name = "tbx_grade";
            tbx_grade.ReadOnly = true;
            tbx_grade.Size = new Size(228, 27);
            tbx_grade.TabIndex = 12;
            // 
            // btn_proses
            // 
            btn_proses.Location = new Point(493, 307);
            btn_proses.Margin = new Padding(3, 4, 3, 4);
            btn_proses.Name = "btn_proses";
            btn_proses.Size = new Size(86, 40);
            btn_proses.TabIndex = 13;
            btn_proses.Text = "Proses";
            btn_proses.UseVisualStyleBackColor = true;
            btn_proses.Click += btn_proses_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(607, 307);
            btn_clear.Margin = new Padding(3, 4, 3, 4);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(86, 40);
            btn_clear.TabIndex = 14;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_keluar
            // 
            btn_keluar.Location = new Point(722, 307);
            btn_keluar.Margin = new Padding(3, 4, 3, 4);
            btn_keluar.Name = "btn_keluar";
            btn_keluar.Size = new Size(86, 40);
            btn_keluar.TabIndex = 15;
            btn_keluar.Text = "Keluar";
            btn_keluar.UseVisualStyleBackColor = true;
            btn_keluar.Click += btn_keluar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(34, 27);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 73);
            panel1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(914, 467);
            Controls.Add(panel1);
            Controls.Add(btn_keluar);
            Controls.Add(btn_clear);
            Controls.Add(btn_proses);
            Controls.Add(tbx_grade);
            Controls.Add(tbx_nilaiakhir);
            Controls.Add(tbx_uas);
            Controls.Add(tbx_uts);
            Controls.Add(tbx_tugasabsen);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Nilai Mahasiswa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tbx_tugasabsen;
        private TextBox tbx_uts;
        private TextBox tbx_uas;
        private TextBox tbx_nilaiakhir;
        private TextBox tbx_grade;
        private Button btn_proses;
        private Button btn_clear;
        private Button btn_keluar;
        private Panel panel1;
    }
}