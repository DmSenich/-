using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_Polyclinic
{
    public partial class FormAddDoctor : Form
    {
        SqlManager myDB;
        //DoctorData doctorData;
        Image photo;
        DataTable dtSpecs;
        DataTable dtSpecsForView;
        DataTable newSpec;
        bool oldDoc = false;
        string[] fio = new string[3];
        int workExp;
        int[] idSpec;

        DataTable dtDoc;
        DataTable dtSpec; //для нового конструктора

        private FormAddDoctor()
        {
            InitializeComponent();
            dtSpecsForView = new DataTable();
            dtSpecsForView.Columns.Add("id");
            dtSpecsForView.Columns.Add("Specialty");
            dtSpecsForView.Columns.Add("Having");
            dtSpecsForView.Columns[2].DataType = typeof(bool);
            dtSpecsForView.Columns[2].DefaultValue = false;
        }
        //public FormAddDoctor(SqlManager sqlManager):this()
        //{
        //    myDB = sqlManager;
        //    TableSpecBuild();
        //}
        //public FormAddDoctor(string[] fio, int workExp, int[] idSpec, SqlManager manager) : this()
        //{
        //    oldDoc = true;
        //    myDB = manager;
        //    this.fio = fio;
        //    this.workExp = workExp;
        //    this.idSpec = idSpec;
        //    tLastName.Text = fio[0];
        //    tFirstName.Text = fio[1];
        //    tPatronymic.Text = fio[2];
        //    nWorkExperience.Value = workExp;
        //    TableSpecBuild();
        //    /*Отмечаем специальности*/
        //}
        //public FormAddDoctor(int id, SqlManager manager) : this()
        //{
        //    //string sql = "select * from \"docror_table\" where id_doctor = {id}"
        //}
        public FormAddDoctor(DataTable dtDoc, DataTable dtSpec, DataTable dtSpecs) : this()
        {
            oldDoc = true;
            this.dtSpec = dtSpec;
            this.dtDoc = dtDoc;
            this.dtSpecs = dtSpecs;

            tLastName.Text = dtDoc.Rows[0][1].ToString();
            tFirstName.Text = dtDoc.Rows[0][2].ToString();
            tPatronymic.Text = dtDoc.Rows[0][3].ToString();
            nWorkExperience.Value = Convert.ToInt32(dtDoc.Rows[0][4].ToString());

            TableSpecBuild2();
        }
        public FormAddDoctor(DataTable dtSpecs) : this()
        {
            this.dtSpecs = dtSpecs;
            TableSpecBuild2();
        }
        private int[] DoctorSpecIds()
        {
            int[] idSpec = new int[dtSpec.Rows.Count];

            for (int i = 0; i < dtSpec.Rows.Count; i++)
            {
                idSpec[i] = Convert.ToInt32(dtSpec.Rows[i][0]);
            }
            if(idSpec is null)
            {
                idSpec = new int[] { 0 };
            }
            return idSpec;
        }
        private void TableSpecBuild2()
        {
            if (oldDoc)
            {
                idSpec = DoctorSpecIds();
                byte[] data;
                try
                {
                    data = (byte[])dtDoc.Rows[0][5];
                }
                catch
                {
                    data = null;
                }
                if(data != null)
                    pPhoto.Image = InfoForm.ToImage(data);
            }
            

            for (int i = 0; i < dtSpecs.Rows.Count; i++)
            {
                DataRow dr = dtSpecsForView.NewRow();
                dr[0] = dtSpecs.Rows[i][0];
                dr[1] = dtSpecs.Rows[i][1];
                if (oldDoc && idSpec.Contains(Convert.ToInt32(dr[0])))
                {
                    dr[2] = true;
                }
                dtSpecsForView.Rows.Add(dr);
            }
            dataSpecialty.DataSource = dtSpecsForView;
            dataSpecialty.Columns[0].Visible = false;
        }
        private DataTable CreateNewDTSpec()
        {
            DataTable dt = dtSpecs.Clone();
            dt.Rows.Clear();

            dtSpecsForView.AcceptChanges();

            for(int i = 0; i < dtSpecsForView.Rows.Count; i++)
            {
                if (dtSpecsForView.Rows[i][2].Equals(true))
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = dtSpecsForView.Rows[i][0];
                    dr[1] = dtSpecsForView.Rows[i][1];
                    dt.Rows.Add(dr);
                }
            }

            return dt;
        }
        //private void TableSpecBuild()
        //{
        //    string sql = "select * from SPECIALTY_TABLE";
        //    dtSpecs = myDB.iExecuteReader(sql);
        //    DataTable table = new DataTable();
        //    table.Columns.Add("id");
        //    table.Columns.Add("Specialty");
        //    table.Columns.Add("Having");
        //    table.Columns[2].DataType = typeof(bool);
        //    table.Columns[2].DefaultValue = false;

        //    for(int i = 0; i < dtSpecs.Rows.Count; i++)
        //    {
        //        DataRow dr = table.NewRow();
        //        dr[0] = dtSpecs.Rows[i][0];
        //        dr[1] = dtSpecs.Rows[i][1];
        //        if (oldDoc && idSpec.Contains(i+1))
        //        {
        //            dr[2] = true;
        //        }
        //        table.Rows.Add(dr);
        //    }
        //    dataSpecialty.DataSource = table;
        //    dataSpecialty.Columns[0].Visible = false;
        //}
        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            fio[0] = tLastName.Text;
            fio[1] = tFirstName.Text;
            fio[2] = tPatronymic.Text;
            photo = pPhoto.Image;
            workExp = Convert.ToInt32(nWorkExperience.Value);
            newSpec = CreateNewDTSpec();
            DialogResult = DialogResult.OK;
        }

        private void bAddPhoto_Click(object sender, EventArgs e)
        {
            Bitmap img;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    img = new Bitmap(openFileDialog.FileName);
                    pPhoto.Image = img;
                    pPhoto.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        public string[] FIO { get { return fio; } }
        public int WorkExp { get { return workExp; } }
        public DataTable DTSpec { get { return newSpec; } }
        public Image GetPHOTO { get { return photo; } }
        //private int[] IdSpec { get { return idSpec; } }
        //public void GetInfo()
        //{

        //}
    }
}
