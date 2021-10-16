using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using zatca.einvoicing;

namespace TestApp
{
    public partial class Test_frm : Form
    {
        public Test_frm()
        {
            InitializeComponent();
        }

        private void DigitCtrl(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void NumberCrtl(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void Gent_but_Click(object sender, EventArgs e)
        {
            String Seller = Seller_txt.Text;
            String VatNo = Vat_txt.Text;
            DateTime dTime = Time_val.Value;
            Double Total = Convert.ToDouble(Invoice_txt.Text);
            Double Tax = Convert.ToDouble(Tax_txt.Text);

            TLVCls tlv = new TLVCls(Seller, VatNo, dTime, Total, Tax);

            Hex_txt.Text = tlv.ToString();
            Base64txt.Text = tlv.ToBase64();


            Qr_Box.Image = tlv.toQrCode();
        }
    }
}
