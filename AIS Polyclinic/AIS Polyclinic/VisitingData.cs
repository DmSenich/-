using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_Polyclinic
{
    public class VisitingData
    {
        DateTime date;
        string[] fioDoctor;
        string[] fioPatient;

        private VisitingData() { }
        public VisitingData(DateTime date, string[] fioDoctor, string[] fioPatient)
        {
            this.date = date;
            this.fioDoctor = fioDoctor;
            this.fioPatient = fioPatient;
        }
        public DateTime Date { get { return date; } }
        public string[] FioDoctor { get { return fioDoctor; } }
        public string [] FioPatient { get { return fioPatient; } }
    }
}
