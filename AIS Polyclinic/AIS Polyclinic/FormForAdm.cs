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
    public partial class FormForAdm : Form
    {
        SqlManager myDB;
        DataTable dtCategories, dtSpec;

        public FormForAdm(SqlManager myDB)
        {
            InitializeComponent();
            this.myDB = myDB;
            DataCategory();
            DataSpecialty();
            updateDataView();
        }

        private void DataCategory()
        {
            string sSql = "select * from category_table";
            dtCategories = myDB.iExecuteReader(sSql);

            cCategory.DataSource = dtCategories;
            cCategory.DisplayMember = "NAME_CATEGORY";
            cCategory.ValueMember = "ID_CATEGORY";
        }
        private void DataSpecialty()
        {
            string sSql = "select * from specialty_table";
            dtSpec = myDB.iExecuteReader(sSql);

            cSpecialty.DataSource = dtSpec;
            cSpecialty.DisplayMember = "NAME_SPECIALTY";
            cSpecialty.ValueMember = "ID_SPECIALTY";
        }

        private void updateDataView()
        {
            DataTable dt;
            string sSql = "";
            if (radioBDoctor.Checked)
            {
                sSql = "select * from doctor_table";
            }
            if (radioBPatient.Checked)
            {
                sSql = "Select * from patient_table";
            }

            dt = myDB.iExecuteReader(sSql);
            //dataPerson.DataSource = dt;
            //dataPerson.Columns[0].Visible = false;
            //if(dataPerson.Rows.Count == 1)
            //{
            CreateUserTable(dt);
            //}
            //for(int i = 0; i < dataPerson.Rows.Count; i++)
            //{
            //    dataPerson.Rows[i].ReadOnly = true;
            //}
            dataPerson.ReadOnly = true;
            //dataPerson.Rows[1].Visible = false;

        }
        private void CreateUserTable(DataTable dt)
        {
            //dataPerson.Columns.Add("idCol", "id");
            //dataPerson.Columns[0].Visible = false;
            DataTable table = new DataTable();
            table.Columns.Add("id");

            table.Columns.Add("FIO");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = table.NewRow();
                dr[0] = dt.Rows[i][0];
                dr[1] = String.Join(" ", dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString());
                table.Rows.Add(dr);
            }

            
            dataPerson.DataSource = table;
            dataPerson.Columns[0].Visible = false;
            //dataPerson.Columns[1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            for (int i = 0; i < table.Columns.Count; i++)
            {
                dataPerson.Columns[i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void bAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string newCat = cCategory.Text;
                if(newCat == "")
                {
                    return;
                }
                string sSql = $"execute procedure add_category('{newCat}')";
                myDB.iExeecuteNonQuery(sSql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                int idCat = Convert.ToInt32(cCategory.SelectedValue);
                string sSql = $"execute procedure posible_delete_category({idCat})";
                DataTable dtres = myDB.iExecuteReader(sSql);
                bool res = (bool)(dtres.Rows[0][0]);
                if (!res)
                {
                    throw new Exception("Невозможно удалить, т. к. существуют связанные данные!");
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void radioBPatient_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBPatient.Checked)
            {
                updateDataView();
            }
        }

        private void radioBDoctor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBDoctor.Checked)
            {
                updateDataView();
            }
        }

        private void bDeletePerson_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataPerson.CurrentRow.Cells[0].Value);
                string procedureName = "";
                DataTable dtres;
                
                if (radioBDoctor.Checked)
                {
                    procedureName = "posible_delete_doctor";
                }
                if (radioBPatient.Checked) 
                {
                    procedureName = "posible_delete_patient";
                }
                string sSql = $"execute procedure {procedureName}({id})";
                dtres = myDB.iExecuteReader(sSql);
                if (!(bool)dtres.Rows[0][0])
                {
                    throw (new Exception("Невозможно удалить, т. к. существуют связанные данные!"));
                }
                else
                {
                    updateDataView();
                }
            }
            catch( Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void bAddSpec_Click(object sender, EventArgs e)
        {
            try
            {
                string newSpec = cSpecialty.Text;
                if (newSpec == "")
                {
                    return;
                }
                string sSql = $"execute procedure ADD_SPECIALTY('{newSpec}')";
                myDB.iExeecuteNonQuery(sSql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bDeleteSpec_Click(object sender, EventArgs e)
        {
            try
            {
                int idSpec = Convert.ToInt32(cSpecialty.SelectedValue);
                string sSql = $"execute procedure posible_delete_specialty({idSpec})";
                DataTable dtres = myDB.iExecuteReader(sSql);
                bool res = (bool)(dtres.Rows[0][0]);
                if (!res)
                {
                    throw new Exception("Невозможно удалить, т. к. существуют связанные данные!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }

}
