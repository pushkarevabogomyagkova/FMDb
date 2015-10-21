using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMDb
{
    public partial class Main : Form
    {
        bool adm;
        public Main(bool _adm)
        {
            InitializeComponent();
            adm = _adm;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
