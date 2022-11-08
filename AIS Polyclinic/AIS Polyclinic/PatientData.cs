using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_Polyclinic
{
    public class PatientData
    {
        string[] fio;
        string[] adress;
        DateTime dateBirth;

        private PatientData() { }
        public PatientData(string[] fio, string[] adress, DateTime dateTime)
        {
            this.fio = fio;
            this.adress = adress;
            this.dateBirth = dateTime;
        }
        static public string[] BuildFIO(string lastName, string firstName, string patronymic)
        {
            string[] newfio = { lastName, firstName, patronymic };
            return newfio;
        }
        static public string[] BuildAdress(string area, string city, string house, string apartment)
        {
            string[] newAdress = { area, city, house, apartment };
            return newAdress;
        }
        public string[] Fio { get { return fio; } }
        public string[] Adress { get { return adress; } }
        public DateTime DateBirth { get { return dateBirth; } }
    }
}
