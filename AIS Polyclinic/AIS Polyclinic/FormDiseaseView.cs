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
        }


    }
}
