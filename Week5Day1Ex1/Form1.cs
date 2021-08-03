using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Week5Day1Ex1
{
    public partial class Form1 : Form
    {
        //Step 1. Define an array list within Form1 Class
        //Step 2. Create a class for the student management
        // - Go to student class
        
        ArrayList stulist;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Step 10. Lets call our array
            stulist = new ArrayList();
            //Step 11. Lets add an example Student so we can view in our Data Grid
            stulist.Add(new Student(1, FName: "Ex. Hung", LName: "Le", Address: "TX", MonthofAdmission.June, Grades.B));
            //Step 12. Lets get our data grid to read the student information
            stuGrid.DataSource = stulist;
            //Step 13. Lets see if our information is shown in the datagrid
            //Step 14. Now, lets work on our Add Student button, but we need to put 2 commands so that the drop down will have a value
            comboMonth.DataSource = Enum.GetValues(typeof(MonthofAdmission));
            comboGrade.DataSource = Enum.GetValues(typeof(Grades));
            //Step 15.  Now double click on Add Student Information button on design
            //**Notes** 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Step 15. lets make sure that all information will be enter and that all field must be filled out
            //Step 16. IOT do that, we need to create an if loop
            if (txtID.Text != string.Empty && txtFName.Text != string.Empty && txtLName.Text != string.Empty && txtAddress.Text != string.Empty)
            {
                //Step 17.  Now, lets call student structure so we can write and store the information
                //Step 18.  IOT do that, we need to make a new student by using a new variable
                Student newStu = new Student();
                //lets call the functions with the new variable and assigning it to the text boxes
                newStu.Sid = Int32.Parse(txtID.Text);
                newStu.Firstname = txtFName.Text;
                newStu.Lastname = txtLName.Text;
                newStu.Address = txtAddress.Text;
                newStu.MonthJoined = (MonthofAdmission)0;
                newStu.Grade = (Grades)0;
                stulist.Add(newStu);
                //Step 19.  Now that that's done, we need to create a refresh structure so the add student list will refresh after we add
                //a student.
            }
            //Step 23. Call the Refresh function after the "if" loop
            RefreshList();
            //Step 24.  Now lets test by adding a student, if successful, we'll work on the delete button.
            //Step 25.  Double click the "Delete Student Information" button on design.
        }
        //Step 20. Create a refresh function
        private void RefreshList()
        {
            //Step 21.  IOT clear a text box after information was entered, need to ref the txt with .Clear();
            txtID.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtAddress.Clear();
            comboMonth.Text = "Select Month...";
            comboGrade.Text = "Select Grade...";
            stuGrid.DataSource = null;
            stuGrid.DataSource = stulist; //*Note* this is to refresh the data grid
            //Step 22.  Next, we need to care this function in our Add after we add a new student.
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //Step 26.  Lets delete each row
            stulist.RemoveAt(stuGrid.CurrentRow.Index);
            //From Student List > Remove (Inside Student Grid > Row Selected)
            stuGrid.DataSource = null;
            stuGrid.DataSource = stulist;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
