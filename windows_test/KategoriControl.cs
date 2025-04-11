using System.Windows.Forms;

namespace windows_test
{
    public partial class KategoriControl : UserControl
    {
        public KategoriControl()
        {
            InitializeComponent();

            // Inisialisasi form DataKategori sebagai UserControl
            DataKategori kategoriForm = new DataKategori();
            kategoriForm.TopLevel = false;
            kategoriForm.FormBorderStyle = FormBorderStyle.None;
            kategoriForm.Dock = DockStyle.Fill;
            this.Controls.Add(kategoriForm);
            kategoriForm.Show();
        }
    }
}
