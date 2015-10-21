using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMDb
{
    public partial class frmReg : Form
    {
        string ConnectionString { get; set; }
        public frmReg()
        {
            InitializeComponent();
            var sb = new SqlConnectionStringBuilder
            {
                DataSource = "SUPER_PC",
                InitialCatalog = "FMDb",
                IntegratedSecurity = true
            };
            ConnectionString = sb.ConnectionString;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bntRegist_Click(object sender, EventArgs e)
        {
            var sqlconection = new SqlConnection(ConnectionString);
            using (sqlconection)
            {
                sqlconection.Open();
                var command = new SqlCommand
                {
                    Connection = sqlconection,
                    CommandText = "SELECT * FROM Login WHERE Login.Login= '" + tbNewLog.Text + "'",
                    CommandType = CommandType.Text
                };

                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {label1.Text="Такой логин уже есть";}
                else {
                SqlConnection conn = null;
                String query = "INSERT INTO Login VALUES ('{0}','{1}','False')";
                try
                {
                    conn = new SqlConnection(ConnectionString);
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = string.Format(query, tbNewLog.Text, tbNewPass.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Вы зарегестрированы");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
                finally
                {
                    conn.Close();
                }
                String NewLog = tbNewLog.Text;
                String NewPass = tbNewPass.Text;
                frmLogIn newLogIn = new frmLogIn(NewLog, NewPass);
                newLogIn.Show();
                this.Hide();
                }
                
                dr.Close();
            }
        }
    }
}
