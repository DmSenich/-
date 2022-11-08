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
    public partial class MainForm : Form
    {
        SqlManager myDB;
        public MainForm()
        {
            InitializeComponent();
        }

        private void bAddVisiting_Click(object sender, EventArgs e)
        {
            CreateVisitingForm createVisitingForm = new CreateVisitingForm(myDB);
            //createVisitingForm.Show();
            try
            {
                if (createVisitingForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bAddDoctor_Click(object sender, EventArgs e)
        {
            string sSql = "select * from \"SPECIALTY_TABLE\"";
            DataTable dtSpecs = myDB.iExecuteReader(sSql);
            FormAddDoctor formAddDoctor = new FormAddDoctor(dtSpecs);
            try
            {
                if (formAddDoctor.ShowDialog() == DialogResult.OK)
                {

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bCreateDoc_Click(object sender, EventArgs e)
        {

        }

        private void bAddPatient_Click(object sender, EventArgs e)
        {
            FormAddPatient formAddPatient = new FormAddPatient();
            try
            {
                if (formAddPatient.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
        }

        private void bListVisiting_Click(object sender, EventArgs e)
        {
            FormListPerson formListVisiting = new FormListPerson(2, myDB);
            formListVisiting.Show();
        }

        private void bListDoctor_Click(object sender, EventArgs e)
        {
            FormListPerson formListDoctor = new FormListPerson(0, myDB);
            formListDoctor.Show();
        }

        private void bListPatient_Click(object sender, EventArgs e)
        {
            FormListPerson formListPatient = new FormListPerson(1, myDB);
            formListPatient.Show();
        }

        private void bDisease_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            //myDB.Close();
            //myDB = null;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            //myDB = new SqlManager();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            myDB.Close();
            myDB = null;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            myDB = new SqlManager();
        }
    }
}
