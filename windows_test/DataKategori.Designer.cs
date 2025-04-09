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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupFormInput = new GroupBox();
            btnCreateKategori = new Button();
            dataGridView1 = new DataGridView();
            txtSearchKategori = new TextBox();
            groupFormInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupFormInput
            // 
            groupFormInput.BackColor = Color.WhiteSmoke;
            groupFormInput.Controls.Add(btnCreateKategori);
            groupFormInput.Font = new Font("Segoe UI", 10F);
            groupFormInput.Location = new Point(12, 12);
            groupFormInput.Name = "groupFormInput";
            groupFormInput.Size = new Size(740, 86);
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
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(12, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.Size = new Size(1142, 492);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // txtSearchKategori
            // 
            txtSearchKategori.Location = new Point(12, 104);
            txtSearchKategori.Name = "txtSearchKategori";
            txtSearchKategori.PlaceholderText = "Cari kategori... ";
            txtSearchKategori.Size = new Size(300, 23);
            txtSearchKategori.TabIndex = 0;
            txtSearchKategori.TextChanged += txtSearchKategori_TextChanged;
            // 
            // DataKategori
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1166, 656);
            Controls.Add(txtSearchKategori);
            Controls.Add(dataGridView1);
            Controls.Add(groupFormInput);
            Name = "DataKategori";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Kategori";
            groupFormInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private GroupBox groupFormInput;
        private DataGridView dataGridView1;
        private Button btnCreateKategori;
        private TextBox txtSearchKategori;
    }
}
