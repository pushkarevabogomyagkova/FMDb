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
        string[] genres = new string[35];
        string[] country = new string[35];
        string[] actors = new string[35];
        string[] prod = new string[35];
        string name;
        string year;
        string time;
        string poster;
        string film;
        string dd;
        public string ConnectionString { get; set; }

        public Main(bool _adm, string _login)
        {
            InitializeComponent();
            adm = _adm;
            login = _login;
            var sb = new SqlConnectionStringBuilder
            {
                DataSource = "SUPER_PC",
                InitialCatalog = "FMDb",
                IntegratedSecurity = true
            };
            ConnectionString = sb.ConnectionString;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fMDbDataSet.Film". При необходимости она может быть перемещена или удалена.
            this.filmTableAdapter.Fill(this.fMDbDataSet.Film);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "fMDbDataSet.ViewFilm". При необходимости она может быть перемещена или удалена.
            this.filmTableAdapter.Fill(this.fMDbDataSet.Film);
            dataGridView1.Sort(dataGridViewTextBoxColumn1, ListSortDirection.Ascending);
            this.Text = "Добро пожаловать, " + login+". ";
            panelSearch.Visible = false;
            if (!adm)
            {
                tsAdmin.Visible = false;
            }
            try
            {
                string[] idfilm=new string[35];
                SqlConnection sconn = new SqlConnection(ConnectionString);
                using (sconn)
                {
                    sconn.Open();
                    SqlCommand scommand = new SqlCommand();
                    scommand.Connection = sconn;
                    scommand.CommandText = @"SELECT [IDf] from [View] where [Log]=" + login;
                    SqlDataReader dr = scommand.ExecuteReader();
                    int i = 0;
                    while (dr.Read())
                    {
                        idfilm[i] = dr[0].ToString();
                        i++;
                    }
                    dr.Close();
                } sconn.Close();
                for(int i=0; i<35; i++)
                {
                    if(idfilm!=null)
                    {
                        if(idfilm[i]!=null)
                        {
                            int j=0;
                            while (dataGridView1.Rows[j].Cells[0].Value.ToString() != idfilm[i])
                            { j++; }
                            dataGridView1.Rows[j].Cells[5].Value = true;
                        }
                    
                    }
                }
            }
            catch { }
        }


        private void tsbtnSearch_Click(object sender, EventArgs e)
        {
            if (panelSearch.Visible)
            {
                filterboxRate1.Text = "";
                filterboxName.Text = "";
                filterboxTime1.Text = "";
                filterboxTime2.Text = "";
                filterboxYear1.Text = "";
                filterboxYear2.Text = "";
                checkView.Checked = false;
            }
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
                            film = dr[0].ToString();
                            Process.Start(film);
                        }
                        dr.Close();
                    }
                    sconn.Close();
                }
                catch (Exception ex)
                { }
                if (film != "")
                {
                SqlConnection conn = null;
                string query = "INSERT INTO [View] VALUES ('{0}','{1}')";
                try
                {
                    conn = new SqlConnection(ConnectionString);
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = string.Format(query, Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString()), login);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                { }
                finally
                {
                    conn.Close();
                }
                
                try
                {
                    string[] idfilm = new string[35];
                    SqlConnection sconn = new SqlConnection(ConnectionString);
                    using (sconn)
                    {
                        sconn.Open();
                        SqlCommand scommand = new SqlCommand();
                        scommand.Connection = sconn;
                        scommand.CommandText = @"SELECT [IDf] from [View] where [Log]=" + login;
                        SqlDataReader dr = scommand.ExecuteReader();
                        int i = 0;
                        while (dr.Read())
                        {
                            idfilm[i] = dr[0].ToString();
                            i++;
                        }
                        dr.Close();
                    } sconn.Close();
                    for (int i = 0; i < 35; i++)
                    {
                        if (idfilm != null)
                        {
                            if (idfilm[i] != null)
                            {
                                int j = 0;
                                while (dataGridView1.Rows[j].Cells[0].Value.ToString() != idfilm[i])
                                { j++; }
                                dataGridView1.Rows[j].Cells[5].Value = true;
                            }

                        }
                    }
                }
                catch { }
            }
                else { MessageBox.Show("Такого фильма нет", "Извините", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tsbtnAdm_Click(object sender, EventArgs e)
        {
            Admin newAdmin = new Admin();
            newAdmin.Show(); 
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {   lbGenre.Items.Clear();
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
                            dd = dr[0].ToString();
                            richTextBoxDescription.LoadFile(dd);
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
                        poster = dr[0].ToString();
                        pictureBoxPoster.Load(poster);
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
            filmTableAdapter.Fill(fMDbDataSet.Film);
            try
            {
                string[] idfilm = new string[35];
                SqlConnection sconn = new SqlConnection(ConnectionString);
                using (sconn)
                {
                    sconn.Open();
                    SqlCommand scommand = new SqlCommand();
                    scommand.Connection = sconn;
                    scommand.CommandText = @"SELECT [IDf] from [View] where [Log]=" + login;
                    SqlDataReader dr = scommand.ExecuteReader();
                    int i = 0;
                    while (dr.Read())
                    {
                        idfilm[i] = dr[0].ToString();
                        i++;
                    }
                    dr.Close();
                } sconn.Close();
                for (int i = 0; i < 35; i++)
                {
                    if (idfilm != null)
                    {
                        if (idfilm[i] != null)
                        {
                            int j = 0;
                            while (dataGridView1.Rows[j].Cells[0].Value.ToString() != idfilm[i])
                            { j++; }
                            dataGridView1.Rows[j].Cells[5].Value = true;
                        }

                    }
                }
            }
            catch { }
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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!");
                    }
                    finally
                    {
                        conn.Close();
                        this.filmTableAdapter.Fill(this.fMDbDataSet.Film);
                        string[] idfilm = new string[35];
                        SqlConnection sconn = new SqlConnection(ConnectionString);
                        using (sconn)
                        {
                            sconn.Open();
                            SqlCommand scommand = new SqlCommand();
                            scommand.Connection = sconn;
                            scommand.CommandText = @"SELECT [IDf] from [View] where [Log]=" + login;
                            SqlDataReader dr = scommand.ExecuteReader();
                            int i = 0;
                            while (dr.Read())
                            {
                                idfilm[i] = dr[0].ToString();
                                i++;
                            }
                            dr.Close();
                        } sconn.Close();
                        for (int i = 0; i < 35; i++)
                        {
                            if (idfilm != null)
                            {
                                if (idfilm[i] != null)
                                {
                                    int j = 0;
                                    while (dataGridView1.Rows[j].Cells[0].Value.ToString() != idfilm[i])
                                    { j++; }
                                    dataGridView1.Rows[j].Cells[5].Value = true;
                                }

                            }
                        }
                    }
                }
                
            }
        }

        private void tsbtnChange_Click(object sender, EventArgs e)
        {
            name = dataGridView1.SelectedCells[1].Value.ToString();
            year = dataGridView1.SelectedCells[3].Value.ToString();
            time = dataGridView1.SelectedCells[2].Value.ToString();
            int i = 0;
            while (i < lbGenre.Items.Count)
            {
                genres[i] = lbGenre.Items[i].ToString();
                i++;
            }
            i = 0;
            while (i < lbCountry.Items.Count)
            {
                country[i] = lbCountry.Items[i].ToString();
                i++;
            }
            i = 0;
            while (i < lbActors.Items.Count)
            {
                actors[i] = lbActors.Items[i].ToString();
                i++;
            }
            i = 0;
            while (i < lbProd.Items.Count)
            {
                prod[i] = lbProd.Items[i].ToString();
                i++;
            }
            frmAdd newChange = new frmAdd("Изменить", login,dataGridView1.SelectedCells[0].Value.ToString(), name, year, time, genres, country, actors, prod, poster, film, dd);
            newChange.Show(); 
            this.Hide();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {            
            frmAdd newAdd = new frmAdd("Добавить",login,"","","","",null,null,null,null,"","","");
            newAdd.Show(); 
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string str;
            string str1="";
            string str2="";
            string str3="";
            string str4="";
            string str5="";
            if (filterboxName.Text!="")
            {
                str1 = "[Название] like '%" + filterboxName.Text + "%' AND ";
            }
            
            if (filterboxYear1.Text != "" && filterboxYear2.Text!="" )
            {
                str2 = "[Год]>= " + Convert.ToInt32(filterboxYear1.Text) + " AND [Год]<= " + Convert.ToInt32(filterboxYear2.Text) + " AND ";
            }
            else
                if (filterboxYear2.Text == "" && filterboxYear1.Text != "")
                {
                    str2 = "[Год]=" + Convert.ToInt32(filterboxYear1.Text) + " AND ";
                }
                else
                    if (filterboxYear1.Text == "" && filterboxYear2.Text != "")
                    {
                        str2 = "[Год]=" + Convert.ToInt32(filterboxYear2.Text) + " AND ";
                    }
                    
            if (filterboxTime1.Text != "" && filterboxTime2.Text != "")
            {
                str3 = "[Длительность]>= " + Convert.ToInt32(filterboxTime1.Text) + " AND [Длительность]<= " + Convert.ToInt32(filterboxTime2.Text)+" AND ";
            }
            else
                if (filterboxTime2.Text == "" && filterboxTime1.Text != "")
                {
                    str2 = "[Длительность]=" + Convert.ToInt32(filterboxTime1.Text) + " AND ";
                }
                else
                    if (filterboxTime1.Text == "" && filterboxTime2.Text != "")
                    {
                        str2 = "[Длительность]=" + Convert.ToInt32(filterboxTime2.Text) + " AND ";
                    }

            if (filterboxRate1.Text != "" )
            {
                str4 = "[Оценка] like '%" + filterboxRate1.Text+"%' AND ";
            }
            if (checkView.Checked)
            {
                str5 = "[Просмотрен] = true AND";
            }
            str = str1 + str2 + str3 + str4 + str5 + " true";
            viewFilmBindingSource.Filter =str;
        }

        private void filterboxYear1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void filterboxYear2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void filterboxTime1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void filterboxTime2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void filterboxRate1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            viewFilmBindingSource.Filter = "true";
            filterboxRate1.Text = "";
            filterboxName.Text = "";
            filterboxTime1.Text = "";
            filterboxTime2.Text = "";
            filterboxYear1.Text = "";
            filterboxYear2.Text = "";
            checkView.Checked = false;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(dataGridView1.SelectedCells[5].Value))
            {dataGridView1.SelectedCells[5].Value = false;
            SqlConnection conn = null;
                    String query = "DELETE [View] WHERE [IDf]='{0}' AND [Log]='{1}'";
                    try
                    {
                        conn = new SqlConnection(ConnectionString);
                        conn.Open();
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = string.Format(query, dataGridView1.SelectedCells[0].Value.ToString(), login);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!");
                    }
                    finally
                    {
                        conn.Close();
                    }}
            else
            {
                dataGridView1.SelectedCells[5].Value = true;
                SqlConnection conn = null;
                String query = "INSERT INTO [View] VALUES ('{0}','{1}')";
                try
                {
                    conn = new SqlConnection(ConnectionString);
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = string.Format(query, dataGridView1.SelectedCells[0].Value.ToString(), login);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void tsbGCAP_Click(object sender, EventArgs e)
        {
            ChngGCAP newChngGCAP = new ChngGCAP();
            newChngGCAP.Show();
            newChngGCAP.FormClosed += newChngGCAP_FormClosed;
        }

        private void newChngGCAP_FormClosed(object sender, FormClosedEventArgs e)
        {
            filmTableAdapter.Fill(fMDbDataSet.Film);
            try
            {
                string[] idfilm = new string[35];
                SqlConnection sconn = new SqlConnection(ConnectionString);
                using (sconn)
                {
                    sconn.Open();
                    SqlCommand scommand = new SqlCommand();
                    scommand.Connection = sconn;
                    scommand.CommandText = @"SELECT [IDf] from [View] where [Log]=" + login;
                    SqlDataReader dr = scommand.ExecuteReader();
                    int i = 0;
                    while (dr.Read())
                    {
                        idfilm[i] = dr[0].ToString();
                        i++;
                    }
                    dr.Close();
                } sconn.Close();
                for (int i = 0; i < 35; i++)
                {
                    if (idfilm != null)
                    {
                        if (idfilm[i] != null)
                        {
                            int j = 0;
                            while (dataGridView1.Rows[j].Cells[0].Value.ToString() != idfilm[i])
                            { j++; }
                            dataGridView1.Rows[j].Cells[5].Value = true;
                        }

                    }
                }
            }
            catch { }
        }

   

    }
}
