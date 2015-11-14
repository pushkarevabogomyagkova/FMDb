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
    public partial class Admin : Form
    {
        string ConnectionString { get; set; }            
        public Admin()
        {
            InitializeComponent();
            var sb = new SqlConnectionStringBuilder
            {
                //DataSource = "SUPER_PC",
                DataSource = "GALINA-PC",
                InitialCatalog = "FMDb",
                IntegratedSecurity = true
            };
            ConnectionString = sb.ConnectionString;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fMDbDataSet.Login". При необходимости она может быть перемещена или удалена.
            this.loginTableAdapter.Fill(this.fMDbDataSet.Login);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgLogPassAdm_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tbLog.Text = dgLogPassAdm.SelectedCells[0].Value.ToString();
                tbPass.Text = dgLogPassAdm.SelectedCells[1].Value.ToString();
                chbChange.Checked = Convert.ToBoolean(dgLogPassAdm.SelectedCells[2].Value);
            }
            catch (Exception ex)
            { }
        }

        private void tbLog_TextChanged(object sender, EventArgs e)
        {
            lblErLog.Text = "";
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            lblErPass.Text = "";
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbLog.Text == "") { lblErLog.Text = "Введите логин"; }
                else
                {
                    if (tbPass.Text == "") { lblErPass.Text = "Введите пароль"; }
                    else
                    {
                        if (tbLog.Text != dgLogPassAdm.SelectedCells[0].Value.ToString())
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
                                { lblErLog.Text = "Такой логин уже есть"; }
                                else
                                {
                                    if (dgLogPassAdm.DataSource == loginBindingSource)
                                    {
                                        dgLogPassAdm.SelectedCells[0].Value = tbLog.Text;
                                        dgLogPassAdm.SelectedCells[1].Value = tbPass.Text;
                                        dgLogPassAdm.SelectedCells[2].Value = chbChange.Checked;
                                        this.Validate();
                                        loginBindingSource.EndEdit();
                                        loginTableAdapter.Update(fMDbDataSet);
                                        loginTableAdapter.Fill(fMDbDataSet.Login);
                                    }
                                }
                                dr.Close();
                            }
                        }
                        else
                        {
                            if (dgLogPassAdm.DataSource == loginBindingSource)
                            {
                                dgLogPassAdm.SelectedCells[0].Value = tbLog.Text;
                                dgLogPassAdm.SelectedCells[1].Value = tbPass.Text;
                                dgLogPassAdm.SelectedCells[2].Value = chbChange.Checked;
                                this.Validate();
                                loginBindingSource.EndEdit();
                                loginTableAdapter.Update(fMDbDataSet);
                                loginTableAdapter.Fill(fMDbDataSet.Login);
                            }
                        }
                    }
                }

            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Ошибка!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
                        { lblAddLog.Text = "Такой логин уже есть"; dr.Close(); }
                        else
                        {
                            SqlConnection conn = null;
                            string query = "INSERT INTO Login VALUES ('{0}','{1}','{2}')";
                            try
                            {
                                conn = new SqlConnection(ConnectionString);
                                conn.Open();
                                using (var cmd = conn.CreateCommand())
                                {
                                    cmd.CommandType = CommandType.Text;
                                    cmd.CommandText = string.Format(query, tbNewLog.Text, tbNewPass.Text,chbAdm.Checked);
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

                        dr.Close();
                        this.loginTableAdapter.Fill(this.fMDbDataSet.Login);
                    }
                }
                else { lblAddPass.Text = "Введите пароль"; }
            }
            else { lblAddLog.Text = "Введите логин"; }
            
        }

        private void btnDel_Click(object sender, EventArgs e)   
        {
            var result = new System.Windows.Forms.DialogResult();
            result = MessageBox.Show("Вы уверены, что желаете удалить эту запись?", "FMDb: Удаление ",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dgLogPassAdm.SelectedCells.Count == 3)
                {
                    SqlConnection conn = null;
                    String query = "DELETE Login WHERE [Login]='{0}'";
                    try
                    {
                        conn = new SqlConnection(ConnectionString);
                        conn.Open();
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = string.Format(query, dgLogPassAdm.SelectedCells[0].Value.ToString());
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
                        this.loginTableAdapter.Fill(this.fMDbDataSet.Login);
                    }
                }
            }
        }

    }
}
