namespace windows_test
{
    partial class FormEditKategori
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
            txtEditNamaKategori = new TextBox();
            labelEditNamaKategori = new Label();

            groupFormInput.SuspendLayout();
            SuspendLayout();

            // 
            // groupFormInput
            // 
            groupFormInput.Controls.Add(txtEditNamaKategori);
            groupFormInput.Controls.Add(labelEditNamaKategori);
            groupFormInput.Location = new Point(12, 12);
            groupFormInput.Name = "groupFormInput";
            groupFormInput.Size = new Size(457, 80);
            groupFormInput.TabIndex = 1;
            groupFormInput.TabStop = false;
            groupFormInput.Text = "Edit Kategori";
            groupFormInput.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            groupFormInput.BackColor = Color.WhiteSmoke;

            // 
            // labelEditNamaKategori
            // 
            labelEditNamaKategori.AutoSize = true;
            labelEditNamaKategori.Location = new Point(24, 35);
            labelEditNamaKategori.Name = "labelEditNamaKategori";
            labelEditNamaKategori.Size = new Size(102, 19);
            labelEditNamaKategori.TabIndex = 0;
            labelEditNamaKategori.Text = "Nama Kategori:";
            labelEditNamaKategori.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            // 
            // txtEditNamaKategori
            // 
            txtEditNamaKategori.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            txtEditNamaKategori.Location = new Point(132, 32);
            txtEditNamaKategori.Name = "txtEditNamaKategori";
            txtEditNamaKategori.Size = new Size(289, 25);
            txtEditNamaKategori.TabIndex = 1;
            txtEditNamaKategori.PlaceholderText = "Edit nama kategori...";
            txtEditNamaKategori.KeyDown += txtEditNamaKategori_KeyDown;

            // 
            // FormEditKategori
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 110);
            Controls.Add(groupFormInput);
            Name = "FormEditKategori";
            Text = "Edit Kategori";
            StartPosition = FormStartPosition.CenterParent;
            BackColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            KeyPreview = true;

            groupFormInput.ResumeLayout(false);
            groupFormInput.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private GroupBox groupFormInput;
        private TextBox txtEditNamaKategori;
        private Label labelEditNamaKategori;
    }
}