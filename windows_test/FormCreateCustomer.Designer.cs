namespace windows_test
{
    partial class FormCreateCustomer
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
            groupFormInput = new GroupBox();
            txtCreateHistoryCustomer = new TextBox();
            label4 = new Label();
            txtCreateEmailCustomer = new TextBox();
            label3 = new Label();
            txtCreateAlamatCustomer = new TextBox();
            label2 = new Label();
            txtCreateTeleponCustomer = new TextBox();
            label1 = new Label();
            txtCreateNamaCustomer = new TextBox();
            labelCreateNamaCustomer = new Label();
            cmbKategoriCustomer = new ComboBox();
            label5 = new Label();
            groupFormInput.SuspendLayout();
            SuspendLayout();
            // 
            // groupFormInput
            // 
            groupFormInput.BackColor = Color.WhiteSmoke;
            groupFormInput.Controls.Add(label5);
            groupFormInput.Controls.Add(cmbKategoriCustomer);
            groupFormInput.Controls.Add(txtCreateHistoryCustomer);
            groupFormInput.Controls.Add(label4);
            groupFormInput.Controls.Add(txtCreateEmailCustomer);
            groupFormInput.Controls.Add(label3);
            groupFormInput.Controls.Add(txtCreateAlamatCustomer);
            groupFormInput.Controls.Add(label2);
            groupFormInput.Controls.Add(txtCreateTeleponCustomer);
            groupFormInput.Controls.Add(label1);
            groupFormInput.Controls.Add(txtCreateNamaCustomer);
            groupFormInput.Controls.Add(labelCreateNamaCustomer);
            groupFormInput.Font = new Font("Segoe UI", 10F);
            groupFormInput.Location = new Point(12, 12);
            groupFormInput.Name = "groupFormInput";
            groupFormInput.Size = new Size(457, 253);
            groupFormInput.TabIndex = 2;
            groupFormInput.TabStop = false;
            groupFormInput.Text = "Input Customer";
            // 
            // txtCreateHistoryCustomer
            // 
            txtCreateHistoryCustomer.Font = new Font("Segoe UI", 10F);
            txtCreateHistoryCustomer.Location = new Point(138, 190);
            txtCreateHistoryCustomer.Name = "txtCreateHistoryCustomer";
            txtCreateHistoryCustomer.PlaceholderText = "Masukkan nama Customer...  ..";
            txtCreateHistoryCustomer.Size = new Size(289, 25);
            txtCreateHistoryCustomer.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(12, 193);
            label4.Name = "label4";
            label4.Size = new Size(118, 19);
            label4.TabIndex = 8;
            label4.Text = "HistoryPembelian:";
            // 
            // txtCreateEmailCustomer
            // 
            txtCreateEmailCustomer.Font = new Font("Segoe UI", 10F);
            txtCreateEmailCustomer.Location = new Point(138, 159);
            txtCreateEmailCustomer.Name = "txtCreateEmailCustomer";
            txtCreateEmailCustomer.PlaceholderText = "Masukkan nama Customer...  ..";
            txtCreateEmailCustomer.Size = new Size(289, 25);
            txtCreateEmailCustomer.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 162);
            label3.Name = "label3";
            label3.Size = new Size(108, 19);
            label3.TabIndex = 6;
            label3.Text = "Email Customer:";
            // 
            // txtCreateAlamatCustomer
            // 
            txtCreateAlamatCustomer.Font = new Font("Segoe UI", 10F);
            txtCreateAlamatCustomer.Location = new Point(138, 128);
            txtCreateAlamatCustomer.Name = "txtCreateAlamatCustomer";
            txtCreateAlamatCustomer.PlaceholderText = "Masukkan nama Customer...  ..";
            txtCreateAlamatCustomer.Size = new Size(289, 25);
            txtCreateAlamatCustomer.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(55, 19);
            label2.TabIndex = 4;
            label2.Text = "Alamat:";
            // 
            // txtCreateTeleponCustomer
            // 
            txtCreateTeleponCustomer.Font = new Font("Segoe UI", 10F);
            txtCreateTeleponCustomer.Location = new Point(138, 97);
            txtCreateTeleponCustomer.Name = "txtCreateTeleponCustomer";
            txtCreateTeleponCustomer.PlaceholderText = "Masukkan telepon Customer...  ..";
            txtCreateTeleponCustomer.Size = new Size(289, 25);
            txtCreateTeleponCustomer.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 100);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 2;
            label1.Text = "Telepon:";
            // 
            // txtCreateNamaCustomer
            // 
            txtCreateNamaCustomer.Font = new Font("Segoe UI", 10F);
            txtCreateNamaCustomer.Location = new Point(138, 66);
            txtCreateNamaCustomer.Name = "txtCreateNamaCustomer";
            txtCreateNamaCustomer.PlaceholderText = "Masukkan nama Customer...  ..";
            txtCreateNamaCustomer.Size = new Size(289, 25);
            txtCreateNamaCustomer.TabIndex = 1;
            txtCreateNamaCustomer.TextChanged += txtCreateNamaCustomer_TextChanged_1;
            txtCreateNamaCustomer.KeyDown += txtCreateNamaCustomer_KeyDown;
            // 
            // labelCreateNamaCustomer
            // 
            labelCreateNamaCustomer.AutoSize = true;
            labelCreateNamaCustomer.Font = new Font("Segoe UI", 10F);
            labelCreateNamaCustomer.Location = new Point(12, 69);
            labelCreateNamaCustomer.Name = "labelCreateNamaCustomer";
            labelCreateNamaCustomer.Size = new Size(112, 19);
            labelCreateNamaCustomer.TabIndex = 0;
            labelCreateNamaCustomer.Text = "Nama Customer:";
            // 
            // cmbKategoriCustomer
            // 
            cmbKategoriCustomer.FormattingEnabled = true;
            cmbKategoriCustomer.Location = new Point(138, 24);
            cmbKategoriCustomer.Name = "cmbKategoriCustomer";
            cmbKategoriCustomer.Size = new Size(289, 25);
            cmbKategoriCustomer.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(12, 27);
            label5.Name = "label5";
            label5.Size = new Size(60, 19);
            label5.TabIndex = 11;
            label5.Text = "Kategori";
            // 
            // FormCreateCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(481, 277);
            Controls.Add(groupFormInput);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCreateCustomer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tambah Customer Baru";
            Load += FormCreateCustomer_Load;
            groupFormInput.ResumeLayout(false);
            groupFormInput.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private GroupBox groupFormInput;
        private TextBox txtCreateNamaCustomer;
        private Label labelCreateNamaCustomer;
        private TextBox txtCreateHistoryCustomer;
        private Label label4;
        private TextBox txtCreateEmailCustomer;
        private Label label3;
        private TextBox txtCreateAlamatCustomer;
        private Label label2;
        private TextBox txtCreateTeleponCustomer;
        private Label label1;
        private Label label5;
        private ComboBox cmbKategoriCustomer;
    }
}