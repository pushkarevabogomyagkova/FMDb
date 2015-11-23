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
    public partial class ChngGCAP : Form
    {
        public ChngGCAP()
        {
            InitializeComponent();
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
