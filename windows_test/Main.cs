using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_test
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void LoadUserControl(UserControl control)
        {
            panelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMain.Controls.Add(control);
        }
        private void btnSidebarKategori_Click(object sender, EventArgs e)
        {
            LoadUserControl(new KategoriControl());
        }

        private void btnSidebarCustomer_Click(object sender, EventArgs e)
        {
            LoadUserControl(new CustomerControl()); // Pastikan kamu sudah buat UserControl ini
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
