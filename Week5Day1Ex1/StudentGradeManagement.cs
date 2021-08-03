using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Day1Ex1
{
    //Step 3. Create a structure for date of admission
    //Step 4. Create a list of grades for grade
    enum MonthofAdmission { May, June, July, August }
    enum Grades { A, B, C, D, F}

    //Step 5. Define a structure with student information
    struct Student
    {
        public int Sid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }

        //Step 6. Make MonthofAdmission and Grades public
        public MonthofAdmission MonthJoined { get; set; }
        public Grades Grade { get; set; }

        //Step 7.  Make struct Student public
        public Student(int ID, string FName, string LName, string Address, MonthofAdmission ma, Grades g)
        {
            this.Sid = ID;
            this.Firstname = FName;
            this.Lastname = LName;
            this.Address = Address;
            this.MonthJoined = ma;
            this.Grade = g;
        }
        //Step 8.  Create design!
        //Step 9.  Once done, go to Form1.cs and begin coding design by double clicking on actual Form
    }


    class StudentGradeManagement
    {
    }
}
