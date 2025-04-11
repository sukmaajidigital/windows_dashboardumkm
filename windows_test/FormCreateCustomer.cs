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
    public partial class FormCreateCustomer : Form
    {
        public FormCreateCustomer()
        {
            InitializeComponent();
        }
        private void txtCreateNamaCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Mencegah bunyi "ding"
                SimpanCustomer();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                this.Close();
            }
        }
        private void SimpanCustomer()
        {
            string namaCustomer = txtCreateNamaCustomer.Text.Trim();
            string teleponCustomer = txtCreateTeleponCustomer.Text.Trim();
            string alamatCustomer = txtCreateAlamatCustomer.Text.Trim();
            string emailCustomer = txtCreateEmailCustomer.Text.Trim();
            string historyCustomer = txtCreateHistoryCustomer.Text.Trim();

            if (string.IsNullOrEmpty(namaCustomer))
            {
                MessageBox.Show("Nama Customer tidak boleh kosong.");
                return;
            }

            if (string.IsNullOrEmpty(teleponCustomer))
            {
                MessageBox.Show("Telepon Customer tidak boleh kosong.");
                return;
            }

            if (string.IsNullOrEmpty(alamatCustomer))
            {
                MessageBox.Show("Alamat Customer tidak boleh kosong.");
                return;
            }



            string connectionString = DatabaseHelper.GetConnectionString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO customers 
                        (nama_customer, telepon, alamat, email, history_pembelian) 
                        VALUES 
                        (@namaCustomer, @teleponCustomer, @alamatCustomer, @emailCustomer, @historyCustomer)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@namaCustomer", namaCustomer);
                    cmd.Parameters.AddWithValue("@teleponCustomer", teleponCustomer);
                    cmd.Parameters.AddWithValue("@alamatCustomer", alamatCustomer);
                    cmd.Parameters.AddWithValue("@emailCustomer", emailCustomer);
                    cmd.Parameters.AddWithValue("@historyCustomer", historyCustomer);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Customer berhasil disimpan!");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
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

        private void txtCreateNamaCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCreateNamaCustomer_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void FormCreateCustomer_Load(object sender, EventArgs e)
        {
            string connectionString = DatabaseHelper.GetConnectionString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, nama_kategori FROM customer_kategoris";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbKategoriCustomer.Items.Clear();

                    while (reader.Read())
                    {
                        cmbKategoriCustomer.Items.Add(new CustomerKategoriItem
                        {
                            Id = reader.GetInt32("id"),
                            Nama = reader.GetString("nama_kategori")
                        });
                    }

                    if (cmbKategoriCustomer.Items.Count > 0)
                        cmbKategoriCustomer.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat kategori: " + ex.Message);
                }
            }
        }
    }
}
