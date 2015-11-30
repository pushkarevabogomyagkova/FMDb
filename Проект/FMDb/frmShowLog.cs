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
    public partial class frmShowLog : Form
    {
        string path = "D:/ОПРИС/log.rtf";
        string appendText;
        public frmShowLog()
        {
            InitializeComponent();
        }

        private void frmShowLog_Load(object sender, EventArgs e)
        {
            label1.Focus();       
            rtbShow.Text = File.ReadAllText(path);
            int length = rtbShow.Text.Length;
            rtbShow.Text = rtbShow.Text.Remove(length-1);
            rtbShow.Select(length-1, 0);
            rtbShow.ScrollToCaret();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {   var result = new System.Windows.Forms.DialogResult();
            result = MessageBox.Show("Вы уверены, что желаете удалить лог?", "FMDb: Удаление лога",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                rtbShow.Clear();
                File.Delete(path);
                appendText = DateTime.Now.ToString() + " Лог был очищен.\n";
                File.AppendAllText(path, appendText, Encoding.UTF8);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
