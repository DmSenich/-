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
    public partial class FormCountDiseases : Form
    {
        SqlManager myDB;
        DataTable dtCategories;
        private FormCountDiseases()
        {
            InitializeComponent();
        }
        public FormCountDiseases(SqlManager myDB) : this()
        {
            this.myDB = myDB;

            string sSql = "select * from category_table";
            dtCategories = myDB.iExecuteReader(sSql);

            cCategories.DataSource = dtCategories;
            cCategories.DisplayMember = "NAME_CATEGORY";
            cCategories.ValueMember = "ID_CATEGORY";
        }
        private void SaveDocumentOne()
        {
            int idCat = Convert.ToInt32(cCategories.SelectedValue);
            string sSql = $"select * from disease_table where id_category  = {idCat}";
            DataTable dtDisease = myDB.iExecuteReader(sSql);
            bool existDisease = true;
            if(dtDisease.Rows.Count == 0 || dtDisease == null)
            {
                existDisease = false;
            }
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text Files(*.DOC)|*.DOC|All files(*.*)|*.*";
            dialog.AddExtension = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                FileInfo info = new FileInfo(path);
                using (TextWriter writer = new StreamWriter(path, false, Encoding.Default))
                {
                    writer.WriteLine("Категория заболевания " + cCategories.Text);

                    if (!existDisease)
                    {
                        writer.WriteLine("Нет данных о заболеваниях этой категории.");
                        writer.Close();
                        return;
                    }

                    writer.WriteLine("Количество заболеваний: " + dtDisease.Rows.Count);

                    writer.Close();
                }
            }

        }
        private void buCreateDocument_Click(object sender, EventArgs e)
        {
            try
            {
                SaveDocumentOne();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
