using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms.VisualStyles;

namespace windows_test
{
    public partial class DataCustomer : Form
    {

        public DataCustomer()
        {
            InitializeComponent();
            LoadDataCustomer();
        }
        private DataTable customerTable;
        private void LoadUserControl(UserControl control)
        {
            panelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMain.Controls.Add(control);
        }
        private void LoadDataCustomer()
        {
            string connectionString = DatabaseHelper.GetConnectionString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT id, nama_customer, telepon, alamat, email, history_pembelian 
                             FROM customers 
                             ORDER BY id DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    customerTable = new DataTable();
                    adapter.Fill(customerTable);

                    // Tambahkan kolom nomor urut manual
                    customerTable.Columns.Add("No", typeof(int));
                    for (int i = 0; i < customerTable.Rows.Count; i++)
                    {
                        customerTable.Rows[i]["No"] = i + 1;
                    }
                    customerTable.Columns["No"].SetOrdinal(0);

                    tableDataCustomer.DataSource = customerTable;
                    tableDataCustomer.Columns["id"].Visible = false; // Sembunyikan kolom id

                    // (Opsional) Atur header kolom agar lebih rapi ditampilkan
                    tableDataCustomer.Columns["nama_customer"].HeaderText = "Nama";
                    tableDataCustomer.Columns["telepon"].HeaderText = "Telepon";
                    tableDataCustomer.Columns["alamat"].HeaderText = "Alamat";
                    tableDataCustomer.Columns["email"].HeaderText = "Email";
                    tableDataCustomer.Columns["history_pembelian"].HeaderText = "Riwayat";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal load data: " + ex.Message);
                }
            }

            // Tambahkan kolom aksi jika belum ada
            if (!tableDataCustomer.Columns.Contains("actionColumn"))
            {
                DataGridViewTextBoxColumn actionColumn = new DataGridViewTextBoxColumn();
                actionColumn.Name = "actionColumn";
                actionColumn.HeaderText = "Aksi";
                actionColumn.ReadOnly = true;
                actionColumn.Width = 120;
                tableDataCustomer.Columns.Add(actionColumn);
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == tableDataCustomer.Columns["actionColumn"].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Ukuran tombol
                int buttonWidth = 50;
                int buttonHeight = 20;

                // Lokasi tombol Edit
                Rectangle editButtonRect = new Rectangle(
                    e.CellBounds.Left + 10,
                    e.CellBounds.Top + (e.CellBounds.Height - buttonHeight) / 2,
                    buttonWidth, buttonHeight
                );

                // Lokasi tombol Delete
                Rectangle deleteButtonRect = new Rectangle(
                    e.CellBounds.Left + 10 + buttonWidth + 10,
                    e.CellBounds.Top + (e.CellBounds.Height - buttonHeight) / 2,
                    buttonWidth, buttonHeight
                );

                ButtonRenderer.DrawButton(e.Graphics, editButtonRect, "Edit", tableDataCustomer.Font, false, PushButtonState.Default);
                ButtonRenderer.DrawButton(e.Graphics, deleteButtonRect, "Delete", tableDataCustomer.Font, false, PushButtonState.Default);

                e.Handled = true;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && tableDataCustomer.Columns[e.ColumnIndex].Name == "actionColumn")
            {
                int id = Convert.ToInt32(tableDataCustomer.Rows[e.RowIndex].Cells["id"].Value);

                // Hitung posisi klik relatif
                var cellRect = tableDataCustomer.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                int clickX = tableDataCustomer.PointToClient(Cursor.Position).X - cellRect.X;

                if (clickX < 60) // Klik Edit
                {
                    FormEditCustomer editForm = new FormEditCustomer(id);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadDataCustomer(); // Refresh data setelah edit
                    }
                }
                else if (clickX < 120) // Klik Delete
                {
                    DialogResult result = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.GetConnectionString()))
                        {
                            try
                            {
                                conn.Open();
                                string query = "DELETE FROM customers WHERE id = @id";
                                MySqlCommand cmd = new MySqlCommand(query, conn);
                                cmd.Parameters.AddWithValue("@id", id);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Data berhasil dihapus!");
                                LoadDataCustomer();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Gagal menghapus data: " + ex.Message);
                            }
                        }
                    }
                }
            }
        }
        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            FormCreateCustomer createForm = new FormCreateCustomer(); // pakai tanda ()
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                LoadDataCustomer(); // Refresh tabel kalau form create berhasil
            }
        }
        private void groupFormInput_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if (customerTable != null)
            {
                DataView dv = customerTable.DefaultView;
                dv.RowFilter = $"nama_customer LIKE '%{txtSearchCustomer.Text}%'"; // filter berdasarkan isi textbox
                tableDataCustomer.DataSource = dv;
            }
        }

        private void btnSidebarCustomer_Click(object sender, EventArgs e)
        {
            LoadUserControl(new CustomerControl());
        }

    }
}



