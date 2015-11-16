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
    public partial class frmLogIn : Form
    {
        string ConnectionString { get; set; }
        public frmLogIn()
        {
            InitializeComponent();
            var sb = new SqlConnectionStringBuilder
            {
                //DataSource = "SUPER_PC",
                DataSource = "SUPER_PC",
                InitialCatalog = "FMDb",
                IntegratedSecurity = true
            };
            ConnectionString = sb.ConnectionString;
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            frmReg newReg = new frmReg(this);
            newReg.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (tbLog.Text != "")
            {
                if (tbPass.Text != "")
                {
                    var sqlconection = new SqlConnection(ConnectionString);
                    using (sqlconection)
                    {
                        sqlconection.Open();
                        var command = new SqlCommand
                        {
                            Connection = sqlconection,
                            CommandText = "SELECT * FROM Login WHERE Login.Login= '" + tbLog.Text + "'",
                            CommandType = CommandType.Text
                        };

                        SqlDataReader dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            string log = dr[0].ToString();
                            string pass = dr[1].ToString();
                            if (pass == tbPass.Text)
                            {
                                bool adm = Convert.ToBoolean(dr[2]); Main newMain = new Main(adm, log);
                                newMain.Show(); this.Hide();
                            }
                            else
                            {
                                tbPass.Clear();
                                lblErrPass.Text = "Неверный пароль";
                            }
                        }
                        else
                        {
                            tbLog.Clear();
                            tbPass.Clear();
                            lblErrLog.Text = "Неверный логин";
                        };
                        dr.Close();
                    }
                }
                else { lblErrPass.Text = "Введите пароль";}
            }
            else { lblErrLog.Text = "Введите логин"; }
        }

        private void tbLog_TextChanged(object sender, EventArgs e)
        {
            lblErrLog.Text = "";
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            lblErrPass.Text = "";
        }

        private void frmLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;
            if (DialogResult.Yes == MessageBox.Show("Вы уверены, что желаете закрыть программу?", "FMDb: Выход из программы",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
            else { e.Cancel = true; }
        }
    }
}
