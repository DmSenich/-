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
            //switch (numTable)
            //{
            //    case 0:
            //        this.Text = "List of doctors";
            //        sSql = "Select * from doctor_table";
            //        break;
            //    case 1:
            //        this.Text = "List of patients";
            //        sSql = "Select * from patient_table";
            //        break;
            //    case 2:
            //        this.Text = "List of visiting";
            //        sSql = "Select * from visiting_table";
            //        break;
            //}
            //DataTable dt = myDB.iExecuteReader(sSql);
            //dataPerson.DataSource = dt;
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
                    table.Columns.Add("Date");
                    table.Columns.Add("FIO Doctor");
                    table.Columns.Add("FIO Patient");

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int idD = Convert.ToInt32(dt.Rows[i][2]),
                            idP = Convert.ToInt32(dt.Rows[i][3]);
                        
                        DataRow dr = table.NewRow();
                        dr[0] = dt.Rows[i][0];
                        dr[1] = Convert.ToDateTime(dt.Rows[i][1]).ToString("dd.MM.yyyy");
                        string sql = $"select * from doctor_table where id_doctor = {idD}";
                        DataTable data = myDB.iExecuteReader(sql);
                        dr[2] = String.Join(" ", data.Rows[0][1].ToString(), data.Rows[0][2].ToString(), data.Rows[0][3].ToString());
                        sql = $"select * from patient_table where id_patient = {idP}";
                        data = myDB.iExecuteReader(sql);
                        dr[3] = String.Join(" ", data.Rows[0][1].ToString(), data.Rows[0][2].ToString(), data.Rows[0][3].ToString());
                        table.Rows.Add(dr);
                    }
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
            switch (numTable)
            {
                case 0:
                    this.Text = "List of doctors";
                    sSql = "Select * from doctor_table";
                    break;
                case 1:
                    this.Text = "List of patients";
                    sSql = "Select * from patient_table";
                    break;
                case 2:
                    this.Text = "List of visiting";
                    sSql = "Select * from visiting_table";
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
            DataRow dr = dt.Rows[dataPerson.CurrentRow.Index];
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
                    InfoForm infoDoctor = new InfoForm(Convert.ToInt32(dr[0]), 0, myDB);
                    infoDoctor.Show();
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
        }

        private void tFind_TextChanged(object sender, EventArgs e)
        {
            for (int k = 0; k < dataPerson.Rows.Count; k++)
            {
                dataPerson.Rows[k].Visible = true;
            }
            string find = tFind.Text.ToLower();
            if(find == "")
            {
                for (int k = 0; k < dataPerson.Rows.Count; k++)
                {
                    dataPerson.Rows[k].Visible = true;
                }
                return;
            }

            for(int k = 0; k < dt.Rows.Count; k++)
            {
                Regex regex = new Regex(find);
                bool f = false, i = false, o = false;
                f = regex.IsMatch(dt.Rows[k][1].ToString().ToLower());
                i = regex.IsMatch(dt.Rows[k][2].ToString().ToLower());
                o = regex.IsMatch(dt.Rows[k][3].ToString().ToLower());
                if(!(f || i || o))
                {
                    dataPerson.Rows[k].Visible = false;
                }
            }
        }
    }
}
