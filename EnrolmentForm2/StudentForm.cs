using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnrolmentForm2.StudentAdminServiceReference;

namespace EnrolmentForm2
{
    public partial class StudentForm : Form
    {
        private StudentAdminClient clientS = new StudentAdminClient();
        
        public StudentForm()
        {
            InitializeComponent();
        }
        private void displayViewStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                studentListBox.Items.Clear();
                foreach (Student student in clientS.ViewStudent())
                {
                    studentListBox.Items.Add("Student ID: " + student.StudentID + ", Student Name: " +
                        student.StudentName + ", Date Enrolled: " + student.DateEnrolled);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            
        }

        private void displayStudentTimeTable_Click(object sender, EventArgs e)
        {
            try
            {
                studentListBox.Items.Clear();
                foreach (TimetableEntry timetableEntries in clientS.StudentTimetable())
                {
                    studentListBox.Items.Add("Student ID: " + timetableEntries.StudentID + ", Student Name: " + timetableEntries.StudentName 
                        + ", Course ID: " + timetableEntries.CourseID + ", Course Name: " + timetableEntries.CourseName);
                }
 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying timetable: {ex.Message}", "Error");
            }
        }



        private void addStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = int.Parse(txtStudentID.Text);
                string studentName = txtStudentFirstName.Text + " " + txtStudentLastName.Text;
                DateTime dateEnrolled = DateTime.Now;

                clientS.NewStudent(studentID, studentName, dateEnrolled);

                string message = $"Student added successfully:\n" +
                        $"Student ID: {studentID}\n" +
                        $"Student Name: {studentName}\n" +
                        $"Date Enrolled: {dateEnrolled}";
                MessageBox.Show(message, "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding student: {ex.Message}", "Error");
            }
        }
    }
}
