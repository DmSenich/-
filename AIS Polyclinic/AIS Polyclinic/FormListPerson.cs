using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AIS_Polyclinic
{
    public partial class FormListPerson : Form
    {
        int numTable;
        SqlManager myDB;
        string sSql;
        DataTable dt;

        private FormListPerson()
        {
            InitializeComponent();
        }
        public FormListPerson(int num, SqlManager myDB) : this()
        {
            numTable = num;
            this.myDB = myDB;
            //switch (num)
            //{
            //    case 0:
            //        this.Text = "List of doctors";
            //        break;
            //    case 1:
            //        this.Text = "List of patients";
            //        break;
            //    case 2:
            //        this.Text = "List of visiting";
            //        break;
            //}
        }

        private void FormListPerson_Activated(object sender, EventArgs e)
        {
            updateDataView();
        }
        private void CreateUserTable()
        {
            //dataPerson.Columns.Add("idCol", "id");
            //dataPerson.Columns[0].Visible = false;
            DataTable table = new DataTable();
            table.Columns.Add("id");
            switch (numTable)
            {
                case 0:
                    table.Columns.Add("FIO Doctor");
                    
                    for(int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = table.NewRow();
                        dr[0] = dt.Rows[i][0];
                        dr[1] = String.Join(" ", dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString());
                        table.Rows.Add(dr);
                    }
                    
                    break;
                case 1:
                    table.Columns.Add("FIO Patient");

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = table.NewRow();
                        dr[0] = dt.Rows[i][0];
                        dr[1] = String.Join(" ", dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString());
                        table.Rows.Add(dr);
                    }
                    break;
                case 2:
                    //table.Columns.Add("Date");
                    //table.Columns.Add("FIO Doctor");
                    //table.Columns.Add("FIO Patient");

                    //for (int i = 0; i < dt.Rows.Count; i++)
                    //{
                    //    int idD = Convert.ToInt32(dt.Rows[i][2]),
                    //        idP = Convert.ToInt32(dt.Rows[i][3]);
                        
                    //    DataRow dr = table.NewRow();
                    //    dr[0] = dt.Rows[i][0];
                    //    dr[1] = Convert.ToDateTime(dt.Rows[i][1]).ToString("dd.MM.yyyy");
                    //    string sql = $"select * from doctor_table where id_doctor = {idD}";
                    //    DataTable data = myDB.iExecuteReader(sql);
                    //    dr[2] = String.Join(" ", data.Rows[0][1].ToString(), data.Rows[0][2].ToString(), data.Rows[0][3].ToString());
                    //    sql = $"select * from patient_table where id_patient = {idP}";
                    //    data = myDB.iExecuteReader(sql);
                    //    dr[3] = String.Join(" ", data.Rows[0][1].ToString(), data.Rows[0][2].ToString(), data.Rows[0][3].ToString());
                    //    table.Rows.Add(dr);
                    //}
                    //dataPerson.Columns.Add("dateCol", "Date");
                    //dataPerson.Columns.Add("fioDocCol", "FIO Doctor");
                    //dataPerson.Columns.Add("fioPatCol", "FIO Patient");
                    break;
            }
            dataPerson.DataSource = table;
            dataPerson.Columns[0].Visible = false;
            //dataPerson.Columns[1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            for(int i = 0; i < table.Columns.Count; i++)
            {
                dataPerson.Columns[i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void FormListPerson_Shown(object sender, EventArgs e)
        {
            updateDataView();
        }

        private void updateDataView()
        {
            switch (numTable)
            {
                case 0:
                    this.Text = "Список докторов";
                    sSql = "Select * from doctor_table";
                    break;
                case 1:
                    this.Text = "Список пациентов";
                    sSql = "Select * from patient_table";
                    break;
                case 2:
                    //this.Text = "List of visiting";
                    //sSql = "Select * from visiting_table";
                    break;
            }
            dt = myDB.iExecuteReader(sSql);
            //dataPerson.DataSource = dt;
            //dataPerson.Columns[0].Visible = false;
            //if(dataPerson.Rows.Count == 1)
            //{
            CreateUserTable();
            //}
            //for(int i = 0; i < dataPerson.Rows.Count; i++)
            //{
            //    dataPerson.Rows[i].ReadOnly = true;
            //}
            dataPerson.ReadOnly = true;
            //dataPerson.Rows[1].Visible = false;

        }
        private void CreateObj(int id)
        {
            switch (numTable)
            {
                case 0:
                    
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
        }
        private void dataPerson_DoubleClick(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dataPerson.Rows[dataPerson.CurrentRow.Index].Cells[0].Value);

            switch (numTable)
            {
                case 0:
                    //string[] fio = {dr[1].ToString(), dr[2].ToString(), dr[3].ToString()};
                    //int workExp = Convert.ToInt32(dr[4]);
                    //string sql = $"select * from DOCTOR-SPECIALTY_TABLE where id_doctor = {dr[0]}";
                    //DataTable dtSpec = myDB.iExecuteReader(sql);
                    //int[] idSpec = {5};
                    //FormAddDoctor formAddDoctor = new FormAddDoctor(fio, workExp, idSpec, myDB);
                    //if(formAddDoctor.ShowDialog() == DialogResult.OK)
                    //{

                    //}
                    InfoForm infoDoctor = new InfoForm(id, 0, myDB);
                    infoDoctor.Show();
                    break;
                case 1:
                    InfoForm infoPatient = new InfoForm(id, 1, myDB);
                    infoPatient.Show();
                    break;
                case 2:
                    break;
            }

        }

        private void tFind_TextChanged(object sender, EventArgs e)
        {     
            try
            {       
                for (int k = 0; k < dataPerson.Rows.Count; k++)
                {
                    dataPerson.Rows[k].Visible = true;
                }
                string find = tFind.Text.ToLower();
                if (find == "")
                {
                    for (int k = 0; k < dataPerson.Rows.Count; k++)
                    {
                        dataPerson.Rows[k].Visible = true;
                    }
                    return;
                }
                dataPerson.CurrentCell = null;
                for (int k = 0; k < dataPerson.RowCount; k++)
                {
                    Regex regex = new Regex(find);
                    bool f = false, i = false, o = false, fio = false;
                    //f = regex.IsMatch(dataPerson.Rows[k].Cells[1].ToString().ToLower());
                    //i = regex.IsMatch(dataPerson.Rows[k].Cells[2].ToString().ToLower());
                    //o = regex.IsMatch(dataPerson.Rows[k].Cells[3].ToString().ToLower());
                    fio = regex.IsMatch(dataPerson.Rows[k].Cells[1].Value.ToString().ToLower());
                    if (!fio)
                    {
                        dataPerson.Rows[k].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if(!Regex.Match(c, @"[а-яА-Я\s\b]").Success)
            {
                e.Handled = true;
            }
        }

        private void dataPerson_Enter(object sender, EventArgs e)
        {
            updateDataView();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            switch (numTable)
            {
                case 0:

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
                            //if(dtSpec == null || dtSpec.Rows.Count == 0)
                            //{
                            //    throw new Exception("Нет специальностей (2)!");
                            //}


                            Image photo = formAddDoctor.GetPHOTO;
                            byte[] blob = InfoForm.ToByte(photo);
                            //sSql = $"insert into doctor_table (last_name, first_name, patronymic, work_experience) values('{fio[0]}', '{fio[1]}', '{fio[2]}', {workExp})"; // ДОБАВИТЬ ФОТО

                            if(fio[0] == "" || fio[1] == "")
                            {
                                throw new Exception("Должны присутствовать и имя, и фамилия.");
                            }

                            myDB.iExeecuteAddDoctor(fio[0], fio[1], fio[2], workExp, blob);
                            //sSql = $"select * from doctor_table where last_name = '{fio[0]}' and first_name = '{fio[1]}' and patronymic = '{fio[2]}' and work_experience = {workExp}";                  
                            //DataTable newDoc = myDB.iExecuteReader(sSql);
                            //int id = Convert.ToInt32(newDoc.Rows[0][0]);
                            sSql = $"select max(id_doctor) from doctor_table";

                            int id = myDB.iExecuteScalar(sSql);
                            foreach (DataRow row in dtSpec.Rows)
                            {
                                //sSql = $"insert into \"DOCTOR-SPECIALTY_TABLE\" (id_doctor, id_specialty) values({id}, {row[0]}) ";
                                sSql = $"execute procedure add_doc_spec({id}, {row[0]})";
                                myDB.iExeecuteNonQuery(sSql);
                            }
                            updateDataView();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 1:
                    FormAddPatient formAddPatient = new FormAddPatient();
                    try
                    {
                        if (formAddPatient.ShowDialog() == DialogResult.OK)
                        {
                            string[] fio = formAddPatient.FIO;
                            string[] adress = formAddPatient.Adress;
                            DateTime dateBirth = formAddPatient.DateBirth;

                            //string sSql = $"insert into patient_table (last_name, first_name, patronymic, area, city, house, apartment, date_birth) values('{fio[0]}', '{fio[1]}', '{fio[2]}', '{adress[0]}', '{adress[1]}', '{adress[2]}', '{adress[3]}', '{dateBirth.ToShortDateString()}')";
                            sSql = $"execute procedure add_patient('{fio[0]}', '{fio[1]}', '{fio[2]}', '{adress[0]}', '{adress[1]}', '{adress[2]}', '{adress[3]}', '{dateBirth.ToShortDateString()}')";
                            myDB.iExeecuteNonQuery(sSql);
                            updateDataView();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 2:
                    break;
            }
            
        }
    }
}
