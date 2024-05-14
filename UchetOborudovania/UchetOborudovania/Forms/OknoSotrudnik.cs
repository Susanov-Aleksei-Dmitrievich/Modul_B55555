using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchetOborudovania
{
    public partial class OknoSotrudnik : Form
    {
        public DataSet ds = new DataSet();

        public OknoSotrudnik()
        {
            InitializeComponent();
        }

        private void OknoSotrudnik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetOborudovaniaDataSet4.Oborudovanie". При необходимости она может быть перемещена или удалена.
            this.oborudovanieTableAdapter.Fill(this.uchetOborudovaniaDataSet4.Oborudovanie);

            byte[] foto = null;
            foto = (byte[])ds.Tables[0].Rows[0][6];
            using (MemoryStream memoryStream = new MemoryStream(foto))
            {
                Image originalFoto = Image.FromStream(memoryStream);
                pictureBox2.Image = new Bitmap(originalFoto, new Size(183, 207));
            }

            label3.Text = ds.Tables[0].Rows[0][1].ToString();

        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            OknoAvtorizacia oknoAvtorizacia = new OknoAvtorizacia();
            oknoAvtorizacia.Show();
        }
    }
}
