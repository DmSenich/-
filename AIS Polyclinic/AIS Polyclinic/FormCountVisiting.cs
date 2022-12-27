using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_Polyclinic
{
    public partial class FormCountVisiting : Form
    {
        SqlManager myDB;
        DataTable dtDoctors;

        private FormCountVisiting()
        {
            InitializeComponent();
        }
        public FormCountVisiting(SqlManager myDB) : this()
        {
            this.myDB = myDB;
            string sSql = $"select * from doctor_table";
            dtDoctors = myDB.iExecuteReader(sSql);
            FillData();
        }
        private void FillData()
        {
            DataTable dtDocView = new DataTable();
            dtDocView.Columns.Add("id");
            dtDocView.Columns.Add("ФИО доктора");

            for (int i = 0; i < dtDoctors.Rows.Count; i++)
            {
                DataRow dr = dtDocView.NewRow();
                dr[0] = dtDoctors.Rows[i][0];
                dr[1] = String.Join(" ", dtDoctors.Rows[i][1], dtDoctors.Rows[i][2], dtDoctors.Rows[i][3]);
                dtDocView.Rows.Add(dr);
            }

            dataDoctor.DataSource = dtDocView;
            dataDoctor.Columns[0].Visible = false;

            dataDoctor.ReadOnly = true;
            dataDoctor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void SearchDoc(string tDoc)
        {
            bool doc = true;
            bool dfio = false;
            if (tDoc == "")
            {
                doc = false;
                dfio = true;
            }

            dataDoctor.CurrentCell = null;

            for (int k = 0; k < dataDoctor.Rows.Count; k++)
            {
                if (doc)
                {
                    Regex regexD = new Regex(tDoc);
                    dfio = regexD.IsMatch(dataDoctor.Rows[k].Cells[1].Value.ToString().ToLower());
                }

                if (!dfio)
                {
                    dataDoctor.Rows[k].Visible = false;
                }
            }
        }
        private void SaveDocumentOne(int idDoctor, string fio)
        {
            string sSql = $"select * from visiting_table where id_doctor = {idDoctor}";
            DataTable dtVisiting = myDB.iExecuteReader(sSql);
            bool existVisitings = true;
            if(dtVisiting == null || dtVisiting.Rows.Count == 0)
            {
                existVisitings = false;
            }
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text Files(*.DOC)|*.DOC|All files(*.*)|*.*";
            dialog.AddExtension = true;
            Dictionary<DateTime, int> countVisitings = DateDictionary(dtVisiting, idDoctor);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                FileInfo info = new FileInfo(path);
                using (TextWriter writer = new StreamWriter(path, false, Encoding.Default))
                {
                    writer.WriteLine("Информация о количестрве посещиний");
                    writer.WriteLine();
                    writer.WriteLine("Врач " + fio);

                    if (!existVisitings)
                    {
                        writer.WriteLine("Нет данных о принятых пациентах.");
                        writer.Close();
                        return;
                    }
                    writer.WriteLine("Количество посещений по датам:");
                    writer.WriteLine();
                    
                    foreach(DateTime dateTime in countVisitings.Keys)
                    {
                        writer.Write("На " + dateTime.ToShortDateString() + ": ");
                        writer.WriteLine(countVisitings[dateTime]);
                        writer.WriteLine();
                    }

                    writer.Close();
                }
            }

        }

        private Dictionary<DateTime, int> DateDictionary(DataTable dtVisiting, int idDoctor)
        {
            Dictionary<DateTime, int> result = new Dictionary<DateTime, int>();

            foreach (DataRow dr in dtVisiting.Rows)
            {
                DateTime date = Convert.ToDateTime(dr[1]);
                if (result.ContainsKey(date))
                {
                    continue;
                }
                string sSql = $"select count(*) from visiting_table where id_doctor = {idDoctor} and date_visiting = '{date.ToShortDateString()}'";
                int count = myDB.iExecuteScalar(sSql);
                result.Add(date, count);
            }
            

            return result;
        }

        private void tFindDoc_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataDoctor.Rows.Count; i++)
            {
                dataDoctor.Rows[i].Visible = true;
            }
            SearchDoc(tFindDoc.Text.ToLower());
        }

        private void FormCountVisiting_Load(object sender, EventArgs e)
        {

        }

        private void bCreateDocument_Click(object sender, EventArgs e)
        {
            try
            {
                int idDoctor = Convert.ToInt32(dataDoctor.CurrentRow.Cells[0].Value);
                string fio = dataDoctor.CurrentRow.Cells[1].Value.ToString();

                SaveDocumentOne(idDoctor, fio);
            }
            catch { MessageBox.Show("Невозможно создать документ."); }
        }

        private void tFindDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if (!Regex.Match(c, @"[а-яА-Я\s\b]").Success)
            {
                e.Handled = true;
            }
        }
    }
}
