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
        public frmLogIn(String _NewLog, String _NewPass)
        {
            InitializeComponent();
            var sb = new SqlConnectionStringBuilder
            {
                DataSource = "SUPER_PC",
                InitialCatalog = "FMDb",
                IntegratedSecurity = true
            };
            ConnectionString = sb.ConnectionString;
            tbLog.Text = _NewLog;
            tbPass.Text = _NewPass;
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            frmReg newReg = new frmReg();
            newReg.Show();
            this.Hide();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
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
                    String log = dr[0].ToString();
                    String pass = dr[1].ToString();
                    if (pass == tbPass.Text)
                    {
                        Boolean adm = Convert.ToBoolean(dr[2]); Main newMain = new Main(adm);
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

        private void tbLog_TextChanged(object sender, EventArgs e)
        {
            lblErrLog.Text = "";
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            lblErrPass.Text = "";
        }
    }
}
