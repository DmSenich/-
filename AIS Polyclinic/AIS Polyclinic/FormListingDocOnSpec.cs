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
    public partial class FormListingDocOnSpec : Form
    {
        SqlManager myDB;
        DataTable dtSpec;
        public FormListingDocOnSpec()
        {
            InitializeComponent();
        }

        public FormListingDocOnSpec(SqlManager myDB) : this()
        {
            this.myDB = myDB;
            DataSpecialty();
        }
        private void DataSpecialty()
        {
            string sSql = "select * from specialty_table";
            dtSpec = myDB.iExecuteReader(sSql);

            cSpecialty.DataSource = dtSpec;
            cSpecialty.DisplayMember = "NAME_SPECIALTY";
            cSpecialty.ValueMember = "ID_SPECIALTY";
        }
        private void SaveDocument()
        {
            int idSpec = Convert.ToInt32(cSpecialty.SelectedValue);
            string sSql = $"select * from doctor_table where id_doctor in (select id_doctor from \"DOCTOR-SPECIALTY_TABLE\" where id_specialty = {idSpec})";
            DataTable dtDoctors = myDB.iExecuteReader(sSql);
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text Files(*.DOC)|*.DOC|All files(*.*)|*.*";
            dialog.AddExtension = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                FileInfo info = new FileInfo(path);
                using(TextWriter writer = new StreamWriter(path, false, Encoding.Default))
                {
                    writer.WriteLine("Список докторов по специальности: " + cSpecialty.Text);
                    writer.WriteLine();
                    writer.WriteLine("Дата: " + DateTime.Now.ToShortDateString());
                    
                    for(int i = 0; i < dtDoctors.Rows.Count; i++)
                    {
                        writer.WriteLine();
                        DataRow drDoctor = dtDoctors.Rows[i];
                        writer.Write(i+1 + ") ");
                        string fio = drDoctor[1].ToString() + " " + drDoctor[2].ToString() + " " + drDoctor[3].ToString();
                        writer.WriteLine(fio);
                        writer.Write("Опыт работы (в годах): ");
                        writer.WriteLine(drDoctor[4]);
                    }

                    writer.Close();
                }
            }

        }
        private void bCreate_Click(object sender, EventArgs e)
        {
            try
            {
                SaveDocument();
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void radioBSpec_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cSpecialty_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}
