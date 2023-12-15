using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnrolmentForm2.CourseAdminServiceReference;

namespace EnrolmentForm2
{
    public partial class CourseForm : Form
    {
        private CourseAdminClient clientC = new CourseAdminClient();
        public CourseForm()
        {
            InitializeComponent();
        }

        private void addCourse_Click(object sender, EventArgs e)
        {
            try
            {
                int courseID = int.Parse(textCourseIDBox.Text);
                string courseName = textCourseNameBox.Text;
                decimal cost = decimal.Parse(txtCourseCostBox.Text);

                clientC.NewCourse(courseID, courseName, cost);

                string message = $"Student added successfully:\n" +
                        $"Student ID: {courseID},\n" +
                        $"Student Name: {courseName},\n" +
                        $"Cost $: {cost},";
                MessageBox.Show(message, "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding student: {ex.Message}", "Error");
            }
        }

        private void displayCourse_Click(object sender, EventArgs e)
        {
            try
            {
                courseTextBoxList.Items.Clear();
                foreach (Course course in clientC.ViewCourse())
                {
                    courseTextBoxList.Items.Add("Course ID: " + course.CourseID+ "," + " Course Name: " + 
                        course.CourseName + "," + " Cost: $" + course.Cost);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }

        }

        private void displayCourseBill_Click(object sender, EventArgs e)
        {
            try
            {
                courseTextBoxList.Items.Clear();
                foreach (Course course in clientC.DisplayBill())
                {
                    courseTextBoxList.Items.Add("Course ID: "+ course.CourseID + "," + " Cost: $" + course.Cost);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }

        }
    }
}
