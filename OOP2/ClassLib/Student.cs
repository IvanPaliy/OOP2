using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Student : Applicant
    {
        protected int Course;
        protected int Group;
        protected string Faculty;
        protected string Institute;
        public Student(string schoolName, string firstName, string lastName, string faculty, string institute)
            :base(schoolName,  firstName,  lastName)
        {
            Faculty = faculty;
            Institute = institute;
        }
        public Student(int course, int groupe, int znocount, int certificatecount, int year, int month, int day)
            : base(znocount, certificatecount, year, month, day)
        {
            Course = course;
            Group = groupe;
        }
        public void SetCourse(int course)
        {
            if (course < 0 && course > 4)
                Course = 1;
            else Course = course;
        }
        public void SetGroup(int group)
        {
            if (group < 0 && group > 4)
                Group = 1;
            else Group = group;
        }
        public void SetFaculty(string faculty)
        {
            Faculty = faculty;
        }
        public void SetInstitute(string institute)
        {
            Institute = institute;
        }
        public int GetCourse()
        { return Course; }
        public int GetGroup()
        { return Group; }
        public string GetFaculty()
        { return Faculty;}
        public string GetInstitute()
        { return Institute;}
        public override string GetInfo()
        {
            return $"{LastName} {FirstName} - {Day}:{Month}:{Year}, \nZNOcount - {ZNOcount}, SchoolName - {SchoolName}, Certificatecount = {Certificatecount} \nCourse - {Course}, Group - {Group}, Faculty - {Faculty}, Institute - {Institute}\n" ;
        }



    }
}
