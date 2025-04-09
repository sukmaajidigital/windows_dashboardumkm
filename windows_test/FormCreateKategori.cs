using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace windows_test
{
    public partial class FormCreateKategori : Form
    {
        public FormCreateKategori()
        {
            InitializeComponent();
        }
        private void txtCreateNamaKategori_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Mencegah bunyi "ding"
                SimpanKategori();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                this.Close();
            }
        }
        private void SimpanKategori()
        {
            string namaKategori = txtCreateNamaKategori.Text.Trim();

            if (string.IsNullOrEmpty(namaKategori))
            {
                MessageBox.Show("Nama kategori tidak boleh kosong.");
                return;
            }

            string connectionString = DatabaseHelper.GetConnectionString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO customer_kategoris (nama_kategori) VALUES (@namaKategori)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@namaKategori", namaKategori);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kategori berhasil disimpan!");

                    this.DialogResult = DialogResult.OK; // <-- tambah ini
                    this.Close();                        // <-- dan ini
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }

        private void groupFormInput_Enter(object sender, EventArgs e)
        {

        }

        private void txtCreateNamaKategori_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCreateNamaKategori_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
