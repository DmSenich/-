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
            foreach(DataRow dr in dtSpecs.Rows)
            {
                cSpecs.Items.Add(dr[1].ToString());
            }
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
            table.Columns.Add("Date");
            table.Columns.Add("FIO Doctor");
            table.Columns.Add("FIO Patient");

            for (int i = 0; i < dtVisiting.Rows.Count; i++)
            {
                int idD = Convert.ToInt32(dtVisiting.Rows[i][2]),
                    idP = Convert.ToInt32(dtVisiting.Rows[i][3]);

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
            for (int i = 0; i < table.Columns.Count; i++)
            {
                dataVisiting.Columns[i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void tFindDoc_TextChanged(object sender, EventArgs e)
        {
            //for (int k = 0; k < dataPerson.Rows.Count; k++)
            //{
            //    dataPerson.Rows[k].Visible = true;
            //}
            //string find = tFind.Text.ToLower();
            //if (find == "")
            //{
            //    for (int k = 0; k < dataPerson.Rows.Count; k++)
            //    {
            //        dataPerson.Rows[k].Visible = true;
            //    }
            //    return;
            //}

            //for (int k = 0; k < dt.Rows.Count; k++)
            //{
            //    Regex regex = new Regex(find);
            //    bool f = false, i = false, o = false;
            //    f = regex.IsMatch(dt.Rows[k][1].ToString().ToLower());
            //    i = regex.IsMatch(dt.Rows[k][2].ToString().ToLower());
            //    o = regex.IsMatch(dt.Rows[k][3].ToString().ToLower());
            //    if (!(f || i || o))
            //    {
            //        dataPerson.Rows[k].Visible = false;
            //    }
            //}
        }

        private void tFindPat_TextChanged(object sender, EventArgs e)
        {

        }

        private void tFindDoc_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tFindPat_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

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
                    string name = formAddDisease.NameDis;
                    int idCat = formAddDisease.IdCategory;

                    string sSql = $"execute procedure add_disease({idVis}, '{name}', '{description}', {idCat})";

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



        //private void FillData()
        //{
        //    DataTable dtDocView = new DataTable();
        //    dtDocView.Columns.Add("id");
        //    dtDocView.Columns.Add("FIO Doctor");
        //    DataTable dtPatView = new DataTable();
        //    dtPatView.Columns.Add("id");
        //    dtPatView.Columns.Add("FIO Patient");

        //    for (int i = 0; i < dtDocs.Rows.Count; i++)
        //    {
        //        DataRow dr = dtDocView.NewRow();
        //        dr[0] = dtDocs.Rows[i][0];
        //        dr[1] = String.Join(" ", dtDocs.Rows[i][1], dtDocs.Rows[i][2], dtDocs.Rows[i][3]);
        //        dtDocView.Rows.Add(dr);
        //    }

        //    for (int i = 0; i < dtPatients.Rows.Count; i++)
        //    {
        //        DataRow dr = dtPatView.NewRow();
        //        dr[0] = dtPatients.Rows[i][0];
        //        dr[1] = String.Join(" ", dtPatients.Rows[i][1], dtPatients.Rows[i][2], dtPatients.Rows[i][3]);
        //        dtPatView.Rows.Add(dr);
        //    }

        //    dataDoctor.DataSource = dtDocView;
        //    dataPatient.DataSource = dtPatView;
        //    dataDoctor.Columns[0].Visible = false;
        //    dataPatient.Columns[0].Visible = false;

        //    dataDoctor.ReadOnly = true;
        //    dataPatient.ReadOnly = true;

        //}
        //private void tFind_TextChanged(object sender, EventArgs e)
        //{
        //    for (int k = 0; k < dataPerson.Rows.Count; k++)
        //    {
        //        dataPerson.Rows[k].Visible = true;
        //    }
        //    string find = tFind.Text.ToLower();
        //    if (find == "")
        //    {
        //        for (int k = 0; k < dataPerson.Rows.Count; k++)
        //        {
        //            dataPerson.Rows[k].Visible = true;
        //        }
        //        return;
        //    }

        //    for (int k = 0; k < dt.Rows.Count; k++)
        //    {
        //        Regex regex = new Regex(find);
        //        bool f = false, i = false, o = false;
        //        f = regex.IsMatch(dt.Rows[k][1].ToString().ToLower());
        //        i = regex.IsMatch(dt.Rows[k][2].ToString().ToLower());
        //        o = regex.IsMatch(dt.Rows[k][3].ToString().ToLower());
        //        if (!(f || i || o))
        //        {
        //            dataPerson.Rows[k].Visible = false;
        //        }
        //    }
        //}

        //private void tFind_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    string c = e.KeyChar.ToString();
        //    if (!Regex.Match(c, @"[а-яА-Я\s\b]").Success)
        //    {
        //        e.Handled = true;
        //    }
        //}
    }
}
