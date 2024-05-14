using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace UchetOborudovania.Forms
{
    public partial class QRCode2 : Form
    {
        public QRCode2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qrCodeGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrCodeGenerator.CreateQrCode(textBox1.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            Image qrCodeImage = qrCode.GetGraphic(10);

            pictureBox1.Image = qrCodeImage;

        }
    }
}
