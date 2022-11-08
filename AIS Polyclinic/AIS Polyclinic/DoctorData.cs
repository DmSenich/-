using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_Polyclinic
{
    public class DoctorData
    {
        string[] fio;
        int workEx;
        byte[] photo;

        private DoctorData() { }
        public DoctorData(string[] fio, int workEx, byte[] photo)
        {
            this.fio = fio;
            this.workEx = workEx;
            this.photo = photo;
        }
        static public string[] BuildFIO(string lastName, string firstName, string patronymic)
        {
            string[] newfio = {lastName, firstName, patronymic};
            return newfio;
        }
        public string[] Fio { get { return fio; } }
        public int WorkEx { get { return workEx; } }
        public byte[] Photo { get { return photo; } }
    }
}
