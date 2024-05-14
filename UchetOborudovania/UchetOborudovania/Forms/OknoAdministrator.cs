using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchetOborudovania
{
    public partial class OknoAdministrator : Form
    {
        string strokaPodcluchenia = @"Data Source = DESKTOP-LJ3RRK0\MSSQLSERVER2; Initial Catalog = UchetOborudovania; Integrated Security = true";
        public DataSet ds = new DataSet();
        public DataTable dataTable = new DataTable();
        

        public OknoAdministrator()
        {
            InitializeComponent();
            loadData();


        }

        public void loadData()
        {
            using (SqlConnection connection = new SqlConnection(strokaPodcluchenia))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("select [idOborudovania] as [АЙ ДИ Оборудования], [foto] as [Ф], [seriyniyNomer] as [СЕ], [naimenovanie] as [НА], [opisanie] as [ОП], [nomerKabineta] as [НК], [status] as [СТ], [idSotrudnika] as [СО] from Oborudovanie", connection);
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Dispose();
                    }
                }
            }
        }

        




        private void buttonNazad_Click(object sender, EventArgs e)
        {
            OknoAvtorizacia oknoAvtorizacia = new OknoAvtorizacia();
            oknoAvtorizacia.Show();
        }

        private void OknoAdministrator_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetOborudovaniaDataSet1.IstoriaVhoda". При необходимости она может быть перемещена или удалена.
            this.istoriaVhodaTableAdapter.Fill(this.uchetOborudovaniaDataSet1.IstoriaVhoda);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetOborudovaniaDataSet.Oborudovanie". При необходимости она может быть перемещена или удалена.
            // this.oborudovanieTableAdapter.Fill(this.uchetOborudovaniaDataSet.Oborudovanie);

            label3.Text = ds.Tables[0].Rows[0][1].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы хотите сохранить изменения?", "Сохранить изменения?", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(strokaPodcluchenia))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter("select * from Oborudovanie", connection);
                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                        adapter.Update(dataTable);
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Dispose();
                        }
                    }
                }
                MessageBox.Show("Изменения сохранены!");
            }
            else
            {
                MessageBox.Show("Изменения не сохранены!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string poiskovoeZnachenie = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(poiskovoeZnachenie))
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dataTable;
                dataGridView2.DataSource = null;

                return;

            }

            DataRow[] naydennieStroki = dataTable.Select("СЕ = '" + poiskovoeZnachenie + "'");

            DataTable poluchivhayasaTablica = dataTable.Clone();

            foreach (DataRow row in naydennieStroki)
            {
                poluchivhayasaTablica.ImportRow(row);
            }

            dataGridView1.DataSource = poluchivhayasaTablica;

            dataGridView2.DataSource = poluchivhayasaTablica;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int chislo1 = Convert.ToInt32(dataGridView1.Rows[1].Cells[0].Value);
            int chislo2 = Convert.ToInt32(dataGridView1.Rows[4].Cells[0].Value);

            int result = chislo1 + chislo2;

            dataGridView1.Rows[Convert.ToInt32(textBox2.Text) - 1].Cells[2].Value = result.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.Enabled = true;
        }
    }
}

