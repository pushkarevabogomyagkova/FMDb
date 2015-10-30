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
        frmLogIn frm;
        public frmReg( frmLogIn _frm)
        {
            InitializeComponent();
            var sb = new SqlConnectionStringBuilder
            {
                DataSource = "SUPER_PC",
                InitialCatalog = "FMDb",
                IntegratedSecurity = true
            };
            ConnectionString = sb.ConnectionString;
            frm = _frm;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bntRegist_Click(object sender, EventArgs e)
        {    if (tbNewLog.Text != "")
            {
                if (tbNewPass.Text != "")
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
                { lblEL.Text = "Такой логин уже есть"; dr.Close(); }
                else {
                SqlConnection conn = null;
                string query = "INSERT INTO Login VALUES ('{0}','{1}','False')";
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
                frm.tbLog.Text = tbNewLog.Text;
                frm.tbPass.Text = tbNewPass.Text;
                this.Hide();
                }
                
                dr.Close();
            }
                }
                else { lblEP.Text = "Введите пароль"; }
            }
        else { lblEL.Text = "Введите логин"; }
        }
        private void tbNewLog_TextChanged(object sender, EventArgs e)
        {
            lblEL.Text = "";
        }

        private void tbNewPass_TextChanged(object sender, EventArgs e)
        {
            lblEP.Text = "";
        }
    }
}
