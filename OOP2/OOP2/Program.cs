using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ivan", "Ivanov");
            Person person1 = new Person(2000, 09, 27);
            Applicant applicant = new Applicant("ZEL24", "Ivan", "Ivanov");
            Applicant applicant2 = new Applicant(197,193,2000,09,27);
            Student student = new Student("ZEL24", "Ivan", "Ivanov", "FICT", "ZTU");
            Student student2 = new Student(1,2, 197, 193, 2000, 09, 27);
            Teacher teacher = new Teacher("Petro", "Petrov", "Teacher", "Department of Information and Computer Technologies");
            Teacher teacher1 = new Teacher("Petro", "Petrov", "ZTU");
            LibraryUser libraryUser = new LibraryUser(1, 2, 197, 193, 2000, 09, 27, 121, 06, 09, 2020);
            LibraryUser libraryUser1 = new LibraryUser(1, 2, 197, 193, 2000, 09, 27, 50);
            Console.Write(person.GetInfo()); Console.WriteLine(person1.GetInfo2());
            Console.WriteLine(applicant.GetInfo());
            Console.WriteLine(student.GetInfo());
            Console.WriteLine(teacher.GetInfo());
            Console.WriteLine(teacher1.GetInfo());
            Console.WriteLine(libraryUser.GetInfo());








        }
    }
}
