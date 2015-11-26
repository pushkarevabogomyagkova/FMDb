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
    public partial class frmRate : Form
    {
        string s;
        float sum1;
        int count1;
        double rate1;
        string path = "D:/ОПРИС/log.rtf";
        string appendText;
        string log;
        public string ConnectionString { get; set; }
        public frmRate(string _s,string _log)
        {
            InitializeComponent();
            s = _s;
            log = _log;
            var sb = new SqlConnectionStringBuilder
            {
                DataSource = "SUPER_PC",
                InitialCatalog = "FMDb",
                IntegratedSecurity = true
            };
            ConnectionString = sb.ConnectionString;

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmRate_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sconn = new SqlConnection(ConnectionString);
                using (sconn)
                {
                    sconn.Open();
                    SqlCommand scommand = new SqlCommand();
                    scommand.Connection = sconn;
                    scommand.CommandText = @"SELECT [Название], [Длительность], [Год], [rate] from [Film] where [IDMovie]=" + s;
                    SqlDataReader dr = scommand.ExecuteReader();
                   
                    while (dr.Read())
                    {
                        lm.Text = dr[0].ToString();
                        ly.Text = dr[1].ToString();
                        lc.Text = dr[2].ToString();
                        lr.Text = dr[3].ToString();
                    }
                    dr.Close();
                } sconn.Close();
            }
            catch (Exception ex)
            {  }
            try
            {
                SqlConnection sconn = new SqlConnection(ConnectionString);
                using (sconn)
                {
                    sconn.Open();                   
                    SqlCommand scom = new SqlCommand();
                    scom.Connection = sconn;
                    scom.CommandText = @"SELECT [sum], [count] from [Film] where [IDMovie]=" + s;
                    SqlDataReader dr1 = scom.ExecuteReader();
                    while (dr1.Read())
                    {
                        sum1 = Convert.ToSingle(dr1[0].ToString());
                        count1 = Convert.ToInt32(dr1[1].ToString(), 10);
                    }
                    dr1.Close();
                } sconn.Close();
            }
            catch (Exception ex)
            { }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int num=0;
            if (rbtn0.Checked) { num = 0; }
            if (rbtn1.Checked) { num = 1; }
            if (rbtn2.Checked) { num = 2; }
            if (rbtn3.Checked) { num = 3; }
            if (rbtn4.Checked) { num = 4; }
            if (rbtn5.Checked) { num = 5; }
            if (rbtn6.Checked) { num = 6; }
            if (rbtn7.Checked) { num = 7; }
            if (rbtn8.Checked) { num = 8; }
            if (rbtn9.Checked) { num = 9; }
            appendText = DateTime.Now.ToString() + ": пользователь " + log + " поставил оценку "+num.ToString()+" фильму "+lm.Text+".\n";
            File.AppendAllText(path, appendText, Encoding.UTF8);
            sum1 += num;
            count1++;
            rate1 = Math.Round(sum1 / count1,0);
                SqlConnection conn = null;
                String query = "UPDATE [Film] SET [sum]='{0}',[count]='{1}',[rate]='{2}' WHERE [IDMovie]='{3}'";
                try
                {
                    conn = new SqlConnection(ConnectionString);
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = string.Format(query, sum1.ToString(), count1.ToString(), rate1.ToString(), s);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                { }
                this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
             this.Hide();
        }
    }
}
