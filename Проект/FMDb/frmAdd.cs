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
    public partial class frmAdd : Form
    {
        string log;
        string textf;
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
        string idf;
        public string ConnectionString { get; set; }
        public frmAdd(string _textfrm,string _log,string _idf,string _name, string _year, string _time,string[] _genre,string[] _country, string[] _actor, string[] _prod, string _poster,string _film, string _d)
        {
            InitializeComponent();


            var sb = new SqlConnectionStringBuilder
            {
                DataSource = "SUPER_PC",
                InitialCatalog = "FMDb",
                IntegratedSecurity = true
            };
            ConnectionString = sb.ConnectionString;
            textf=_textfrm;
            this.Text = textf;
            btnCAFilm.Text = textf;
            log = _log;
            idf = _idf;
            name = _name;
            year = _year;
            time = _time;
            genres = _genre;
            country = _country;
            actors = _actor;
            prod = _prod;
            poster = _poster;
            film = _film;
            dd = _d;
            tbName.Text = _name;
            tbYear.Text = _year;
            tbTime.Text = _time;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void btnNewG_Click(object sender, EventArgs e)
        {
            if (tbNameG.Text != "")
            {
                SqlConnection sconn = new SqlConnection(ConnectionString);
                bool error = false;
                using (sconn)
                {
                    sconn.Open();
                    SqlCommand scommand = new SqlCommand();
                    scommand.Connection = sconn;
                    scommand.CommandText = @"SELECT [Genre] from [Genre]";
                    SqlDataReader dr = scommand.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr[0].ToString() == tbNameG.Text)
                            error = true;
                    }
                    if (error == true)
                    {
                        MessageBox.Show("Такой жанр уже есть!", "Ошибка!");
                        genreTableAdapter.Fill(fMDbDataSet.Genre);
                        error = false;
                    }
                    else
                    {
                        genreTableAdapter.Insert(tbNameG.Text);
                        this.genreTableAdapter.Fill(this.fMDbDataSet.Genre);
                        cbG.SelectedIndex = cbG.Items.Count - 1;
                        rbtnSelG.Checked = true;
                    }
                } sconn.Close();
                tbNameG.Text = "";
            }
            else
            { MessageBox.Show("Вы не ввели название жанра!"); }
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            
            rbtnSelG.Checked = true;
            rbtnSelA.Checked = true;
            rbtnSelC.Checked = true;
            rbtnSelP.Checked = true;
            btnNewG.Enabled = false;
            tbNameG.Enabled = false;
            btnNewA.Enabled = false;
            tbNameA.Enabled = false;
            btnNewC.Enabled = false;
            tbNameC.Enabled = false;
            btnNewP.Enabled = false;
            tbNameP.Enabled = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fMDbDataSet.Producer". При необходимости она может быть перемещена или удалена.
            this.producerTableAdapter.Fill(this.fMDbDataSet.Producer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fMDbDataSet.Actors". При необходимости она может быть перемещена или удалена.
            this.actorsTableAdapter.Fill(this.fMDbDataSet.Actors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fMDbDataSet.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.fMDbDataSet.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fMDbDataSet.Genre". При необходимости она может быть перемещена или удалена.
            this.genreTableAdapter.Fill(this.fMDbDataSet.Genre);
            if (genres != null)
            {
                for (int i = 0; i < 35; i++)
                {
                    if (genres[i] != null) { lbG.Items.Add(genres[i]); }
                    if (country[i] != null) { lbC.Items.Add(country[i]); }
                    if (actors[i] != null) { lbA.Items.Add(actors[i]); }
                    if (prod[i] != null) { lbP.Items.Add(prod[i]); }
                }
            }
            if (lbG.Items.Count>0) lbG.SelectedIndex = 0;
            if (lbC.Items.Count > 0) lbC.SelectedIndex = 0;
            if (lbA.Items.Count > 0) lbA.SelectedIndex = 0;
            if (lbP.Items.Count > 0) lbP.SelectedIndex = 0;
            rbtnSelG.Checked=true;
            rbtnSelC.Checked = true;
            rbtnSelA.Checked = true;
            rbtnSelP.Checked = true;
            if (btnCAFilm.Text == "Изменить")
            {   SqlConnection sconn = null;
                sconn = new SqlConnection(ConnectionString);
                using (sconn)
                {
                    sconn.Open();
                    var command = new SqlCommand
                    {
                        Connection = sconn,
                        CommandText = "SELECT [Путь к фильму],[Путь к постеру],[Путь к описанию] FROM [Film] WHERE IDMovie = " + Convert.ToInt32(idf),
                        CommandType = CommandType.Text
                    };
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        tbFilm.Text = dr[0].ToString();
                        tbPoster.Text = dr[1].ToString();
                        tbDesc.Text = dr[2].ToString();
                    }
                    dr.Close();
                } sconn.Close();
            }
        }

        private void btnNewC_Click(object sender, EventArgs e)
        {
            if (tbNameC.Text != "")
            {
                SqlConnection sconn = new SqlConnection(ConnectionString);
                bool error = false;
                using (sconn)
                {
                    sconn.Open();
                    SqlCommand scommand = new SqlCommand();
                    scommand.Connection = sconn;
                    scommand.CommandText = @"SELECT [Country] from [Country]";
                    SqlDataReader dr = scommand.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr[0].ToString() == tbNameC.Text)
                            error = true;
                    }
                    if (error == true)
                    {
                        MessageBox.Show("Такая страна уже есть!", "Ошибка!");
                        countryTableAdapter.Fill(fMDbDataSet.Country);
                        error = false;
                    }
                    else
                    {
                        countryTableAdapter.Insert(tbNameC.Text);
                        this.countryTableAdapter.Fill(this.fMDbDataSet.Country);
                        cbC.SelectedIndex = cbC.Items.Count - 1;
                        rbtnSelC.Checked = true;
                    }
                } sconn.Close();
                tbNameC.Text = "";
            }
            else
            { MessageBox.Show("Вы не ввели название страны!"); }
        }

        private void btnNewA_Click(object sender, EventArgs e)
        {
            if (tbNameA.Text != "")
            {
                SqlConnection sconn = new SqlConnection(ConnectionString);
                bool error = false;
                using (sconn)
                {
                    sconn.Open();
                    SqlCommand scommand = new SqlCommand();
                    scommand.Connection = sconn;
                    scommand.CommandText = @"SELECT [name] from [Actors]";
                    SqlDataReader dr = scommand.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr[0].ToString() == tbNameA.Text)
                            error = true;
                    }
                    if (error == true)
                    {
                        MessageBox.Show("Такой актер уже есть!", "Ошибка!");
                        actorsTableAdapter.Fill(fMDbDataSet.Actors);
                        error = false;
                    }
                    else
                    {
                        actorsTableAdapter.Insert(tbNameA.Text);
                        this.actorsTableAdapter.Fill(this.fMDbDataSet.Actors);
                        cbA.SelectedIndex = cbA.Items.Count - 1;
                        rbtnSelA.Checked = true;
                    }
                } sconn.Close();
                tbNameA.Text = "";
            }
            else
            { MessageBox.Show("Вы не ввели имя актера!"); }
        }

        private void btnNewP_Click(object sender, EventArgs e)
        {
            if (tbNameP.Text != "")
            {
                SqlConnection sconn = new SqlConnection(ConnectionString);
                bool error = false;
                using (sconn)
                {
                    sconn.Open();
                    SqlCommand scommand = new SqlCommand();
                    scommand.Connection = sconn;
                    scommand.CommandText = @"SELECT [Name_p] from [Producer]";
                    SqlDataReader dr = scommand.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr[0].ToString() == tbNameP.Text)
                            error = true;
                    }
                    if (error == true)
                    {
                        MessageBox.Show("Такой режиссер уже есть!", "Ошибка!");
                        producerTableAdapter.Fill(fMDbDataSet.Producer);
                        error = false;
                    }
                    else
                    {
                        producerTableAdapter.Insert(tbNameP.Text);
                        this.producerTableAdapter.Fill(this.fMDbDataSet.Producer);
                        cbP.SelectedIndex = cbP.Items.Count - 1;
                        rbtnSelP.Checked = true;
                    }
                } sconn.Close();
                tbNameP.Text = "";
            }
            else
            { MessageBox.Show("Вы не ввели имя режиссера!"); }
        }

        private void btnAddG_Click(object sender, EventArgs e)
        {
            if (!lbG.Items.Contains(cbG.Text))
            {
                lbG.Items.Add(cbG.Text);
                lbG.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Жанр уже внесен! Повторно внесен не будет.", "Ошибка!");
            
        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            if (!lbC.Items.Contains(cbC.Text))
            {
                lbC.Items.Add(cbC.Text);
                lbC.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Cтрана уже внесена! Повторно внесена не будет.", "Ошибка!");
        }

        private void btnAddA_Click(object sender, EventArgs e)
        {
            if (!lbA.Items.Contains(cbA.Text))
            {
                lbA.Items.Add(cbA.Text);
                lbA.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Актер уже внесен! Повторно внесен не будет.", "Ошибка!");
        }

        private void btnAddP_Click(object sender, EventArgs e)
        {
            if (!lbP.Items.Contains(cbP.Text))
            { 
                lbP.Items.Add(cbP.Text);
                lbP.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Режиссер уже внесен! Повторно внесен не будет.", "Ошибка!");
        }

        private void btnDelG_Click(object sender, EventArgs e)
        {
            if (lbG.SelectedIndex >= 0)
            {
                int del = lbG.SelectedIndex;
                lbG.Items.RemoveAt(del);
            }
            else { MessageBox.Show("Нет жанров для удаления!"); }
        }

        private void btnDelC_Click(object sender, EventArgs e)
        {
            if (lbC.SelectedIndex >= 0)
            {
                int del = lbC.SelectedIndex;
                lbC.Items.RemoveAt(del);
            
            }
            else { MessageBox.Show("Нет стран для удаления!"); }
        }

        private void btnDelA_Click(object sender, EventArgs e)
        {
            if (lbA.SelectedIndex >= 0)
            {
                int del = lbA.SelectedIndex;
                lbA.Items.RemoveAt(del);
            }
            else { MessageBox.Show("Нет актеров для удаления!"); }
        }

        private void btnDelP_Click(object sender, EventArgs e)
        {
            if (lbP.SelectedIndex >= 0)
            {
                int del = lbP.SelectedIndex;
                lbP.Items.RemoveAt(del);
            }
            else { MessageBox.Show("Нет режиссеров для удаления!"); }
        }

        private void btnPoster_Click(object sender, EventArgs e)
        {

            ofdPoster.Title = "Выберите файл";
            ofdPoster.Filter = "Изображения|*.bmp";
            ofdPoster.FileName = "";
            if (ofdPoster.ShowDialog() != DialogResult.OK) return;
            tbPoster.Text = ofdPoster.FileName;

        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            ofdFilm.Title = "Выберите файл";
            ofdFilm.Filter = "Видео файлы|*.mp4;*.avi;*.mkv";
            if (ofdFilm.ShowDialog() != DialogResult.OK) return;
            tbFilm.Text = ofdFilm.FileName;
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            ofdDesc.Title = "Выберите файл";
            ofdDesc.Filter = "Текстовые файлы|*.rtf";
            if (ofdDesc.ShowDialog() != DialogResult.OK) return;
            tbDesc.Text = ofdDesc.FileName;
        }


        private void AddNewFilm(int idfilm,int s, int c, string r)
        
        {
            int idG = 0;
            int idA= 0;
            int idP = 0;
            int idC = 0;
            
            
                if (rbtnSelG.Checked == true && rbtnSelC.Checked == true && rbtnSelA.Checked == true && rbtnSelP.Checked == true && cbG.Text != "" && cbC.Text != "" && cbA.Text != "" && cbP.Text != "" && tbName.Text != "" && tbYear.Text != "" && tbTime.Text != "" && lbG.Items.Count != 0 && lbC.Items.Count != 0 && lbC.Items.Count != 0 && lbP.Items.Count != 0)
                {

                    SqlConnection conn = new SqlConnection(ConnectionString);
                    using (conn)
                    {
                        conn.Open();
                        var command = new SqlCommand
                        {
                            Connection = conn,
                            CommandText = "(Select MAX(IDMovie) from Film)",
                            CommandType = CommandType.Text
                        };
                        SqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            idfilm = Convert.ToInt32(dr[0].ToString()) + 1;
                        }
                        dr.Close();
                    }
                    conn.Close();
                    SqlConnection sconn = new SqlConnection(ConnectionString);
                    String query1 = "INSERT INTO [Film] ([IDMovie],[Название],[Длительность],[Год],[Путь к описанию],[Путь к фильму],[Путь к постеру],[sum],[count],[rate],[Просмотрен]) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','False')";
                    using (sconn)
                    {
                        sconn.Open();
                        SqlCommand scommand = new SqlCommand();
                        scommand.Connection = sconn;
                        scommand.CommandText = string.Format(query1,idfilm, tbName.Text,Convert.ToInt32(tbTime.Text), Convert.ToInt32(tbYear.Text),tbDesc.Text,tbFilm.Text,tbPoster.Text,s,c,r);
                        scommand.CommandType = CommandType.Text;
                        scommand.ExecuteNonQuery();
                    } sconn.Close();

                    SqlConnection conn1 = new SqlConnection(ConnectionString);
                    using (conn1)
                    {
                        conn1.Open();
                        foreach (var lbGItem in lbG.Items)
                        {
                            var command = new SqlCommand
                            {
                                Connection = conn1,
                                CommandText = "SELECT [IDG] FROM [Genre] WHERE [Genre] = '"+lbGItem.ToString()+"'",
                                CommandType = CommandType.Text
                            };
                            SqlDataReader dr = command.ExecuteReader();
                            while (dr.Read())
                            {
                               idG = Convert.ToInt32(dr[0].ToString());
                            }
                            dr.Close();
                            String query2 = "INSERT INTO [MovieGenre] VALUES ('{0}','{1}')";
                          
                                SqlCommand scommand = new SqlCommand();
                                scommand.Connection = conn1;
                                scommand.CommandText = string.Format(query2, idfilm, idG);
                                scommand.CommandType = CommandType.Text;
                                scommand.ExecuteNonQuery();
                           
                        }
                    }
                    conn1.Close();

                    SqlConnection conn2 = new SqlConnection(ConnectionString);
                    using (conn2)
                    {
                        conn2.Open();
                        foreach (var lbAItem in lbA.Items)
                        {
                            var command = new SqlCommand
                            {
                                Connection = conn2,
                                CommandText = "SELECT [IDact] FROM [Actors] WHERE [name] = '" + lbAItem.ToString() + "'",
                                CommandType = CommandType.Text
                            };
                            SqlDataReader dr = command.ExecuteReader();
                            while (dr.Read())
                            {
                                idA = Convert.ToInt32(dr[0].ToString());
                            }
                            dr.Close();
                            String query2 = "INSERT INTO [MovieActor] VALUES ('{0}','{1}')";

                            SqlCommand scommand = new SqlCommand();
                            scommand.Connection = conn2;
                            scommand.CommandText = string.Format(query2, idfilm, idA);
                            scommand.CommandType = CommandType.Text;
                            scommand.ExecuteNonQuery();

                        }
                    }
                    conn2.Close();

                    SqlConnection conn3 = new SqlConnection(ConnectionString);
                    using (conn3)
                    {
                        conn3.Open();
                        foreach (var lbCItem in lbC.Items)
                        {
                            var command = new SqlCommand
                            {
                                Connection = conn3,
                                CommandText = "SELECT [IDC] FROM [Country] WHERE [Country] = '" + lbCItem.ToString() + "'",
                                CommandType = CommandType.Text
                            };
                            SqlDataReader dr = command.ExecuteReader();
                            while (dr.Read())
                            {
                                idC = Convert.ToInt32(dr[0].ToString());
                            }
                            dr.Close();
                            String query2 = "INSERT INTO [MovieCountry] VALUES ('{0}','{1}')";

                            SqlCommand scommand = new SqlCommand();
                            scommand.Connection = conn3;
                            scommand.CommandText = string.Format(query2, idfilm, idC);
                            scommand.CommandType = CommandType.Text;
                            scommand.ExecuteNonQuery();

                        }
                    }
                    conn3.Close();

                    SqlConnection conn4 = new SqlConnection(ConnectionString);
                    using (conn4)
                    {
                        conn4.Open();
                        foreach (var lbPItem in lbP.Items)
                        {
                            var command = new SqlCommand
                            {
                                Connection = conn4,
                                CommandText = "SELECT [IDprod] FROM [Producer] WHERE [Name_p] = '" + lbPItem.ToString() + "'",
                                CommandType = CommandType.Text
                            };
                            SqlDataReader dr = command.ExecuteReader();
                            while (dr.Read())
                            {
                                idP = Convert.ToInt32(dr[0].ToString());
                            }
                            dr.Close();
                            String query2 = "INSERT INTO [MovieProducer] VALUES ('{0}','{1}')";

                            SqlCommand scommand = new SqlCommand();
                            scommand.Connection = conn4;
                            scommand.CommandText = string.Format(query2, idfilm, idP);
                            scommand.CommandType = CommandType.Text;
                            scommand.ExecuteNonQuery();

                        }
                    }
                    conn4.Close();
                    Main newMain = new Main(true, log);
                    newMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Заполните все поля!", "Ошибка!");
                }        
        }

        private void btnCAFilm_Click(object sender, EventArgs e)
        {
            if (this.Text=="Добавить")
            {
                AddNewFilm(0,0,0,"0");     
            }
            else
            {
                int sum=0;
                int count = 0;
                string rate="";
                bool view=false;
                SqlConnection sconn = null;
                sconn = new SqlConnection(ConnectionString);
                using (sconn)
                {
                    sconn.Open();
                    var command = new SqlCommand
                    {
                        Connection = sconn,
                        CommandText = "SELECT [sum],[count],[rate] FROM [Film] WHERE IDMovie = " + Convert.ToInt32(idf),
                        CommandType = CommandType.Text
                    };
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        sum = Convert.ToInt32(dr[0].ToString());
                        count = Convert.ToInt32(dr[1].ToString());
                        rate = dr[2].ToString();
                    }
                    dr.Close();
                } sconn.Close();

                SqlConnection sconn11 = new SqlConnection(ConnectionString);
                using (sconn11)
                {
                    sconn11.Open();
                    SqlCommand scommand = new SqlCommand();
                    scommand.Connection = sconn11;
                    scommand.CommandText = @"SELECT [IDf] from [View] where [Log]=" + log+" AND IDf="+Convert.ToInt32(idf);
                    SqlDataReader dr = scommand.ExecuteReader();
                    while (dr.Read())
                    {
                        view = true;
                    }
                    dr.Close();
                } sconn.Close();
                SqlConnection conn = null;
                String query = "DELETE Film WHERE [IDMovie]='{0}'";
                try
                {
                    conn = new SqlConnection(ConnectionString);
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = string.Format(query, Convert.ToInt32(idf));
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
                int intidf = Convert.ToInt32(idf);
                AddNewFilm(intidf, sum, count, rate);

                if (view)
                {
                    SqlConnection conn1 = null;
                    string query2 = "INSERT INTO [View] VALUES ('{0}','{1}')";
                    try
                    {
                        conn1 = new SqlConnection(ConnectionString);
                        conn1.Open();
                        using (var cmd = conn1.CreateCommand())
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = string.Format(query2, intidf.ToString(), log);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    { }
                    finally
                    {
                        conn1.Close();
                    }
                }
                Main newMain = new Main(true, log);
                newMain.Show();
                this.Hide();
            }

        }

        private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void tbTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void rbtnNewG_CheckedChanged(object sender, EventArgs e)
        {
            btnNewG.Enabled = true;
            tbNameG.Enabled = true;
            btnAddG.Enabled = false;
        }

        private void rbtnNewC_CheckedChanged(object sender, EventArgs e)
        {
            btnNewC.Enabled = true;
            tbNameC.Enabled = true;
            btnAddC.Enabled = false;
        }

        private void rbtnNewA_CheckedChanged(object sender, EventArgs e)
        {
            btnNewA.Enabled = true;
            tbNameA.Enabled = true;
            btnAddA.Enabled = false;
        }

        private void rbtnNewP_CheckedChanged(object sender, EventArgs e)
        {
            btnNewP.Enabled = true;
            tbNameP.Enabled = true;
            btnAddP.Enabled = false;
        }

        private void frmAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main newMain = new Main(true, log);
            newMain.Show();
        }

        private void rbtnSelG_CheckedChanged(object sender, EventArgs e)
        {
            btnNewG.Enabled = false;
            tbNameG.Enabled = false;
            btnAddG.Enabled = true;
        }

        private void rbtnSelC_CheckedChanged(object sender, EventArgs e)
        {
            btnNewC.Enabled = false;
            tbNameC.Enabled = false;
            btnAddC.Enabled = true;
        }

        private void rbtnSelA_CheckedChanged(object sender, EventArgs e)
        {
            btnNewA.Enabled = false;
            tbNameA.Enabled = false;
            btnAddA.Enabled = true;
        }

        private void rbtnSelP_CheckedChanged(object sender, EventArgs e)
        {
            btnNewP.Enabled = false;
            tbNameP.Enabled = false;
            btnAddP.Enabled = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }




    }
}
