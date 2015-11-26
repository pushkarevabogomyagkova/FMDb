using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        string title;
        string path = "D:/ОПРИС/log.rtf";
        string appendText;
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
            this.Close();
        }

        private void bntRegist_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text.ToLower() == title)
            {
                if (tbNewLog.Text != "")
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
                            else
                            {
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
                                    appendText = DateTime.Now.ToString() + ": пользователь " + tbNewLog.Text + " зарегистрировался.\n";
                                    File.AppendAllText(path, appendText, Encoding.UTF8);
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
                        sqlconection.Close();
                    }
                    else { lblEP.Text = "Введите пароль"; }
                }
                else { lblEL.Text = "Введите логин"; }
            }
            else 
            {
                Random random = new Random();
                int idc;
                idc = random.Next(1, 31);
                var sqlconection = new SqlConnection(ConnectionString);
                using (sqlconection)
                {
                    sqlconection.Open();
                    var command = new SqlCommand
                    {
                        Connection = sqlconection,
                        CommandText = "SELECT [capture],[title] FROM Capture WHERE IDcapture = " + idc,
                        CommandType = CommandType.Text
                    };

                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        title = dr[1].ToString();
                        pbCapture.Load(dr[0].ToString());
                    }
                    dr.Close();
                }
                sqlconection.Close();
                tbTitle.Text = "";
                lblErCapture.Text = "Символы введены не верно";
                
            }
        }
        private void tbNewLog_TextChanged(object sender, EventArgs e)
        {
            lblEL.Text = "";
        }

        private void tbNewPass_TextChanged(object sender, EventArgs e)
        {
            lblEP.Text = "";
        }

        private void frmReg_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int idc;
            idc=random.Next(1,31);
            var sqlconection = new SqlConnection(ConnectionString);
            using (sqlconection)
            {
                sqlconection.Open();
                var command = new SqlCommand
                {
                    Connection = sqlconection,
                    CommandText = "SELECT [capture],[title] FROM Capture WHERE IDcapture = " + idc,
                    CommandType = CommandType.Text
                };

                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    title = dr[1].ToString();
                    pbCapture.Load(dr[0].ToString());
                }
                dr.Close();
            }
            sqlconection.Close();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int idc;
            idc = random.Next(1, 31);
            var sqlconection = new SqlConnection(ConnectionString);
            using (sqlconection)
            {
                sqlconection.Open();
                var command = new SqlCommand
                {
                    Connection = sqlconection,
                    CommandText = "SELECT [capture],[title] FROM Capture WHERE IDcapture = " + idc,
                    CommandType = CommandType.Text
                };

                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    title = dr[1].ToString();
                    pbCapture.Load(dr[0].ToString());
                }
                dr.Close();
            }
            sqlconection.Close();
            tbTitle.Text = "";
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            lblErCapture.Text = "";
        }
    }
}
    