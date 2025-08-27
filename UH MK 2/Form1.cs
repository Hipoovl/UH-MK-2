using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataNilaiMahasiswa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_proses_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi input kosong
                if (string.IsNullOrWhiteSpace(tbx_tugasabsen.Text) ||
                    string.IsNullOrWhiteSpace(tbx_uts.Text) ||
                    string.IsNullOrWhiteSpace(tbx_uas.Text))
                {
                    MessageBox.Show("Mohon isi semua field input!", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Konversi input ke double
                double tugasAbsen = Convert.ToDouble(tbx_tugasabsen.Text);
                double uts = Convert.ToDouble(tbx_uts.Text);
                double uas = Convert.ToDouble(tbx_uas.Text);

                // Validasi rentang nilai (0-100)
                if (tugasAbsen < 0 || tugasAbsen > 100 ||
                    uts < 0 || uts > 100 ||
                    uas < 0 || uas > 100)
                {
                    MessageBox.Show("Nilai harus dalam rentang 0-100!", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hitung nilai akhir dengan bobot:
                // Tugas + Absen: 30%
                // UTS: 35%
                // UAS: 35%
                double nilaiAkhir = (tugasAbsen * 0.3) + (uts * 0.35) + (uas * 0.35);

                // Tentukan grade berdasarkan nilai akhir
                string grade;
                if (nilaiAkhir >= 85)
                    grade = "A";
                else if (nilaiAkhir >= 70)
                    grade = "B";
                else if (nilaiAkhir >= 60)
                    grade = "C";
                else if (nilaiAkhir >= 50)
                    grade = "D";
                else
                    grade = "E";

                // Tampilkan hasil
                tbx_nilaiakhir.Text = nilaiAkhir.ToString("F2");
                tbx_grade.Text = grade;
            }
            catch (FormatException)
            {
                MessageBox.Show("Input harus berupa angka!", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // Bersihkan semua textbox
            tbx_tugasabsen.Clear();
            tbx_uts.Clear();
            tbx_uas.Clear();
            tbx_nilaiakhir.Clear();
            tbx_grade.Clear();

            // Set focus ke textbox pertama
            tbx_tugasabsen.Focus();
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            // Tampilkan dialog konfirmasi keluar
            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin keluar dari aplikasi?",
                "Konfirmasi Keluar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}