using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class LibraryUser : Student
    {
        protected int ReaderTicketNumber;
        protected int DayOfIssue;
        protected int MonthOfIssue;
        protected int YearOfIssue;
        protected int AmountReaderFee;
        //protected string FstName;
        //protected string LstName;
        public LibraryUser(int course, int groupe, int znocount, int certificatecount, int year, int month, int day, int readerTicketNumber, int dayOfIssue, int monthOfIssue, int yearOfIssue)
         : base(znocount, certificatecount, year, month, day, course, groupe)
        {
            ReaderTicketNumber = readerTicketNumber;
            DayOfIssue = dayOfIssue;
            MonthOfIssue = monthOfIssue;
            YearOfIssue = yearOfIssue;
        }
        public LibraryUser(int course, int groupe, int znocount, int certificatecount, int year, int month, int day,  int amountReaderFee)
         : base(znocount, certificatecount, year, month, day, course, groupe)
        {
            AmountReaderFee = amountReaderFee;
        }

        public void SetReaderTicketNumber(int readerTicketNumber)
        {
            if (readerTicketNumber < 0)
                ReaderTicketNumber = 1;
            else
                ReaderTicketNumber = readerTicketNumber;
        }
        public void SetDayOfIssue(int dayOfIssue)
        {
            if (dayOfIssue < 31 && dayOfIssue > 0)
                DayOfIssue = dayOfIssue;
            else
                DayOfIssue = 1;
        }
        public void SetMonthOfIssue(int monthOfIssue)
        {
            if (monthOfIssue < 13 && monthOfIssue > 0)
                MonthOfIssue = monthOfIssue;
            else
                MonthOfIssue = 1;
        }
        public void SetYearOfIssue(int yearOfIssue)
        {
            if (yearOfIssue < 3000 && yearOfIssue > 2000)
                YearOfIssue = yearOfIssue;
            else
                YearOfIssue = 2020;
        }
        public void SetAmountReaderFee(int amountReaderFee)
        {
            if (amountReaderFee < 0)
                AmountReaderFee = 1;
            else
                AmountReaderFee = amountReaderFee;
        }
        public int GetReaderTicketNumber()
        {
            return ReaderTicketNumber;
        }
        public int GetDayOfIssue()
        {
            return DayOfIssue;
        }
        public int GetMonthOfIssue()
        { return MonthOfIssue; }
        public int GetYearOfIssue()
        { return YearOfIssue; }
        public override string GetInfo()
        {
            return $"{LastName} {FirstName} - {Day}:{Month}:{Year},\nZNOcount - {ZNOcount}, SchoolName - {SchoolName}, Certificatecount = {Certificatecount}\nCourse - {Course}, Group - {Group}, Faculty - {Faculty}, Institute - {Institute}\nReader's ticket number - {ReaderTicketNumber}, Date Of Issue - {DayOfIssue}:{MonthOfIssue}:{YearOfIssue}, The amount of the reader's fee - {AmountReaderFee}\n";
        }



    }
}
