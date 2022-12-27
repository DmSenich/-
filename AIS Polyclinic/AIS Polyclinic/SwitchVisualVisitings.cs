using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_Polyclinic
{
    public partial class SwitchVisualVisitings : Form
    {
        SqlManager myDB;
        //DataTable dtDocs, dtPatients;
        DataTable dtVisiting, dtSpecs;
        private SwitchVisualVisitings()
        {
            InitializeComponent();
        }
        public SwitchVisualVisitings(SqlManager myDB) :this()
        {
            this.myDB = myDB;
            string sSql = "select * from visiting_table";
            dtVisiting = myDB.iExecuteReader(sSql);
            sSql = "select * from specialty_table";
            dtSpecs = myDB.iExecuteReader(sSql);
            //foreach(DataRow dr in dtSpecs.Rows)
            //{
            //    cSpecs.Items.Add(dr[1].ToString());
            //}
            cSpecs.DataSource = dtSpecs;
            cSpecs.DisplayMember = "name_specialty";
            cSpecs.ValueMember = "id_specialty";

            CreateTable();
            //string sSql = "select * from doctor_table";
            //dtDocs = myDB.iExecuteReader(sSql);
            //sSql = "select * from patient_table";
            //dtPatients = myDB.iExecuteReader(sSql);
            //CreateTables();

            //dataDoctor.ReadOnly = true;
            //dataPatient.ReadOnly = true;
        }
        private void CreateTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("id");
            table.Columns.Add("Дата");
            table.Columns.Add("ФИО доктора");
            table.Columns.Add("ФИО пациента");

            for (int i = 0; i < dtVisiting.Rows.Count; i++)
            {
                int idD, idP;
                try
                {
                    idD = Convert.ToInt32(dtVisiting.Rows[i][2]);
                    idP = Convert.ToInt32(dtVisiting.Rows[i][3]);
                }
                catch
                {
                    continue;
                }

                DataRow dr = table.NewRow();
                dr[0] = dtVisiting.Rows[i][0];
                dr[1] = Convert.ToDateTime(dtVisiting.Rows[i][1]).ToString("dd.MM.yyyy");
                string sql = $"select * from doctor_table where id_doctor = {idD}";
                DataTable data = myDB.iExecuteReader(sql);
                dr[2] = String.Join(" ", data.Rows[0][1].ToString(), data.Rows[0][2].ToString(), data.Rows[0][3].ToString());
                sql = $"select * from patient_table where id_patient = {idP}";
                data = myDB.iExecuteReader(sql);
                dr[3] = String.Join(" ", data.Rows[0][1].ToString(), data.Rows[0][2].ToString(), data.Rows[0][3].ToString());
                table.Rows.Add(dr);
            }
            dataVisiting.DataSource = table;
            dataVisiting.Columns[0].Visible = false;
            dataVisiting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataVisiting.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void ForSearch()
        {
            string tDoc = tFindDoc.Text.ToLower();
            string tPat = tFindPat.Text.ToLower();
            Search(tDoc, tPat, checkSpecs.Checked, checkDate.Checked);
        }

        private void Search(string tDoc, string tPat, bool bSpec, bool bDate)
        {
            bool doc = true, pat = true;
            bool dfio = false, pfio = false;
            int[] idVisitFromSpec = null;
            DateTime dateTime = DateTime.Now;
            if (tDoc == "")
            {
                doc = false;
                dfio = true;
            }
            if (tPat == "")
            {
                pat = false;
                pfio = true;
            }
            if (bSpec)
            {
                idVisitFromSpec = VisitFromSpec();
            }
            if (bDate)
            {
                dateTime = monthCalendar1.SelectionStart;
            }
            

            //for (int k = 0; k < dataVisiting.Rows.Count; k++)
            //{
            //    dataVisiting.Rows[k].Visible = true;
            //}

            dataVisiting.CurrentCell = null;

            for (int k = 0; k < dataVisiting.Rows.Count; k++)
            {
                if (doc)
                {
                    Regex regexD = new Regex(tDoc);
                    dfio = regexD.IsMatch(dataVisiting.Rows[k].Cells[2].Value.ToString().ToLower());
                }

                if (pat)
                {
                    Regex regexP = new Regex(tPat);
                    pfio = regexP.IsMatch(dataVisiting.Rows[k].Cells[3].Value.ToString().ToLower());
                }
                int idV = Convert.ToInt32(dataVisiting.Rows[k].Cells[0].Value);

                if (!(dfio && pfio))
                {
                    dataVisiting.Rows[k].Visible = false;
                }
                if(bSpec && !idVisitFromSpec.Contains(idV))
                {
                    dataVisiting.Rows[k].Visible = false;
                }
                if(bDate && !dataVisiting.Rows[k].Cells[1].Value.Equals(dateTime.ToShortDateString()))
                {
                    dataVisiting.Rows[k].Visible = false;
                }
            }
        }
       
        private void tFindDoc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int k = 0; k < dataVisiting.Rows.Count; k++)
                {
                    dataVisiting.Rows[k].Visible = true;
                }
                ForSearch();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tFindPat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int k = 0; k < dataVisiting.Rows.Count; k++)
                {
                    dataVisiting.Rows[k].Visible = true;
                }
                ForSearch();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tFindDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if (!Regex.Match(c, @"[а-яА-Я\s\b]").Success)
            {
                e.Handled = true;
            }
        }

        private void tFindPat_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if (!Regex.Match(c, @"[а-яА-Я\s\b]").Success)
            {
                e.Handled = true;
            }
        }
        

        //private void Search(string tDoc, string tPat, DateTime date, ) ----- с учетом специальности 
        //{

        //}

        private void bAddDisease_Click(object sender, EventArgs e)
        {
            //dtPatients.Rows[dataPatient.CurrentRow.Index];

            try
            {
                int idVis = Convert.ToInt32(dtVisiting.Rows[dataVisiting.CurrentRow.Index][0]);
                FormAddDisease formAddDisease = new FormAddDisease(myDB);
                if(formAddDisease.ShowDialog() == DialogResult.OK)
                {
                    string description = formAddDisease.Description;
                    int idCat = formAddDisease.IdCategory;

                    string sSql = $"execute procedure add_disease({idVis}, '{description}', {idCat})";

                    myDB.iExeecuteNonQuery(sSql);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDiseaseView diseaseView = new FormDiseaseView(myDB, 1);
            diseaseView.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                for (int k = 0; k < dataVisiting.Rows.Count; k++)
                {
                    dataVisiting.Rows[k].Visible = true;
                }
                ForSearch();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void bDateToNull_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        for (int k = 0; k < dataVisiting.Rows.Count; k++)
        //        {
        //            dataVisiting.Rows[k].Visible = true;
        //        }
        //        ForSearch();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void cSpecs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkSpecs_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int k = 0; k < dataVisiting.Rows.Count; k++)
                {
                    dataVisiting.Rows[k].Visible = true;
                }
                ForSearch();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int[] VisitFromSpec()
        {
            int idS = Convert.ToInt32(cSpecs.SelectedValue);
            string sSql = $"select id_visiting from visiting_table where id_doctor in (select id_doctor from \"DOCTOR-SPECIALTY_TABLE\" where id_specialty = {idS})";
            DataTable dtV = myDB.iExecuteReader(sSql);
            if(dtV.Rows.Count == 0)
            {
                int[] nres = new int[] { -1 };
                return nres;
            }
            int[] idV = new int[dtV.Rows.Count];
            for (int i = 0; i < dtV.Rows.Count; i++)
            {
                idV[i] = Convert.ToInt32(dtV.Rows[i][0]);
            }
            return idV;
        }

        private void cSpecs_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (checkSpecs.Checked)
                {
                    for (int k = 0; k < dataVisiting.Rows.Count; k++)
                    {
                        dataVisiting.Rows[k].Visible = true;
                    }
                    ForSearch();
                    
                    //dataVisiting.CurrentCell = null;
                    //for(int i = 0; i < dataVisiting.RowCount; i++)
                    //{
                    //    if (!idV.Contains(Convert.ToInt32(dataVisiting.Rows[i].Cells[0].Value)))
                    //    {
                    //        dataVisiting.Rows[i].Visible = false;
                    //    }
                    //    else
                    //    {
                    //        dataVisiting.Rows[i].Visible = true;
                    //    }
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkDate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int k = 0; k < dataVisiting.Rows.Count; k++)
                {
                    dataVisiting.Rows[k].Visible = true;
                }
                ForSearch();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bListDisease_Click(object sender, EventArgs e)
        {
            try 
            {
                int idV = Convert.ToInt32(dataVisiting.CurrentRow.Cells[0].Value);
                FormDiseaseView diseaseView = new FormDiseaseView(myDB, idV);
                diseaseView.Show();
            }
            catch { MessageBox.Show("Диагнозы отсутствуют."); }
        }

        private void bDeleteVisiting_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataVisiting.CurrentRow.Cells[0].Value);
                string procedureName = "posible_delete_visiting";
                DataTable dtres;

                string sSql = $"execute procedure {procedureName}({id})";
                dtres = myDB.iExecuteReader(sSql);
                if (!(bool)dtres.Rows[0][0])
                {
                    throw (new Exception("Невозможно удалить, т. к. существуют связанные данные!"));
                }
                else
                {
                    int index = dataVisiting.CurrentRow.Index;
                    dataVisiting.CurrentCell = null;
                    dtVisiting.Rows[index].Delete();
                    CreateTable();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void bAddVisiting_Click(object sender, EventArgs e)
        {
            //CreateVisitingForm createVisitingForm = new CreateVisitingForm(myDB);

            //createVisitingForm.Show();

            string sSql = $"select * from doctor_table";
            DataTable dtDocs = myDB.iExecuteReader(sSql);
            sSql = $"select * from patient_table";
            DataTable dtPatients = myDB.iExecuteReader(sSql);

            CreateVisitingForm createVisitingForm = new CreateVisitingForm(myDB);
            try
            {
                if (createVisitingForm.ShowDialog() == DialogResult.OK)
                {
                    int idDoc = createVisitingForm.IdDoc;
                    int idPat = createVisitingForm.IdPat;
                    DateTime date = createVisitingForm.Date;
                    sSql = $"execute procedure add_visiting('{date.ToShortDateString()}', {idDoc}, {idPat})";
                    myDB.iExeecuteNonQuery(sSql);

                    sSql = "select * from visiting_table";
                    dtVisiting = myDB.iExecuteReader(sSql);
                    CreateTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
