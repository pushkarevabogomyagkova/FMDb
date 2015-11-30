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

    public partial class ChngGCAP : Form
    {
        string path = "D:/ОПРИС/log.rtf";
        string appendText;
        string log;
        public string ConnectionString { get; set; }
        public ChngGCAP(string _log)
        {
            InitializeComponent();
            log = _log;
            var sb = new SqlConnectionStringBuilder
            {
                DataSource = "SUPER_PC",
                InitialCatalog = "FMDb",
                IntegratedSecurity = true
            };
            ConnectionString = sb.ConnectionString;
        }

        private void ChngGCAP_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fMDbDataSet.Producer". При необходимости она может быть перемещена или удалена.
            this.producerTableAdapter.Fill(this.fMDbDataSet.Producer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fMDbDataSet.Actors". При необходимости она может быть перемещена или удалена.
            this.actorsTableAdapter.Fill(this.fMDbDataSet.Actors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fMDbDataSet.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.fMDbDataSet.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fMDbDataSet.Genre". При необходимости она может быть перемещена или удалена.
            this.genreTableAdapter.Fill(this.fMDbDataSet.Genre);


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = new System.Windows.Forms.DialogResult();
            result = MessageBox.Show("Вы уверены, что желаете сохранить изменения?", "FMDb: сохранение изменений ",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    appendText = DateTime.Now.ToString() + ": пользователь " + log + " внес изменения в один из рабочих списков (жанры, страны, актеры, режиссеры).\n";
                    File.AppendAllText(path, appendText, Encoding.UTF8);

                    if (dgvGenre.DataSource == genreBindingSource)
                    {
                        this.Validate();
                        genreBindingSource.EndEdit();
                        genreTableAdapter.Update(fMDbDataSet);
                        genreTableAdapter.Fill(fMDbDataSet.Genre);
                    }
                    if (dgvCountry.DataSource == countryBindingSource)
                    {
                        this.Validate();
                        countryBindingSource.EndEdit();
                        countryTableAdapter.Update(fMDbDataSet);
                        countryTableAdapter.Fill(fMDbDataSet.Country);
                    }
                    if (dgvActors.DataSource == actorsBindingSource)
                    {
                        this.Validate();
                        actorsBindingSource.EndEdit();
                        actorsTableAdapter.Update(fMDbDataSet);
                        actorsTableAdapter.Fill(fMDbDataSet.Actors);
                    }
                    if (dgvProd.DataSource == producerBindingSource)
                    {
                        this.Validate();
                        producerBindingSource.EndEdit();
                        producerTableAdapter.Update(fMDbDataSet);
                        producerTableAdapter.Fill(fMDbDataSet.Producer);
                    }
                }

                catch (Exception except)
                {
                    MessageBox.Show(except.Message, "Ошибка!");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvGenre_CellEndEdit(object sender, DataGridViewCellEventArgs e)
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
                    if (dr[0].ToString() == dgvGenre.CurrentCell.Value.ToString())
                        error = true;
                }
                if (error == true)
                {
                    MessageBox.Show("Такой жанр уже есть!", "Ошибка!");
                    genreTableAdapter.Fill(fMDbDataSet.Genre);
                    error = false;
                }
            } sconn.Close();
        }

        private void dgvCountry_CellEndEdit(object sender, DataGridViewCellEventArgs e)
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
                    if (dr[0].ToString() == dgvCountry.CurrentCell.Value.ToString())
                        error = true;
                }
                if (error == true)
                {
                    MessageBox.Show("Такая страна уже есть!", "Ошибка!");
                    countryTableAdapter.Fill(fMDbDataSet.Country);
                    error = false;
                }
            } sconn.Close();
        }

        private void dgvActors_CellEndEdit(object sender, DataGridViewCellEventArgs e)
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
                    if (dr[0].ToString() == dgvActors.CurrentCell.Value.ToString())
                        error = true;
                }
                if (error == true)
                {
                    MessageBox.Show("Такой актер уже есть!", "Ошибка!");
                    actorsTableAdapter.Fill(fMDbDataSet.Actors);
                    error = false;
                }
            } sconn.Close();
        }

        private void dgvProd_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection sconn = new SqlConnection(ConnectionString);
            bool error = false;
            using (sconn)
            {
                sconn.Open();
                SqlCommand scommand = new SqlCommand();
                scommand.Connection = sconn;
                scommand.CommandText = @"SELECT [name_p] from [Producer]";
                SqlDataReader dr = scommand.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0].ToString() == dgvProd.CurrentCell.Value.ToString())
                        error = true;
                }
                if (error == true)
                {
                    MessageBox.Show("Такой режиссер уже есть!", "Ошибка!");
                    producerTableAdapter.Fill(fMDbDataSet.Producer);
                    error = false;
                }
            } sconn.Close();
        }

        private void tbfGenre_TextChanged(object sender, EventArgs e)
        {
            genreBindingSource.Filter = "[Genre] like '%" + tbfGenre.Text + "%'";
        }

        private void tbfCountry_TextChanged(object sender, EventArgs e)
        {
            countryBindingSource.Filter = "[Country] like '%" + tbfCountry.Text + "%'";
        }

        private void tbfActors_TextChanged(object sender, EventArgs e)
        {
            actorsBindingSource.Filter = "[name] like '%" + tbfActors.Text + "%'";
        }

        private void tbfProd_TextChanged(object sender, EventArgs e)
        {
            producerBindingSource.Filter = "[name_p] like '%" + tbfProd.Text + "%'";
        }
    }

}
