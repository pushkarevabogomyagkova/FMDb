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
        public string ConnectionString { get; set; }
        public frmAdd(string _textfrm,string _log)
        {
            InitializeComponent();
            var sb = new SqlConnectionStringBuilder
            {
                DataSource = "GALINA-PC",
                InitialCatalog = "FMDb",
                IntegratedSecurity = true
            };
            ConnectionString = sb.ConnectionString;
            textf=_textfrm;
            this.Text = textf;
            btnCAFilm.Text = textf;
            log = _log;//тут надо нам посмотреть
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Main newMain = new Main(true, log);
            newMain.Show(); this.Hide();
        }

        private void btnNewG_Click(object sender, EventArgs e)
        {

        }
    }
}
