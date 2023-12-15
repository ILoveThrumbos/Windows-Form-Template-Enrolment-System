namespace EnrolmentForm2
{
    partial class CourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtCourseCostBox = new System.Windows.Forms.TextBox();
            this.textCourseNameBox = new System.Windows.Forms.TextBox();
            this.textCourseIDBox = new System.Windows.Forms.TextBox();
            this.courseTextBoxList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "View Course";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.displayCourse_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(499, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Course";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.addCourse_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "View Bill";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.displayCourseBill_Click);
            // 
            // txtCourseCostBox
            // 
            this.txtCourseCostBox.Location = new System.Drawing.Point(499, 192);
            this.txtCourseCostBox.Name = "txtCourseCostBox";
            this.txtCourseCostBox.Size = new System.Drawing.Size(84, 20);
            this.txtCourseCostBox.TabIndex = 3;
            // 
            // textCourseNameBox
            // 
            this.textCourseNameBox.Location = new System.Drawing.Point(499, 166);
            this.textCourseNameBox.Name = "textCourseNameBox";
            this.textCourseNameBox.Size = new System.Drawing.Size(84, 20);
            this.textCourseNameBox.TabIndex = 4;
            // 
            // textCourseIDBox
            // 
            this.textCourseIDBox.Location = new System.Drawing.Point(499, 140);
            this.textCourseIDBox.Name = "textCourseIDBox";
            this.textCourseIDBox.Size = new System.Drawing.Size(84, 20);
            this.textCourseIDBox.TabIndex = 5;
            // 
            // courseTextBoxList
            // 
            this.courseTextBoxList.FormattingEnabled = true;
            this.courseTextBoxList.Location = new System.Drawing.Point(69, 143);
            this.courseTextBoxList.Name = "courseTextBoxList";
            this.courseTextBoxList.Size = new System.Drawing.Size(300, 95);
            this.courseTextBoxList.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "CourseID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Add New Course";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseTextBoxList);
            this.Controls.Add(this.textCourseIDBox);
            this.Controls.Add(this.textCourseNameBox);
            this.Controls.Add(this.txtCourseCostBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "CourseForm";
            this.Text = "Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtCourseCostBox;
        private System.Windows.Forms.TextBox textCourseNameBox;
        private System.Windows.Forms.TextBox textCourseIDBox;
        private System.Windows.Forms.ListBox courseTextBoxList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}