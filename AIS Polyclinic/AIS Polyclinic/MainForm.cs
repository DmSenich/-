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
            ////CreateVisitingForm createVisitingForm = new CreateVisitingForm(myDB);

            ////createVisitingForm.Show();
            
            //string sSql = $"select * from doctor_table";
            //DataTable dtDocs = myDB.iExecuteReader(sSql);
            //sSql = $"select * from patient_table";
            //DataTable dtPatients = myDB.iExecuteReader(sSql);

            //CreateVisitingForm createVisitingForm = new CreateVisitingForm(myDB);
            //try
            //{
            //    if (createVisitingForm.ShowDialog() == DialogResult.OK)
            //    {

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void bAddDoctor_Click(object sender, EventArgs e)
        {
            //string sSql = "select * from \"SPECIALTY_TABLE\"";
            //DataTable dtSpecs = myDB.iExecuteReader(sSql);
            //FormAddDoctor formAddDoctor = new FormAddDoctor(dtSpecs);
            //try
            //{
            //    if (formAddDoctor.ShowDialog() == DialogResult.OK)
            //    {
            //        string[] fio = formAddDoctor.FIO;
            //        int workExp = formAddDoctor.WorkExp;
            //        DataTable dtSpec = formAddDoctor.DTSpec;
            //        //if(dtSpec == null || dtSpec.Rows.Count == 0)
            //        //{
            //        //    throw new Exception("Нет специальностей (2)!");
            //        //}


            //        Image photo = formAddDoctor.GetPHOTO;
            //        byte[] blob = InfoForm.ToByte(photo);
            //        //sSql = $"insert into doctor_table (last_name, first_name, patronymic, work_experience) values('{fio[0]}', '{fio[1]}', '{fio[2]}', {workExp})"; // ДОБАВИТЬ ФОТО
            //        sSql = $"EXECUTE PROCEDURE add_doctor('{fio[0]}', '{fio[1]}', '{fio[2]}', {workExp}, {blob})";

            //        myDB.iExeecuteNonQuery(sSql);
            //        //sSql = $"select * from doctor_table where last_name = '{fio[0]}' and first_name = '{fio[1]}' and patronymic = '{fio[2]}' and work_experience = {workExp}";                  
            //        //DataTable newDoc = myDB.iExecuteReader(sSql);
            //        //int id = Convert.ToInt32(newDoc.Rows[0][0]);
            //        sSql = $"select max(id_doctor) from doctor_table";

            //        int id = myDB.iExecuteScalar(sSql);
            //        foreach(DataRow row in dtSpec.Rows)
            //        {
            //            //sSql = $"insert into \"DOCTOR-SPECIALTY_TABLE\" (id_doctor, id_specialty) values({id}, {row[0]}) ";
            //            sSql = $"execute procedure add_doc_spec({id}, {row[0]})";
            //            myDB.iExeecuteNonQuery(sSql);
            //        }
            //    }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void bCreateDoc_Click(object sender, EventArgs e)
        {
            FormGenerateDoc generateDoc = new FormGenerateDoc(myDB);
            generateDoc.Show();
        }

        private void bAddPatient_Click(object sender, EventArgs e)
        {
            //FormAddPatient formAddPatient = new FormAddPatient();
            //try
            //{
            //    if (formAddPatient.ShowDialog() == DialogResult.OK)
            //    {
            //        string[] fio = formAddPatient.FIO;
            //        string[] adress = formAddPatient.Adress;
            //        DateTime dateBirth = formAddPatient.DateBirth;

            //        //string sSql = $"insert into patient_table (last_name, first_name, patronymic, area, city, house, apartment, date_birth) values('{fio[0]}', '{fio[1]}', '{fio[2]}', '{adress[0]}', '{adress[1]}', '{adress[2]}', '{adress[3]}', '{dateBirth.ToShortDateString()}')";
            //        string sSql = $"execute procedure add_patient('{fio[0]}', '{fio[1]}', '{fio[2]}', '{adress[0]}', '{adress[1]}', '{adress[2]}', '{adress[3]}', '{dateBirth.ToShortDateString()}')";
            //        myDB.iExeecuteNonQuery(sSql);
            //    }
            //}
            //catch( Exception ex)
            //{
            //    MessageBox.Show(ex.Message );
            //}
        }

        private void bListVisiting_Click(object sender, EventArgs e)
        {
            //FormListPerson formListVisiting = new FormListPerson(2, myDB);
            //formListVisiting.Show();
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
            //myDB.Close();
            myDB = null;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            myDB = new SqlManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bSwitchVisitings_Click(object sender, EventArgs e)
        {
            SwitchVisualVisitings visitingsForm = new SwitchVisualVisitings(myDB);
            visitingsForm.Show();
        }

        private void bAdminUp_Click(object sender, EventArgs e)
        {
            try
            {
                FormForAdm adm = new FormForAdm(myDB);
                adm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Все английские слова перевести
        Добавить номер медицинского страхования пациентов
        Выводить врачей со специальностями
        Запретить создание (изменение) врачей без специальности (должна быть хотя бы одна)*/
    }
}
