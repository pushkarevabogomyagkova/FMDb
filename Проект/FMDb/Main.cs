using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Main(bool _adm, string _login)
        {
            InitializeComponent();
            adm = _adm;
            login = _login;
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

        private void btnRule_Click(object sender, EventArgs e)
        {
            frmAdmin newAdmin = new frmAdmin();
            newAdmin.Show();
        }

        private void tsbtnSearch_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = !panelSearch.Visible;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsSearch_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsSearch_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

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

    }
}
