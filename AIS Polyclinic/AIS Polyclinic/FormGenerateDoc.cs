using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_Polyclinic
{
    public partial class FormGenerateDoc : Form
    {
        SqlManager myDB;
        private FormGenerateDoc()
        {
            InitializeComponent();
        }
        public FormGenerateDoc(SqlManager myDB) : this()
        {
            this.myDB = myDB;
        }

        private void bListingDoctors_Click(object sender, EventArgs e)
        {
            FormListingDocOnSpec docOnSpec = new FormListingDocOnSpec(myDB);
            if(docOnSpec.ShowDialog() == DialogResult.OK)
            {
                docOnSpec.Close();
            }
            //docOnSpec.Show();
        }

        private void bCountVisiting_Click(object sender, EventArgs e)
        {
            FormCountVisiting countVisiting = new FormCountVisiting(myDB);
            countVisiting.Show();
        }

        private void bCountDisease_Click(object sender, EventArgs e)
        {
            FormCountDiseases countDiseases = new FormCountDiseases(myDB);
            if(countDiseases.ShowDialog() == DialogResult.OK)
            {
                countDiseases.Close();
            }
        }
    }
}
