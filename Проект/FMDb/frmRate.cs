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
    public partial class frmRate : Form
    {
        string s;
        float sum1;
        int count1;
        double rate1;
        public string ConnectionString { get; set; }
        public frmRate(string _s)
        {
            InitializeComponent();
            s = _s;
            var sb = new SqlConnectionStringBuilder
            {
                DataSource = "GALINA-PC",
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
            if (rbtn0.Checked) { sum1 += 0; count1++; }
            if (rbtn1.Checked) { sum1 += 1; count1++; }
            if (rbtn2.Checked) { sum1 += 2; count1++; }
            if (rbtn3.Checked) { sum1 += 3; count1++; }
            if (rbtn4.Checked) { sum1 += 4; count1++; }
            if (rbtn5.Checked) { sum1 += 5; count1++; }
            if (rbtn6.Checked) { sum1 += 6; count1++; }
            if (rbtn7.Checked) { sum1 += 7; count1++; }
            if (rbtn8.Checked) { sum1 += 8; count1++; }
            if (rbtn9.Checked) { sum1 += 9; count1++; }
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
