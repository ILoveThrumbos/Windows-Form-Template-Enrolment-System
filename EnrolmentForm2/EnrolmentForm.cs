using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnrolmentForm2.EnrolmentAdminServiceReference;

namespace EnrolmentForm2
{
    public partial class EnrolmentForm : Form
    {
        private EnrolmentAdminClient clientE = new EnrolmentAdminClient();
        public EnrolmentForm()
        {
            InitializeComponent();
        }

        private void displayEnrolmentByCourseID_Click(object sender, EventArgs e)
        {
            try
            {
                int courseID = int.Parse(txtEnrolmentCourseID.Text);

                Enrolment1 enrolment = clientE.GetEnrolmentByCourseID(courseID);

                // Now you can use the 'enrolment' object as needed, for example, display it in a MessageBox
                MessageBox.Show($"Student ID: {enrolment.StudentID}\nCourse ID: {enrolment.CourseID}\nGrade: {enrolment.Grade}",
                    "Enrolment Details");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting enrolment: {ex.Message}", "Error");
            }
        }


        private void displayStudentEnrolments_Click(object sender, EventArgs e)
        {
            try
            {
                enrolmentListBox.Items.Clear();
                foreach (Enrolment1 enrolment in clientE.GetEnrolments())
                {
                    enrolmentListBox.Items.Add("Student ID: " + enrolment.StudentID + ", Course ID: " + enrolment.CourseID 
                        + ", Grade: " + enrolment.Grade);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }

        }

        private void enrolStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = int.Parse(txtStudentIDBox.Text);
                int courseID = int.Parse(txtCourseIDBox.Text);

                clientE.EnrolStudent(studentID, courseID);

                string message = $"Student added successfully:\n" +
                        $"Student ID: {studentID}\n" +
                        $"Course ID: {courseID}\n";
                MessageBox.Show(message, "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding student: {ex.Message}", "Error");
            }
        }

    }
}
