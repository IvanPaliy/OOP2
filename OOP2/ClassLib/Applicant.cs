using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
   public class Applicant : Person
    {
        protected int ZNOcount;
        protected int Certificatecount;
        protected string SchoolName;
        public Applicant(string schoolName, string firstName, string lastName)
            :base(firstName, lastName)
        {
            SchoolName = schoolName;
        }
        public Applicant(int znocount, int certificatecount, int year, int month, int day)
            : base (year, month, day)
        {
            ZNOcount = znocount;
            Certificatecount = certificatecount;
        }
        public void SetZNOCoount(int znocount)
        {
            if (znocount > 200)
                ZNOcount = 200;
            if (znocount < 0)
                ZNOcount = 100;
            else
                ZNOcount = znocount;
        }
        public void SetCertificatecount(int certificatecount)
        {
            if (certificatecount > 200)
                Certificatecount = 200;
            if (certificatecount < 0)
                Certificatecount = 1;
            else
                Certificatecount = certificatecount;
        }
        public void SetSchoolNaame(string schoolname)
        {
            SchoolName = schoolname;
        }
        public int GetZNOcount()
        { return ZNOcount; }
        public int GetCertificatecount()
        {
            return Certificatecount;
        }
        public string GetSchoolName()
        {
            return SchoolName;
        }
        public override string GetInfo()
        {
            return $"{LastName} {FirstName} - {Day}:{Month}:{Year}, \nZNOcount - {ZNOcount}, SchoolName - {SchoolName}, Certificatecount = {Certificatecount}\n";
        }



    }
}
