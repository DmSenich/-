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
    public partial class FormDiseaseView : Form
    {
        SqlManager myDB;
        int idVis;
        DataTable dtDisease;

        private FormDiseaseView()
        {
            InitializeComponent();
        }
        public FormDiseaseView(SqlManager myDB, int idVis) : this()
        {
            //this.dtDisease = dtDisease;
            this.myDB = myDB;
            this.idVis = idVis;
            string sSql;
            //sSql = $"select list(id_disease,' ') from \"DISEASE - VISITING_TABLE\" where id_visiting = {idVis}";

            //string[] sIddis = myDB.iExecuteScalar(sSql).ToString().Split(' ');
            //int[] idDis = new int[sIddis.Length];
            //for(int i = 0; i < idDis.Length; i++)
            //{
            //    idDis[i] = int.Parse(sIddis[i]);
            //}

            sSql = $"select * from disease_table where id_disease in (select id_disease from \"DISEASE-VISITING_TABLE\" where id_visiting = {idVis})";
            dtDisease = myDB.iExecuteReader(sSql);
            sSql = $"select * from category_table where id_category in (select id_category from disease_table where id_disease in (select id_disease from disease_table where id_disease in (select id_disease from \"DISEASE-VISITING_TABLE\" where id_visiting = {idVis})))";
            DataTable dtCat = myDB.iExecuteReader(sSql);
            dtDisease.Columns.Add("name_category");

            int[] idCat = new int[dtCat.Rows.Count];
            for(int i = 0; i < dtCat.Rows.Count; i++)
            {
                idCat[i] = Convert.ToInt32(dtCat.Rows[i][0]);
            }
            for(int i = 0; i < dtDisease.Rows.Count; i++)
            {
                for(int j = 0; j < idCat.Length; j++)
                {
                    if (idCat[j] == Convert.ToInt32(dtDisease.Rows[i][2]))
                    {
                        dtDisease.Rows[i][3] = dtCat.Rows[j][1];
                    }
                }
                
            }
            cNames.DataSource = dtDisease;
            cNames.DisplayMember = "name_category";
            cNames.ValueMember = "id_disease";

            FullData(Convert.ToInt32(cNames.SelectedValue));
        }
        private void FullData(int idDis)
        {
            try 
            {
                string sSql = $"select * from disease_table where id_disease = {idDis}";
                DataTable dis = myDB.iExecuteReader(sSql);
                richDescription.Text = dis.Rows[0][1].ToString();

            }
            catch 
            {
                //MessageBox.Show("Диагнозы отсутствуют.");
                Close();
            }
        }

        private void cNames_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idDis = Convert.ToInt32(cNames.SelectedValue);
            FullData(idDis);
        }

        private void bDeleteDisease_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cNames.SelectedValue);
                string sSql = $"execute procedure delete_disease({id})";
                myDB.iExeecuteNonQuery(sSql);
                dtDisease.Rows.RemoveAt(cNames.SelectedIndex);
               
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
