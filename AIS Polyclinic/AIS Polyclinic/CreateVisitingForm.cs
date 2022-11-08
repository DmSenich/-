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
        string messegeL = "На данный день у этого врача назначено визитов: ";
        private CreateVisitingForm()     //сделать приватным
        {
            InitializeComponent();
        }
        public CreateVisitingForm(SqlManager myDB) : this()
        {
            this.myDB = myDB;
        }

        private void bOK_Click(object sender, EventArgs e)
        {

        }

        private void bCancel_Click(object sender, EventArgs e)
        {

        }

        private void CreateVisitingForm_Activated(object sender, EventArgs e)
        {

        }

        private void CreateVisitingForm_Shown(object sender, EventArgs e)
        {

        }
    }
}
