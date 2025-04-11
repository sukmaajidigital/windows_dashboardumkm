using System.Windows.Forms;

namespace windows_test
{
    public partial class CustomerControl : UserControl
    {
        public CustomerControl()
        {
            InitializeComponent();

            // Inisialisasi form DataKategori sebagai UserControl
            DataCustomer customerForm = new DataCustomer();
            customerForm.TopLevel = false;
            customerForm.FormBorderStyle = FormBorderStyle.None;
            customerForm.Dock = DockStyle.Fill;
            this.Controls.Add(customerForm);
            customerForm.Show();
        }
    }
}
