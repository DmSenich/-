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
    public partial class FormAddDisease : Form
    {
        SqlManager myDB;
        //int idVis;
        int idCat;
        string description, name;
        DataTable dtCategories;

        private FormAddDisease()
        {
            InitializeComponent();
            
        }

        public FormAddDisease(SqlManager myDB) : this()
        {
            this.myDB = myDB;
            //this.idVis = idVis;

            string sSql = "select * from category_table";
            dtCategories = myDB.iExecuteReader(sSql);

            cCategories.DataSource = dtCategories;
            cCategories.DisplayMember = "NAME_CATEGORY";
            cCategories.ValueMember = "ID_CATEGORY";
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            //string i = cCategories.SelectedValue.ToString();
            try
            {
                description = richDescription.Text;
                name = tName.Text;
                idCat = Convert.ToInt32(cCategories.SelectedValue);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        public int IdCategory { get { return idCat; } }
        public string Description { get { return description; } }
        public string NameDis { get { return name; } }

        private void cCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
