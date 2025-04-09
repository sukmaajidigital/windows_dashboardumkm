namespace windows_test
{
    partial class FormCreateKategori
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
            txtCreateNamaKategori = new TextBox();
            labelCreateNamaKategori = new Label();
            groupFormInput.SuspendLayout();
            SuspendLayout();
            // 
            // groupFormInput
            // 
            groupFormInput.BackColor = Color.WhiteSmoke;
            groupFormInput.Controls.Add(txtCreateNamaKategori);
            groupFormInput.Controls.Add(labelCreateNamaKategori);
            groupFormInput.Font = new Font("Segoe UI", 10F);
            groupFormInput.Location = new Point(12, 12);
            groupFormInput.Name = "groupFormInput";
            groupFormInput.Size = new Size(457, 80);
            groupFormInput.TabIndex = 2;
            groupFormInput.TabStop = false;
            groupFormInput.Text = "Input Kategori";
            // 
            // txtCreateNamaKategori
            // 
            txtCreateNamaKategori.Font = new Font("Segoe UI", 10F);
            txtCreateNamaKategori.Location = new Point(132, 32);
            txtCreateNamaKategori.Name = "txtCreateNamaKategori";
            txtCreateNamaKategori.PlaceholderText = "Masukkan nama kategori...  ..";
            txtCreateNamaKategori.Size = new Size(289, 25);
            txtCreateNamaKategori.TabIndex = 1;
            txtCreateNamaKategori.TextChanged += txtCreateNamaKategori_TextChanged_1;
            txtCreateNamaKategori.KeyDown += txtCreateNamaKategori_KeyDown;
            // 
            // labelCreateNamaKategori
            // 
            labelCreateNamaKategori.AutoSize = true;
            labelCreateNamaKategori.Font = new Font("Segoe UI", 10F);
            labelCreateNamaKategori.Location = new Point(24, 35);
            labelCreateNamaKategori.Name = "labelCreateNamaKategori";
            labelCreateNamaKategori.Size = new Size(103, 19);
            labelCreateNamaKategori.TabIndex = 0;
            labelCreateNamaKategori.Text = "Nama Kategori:";
            // 
            // FormCreateKategori
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(481, 110);
            Controls.Add(groupFormInput);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCreateKategori";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tambah Kategori Baru";
            groupFormInput.ResumeLayout(false);
            groupFormInput.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private GroupBox groupFormInput;
        private TextBox txtCreateNamaKategori;
        private Label labelCreateNamaKategori;
    }
}