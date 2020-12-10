using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Person
    {
        protected string FirstName;
        protected string LastName;
        protected int BirthDate;
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Person ()
        {
            FirstName = "Ivan";
            LastName = "Ivanov";
            Date BirthDate = new Date(30, 12, 30);
        }
        public string GetFirstName()
        {
            return FirstName;
        }
        public string GetLastName()
        {
            return LastName;
        }
      
        public void ShowInfo()
        {
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Birth Date: {BirthDate}");
        }

    }
    public class Student
    {
        protected int Course;
        protected int Group;
        protected string Faculty;
        protected string University;
        public Student (int Course, int Group, string Faculty, string University)
        {
            this.Course = Course;
            this.Group = Group;
            this.Faculty = Faculty;
            this.University = University;
        }
        public Student(int Course, int Group)
        {
            this.Course = 1;
            this.Group = 20-2;
        }

    }
    public class Applicant
    {
        protected int ZNOGrades;
        protected int NumberOfGradesInSchool;
        protected string NameOfSchool;
        public Applicant (int ZNOGrades, int NumberOfGradesInSchool, string NameOfSchool)
        {
            this.ZNOGrades = ZNOGrades;
            this.NumberOfGradesInSchool = NumberOfGradesInSchool;
            this.NameOfSchool = NameOfSchool; 
        }
        public Applicant(int ZNOGrades, int NumberOfGradesInSchool)
        {
            this.ZNOGrades = 400;
            this.NumberOfGradesInSchool = 160;
        }
    }
    public class Lecturer
    {
        protected string Position;
        protected string Chair;
        protected string University;
        public Lecturer(string Position, string Chair, string University)
        {
            this.Position = Position;
            this.Chair = Chair;
            this.University = University;
        }
        public Lecturer(string Position, string University)
        {
            this.Position = "Professor";
            this.University = "Zhytomyr Polytechnic";
        }
    }
    public class LibraryUser
    {
        protected int NumberOfLibraryUsersCard;
        protected double DateOfIssue;
        protected int TheAmountOfTheMonthlyReadersFee;
        public LibraryUser(int NumberOfLibraryUsersCard, int DateOfIssue, int TheAmountOfTheMonthlyReadersFee)
        {
            this.NumberOfLibraryUsersCard = NumberOfLibraryUsersCard;
            this.DateOfIssue = DateOfIssue;
        }
        public LibraryUser(int NumberOfLibraryUsersCard, double DateOfIssue)
        {
            this.NumberOfLibraryUsersCard = 115;
            this.DateOfIssue = DateOfIssue;
        }
    }
    public class Date
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;
        public void SetYear(int Year)
        {
            if (Year >= 2020)
            {
                this.Year = Year;
            }
        }
        public void SetMonth(int Month)
        {
            if (Month <= 12 && Month > 0)
            {
                this.Month = Month;
            }
        }
        public void SetDay(int Day)
        {
            if (Day <= 31 && Day > 0)
            {
                this.Day = Day;
            }
        }
        public int GetYear()
        {
            return Year;
        }
        public int GetMonth()
        {
            return Month;
        }
        public int GetDay()
        {
            return Day;
        }
        public Date()
        {
            Year = 1900;
            Month = 12;
            Day = 31;
        }
        public Date(int Day, int Month, int Year)
        {
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
        }
        public Date(int Day, int Month)
        {
            Year = 2020;
            Month = 11;
            this.Day = Day;

        }
        public Date(Date d)
        {
            Year = d.Year;
            Month = d.Month;
            Day = d.Day;

        }

    }
    

}

