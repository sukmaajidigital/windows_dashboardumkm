namespace windows_test
{
    partial class DataKategori
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            txtSearchKategori = new TextBox();
            groupFormInput = new GroupBox();
            btnCreateKategori = new Button();
            tableDataKategori = new DataGridView();
            panelMain = new Panel();
            groupFormInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableDataKategori).BeginInit();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearchKategori
            // 
            txtSearchKategori.Location = new Point(18, 104);
            txtSearchKategori.Name = "txtSearchKategori";
            txtSearchKategori.PlaceholderText = "Cari kategori... ";
            txtSearchKategori.Size = new Size(300, 23);
            txtSearchKategori.TabIndex = 0;
            txtSearchKategori.TextChanged += txtSearchKategori_TextChanged;
            // 
            // groupFormInput
            // 
            groupFormInput.BackColor = Color.WhiteSmoke;
            groupFormInput.Controls.Add(btnCreateKategori);
            groupFormInput.Font = new Font("Segoe UI", 10F);
            groupFormInput.Location = new Point(18, 12);
            groupFormInput.Name = "groupFormInput";
            groupFormInput.Size = new Size(755, 86);
            groupFormInput.TabIndex = 0;
            groupFormInput.TabStop = false;
            groupFormInput.Text = "Tambah Kategori";
            // 
            // btnCreateKategori
            // 
            btnCreateKategori.BackColor = Color.SteelBlue;
            btnCreateKategori.FlatAppearance.BorderSize = 0;
            btnCreateKategori.FlatStyle = FlatStyle.Flat;
            btnCreateKategori.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCreateKategori.ForeColor = Color.White;
            btnCreateKategori.Location = new Point(15, 25);
            btnCreateKategori.Name = "btnCreateKategori";
            btnCreateKategori.Size = new Size(198, 40);
            btnCreateKategori.TabIndex = 2;
            btnCreateKategori.Text = "+ Buat Kategori Baru";
            btnCreateKategori.UseVisualStyleBackColor = false;
            btnCreateKategori.Click += btnCreateKategori_Click;
            // 
            // tableDataKategori
            // 
            tableDataKategori.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            tableDataKategori.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            tableDataKategori.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableDataKategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableDataKategori.BackgroundColor = Color.White;
            tableDataKategori.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            tableDataKategori.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            tableDataKategori.DefaultCellStyle = dataGridViewCellStyle6;
            tableDataKategori.EnableHeadersVisualStyles = false;
            tableDataKategori.Location = new Point(18, 133);
            tableDataKategori.Name = "tableDataKategori";
            tableDataKategori.RowHeadersVisible = false;
            tableDataKategori.RowTemplate.Height = 35;
            tableDataKategori.Size = new Size(1114, 483);
            tableDataKategori.TabIndex = 0;
            tableDataKategori.CellClick += dataGridView1_CellClick;
            tableDataKategori.CellContentClick += dataGridView1_CellContentClick;
            tableDataKategori.CellPainting += dataGridView1_CellPainting;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(tableDataKategori);
            panelMain.Controls.Add(groupFormInput);
            panelMain.Controls.Add(txtSearchKategori);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1166, 656);
            panelMain.TabIndex = 3;
            // 
            // DataKategori
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1166, 656);
            Controls.Add(panelMain);
            Name = "DataKategori";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Kategori";
            groupFormInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableDataKategori).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSearchKategori;
        private GroupBox groupFormInput;
        private Button btnCreateKategori;
        private DataGridView tableDataKategori;
        private Panel panelMain;
    }
}
