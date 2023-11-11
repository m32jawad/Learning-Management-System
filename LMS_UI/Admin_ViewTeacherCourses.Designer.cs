
namespace LMS_UI
{
    partial class Admin_ViewTeacherCourses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.teacherNameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.depLabel = new System.Windows.Forms.Label();
            this.teacherCoursesGridView = new System.Windows.Forms.DataGridView();
            this.courseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherCoursesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.teacherCoursesGridView);
            this.panel1.Controls.Add(this.depLabel);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.teacherNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 302);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // teacherNameLabel
            // 
            this.teacherNameLabel.AutoSize = true;
            this.teacherNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherNameLabel.Location = new System.Drawing.Point(78, 48);
            this.teacherNameLabel.Name = "teacherNameLabel";
            this.teacherNameLabel.Size = new System.Drawing.Size(66, 24);
            this.teacherNameLabel.TabIndex = 0;
            this.teacherNameLabel.Text = "label1";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(79, 72);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(52, 18);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "label1";
            // 
            // depLabel
            // 
            this.depLabel.AutoSize = true;
            this.depLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depLabel.Location = new System.Drawing.Point(79, 93);
            this.depLabel.Name = "depLabel";
            this.depLabel.Size = new System.Drawing.Size(51, 20);
            this.depLabel.TabIndex = 2;
            this.depLabel.Text = "label1";
            // 
            // teacherCoursesGridView
            // 
            this.teacherCoursesGridView.AllowUserToAddRows = false;
            this.teacherCoursesGridView.AllowUserToDeleteRows = false;
            this.teacherCoursesGridView.AllowUserToOrderColumns = true;
            this.teacherCoursesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teacherCoursesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.teacherCoursesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherCoursesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseID,
            this.courseTitle,
            this.semester,
            this.Section,
            this.department,
            this.remove});
            this.teacherCoursesGridView.Location = new System.Drawing.Point(33, 125);
            this.teacherCoursesGridView.Name = "teacherCoursesGridView";
            this.teacherCoursesGridView.ReadOnly = true;
            this.teacherCoursesGridView.Size = new System.Drawing.Size(398, 150);
            this.teacherCoursesGridView.TabIndex = 3;
            this.teacherCoursesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacherCoursesGridView_CellContentClick);
            // 
            // courseID
            // 
            this.courseID.HeaderText = "Course Code";
            this.courseID.Name = "courseID";
            this.courseID.ReadOnly = true;
            // 
            // courseTitle
            // 
            this.courseTitle.HeaderText = "Course Title";
            this.courseTitle.Name = "courseTitle";
            this.courseTitle.ReadOnly = true;
            // 
            // semester
            // 
            this.semester.HeaderText = "Semester";
            this.semester.Name = "semester";
            this.semester.ReadOnly = true;
            // 
            // Section
            // 
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            // 
            // department
            // 
            this.department.HeaderText = "Department";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            // 
            // remove
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.remove.DefaultCellStyle = dataGridViewCellStyle3;
            this.remove.HeaderText = "Remove Course";
            this.remove.Name = "remove";
            this.remove.ReadOnly = true;
            this.remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.remove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Admin_ViewTeacherCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 302);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_ViewTeacherCourses";
            this.Text = "Admin_ViewTeacherCourses";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherCoursesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label depLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label teacherNameLabel;
        private System.Windows.Forms.DataGridView teacherCoursesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewButtonColumn remove;
    }
}