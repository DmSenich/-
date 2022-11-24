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
        DataTable dtPatient;
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
        public FormAddPatient(DataTable dtPAtient) : this()
        {
            this.dtPatient = dtPAtient;
            fio[0] = dtPatient.Rows[0][1].ToString();
            fio[1] = dtPatient.Rows[0][2].ToString();
            fio[2] = dtPatient.Rows[0][3].ToString();
            adress[0] = dtPatient.Rows[0][4].ToString();
            adress[1] = dtPatient.Rows[0][5].ToString();
            adress[2] = dtPatient.Rows[0][6].ToString();
            adress[3] = dtPatient.Rows[0][7].ToString();
            dateOfBirth = Convert.ToDateTime(dtPatient.Rows[0][8]);

            tLastName.Text = fio[0];
            tFirstName.Text = fio[1];
            tPatronymic.Text = fio[2];
            tArea.Text = adress[0];
            tCity.Text = adress[1];
            tHouse.Text = adress[2];
            tApartment.Text = adress[3];
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            fio[0] = tLastName.Text;
            fio[1] = tFirstName.Text;
            fio[2] = tPatronymic.Text;
            adress[0] = tArea.Text;
            adress[1] = tCity.Text;
            adress[2] = tHouse.Text;
            adress[3] = tApartment.Text;
            dateOfBirth = dateBirth.Value;

            DialogResult = DialogResult.OK;
        }
        public string[] FIO { get { return fio; } }
        public string[] Adress { get { return adress; } }
        public DateTime DateBirth { get { return dateOfBirth; } }
    }
}
