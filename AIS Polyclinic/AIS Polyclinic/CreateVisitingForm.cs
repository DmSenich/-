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
    public partial class CreateVisitingForm : Form
    {
        SqlManager myDB;
        DataTable dtDocs, dtPatients, dtSpecs;
        int idDoc, idPat;
        DateTime date;
        string messegeL = "На данный день у этого врача назначено визитов: ";
        private CreateVisitingForm()     //сделать приватным
        {
            InitializeComponent();
        }
        public CreateVisitingForm(SqlManager myDB) : this()
        {
            this.myDB = myDB;
            string sSql = $"select * from doctor_table";
            dtDocs = myDB.iExecuteReader(sSql);
            sSql = $"select * from patient_table";
            dtPatients = myDB.iExecuteReader(sSql);
            sSql = $"select * from specialty_table";
            dtSpecs = myDB.iExecuteReader(sSql);
            cSpecs.DataSource = dtSpecs;
            cSpecs.DisplayMember = "name_specialty";
            cSpecs.ValueMember = "id_specialty";
            FillData();
        }
        //public CreateVisitingForm(DataTable dtDocs, DataTable dtPatients):this()
        //{
        //    this.dtDocs = dtDocs;
        //    this.dtPatients = dtPatients;
        //    FillData();
        //}
        private void FillData()
        {
            DataTable dtDocView = new DataTable();
            dtDocView.Columns.Add("id");
            dtDocView.Columns.Add("FIO Doctor");
            DataTable dtPatView = new DataTable();
            dtPatView.Columns.Add("id");
            dtPatView.Columns.Add("FIO Patient");

            for(int i = 0; i < dtDocs.Rows.Count; i++)
            {
                DataRow dr = dtDocView.NewRow();
                dr[0] = dtDocs.Rows[i][0];
                dr[1] = String.Join(" ", dtDocs.Rows[i][1], dtDocs.Rows[i][2], dtDocs.Rows[i][3]);
                dtDocView.Rows.Add(dr);
            }

            for (int i = 0; i < dtPatients.Rows.Count; i++)
            {
                DataRow dr = dtPatView.NewRow();
                dr[0] = dtPatients.Rows[i][0];
                dr[1] = String.Join(" ", dtPatients.Rows[i][1], dtPatients.Rows[i][2], dtPatients.Rows[i][3]);
                dtPatView.Rows.Add(dr);
            }

            dataDoctor.DataSource = dtDocView;
            dataPatient.DataSource = dtPatView;
            dataDoctor.Columns[0].Visible = false;
            dataPatient.Columns[0].Visible = false;

            dataDoctor.ReadOnly = true;
            dataPatient.ReadOnly = true;
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            date = dateTimeVisit.Value;
            DataRow drDoc = dtDocs.Rows[dataDoctor.CurrentRow.Index];
            DataRow drPat = dtPatients.Rows[dataPatient.CurrentRow.Index];
            idDoc = Convert.ToInt32(drDoc[0]);
            idPat = Convert.ToInt32(drPat[0]);
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void CreateVisitingForm_Activated(object sender, EventArgs e)
        {

        }

        private void dataDoctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LabelMesUpdate();
        }

        private void CreateVisitingForm_Shown(object sender, EventArgs e)
        {

        }
        private void LabelMesUpdate()
        {
            DataRow dr = dtDocs.Rows[dataDoctor.CurrentRow.Index];
            int id = Convert.ToInt32(dr[0]);
            DateTime dateTime = dateTimeVisit.Value;
            string sSql = $"select count(id_doctor) from visiting_table where id_doctor = {id} and date_visiting = '{dateTime.ToShortDateString()}'";
            int count = myDB.iExecuteScalar(sSql);
            label1.Text = messegeL + count.ToString();
        }

        
        private void ForSearch(int numT)
        {
            string tDoc = tFindDoc.Text.ToLower();
            string tPat = tFindPat.Text.ToLower();
            switch (numT)
            {
                case 0:
                    SearchDoc(tDoc, checkSpecs.Checked);
                    break;
                case 1:
                    SearchPat(tPat);
                    break;
            }

            
            
        }
        private void SearchPat(string tPat)
        {
            bool doc = true, pat = true;
            bool dfio = false, pfio = false;
            int idS = 0;

            if (tPat == "")
            {
                pat = false;
                pfio = true;
            }

            dataPatient.CurrentCell = null;

            for (int k = 0; k < dataPatient.Rows.Count; k++)
            {
                if (pat)
                {
                    Regex regexP = new Regex(tPat);
                    pfio = regexP.IsMatch(dataPatient.Rows[k].Cells[1].Value.ToString().ToLower());
                }

                if (!pfio)
                {
                    dataPatient.Rows[k].Visible = false;
                }
            }
        }
        private void SearchDoc(string tDoc, bool bSpec)
        {
            bool doc = true, pat = true;
            bool dfio = false, pfio = false;
            int idS = 0;
            if (tDoc == "")
            {
                doc = false;
                dfio = true;
            }
            if (bSpec)
            {
                idS = Convert.ToInt32(cSpecs.SelectedValue);
            }

            dataDoctor.CurrentCell = null;

            for (int k = 0; k < dataDoctor.Rows.Count; k++)
            {
                if (doc)
                {
                    Regex regexD = new Regex(tDoc);
                    dfio = regexD.IsMatch(dataDoctor.Rows[k].Cells[1].Value.ToString().ToLower());
                }

                int idD = Convert.ToInt32(dataDoctor.Rows[k].Cells[0].Value);        

                if (!dfio)
                {
                    dataDoctor.Rows[k].Visible = false;
                }

                if (bSpec)
                {
                    string sSql = $"select count(id_doctor) from \"DOCTOR-SPECIALTY_TABLE\" where id_doctor = {idD} and id_specialty = {idS}";
                    int count = myDB.iExecuteScalar(sSql);
                    if (count == 0)
                    {
                        dataDoctor.Rows[k].Visible = false;
                    }
                    
                }
            }
        }

        private void dateTimeVisit_ValueChanged(object sender, EventArgs e)
        {
            LabelMesUpdate();
        }

        private void dataDoctor_DoubleClick(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dataDoctor.Rows[dataDoctor.CurrentRow.Index].Cells[0].Value);


            InfoForm infoDoctor = new InfoForm(id, 0, myDB);
            infoDoctor.ToBlockUpdate();
            infoDoctor.Show();
            
        }

        private void checkSpecs_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int k = 0; k < dataDoctor.Rows.Count; k++)
                {
                    dataDoctor.Rows[k].Visible = true;
                }
                ForSearch(0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataPatient_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataPatient.Rows[dataPatient.CurrentRow.Index].Cells[0].Value);


            InfoForm infoPatient = new InfoForm(id, 1, myDB);
            infoPatient.ToBlockUpdate();
            infoPatient.Show();

        }

        private void cSpecs_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (checkSpecs.Checked)
                {
                    for (int k = 0; k <dataDoctor.Rows.Count; k++)
                    {
                        dataDoctor.Rows[k].Visible = true;
                    }
                    ForSearch(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tFindDoc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int k = 0; k < dataDoctor.Rows.Count; k++)
                {
                    dataDoctor.Rows[k].Visible = true;
                }
                ForSearch(0);

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

        private void tFindPat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int k = 0; k < dataPatient.Rows.Count; k++)
                {
                    dataPatient.Rows[k].Visible = true;
                }
                ForSearch(1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        public int IdPat { get { return idPat; } }
        public DateTime Date { get { return date; } }
        public int IdDoc { get { return idDoc; } }
    }
}
