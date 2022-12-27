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
    public partial class FormAddDisease : Form
    {
        SqlManager myDB;
        //int idVis;
        int idCat;
        string description;
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
                idCat = Convert.ToInt32(cCategories.SelectedValue);
                if(description == "" || Regex.IsMatch(description, @"^\s"))
                {
                    MessageBox.Show("Введите все данные и/или избавьтесь от пробелов в начале.");
                }
                else
                {
                    DialogResult = DialogResult.OK;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        public int IdCategory { get { return idCat; } }
        public string Description { get { return description; } }

        private void cCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string c = e.KeyChar.ToString();
            //if (!Regex.Match(c, @"[а-яА-Я\s\b,.-]").Success)
            //{
            //    e.Handled = true;
            //}
        }
    }
}
