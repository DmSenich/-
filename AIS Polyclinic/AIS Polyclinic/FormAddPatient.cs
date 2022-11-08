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
    public partial class FormAddPatient : Form
    {
        string[] fio = new string[3];
        string[] adress = new string[4];
        DateTime dateOfBirth;
        public FormAddPatient()
        {
            InitializeComponent();
        }
        public FormAddPatient(string[] fio, string[] adress, DateTime date) : this()
        {
            this.fio = fio;
            this.adress = adress;
            this.dateOfBirth = date;
            tLastName.Text = fio[0];
            tFirstName.Text = fio[1];
            tPatronymic.Text = fio[2];
            tArea.Text = adress[0];
            tCity.Text = adress[1];
            tHouse.Text = adress[2];
            tApartment.Text = adress[3];
            /*Дата дня рождения*/
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        public string[] FIO { get { return fio; } }
        public string[] Adress { get { return adress; } }
        public DateTime DateBirth { get { return dateOfBirth; } }
    }
}
