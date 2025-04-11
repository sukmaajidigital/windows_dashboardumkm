namespace windows_test
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSidebarCustomer = new Button();
            panelSidebar = new Panel();
            btnSidebarKategori = new Button();
            panelMain = new Panel();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // btnSidebarCustomer
            // 
            btnSidebarCustomer.Location = new Point(12, 115);
            btnSidebarCustomer.Name = "btnSidebarCustomer";
            btnSidebarCustomer.Size = new Size(171, 39);
            btnSidebarCustomer.TabIndex = 1;
            btnSidebarCustomer.Text = "Customer";
            btnSidebarCustomer.UseVisualStyleBackColor = true;
            btnSidebarCustomer.Click += btnSidebarCustomer_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.Controls.Add(btnSidebarCustomer);
            panelSidebar.Controls.Add(btnSidebarKategori);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.MaximumSize = new Size(200, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(200, 670);
            panelSidebar.TabIndex = 4;
            // 
            // btnSidebarKategori
            // 
            btnSidebarKategori.Location = new Point(12, 68);
            btnSidebarKategori.Name = "btnSidebarKategori";
            btnSidebarKategori.Size = new Size(171, 41);
            btnSidebarKategori.TabIndex = 0;
            btnSidebarKategori.Text = "Kategori Customer";
            btnSidebarKategori.UseVisualStyleBackColor = true;
            btnSidebarKategori.Click += btnSidebarKategori_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(200, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1060, 670);
            panelMain.TabIndex = 5;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 670);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Name = "Main";
            Text = "Form1";
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSidebarCustomer;
        private Panel panelSidebar;
        private Button btnSidebarKategori;
        private Panel panelMain;
    }
}