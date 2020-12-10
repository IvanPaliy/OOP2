using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Teacher : Person
    {
        protected string Position;
        protected string Department;
        protected string Educationinstitution;
        public Teacher(string firstName, string lastName,string position, string departament)
            : base(firstName, lastName)
        {
            Position = position;
            Department = departament;
        }
        public Teacher(string firstName, string lastName,string educationinstitution)
            : base(firstName, lastName)
        {
            Educationinstitution = educationinstitution;
        }
        public void SetPosition(string position)
        {
            Position = position;
        }
        public void SetDepartment(string department)
        {
            Department = department;
        }
        public void SetEducationinstitution(string educationinstitution)
        {
            Educationinstitution = educationinstitution;
        }
        public string GetPosition()
        { return Position; }
        public string GetDepartment()
        { return Department; }
        public string GetEducationinstitution()
        { return Educationinstitution;}
        public override string GetInfo()
        {
            return $"{LastName} {FirstName} - {Day}:{Month}:{Year},\nPosition - {Position}, SchoolName - {Department}, Higher education institution - {Educationinstitution}\n";
        }






    }
}
