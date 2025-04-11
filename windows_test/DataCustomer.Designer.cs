namespace windows_test
{
    partial class DataCustomer
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
            txtSearchCustomer = new TextBox();
            groupFormInput = new GroupBox();
            btnCreateCustomer = new Button();
            tableDataCustomer = new DataGridView();
            panelMain = new Panel();
            groupFormInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableDataCustomer).BeginInit();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Location = new Point(18, 104);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.PlaceholderText = "Cari Customer... ";
            txtSearchCustomer.Size = new Size(300, 23);
            txtSearchCustomer.TabIndex = 0;
            txtSearchCustomer.TextChanged += txtSearchCustomer_TextChanged;
            // 
            // groupFormInput
            // 
            groupFormInput.BackColor = Color.WhiteSmoke;
            groupFormInput.Controls.Add(btnCreateCustomer);
            groupFormInput.Font = new Font("Segoe UI", 10F);
            groupFormInput.Location = new Point(18, 12);
            groupFormInput.Name = "groupFormInput";
            groupFormInput.Size = new Size(755, 86);
            groupFormInput.TabIndex = 0;
            groupFormInput.TabStop = false;
            groupFormInput.Text = "Tambah Customer";
            // 
            // btnCreateCustomer
            // 
            btnCreateCustomer.BackColor = Color.SteelBlue;
            btnCreateCustomer.FlatAppearance.BorderSize = 0;
            btnCreateCustomer.FlatStyle = FlatStyle.Flat;
            btnCreateCustomer.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCreateCustomer.ForeColor = Color.White;
            btnCreateCustomer.Location = new Point(15, 25);
            btnCreateCustomer.Name = "btnCreateCustomer";
            btnCreateCustomer.Size = new Size(198, 40);
            btnCreateCustomer.TabIndex = 2;
            btnCreateCustomer.Text = "+ Buat Customer Baru";
            btnCreateCustomer.UseVisualStyleBackColor = false;
            btnCreateCustomer.Click += btnCreateCustomer_Click;
            // 
            // tableDataCustomer
            // 
            tableDataCustomer.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            tableDataCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            tableDataCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableDataCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableDataCustomer.BackgroundColor = Color.White;
            tableDataCustomer.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            tableDataCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            tableDataCustomer.DefaultCellStyle = dataGridViewCellStyle6;
            tableDataCustomer.EnableHeadersVisualStyles = false;
            tableDataCustomer.Location = new Point(18, 133);
            tableDataCustomer.Name = "tableDataCustomer";
            tableDataCustomer.RowHeadersVisible = false;
            tableDataCustomer.RowTemplate.Height = 35;
            tableDataCustomer.Size = new Size(1114, 483);
            tableDataCustomer.TabIndex = 0;
            tableDataCustomer.CellClick += dataGridView1_CellClick;
            tableDataCustomer.CellContentClick += dataGridView1_CellContentClick;
            tableDataCustomer.CellPainting += dataGridView1_CellPainting;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(tableDataCustomer);
            panelMain.Controls.Add(groupFormInput);
            panelMain.Controls.Add(txtSearchCustomer);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1166, 656);
            panelMain.TabIndex = 3;
            // 
            // DataCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1166, 656);
            Controls.Add(panelMain);
            Name = "DataCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Customer";
            groupFormInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableDataCustomer).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSearchCustomer;
        private GroupBox groupFormInput;
        private Button btnCreateCustomer;
        private DataGridView tableDataCustomer;
        private Panel panelMain;
    }
}
