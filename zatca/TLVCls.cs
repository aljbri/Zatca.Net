using System;
using System.Text;
using System.Drawing;
using System.Collections.Generic;

using ZXing;
using ZXing.Common;

namespace zatca.einvoicing
{
    public class TLVCls
    {
        byte[] Seller;
        byte[] VatNo;
        byte[] dateTime;
        byte[] Total;
        byte[] Tax;

        public TLVCls(String Seller, String TaxNo, DateTime dateTime, Double Total, Double Tax)
        {
            this.Seller = Encoding.UTF8.GetBytes(Seller);
            this.VatNo = Encoding.UTF8.GetBytes(TaxNo);

            this.dateTime = Encoding.UTF8.GetBytes(dateTime.ToString());
            this.Total = Encoding.UTF8.GetBytes(Total.ToString());
            this.Tax = Encoding.UTF8.GetBytes(Tax.ToString());
        }

        private String getasText(int Tag, byte[] Value)
        {
            return (Tag).ToString("X2") + (Value.Length).ToString("X2") + BitConverter.ToString(Value).Replace("-", string.Empty);
        }

        private byte[] getBytes(int id, byte[] Value)
        {
            byte[] val = new byte[2 + Value.Length];
            val[0] = (byte)id;
            val[1] = (byte)Value.Length;
            Value.CopyTo(val, 2);
            return val;
        }

        private String getString()
        {
            String TLV_Text = "";
            TLV_Text += this.getasText(1, this.Seller);
            TLV_Text += this.getasText(2, this.VatNo);
            TLV_Text += this.getasText(3, this.dateTime);
            TLV_Text += this.getasText(4, this.Total);
            TLV_Text += this.getasText(5, this.Tax);
            return TLV_Text;
        }

        public override string ToString()
        {
            return this.getString();
        }

        public String ToBase64()
        {
            List<byte> TLV_Bytes = new List<byte>();
            TLV_Bytes.AddRange(getBytes(1, this.Seller));
            TLV_Bytes.AddRange(getBytes(2, this.VatNo));
            TLV_Bytes.AddRange(getBytes(3, this.dateTime));
            TLV_Bytes.AddRange(getBytes(4, this.Total));
            TLV_Bytes.AddRange(getBytes(5, this.Tax));
            return Convert.ToBase64String(TLV_Bytes.ToArray());
        }

        public Bitmap toQrCode(int width=250, int height = 250)
        {

            BarcodeWriter barcodeWriter = new BarcodeWriter {
                Format = BarcodeFormat.QR_CODE,
                Options = new EncodingOptions {
                    Width = width,
                    Height = height
                } };
            Bitmap QrCode = barcodeWriter.Write(this.ToBase64());

            return QrCode;
        }


    }

}
