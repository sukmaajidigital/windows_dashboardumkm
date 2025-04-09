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
    public partial class FormEditKategori : Form
    {

        private int kategoriId;

        public FormEditKategori(int id, string namaKategori)
        {
            InitializeComponent();
            kategoriId = id;
            txtEditNamaKategori.Text = namaKategori;
        }

        private void txtEditNamaKategori_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Menghindari bunyi "ding" saat tekan enter

                string namaBaru = txtEditNamaKategori.Text.Trim();

                if (string.IsNullOrEmpty(namaBaru))
                {
                    MessageBox.Show("Nama kategori tidak boleh kosong.");
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.GetConnectionString()))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE customer_kategoris SET nama_kategori = @nama WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@nama", namaBaru);
                        cmd.Parameters.AddWithValue("@id", kategoriId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Kategori berhasil diupdate!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal update data: " + ex.Message);
                    }
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                this.Close();
            }
        }

        private void groupFormInput_Enter(object sender, EventArgs e)
        {

        }
    }
}
