namespace TestApp
{
    partial class Test_frm
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
            this.Qr_Box = new System.Windows.Forms.PictureBox();
            this.Gent_but = new System.Windows.Forms.Button();
            this.InfoGBox = new System.Windows.Forms.GroupBox();
            this.Tax_txt = new System.Windows.Forms.TextBox();
            this.Tax_lbl = new System.Windows.Forms.Label();
            this.Time_val = new System.Windows.Forms.DateTimePicker();
            this.Time_lbl = new System.Windows.Forms.Label();
            this.Invoice_txt = new System.Windows.Forms.TextBox();
            this.Invoice_lbl = new System.Windows.Forms.Label();
            this.Vat_txt = new System.Windows.Forms.TextBox();
            this.VAT_lbl = new System.Windows.Forms.Label();
            this.Seller_txt = new System.Windows.Forms.TextBox();
            this.Seller_lbl = new System.Windows.Forms.Label();
            this.Hex_txt = new System.Windows.Forms.TextBox();
            this.Base64txt = new System.Windows.Forms.TextBox();
            this.Hex_lbl = new System.Windows.Forms.Label();
            this.Base64_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Qr_Box)).BeginInit();
            this.InfoGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Qr_Box
            // 
            this.Qr_Box.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Qr_Box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Qr_Box.Location = new System.Drawing.Point(350, 12);
            this.Qr_Box.Name = "Qr_Box";
            this.Qr_Box.Size = new System.Drawing.Size(250, 250);
            this.Qr_Box.TabIndex = 0;
            this.Qr_Box.TabStop = false;
            // 
            // Gent_but
            // 
            this.Gent_but.Location = new System.Drawing.Point(12, 239);
            this.Gent_but.Name = "Gent_but";
            this.Gent_but.Size = new System.Drawing.Size(326, 23);
            this.Gent_but.TabIndex = 1;
            this.Gent_but.Text = "Generate";
            this.Gent_but.UseVisualStyleBackColor = true;
            this.Gent_but.Click += new System.EventHandler(this.Gent_but_Click);
            // 
            // InfoGBox
            // 
            this.InfoGBox.Controls.Add(this.Tax_txt);
            this.InfoGBox.Controls.Add(this.Tax_lbl);
            this.InfoGBox.Controls.Add(this.Time_val);
            this.InfoGBox.Controls.Add(this.Time_lbl);
            this.InfoGBox.Controls.Add(this.Invoice_txt);
            this.InfoGBox.Controls.Add(this.Invoice_lbl);
            this.InfoGBox.Controls.Add(this.Vat_txt);
            this.InfoGBox.Controls.Add(this.VAT_lbl);
            this.InfoGBox.Controls.Add(this.Seller_txt);
            this.InfoGBox.Controls.Add(this.Seller_lbl);
            this.InfoGBox.Location = new System.Drawing.Point(12, 12);
            this.InfoGBox.Name = "InfoGBox";
            this.InfoGBox.Size = new System.Drawing.Size(332, 210);
            this.InfoGBox.TabIndex = 2;
            this.InfoGBox.TabStop = false;
            this.InfoGBox.Text = "Info";
            // 
            // Tax_txt
            // 
            this.Tax_txt.Location = new System.Drawing.Point(88, 181);
            this.Tax_txt.Name = "Tax_txt";
            this.Tax_txt.Size = new System.Drawing.Size(238, 20);
            this.Tax_txt.TabIndex = 5;
            this.Tax_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tax_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberCrtl);
            // 
            // Tax_lbl
            // 
            this.Tax_lbl.AutoSize = true;
            this.Tax_lbl.Location = new System.Drawing.Point(7, 188);
            this.Tax_lbl.Name = "Tax_lbl";
            this.Tax_lbl.Size = new System.Drawing.Size(25, 13);
            this.Tax_lbl.TabIndex = 8;
            this.Tax_lbl.Text = "Tax";
            // 
            // Time_val
            // 
            this.Time_val.Location = new System.Drawing.Point(88, 99);
            this.Time_val.Name = "Time_val";
            this.Time_val.Size = new System.Drawing.Size(238, 20);
            this.Time_val.TabIndex = 3;
            // 
            // Time_lbl
            // 
            this.Time_lbl.AutoSize = true;
            this.Time_lbl.Location = new System.Drawing.Point(10, 104);
            this.Time_lbl.Name = "Time_lbl";
            this.Time_lbl.Size = new System.Drawing.Size(30, 13);
            this.Time_lbl.TabIndex = 6;
            this.Time_lbl.Text = "Time";
            // 
            // Invoice_txt
            // 
            this.Invoice_txt.Location = new System.Drawing.Point(88, 140);
            this.Invoice_txt.Name = "Invoice_txt";
            this.Invoice_txt.Size = new System.Drawing.Size(238, 20);
            this.Invoice_txt.TabIndex = 4;
            this.Invoice_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Invoice_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberCrtl);
            // 
            // Invoice_lbl
            // 
            this.Invoice_lbl.AutoSize = true;
            this.Invoice_lbl.Location = new System.Drawing.Point(7, 146);
            this.Invoice_lbl.Name = "Invoice_lbl";
            this.Invoice_lbl.Size = new System.Drawing.Size(42, 13);
            this.Invoice_lbl.TabIndex = 4;
            this.Invoice_lbl.Text = "Invoice";
            // 
            // Vat_txt
            // 
            this.Vat_txt.Location = new System.Drawing.Point(88, 58);
            this.Vat_txt.MaxLength = 15;
            this.Vat_txt.Name = "Vat_txt";
            this.Vat_txt.Size = new System.Drawing.Size(238, 20);
            this.Vat_txt.TabIndex = 2;
            this.Vat_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Vat_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitCtrl);
            // 
            // VAT_lbl
            // 
            this.VAT_lbl.AutoSize = true;
            this.VAT_lbl.Location = new System.Drawing.Point(7, 62);
            this.VAT_lbl.Name = "VAT_lbl";
            this.VAT_lbl.Size = new System.Drawing.Size(54, 13);
            this.VAT_lbl.TabIndex = 2;
            this.VAT_lbl.Text = "VAT Reg.";
            // 
            // Seller_txt
            // 
            this.Seller_txt.Location = new System.Drawing.Point(88, 17);
            this.Seller_txt.Name = "Seller_txt";
            this.Seller_txt.Size = new System.Drawing.Size(238, 20);
            this.Seller_txt.TabIndex = 1;
            this.Seller_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Seller_lbl
            // 
            this.Seller_lbl.AutoSize = true;
            this.Seller_lbl.Location = new System.Drawing.Point(7, 20);
            this.Seller_lbl.Name = "Seller_lbl";
            this.Seller_lbl.Size = new System.Drawing.Size(33, 13);
            this.Seller_lbl.TabIndex = 0;
            this.Seller_lbl.Text = "Seller";
            // 
            // Hex_txt
            // 
            this.Hex_txt.Location = new System.Drawing.Point(12, 285);
            this.Hex_txt.Multiline = true;
            this.Hex_txt.Name = "Hex_txt";
            this.Hex_txt.ReadOnly = true;
            this.Hex_txt.Size = new System.Drawing.Size(588, 89);
            this.Hex_txt.TabIndex = 3;
            // 
            // Base64txt
            // 
            this.Base64txt.Location = new System.Drawing.Point(12, 401);
            this.Base64txt.Multiline = true;
            this.Base64txt.Name = "Base64txt";
            this.Base64txt.ReadOnly = true;
            this.Base64txt.Size = new System.Drawing.Size(588, 89);
            this.Base64txt.TabIndex = 4;
            // 
            // Hex_lbl
            // 
            this.Hex_lbl.AutoSize = true;
            this.Hex_lbl.Location = new System.Drawing.Point(12, 269);
            this.Hex_lbl.Name = "Hex_lbl";
            this.Hex_lbl.Size = new System.Drawing.Size(56, 13);
            this.Hex_lbl.TabIndex = 5;
            this.Hex_lbl.Text = "Hex Value";
            // 
            // Base64_lbl
            // 
            this.Base64_lbl.AutoSize = true;
            this.Base64_lbl.Location = new System.Drawing.Point(12, 383);
            this.Base64_lbl.Name = "Base64_lbl";
            this.Base64_lbl.Size = new System.Drawing.Size(73, 13);
            this.Base64_lbl.TabIndex = 6;
            this.Base64_lbl.Text = "Base64 Value";
            // 
            // Test_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 506);
            this.Controls.Add(this.Base64_lbl);
            this.Controls.Add(this.Hex_lbl);
            this.Controls.Add(this.Base64txt);
            this.Controls.Add(this.Hex_txt);
            this.Controls.Add(this.InfoGBox);
            this.Controls.Add(this.Gent_but);
            this.Controls.Add(this.Qr_Box);
            this.Name = "Test_frm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Qr_Box)).EndInit();
            this.InfoGBox.ResumeLayout(false);
            this.InfoGBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Qr_Box;
        private System.Windows.Forms.Button Gent_but;
        private System.Windows.Forms.GroupBox InfoGBox;
        private System.Windows.Forms.Label Seller_lbl;
        private System.Windows.Forms.TextBox Seller_txt;
        private System.Windows.Forms.TextBox Tax_txt;
        private System.Windows.Forms.Label Tax_lbl;
        private System.Windows.Forms.DateTimePicker Time_val;
        private System.Windows.Forms.Label Time_lbl;
        private System.Windows.Forms.TextBox Invoice_txt;
        private System.Windows.Forms.Label Invoice_lbl;
        private System.Windows.Forms.TextBox Vat_txt;
        private System.Windows.Forms.Label VAT_lbl;
        private System.Windows.Forms.TextBox Hex_txt;
        private System.Windows.Forms.TextBox Base64txt;
        private System.Windows.Forms.Label Hex_lbl;
        private System.Windows.Forms.Label Base64_lbl;
    }
}

