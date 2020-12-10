using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Person
    {
        protected string FirstName;
        protected string LastName;
        protected int Year;
        protected int Month;
        protected int Day;
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Person(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public void SetFirstName(string firstName)
        {
            FirstName = firstName;
        }
        public void SetLasttName(string lastName)
        {   
            LastName = lastName;
        }
        public void SetYear(int year)
        {
            if (year < 1900 && year > 2100)
                Year = 2000;
            else
                Year = year;
        }
        public void SetMonth(int month)
        {
            if (month <= 0 && month > 12)
               Month = 1;
            else 
               Month = month;

        }
        public void SetDay(int day)
        {
            if (day <= 0 && day > 31)
                Day = 1;
            else
                Day = day;

        }
        public string GetFirstName()
        { return FirstName; }
        public string GetLastName()
        { return LastName; }
        public int GetYear()
        { return Year; }
        public int GetMonth()
        { return Month; }
        public int GetDay()
        { return Day; }
        public virtual string GetInfo()
        {
            return $"{LastName} {FirstName} - ";
        }
        public virtual string GetInfo2()
        {
            return $" {Day}:{Month}:{Year}\n";
        }




    }
}
