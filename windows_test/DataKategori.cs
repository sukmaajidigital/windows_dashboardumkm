using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms.VisualStyles;

namespace windows_test
{
    public partial class DataKategori : Form
    {

        public DataKategori()
        {
            InitializeComponent();
            LoadDataKategori();
        }
        private DataTable kategoriTable;
        private void LoadUserControl(UserControl control)
        {
            panelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMain.Controls.Add(control);
        }
        private void LoadDataKategori()
        {
            string connectionString = DatabaseHelper.GetConnectionString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, nama_kategori FROM customer_kategoris ORDER BY id DESC";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    kategoriTable = new DataTable();
                    adapter.Fill(kategoriTable);

                    // Tambahkan kolom nomor urut manual
                    kategoriTable.Columns.Add("No", typeof(int));
                    for (int i = 0; i < kategoriTable.Rows.Count; i++)
                    {
                        kategoriTable.Rows[i]["No"] = i + 1;
                    }
                    kategoriTable.Columns["No"].SetOrdinal(0);

                    tableDataKategori.DataSource = kategoriTable;
                    tableDataKategori.Columns["id"].Visible = false; // Sembunyikan kolom id


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal load data: " + ex.Message);
                }
            }
            if (!tableDataKategori.Columns.Contains("actionColumn"))
            {
                DataGridViewTextBoxColumn actionColumn = new DataGridViewTextBoxColumn();
                actionColumn.Name = "actionColumn";
                actionColumn.HeaderText = "Aksi";
                actionColumn.ReadOnly = true;
                actionColumn.Width = 120; // Sesuaikan
                tableDataKategori.Columns.Add(actionColumn);
            }
        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == tableDataKategori.Columns["actionColumn"].Index && e.RowIndex >= 0)
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

                ButtonRenderer.DrawButton(e.Graphics, editButtonRect, "Edit", tableDataKategori.Font, false, PushButtonState.Default);
                ButtonRenderer.DrawButton(e.Graphics, deleteButtonRect, "Delete", tableDataKategori.Font, false, PushButtonState.Default);

                e.Handled = true;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && tableDataKategori.Columns[e.ColumnIndex].Name == "actionColumn")
            {
                int id = Convert.ToInt32(tableDataKategori.Rows[e.RowIndex].Cells["id"].Value);
                string namaKategori = tableDataKategori.Rows[e.RowIndex].Cells["nama_kategori"].Value.ToString();

                // Hitung posisi klik relatif
                var cellRect = tableDataKategori.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                int clickX = tableDataKategori.PointToClient(Cursor.Position).X - cellRect.X;

                if (clickX < 60) // Klik Edit
                {
                    FormEditKategori editForm = new FormEditKategori(id, namaKategori);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadDataKategori(); // Refresh data setelah edit
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
                                string query = "DELETE FROM customer_kategoris WHERE id = @id";
                                MySqlCommand cmd = new MySqlCommand(query, conn);
                                cmd.Parameters.AddWithValue("@id", id);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Data berhasil dihapus!");
                                LoadDataKategori();
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
        private void btnCreateKategori_Click(object sender, EventArgs e)
        {
            FormCreateKategori createForm = new FormCreateKategori(); // pakai tanda ()
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                LoadDataKategori(); // Refresh tabel kalau form create berhasil
            }
        }
        private void groupFormInput_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchKategori_TextChanged(object sender, EventArgs e)
        {
            if (kategoriTable != null)
            {
                DataView dv = kategoriTable.DefaultView;
                dv.RowFilter = $"nama_kategori LIKE '%{txtSearchKategori.Text}%'"; // filter berdasarkan isi textbox
                tableDataKategori.DataSource = dv;
            }
        }

        private void btnSidebarKategori_Click(object sender, EventArgs e)
        {
            LoadUserControl(new KategoriControl());
        }

        private void btnSidebarCustomer_Click(object sender, EventArgs e)
        {
            LoadUserControl(new CustomerControl());
        }
    }
}



