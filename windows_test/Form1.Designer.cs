namespace windows_test
{
    partial class Form1
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
            groupFormInput = new GroupBox();
            label1 = new Label();
            txtNamaKategori = new TextBox();
            groupFormInput.SuspendLayout();
            SuspendLayout();
            // 
            // groupFormInput
            // 
            groupFormInput.Controls.Add(txtNamaKategori);
            groupFormInput.Controls.Add(label1);
            groupFormInput.Location = new Point(12, 12);
            groupFormInput.Name = "groupFormInput";
            groupFormInput.Size = new Size(498, 86);
            groupFormInput.TabIndex = 0;
            groupFormInput.TabStop = false;
            groupFormInput.Text = "input form";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 33);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama Kategori";
            // 
            // txtNamaKategori
            // 
            txtNamaKategori.Location = new Point(132, 30);
            txtNamaKategori.Name = "txtNamaKategori";
            txtNamaKategori.Size = new Size(289, 23);
            txtNamaKategori.TabIndex = 1;
            txtNamaKategori.Text = "Nama Kategori";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupFormInput);
            Name = "Form1";
            Text = "test";
            groupFormInput.ResumeLayout(false);
            groupFormInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupFormInput;
        private Label label1;
        private TextBox txtNamaKategori;
    }
}
