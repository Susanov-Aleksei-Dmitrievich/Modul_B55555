using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchetOborudovania.Classes
{
    internal class ClassAvtorizacia
    {
        // string strokaPodkluchenia = @"Data Source = DESKTOP-LJ3RRK0\MSSQLSERVER2; DataBase = UchetOborudovania; User ID = user01; Password = 123";
        string strokaPodcluchenia = @"Data Source = DESKTOP-LJ3RRK0\MSSQLSERVER2; Initial Catalog = UchetOborudovania; Integrated Security = true";
        public DataSet ds = new DataSet();

        public DataSet getUser(string login, string password)
        {
            string zapros = string.Format("select * from Sotrudniki where login = '{0}' and password = '{1}'", login, password);

            using (SqlConnection connection = new SqlConnection(strokaPodcluchenia))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(zapros, connection);
                    adapter.Fill(ds);
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if(connection.State == ConnectionState.Open)
                    {
                        connection.Dispose();
                    }
                }

                

            }
            return ds;
            

        }




    }
}
