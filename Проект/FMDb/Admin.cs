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
        bool CellsEdit = false;
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
            if (CellsEdit == true)
                if (MessageBox.Show("Вы хотите сохранить изменения?","Сохранение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CellsEdit = false;
                    btnSave_Click(sender, e);
                }
                else
                {
                    CellsEdit = false;
                    loginTableAdapter.Fill(fMDbDataSet.Login);
                }
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                                        this.Validate();
                                        loginBindingSource.EndEdit();
                                        loginTableAdapter.Update(fMDbDataSet);
                                        loginTableAdapter.Fill(fMDbDataSet.Login);
                                    }
                                    CellsEdit = false;
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
                                this.Validate();
                                loginBindingSource.EndEdit();
                                loginTableAdapter.Update(fMDbDataSet);
                                loginTableAdapter.Fill(fMDbDataSet.Login);
                            }
                            CellsEdit = false;
                        }
                    }
                }
                
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Ошибка!");
            }
        }

        private void dgLogPassAdm_CellEndEdit(object sender,DataGridViewCellEventArgs e)
        {
            CellsEdit = true;
            
        }

        private void dgLogPassAdm_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            CellsEdit = true;
        }

        private void dgLogPassAdm_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tbLog.Text = dgLogPassAdm.SelectedCells[0].Value.ToString();
                tbPass.Text = dgLogPassAdm.SelectedCells[1].Value.ToString();
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

    }
}
