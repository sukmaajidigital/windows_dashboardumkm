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
    public partial class FormEditCustomer : Form
    {

        private int CustomerId;

        public FormEditCustomer(int id)
        {
            InitializeComponent();
            CustomerId = id;
            // Muat kategori dulu
            LoadKategori();

            //// Ambil dan tampilkan data customer
            LoadCustomerData();
        }
        private void LoadKategori()
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat kategori: " + ex.Message);
                }
            }
        }
        private void LoadCustomerData()
        {
            string connectionString = DatabaseHelper.GetConnectionString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT * FROM customers WHERE id = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", CustomerId);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtEditNamaCustomer.Text = reader.IsDBNull(reader.GetOrdinal("nama_customer")) ? "" : reader.GetString("nama_customer");
                        txtCreateTeleponCustomer.Text = reader.IsDBNull(reader.GetOrdinal("telepon")) ? "" : reader.GetString("telepon");
                        txtCreateAlamatCustomer.Text = reader.IsDBNull(reader.GetOrdinal("alamat")) ? "" : reader.GetString("alamat");
                        txtCreateEmailCustomer.Text = reader.IsDBNull(reader.GetOrdinal("email")) ? "" : reader.GetString("email");
                        txtCreateHistoryCustomer.Text = reader.IsDBNull(reader.GetOrdinal("history_pembelian")) ? "" : reader.GetString("history_pembelian");


                        if (!reader.IsDBNull(reader.GetOrdinal("customer_kategori_id")))
                        {
                            int kategoriId = reader.GetInt32("customer_kategori_id");

                            // Pilih kategori yang sesuai di ComboBox
                            for (int i = 0; i < cmbKategoriCustomer.Items.Count; i++)
                            {
                                var item = (CustomerKategoriItem)cmbKategoriCustomer.Items[i];
                                if (item.Id == kategoriId)
                                {
                                    cmbKategoriCustomer.SelectedIndex = i;
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data customer: " + ex.Message);
                }
            }
        }

        private void txtEditNamaCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            string nama = txtEditNamaCustomer.Text.Trim();
            string telepon = txtCreateTeleponCustomer.Text.Trim();
            string alamat = txtCreateAlamatCustomer.Text.Trim();
            string email = txtCreateEmailCustomer.Text.Trim();
            string history = txtCreateHistoryCustomer.Text.Trim();
            int kategoriId = ((CustomerKategoriItem)cmbKategoriCustomer.SelectedItem).Id;

            string connectionString = DatabaseHelper.GetConnectionString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE customers 
                             SET nama_customer = @nama, 
                                 telepon = @telepon,
                                 alamat = @alamat,
                                 email = @email,
                                 history_pembelian = @history,
                                 customer_kategori_id = @kategoriId
                             WHERE id = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@telepon", telepon);
                    cmd.Parameters.AddWithValue("@alamat", alamat);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@history", history);
                    cmd.Parameters.AddWithValue("@kategoriId", kategoriId);
                    cmd.Parameters.AddWithValue("@id", CustomerId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Customer berhasil diperbarui!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan perubahan: " + ex.Message);
                }
            }
        }

        private void FormEditCustomer_Load(object sender, EventArgs e)
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
