using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMDb
{
    public partial class Main : Form
    {
        bool adm;
        string login;
        string[] idgenres = new string[35];
        string[] idcountry = new string[35];
        string[] idactors = new string[35];
        string[] idprod = new string[35];
         public string ConnectionString { get; set; }

        public Main(bool _adm, string _login)
        {
            InitializeComponent();
            adm = _adm;
            login = _login;
            var sb = new SqlConnectionStringBuilder
            {
                DataSource = "GALINA-PC",
                InitialCatalog = "FMDb",
                IntegratedSecurity = true
            };
            ConnectionString = sb.ConnectionString;
        }

        private void Main_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "fMDbDataSet.ViewFilm". При необходимости она может быть перемещена или удалена.
            this.viewFilmTableAdapter.Fill(this.fMDbDataSet.ViewFilm);
            this.Text = "Привет, " + login;
            panelSearch.Visible = false;
            if (!adm)
            {
                tsAdmin.Visible = false;
                       }

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsbtnSearch_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = !panelSearch.Visible;
        }

        private void BtnExt_Click(object sender, EventArgs e)
        {   
            var result=new System.Windows.Forms.DialogResult();
            result = MessageBox.Show("Вы уверены, что желаете закрыть программу?", "FMDb: Выход из программы",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tsbtnLogOut_Click(object sender, EventArgs e)
        {
            var result = new System.Windows.Forms.DialogResult();
            result = MessageBox.Show("Вы уверены, что желаете выйти из учетной записи?", "FMDb: Выход из учетной записи",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                adm = false;
                login = "";
                this.Hide();
                frmLogIn newLog = new frmLogIn();
                newLog.Show();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;
            if (DialogResult.Yes == MessageBox.Show("Вы уверены, что желаете закрыть программу?", "FMDb: Выход из программы",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
            else { e.Cancel = true; }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sconn = new SqlConnection(ConnectionString);
                using (sconn)
                {
                    sconn.Open();
                    SqlCommand scommand = new SqlCommand();
                    scommand.Connection = sconn;
                    scommand.CommandText = @"SELECT [Путь к фильму] from [Film] where [IDMovie]=" + dataGridView1.SelectedCells[0].Value.ToString();
                    SqlDataReader dr = scommand.ExecuteReader();
                    while (dr.Read())
                    {
                        Process.Start(dr[0].ToString());
                    }
                    dr.Close();
                } sconn.Close();

            }
            catch (Exception ex)
            { pictureBoxPoster.Image = null; }
        }

        private void tsbtnAdm_Click(object sender, EventArgs e)
        {
            Admin newAdmin = new Admin();
            newAdmin.Show(); 
        }

        private void filterboxName_TextChanged(object sender, EventArgs e)
        {
            viewFilmBindingSource.Filter = "[Название] like '%" + filterboxName.Text + "%'";
        }

        private void filterboxYear_TextChanged(object sender, EventArgs e)
        {
                viewFilmBindingSource.Filter = "[Год] like '%" + filterboxYear.Text + "%'";
            
        }

        private void filterboxTime_TextChanged(object sender, EventArgs e)
        {
                viewFilmBindingSource.Filter = "[Длительность] like '%" + filterboxTime.Text + "%'";
        }

        private void filterboxRate_TextChanged(object sender, EventArgs e)
        {
                viewFilmBindingSource.Filter = "[Оценка] like '%" + filterboxRate.Text + "%'";
        }

        private void checkView_CheckedChanged(object sender, EventArgs e)
        {
            if (checkView.Checked) viewFilmBindingSource.Filter = "[Просмотрен] = True"; 
            else viewFilmBindingSource.Filter = "[Просмотрен] = True OR [Просмотрен] = False";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            lbGenre.Items.Clear();
            lbCountry.Items.Clear();
            lbActors.Items.Clear();
            lbProd.Items.Clear();
            try
            {
                idgenres = new string[35];
                if (dataGridView1.SelectedCells.Count == 6)
                {
                    SqlConnection sconn = new SqlConnection(ConnectionString);
                    using (sconn)
                    {
                        sconn.Open();
                        SqlCommand scommand = new SqlCommand();
                        scommand.Connection = sconn;
                        scommand.CommandText = @"SELECT [IDG] from [MovieGenre] where [IDM]=" + dataGridView1.SelectedCells[0].Value.ToString();
                        SqlDataReader dr = scommand.ExecuteReader();
                        int i = 0;
                        while (dr.Read())
                        {
                            idgenres[i] = dr[0].ToString();
                            i++;
                        }
                        dr.Close();
                    } sconn.Close();


                    sconn = new SqlConnection(ConnectionString);
                    using (sconn)
                    {
                        sconn.Open();
                        SqlCommand scommand = new SqlCommand();
                        scommand.Connection = sconn;
                        for (int y = 0; y < 35; y++)
                        {
                            if (idgenres[y] != null)
                            {
                                scommand.CommandText = @"SELECT [Genre] from [Genre] where [IDG]=" + idgenres[y];
                                SqlDataReader dr = scommand.ExecuteReader();
                                while (dr.Read())
                                {
                                    lbGenre.Items.Add(dr[0].ToString());
                                }
                                dr.Close();
                            }
                        }
                    } sconn.Close();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }

            try
            {
                idcountry = new string[35];
                if (dataGridView1.SelectedCells.Count == 6)
                {
                    SqlConnection sconn = new SqlConnection(ConnectionString);
                    using (sconn)
                    {
                        sconn.Open();
                        SqlCommand scommand = new SqlCommand();
                        scommand.Connection = sconn;
                        scommand.CommandText = @"SELECT [IDC] from [MovieCountry] where [IDM]=" + dataGridView1.SelectedCells[0].Value.ToString();
                        SqlDataReader dr = scommand.ExecuteReader();
                        int i = 0;
                        while (dr.Read())
                        {
                            idcountry[i] = dr[0].ToString();
                            i++;
                        }
                        dr.Close();
                    } sconn.Close();

                    sconn = new SqlConnection(ConnectionString);
                    using (sconn)
                    {
                        sconn.Open();
                        SqlCommand scommand = new SqlCommand();
                        scommand.Connection = sconn;
                        for (int y = 0; y < 35; y++)
                        {
                            if (idcountry[y] != null)
                            {
                                scommand.CommandText = @"SELECT [Country] from [Country] where [IDC]=" + idcountry[y];
                                SqlDataReader dr = scommand.ExecuteReader();
                                while (dr.Read())
                                {
                                    lbCountry.Items.Add(dr[0].ToString());
                                }
                                dr.Close();
                            }
                        }
                    } sconn.Close();
                }
            }
            catch { }
            try
            {
                idactors = new string[35];
                if (dataGridView1.SelectedCells.Count == 6)
                {
                    SqlConnection sconn = new SqlConnection(ConnectionString);
                    using (sconn)
                    {
                        sconn.Open();
                        SqlCommand scommand = new SqlCommand();
                        scommand.Connection = sconn;
                        scommand.CommandText = @"SELECT [IDa] from [MovieActor] where [IDf]=" + dataGridView1.SelectedCells[0].Value.ToString();
                        SqlDataReader dr = scommand.ExecuteReader();
                        int i = 0;
                        while (dr.Read())
                        {
                            idactors[i] = dr[0].ToString();
                            i++;
                        }
                        dr.Close();
                    } sconn.Close();


                    sconn = new SqlConnection(ConnectionString);
                    using (sconn)
                    {
                        sconn.Open();
                        SqlCommand scommand = new SqlCommand();
                        scommand.Connection = sconn;
                        for (int y = 0; y < 35; y++)
                        {
                            if (idactors[y] != null)
                            {
                                scommand.CommandText = @"SELECT [name] from [Actors] where [IDact]=" + idactors[y];
                                SqlDataReader dr = scommand.ExecuteReader();
                                while (dr.Read())
                                {
                                    lbActors.Items.Add(dr[0].ToString());
                                }
                                dr.Close();
                            }
                        }
                    } sconn.Close();
                }
                //else
                //  MessageBox.Show("Выделите всю строку!", "Ошибка!");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
            try
            {
                idprod = new string[35];
                if (dataGridView1.SelectedCells.Count == 6)
                {
                    SqlConnection sconn = new SqlConnection(ConnectionString);
                    using (sconn)
                    {
                        sconn.Open();
                        SqlCommand scommand = new SqlCommand();
                        scommand.Connection = sconn;
                        scommand.CommandText = @"SELECT [IDp] from [MovieProducer] where [IDf]=" + dataGridView1.SelectedCells[0].Value.ToString();
                        SqlDataReader dr = scommand.ExecuteReader();
                        int i = 0;
                        while (dr.Read())
                        {
                            idprod[i] = dr[0].ToString();
                            i++;
                        }
                        dr.Close();
                    } sconn.Close();


                    sconn = new SqlConnection(ConnectionString);
                    using (sconn)
                    {
                        sconn.Open();
                        SqlCommand scommand = new SqlCommand();
                        scommand.Connection = sconn;
                        for (int y = 0; y < 35; y++)
                        {
                            if (idprod[y] != null)
                            {
                                scommand.CommandText = @"SELECT [Name_p] from [Producer] where [IDprod]=" + idprod[y];
                                SqlDataReader dr = scommand.ExecuteReader();
                                while (dr.Read())
                                {
                                    lbProd.Items.Add(dr[0].ToString());
                                }
                                dr.Close();
                            }
                        }
                    } sconn.Close();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }


            try
            {
                SqlConnection sconn = new SqlConnection(ConnectionString);
                    using (sconn)
                    {
                        sconn.Open();
                        SqlCommand scommand = new SqlCommand();
                        scommand.Connection = sconn;                      
                        scommand.CommandText = @"SELECT [Путь к описанию] from [Film] where [IDMovie]=" + dataGridView1.SelectedCells[0].Value.ToString();
                        SqlDataReader dr = scommand.ExecuteReader();
                        while (dr.Read())
                        {
                            richTextBoxDescription.LoadFile(dr[0].ToString());
                        }
                        dr.Close();                                     
                    } sconn.Close();
                
            }
            catch (Exception ex)
            { richTextBoxDescription.Text="Описания нет"; }


            try
            {
                SqlConnection sconn = new SqlConnection(ConnectionString);
                using (sconn)
                {
                    sconn.Open();
                    SqlCommand scommand = new SqlCommand();
                    scommand.Connection = sconn;
                    scommand.CommandText = @"SELECT [Путь к постеру] from [Film] where [IDMovie]=" + dataGridView1.SelectedCells[0].Value.ToString();
                    SqlDataReader dr = scommand.ExecuteReader();
                    while (dr.Read())
                    {
                        pictureBoxPoster.Load(dr[0].ToString());
                    }
                    dr.Close();
                } sconn.Close();
            }
            catch (Exception ex)
            { pictureBoxPoster.Image = null; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sss = dataGridView1.SelectedCells[0].Value.ToString();
            frmRate newRate = new frmRate(sss);
            newRate.FormClosed+=newRate_FormClosed;
            newRate.Show();
        }

        private void newRate_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewFilmTableAdapter.Fill(fMDbDataSet.ViewFilm);
        }

        private void tsbtnDel_Click(object sender, EventArgs e)
        {
            var result = new System.Windows.Forms.DialogResult();
            result = MessageBox.Show("Вы уверены, что желаете удалить эту запись?", "FMDb: Удаление ",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dataGridView1.SelectedCells.Count == 6)
                {
                    SqlConnection conn = null;
                    String query = "DELETE Film WHERE [IDMovie]='{0}'";
                    try
                    {
                        conn = new SqlConnection(ConnectionString);
                        conn.Open();
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = string.Format(query, dataGridView1.SelectedCells[0].Value.ToString());
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Удалено!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!");
                    }
                    finally
                    {
                        conn.Close();
                        this.viewFilmTableAdapter.Fill(this.fMDbDataSet.ViewFilm);
                    }
                }
                
            }
        }

        private void tsbtnChange_Click(object sender, EventArgs e)
        {
            frmAdd newChange = new frmAdd("Изменить",login);
            newChange.Show(); 
            this.Hide();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            frmAdd newAdd = new frmAdd("Добавить",login);
            newAdd.Show(); 
            this.Hide();
        }

   

    }
}
