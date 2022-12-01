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

            cNames.DataSource = dtDisease;
            cNames.DisplayMember = "name_disease";
            cNames.ValueMember = "id_disease";

            FullData(Convert.ToInt32(cNames.SelectedValue));
        }
        private void FullData(int idDis)
        {
            try 
            {
                string sSql = $"select * from disease_table where id_disease = {idDis}";
                DataTable dis = myDB.iExecuteReader(sSql);
                richDescription.Text = dis.Rows[0][2].ToString();
                int idCat = Convert.ToInt32(dis.Rows[0][3]);
                sSql = $"select * from category_table where id_category = {idCat}";
                DataTable cat = myDB.iExecuteReader(sSql);
                tCategory.Text = cat.Rows[0][1].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cNames_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idDis = Convert.ToInt32(cNames.SelectedValue);
            FullData(idDis);
        }
    }
}
