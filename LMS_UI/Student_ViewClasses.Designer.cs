
namespace LMS_UI
{
    partial class Student_ViewClasses
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
            this.materialDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherCoursesDataGridView = new System.Windows.Forms.DataGridView();
            this.Coursecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherCoursesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDataGridView
            // 
            this.materialDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.materialDataGridView.Location = new System.Drawing.Point(204, 242);
            this.materialDataGridView.Name = "materialDataGridView";
            this.materialDataGridView.Size = new System.Drawing.Size(393, 126);
            this.materialDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Material_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "FIle Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // TeacherCoursesDataGridView
            // 
            this.TeacherCoursesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TeacherCoursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherCoursesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coursecode,
            this.CourseTitle,
            this.Class,
            this.CCID});
            this.TeacherCoursesDataGridView.Location = new System.Drawing.Point(204, 69);
            this.TeacherCoursesDataGridView.Name = "TeacherCoursesDataGridView";
            this.TeacherCoursesDataGridView.Size = new System.Drawing.Size(393, 126);
            this.TeacherCoursesDataGridView.TabIndex = 2;
            this.TeacherCoursesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeacherCoursesDataGridView_CellContentClick);
            // 
            // Coursecode
            // 
            this.Coursecode.HeaderText = "CourseCode";
            this.Coursecode.Name = "Coursecode";
            this.Coursecode.ReadOnly = true;
            // 
            // CourseTitle
            // 
            this.CourseTitle.HeaderText = "Title";
            this.CourseTitle.Name = "CourseTitle";
            this.CourseTitle.ReadOnly = true;
            // 
            // Class
            // 
            this.Class.HeaderText = "Class";
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            // 
            // CCID
            // 
            this.CCID.HeaderText = "CCID";
            this.CCID.Name = "CCID";
            this.CCID.ReadOnly = true;
            // 
            // Student_ViewClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialDataGridView);
            this.Controls.Add(this.TeacherCoursesDataGridView);
            this.Name = "Student_ViewClasses";
            this.Text = "Student_ViewClasses";
            this.Load += new System.EventHandler(this.Student_ViewClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherCoursesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView materialDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView TeacherCoursesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coursecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCID;
    }
}