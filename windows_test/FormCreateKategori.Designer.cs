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
            groupFormInput.Controls.Add(txtCreateNamaKategori);
            groupFormInput.Controls.Add(labelCreateNamaKategori);
            groupFormInput.Location = new Point(12, 12);
            groupFormInput.Name = "groupFormInput";
            groupFormInput.Size = new Size(457, 80);
            groupFormInput.TabIndex = 2;
            groupFormInput.TabStop = false;
            groupFormInput.Text = "Input Kategori";
            groupFormInput.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            groupFormInput.BackColor = Color.WhiteSmoke;

            // 
            // labelCreateNamaKategori
            // 
            labelCreateNamaKategori.AutoSize = true;
            labelCreateNamaKategori.Location = new Point(24, 35);
            labelCreateNamaKategori.Name = "labelCreateNamaKategori";
            labelCreateNamaKategori.Size = new Size(102, 19);
            labelCreateNamaKategori.TabIndex = 0;
            labelCreateNamaKategori.Text = "Nama Kategori:";
            labelCreateNamaKategori.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            // 
            // txtCreateNamaKategori
            // 
            txtCreateNamaKategori.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            txtCreateNamaKategori.Location = new Point(132, 32);
            txtCreateNamaKategori.Name = "txtCreateNamaKategori";
            txtCreateNamaKategori.Size = new Size(289, 25);
            txtCreateNamaKategori.TabIndex = 1;
            txtCreateNamaKategori.PlaceholderText = "Masukkan nama kategori...";
            txtCreateNamaKategori.KeyDown += txtCreateNamaKategori_KeyDown;

            // 
            // FormCreateKategori
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 110);
            Controls.Add(groupFormInput);
            Name = "FormCreateKategori";
            Text = "Tambah Kategori Baru";
            StartPosition = FormStartPosition.CenterParent;
            BackColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

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