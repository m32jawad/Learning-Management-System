
namespace LMS_UI
{
    partial class AdminForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.teacherButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.allocateCourseButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ViewTeacherButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewAllocatedCoursesButton = new System.Windows.Forms.Button();
            this.addTeacherButton = new System.Windows.Forms.Button();
            this.ViewStudentsButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.teacherButton);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.allocateCourseButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(157, 461);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // teacherButton
            // 
            this.teacherButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.teacherButton.Location = new System.Drawing.Point(3, 3);
            this.teacherButton.Name = "teacherButton";
            this.teacherButton.Size = new System.Drawing.Size(152, 43);
            this.teacherButton.TabIndex = 0;
            this.teacherButton.Text = "Teacher";
            this.teacherButton.UseVisualStyleBackColor = true;
            this.teacherButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(3, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Student";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(3, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 62);
            this.button3.TabIndex = 2;
            this.button3.Text = "Courses";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(3, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "Class";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // allocateCourseButton
            // 
            this.allocateCourseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.allocateCourseButton.Location = new System.Drawing.Point(3, 254);
            this.allocateCourseButton.Name = "allocateCourseButton";
            this.allocateCourseButton.Size = new System.Drawing.Size(152, 56);
            this.allocateCourseButton.TabIndex = 4;
            this.allocateCourseButton.Text = "Allocate Course";
            this.allocateCourseButton.UseVisualStyleBackColor = true;
            this.allocateCourseButton.Click += new System.EventHandler(this.allocateCourseButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AllowDrop = true;
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(155, 52);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(519, 409);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // ViewTeacherButton
            // 
            this.ViewTeacherButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ViewTeacherButton.Location = new System.Drawing.Point(433, 0);
            this.ViewTeacherButton.Name = "ViewTeacherButton";
            this.ViewTeacherButton.Size = new System.Drawing.Size(84, 46);
            this.ViewTeacherButton.TabIndex = 2;
            this.ViewTeacherButton.Text = "View Teachers";
            this.ViewTeacherButton.UseVisualStyleBackColor = true;
            this.ViewTeacherButton.Visible = false;
            this.ViewTeacherButton.Click += new System.EventHandler(this.ViewTeacherButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ViewStudentsButton);
            this.panel1.Controls.Add(this.viewAllocatedCoursesButton);
            this.panel1.Controls.Add(this.addTeacherButton);
            this.panel1.Controls.Add(this.ViewTeacherButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(157, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 46);
            this.panel1.TabIndex = 2;
            // 
            // viewAllocatedCoursesButton
            // 
            this.viewAllocatedCoursesButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.viewAllocatedCoursesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllocatedCoursesButton.Location = new System.Drawing.Point(268, 0);
            this.viewAllocatedCoursesButton.Name = "viewAllocatedCoursesButton";
            this.viewAllocatedCoursesButton.Size = new System.Drawing.Size(90, 46);
            this.viewAllocatedCoursesButton.TabIndex = 4;
            this.viewAllocatedCoursesButton.Text = "View aloocated Courses";
            this.viewAllocatedCoursesButton.UseVisualStyleBackColor = true;
            this.viewAllocatedCoursesButton.Visible = false;
            this.viewAllocatedCoursesButton.Click += new System.EventHandler(this.viewAllocatedCoursesButton_Click);
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addTeacherButton.Location = new System.Drawing.Point(358, 0);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(75, 46);
            this.addTeacherButton.TabIndex = 3;
            this.addTeacherButton.Text = "Add Teacher";
            this.addTeacherButton.UseVisualStyleBackColor = true;
            this.addTeacherButton.Visible = false;
            this.addTeacherButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewStudentsButton
            // 
            this.ViewStudentsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ViewStudentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewStudentsButton.Location = new System.Drawing.Point(178, 0);
            this.ViewStudentsButton.Name = "ViewStudentsButton";
            this.ViewStudentsButton.Size = new System.Drawing.Size(90, 46);
            this.ViewStudentsButton.TabIndex = 5;
            this.ViewStudentsButton.Text = "View Students";
            this.ViewStudentsButton.UseVisualStyleBackColor = true;
            this.ViewStudentsButton.Visible = false;
            this.ViewStudentsButton.Click += new System.EventHandler(this.ViewStudentsButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button teacherButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button ViewTeacherButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button allocateCourseButton;
        private System.Windows.Forms.Button addTeacherButton;
        private System.Windows.Forms.Button viewAllocatedCoursesButton;
        private System.Windows.Forms.Button ViewStudentsButton;
    }
}