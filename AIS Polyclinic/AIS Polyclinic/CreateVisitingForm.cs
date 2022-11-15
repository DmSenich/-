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
    public partial class CreateVisitingForm : Form
    {
        SqlManager myDB;
        DataTable dtDocs, dtPatients;
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
            DataRow dr = dtDocs.Rows[dataDoctor.CurrentRow.Index];
            int id = Convert.ToInt32(dr[0]);
            string sSql = $"select count * from visiting_table where id_doctor = {id}";
        }

        private void CreateVisitingForm_Shown(object sender, EventArgs e)
        {

        }
    }
}
