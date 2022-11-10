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
                    string[] fio = formAddDoctor.FIO;
                    int workExp = formAddDoctor.WorkExp;
                    DataTable dtSpec = formAddDoctor.DTSpec;
                    sSql = $"insert into doctor_table (last_name, first_name, patronymic, work_experience) values('{fio[0]}', '{fio[1]}', '{fio[2]}', {workExp})"; // ДОБАВИТЬ ФОТО
                    myDB.iExeecuteNonQuery(sSql);
                    sSql = $"select * from doctor_table where last_name = '{fio[0]}' and first_name = '{fio[1]}' and patronymic = '{fio[2]}' and work_experience = {workExp}";
                    DataTable newDoc = myDB.iExecuteReader(sSql);
                    int id = Convert.ToInt32(newDoc.Rows[0][0]);
                    foreach(DataRow row in dtSpec.Rows)
                    {
                        sSql = $"insert into \"DOCTOR-SPECIALTY_TABLE\" (id_doctor, id_specialty) values({id}, {row[0]}) ";
                        myDB.iExeecuteNonQuery(sSql);
                    }
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
