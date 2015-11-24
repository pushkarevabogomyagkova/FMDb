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
        public frmShowLog()
        {
            InitializeComponent();
        }

        private void frmShowLog_Load(object sender, EventArgs e)
        {
            rtbShow.Text = File.ReadAllText("D:/ОПРИС/log.rtf");
        }
    }
}
