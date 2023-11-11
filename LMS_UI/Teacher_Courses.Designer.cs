
namespace LMS_UI
{
    partial class Teacher_Courses
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TeacherCoursesDataGridView = new System.Windows.Forms.DataGridView();
            this.Coursecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewStudentsButton = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Button();
            this.materialDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classesPanel = new System.Windows.Forms.Panel();
            this.CCIDLabel = new System.Windows.Forms.Label();
            this.instructorLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.courseTitleLabel = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherCoursesDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataGridView)).BeginInit();
            this.classesPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TeacherCoursesDataGridView);
            this.panel1.Location = new System.Drawing.Point(281, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 129);
            this.panel1.TabIndex = 0;
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
            this.TeacherCoursesDataGridView.Location = new System.Drawing.Point(51, 0);
            this.TeacherCoursesDataGridView.Name = "TeacherCoursesDataGridView";
            this.TeacherCoursesDataGridView.Size = new System.Drawing.Size(393, 126);
            this.TeacherCoursesDataGridView.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.viewStudentsButton);
            this.panel2.Controls.Add(this.uploadButton);
            this.panel2.Controls.Add(this.materialDataGridView);
            this.panel2.Location = new System.Drawing.Point(281, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 200);
            this.panel2.TabIndex = 1;
            // 
            // viewStudentsButton
            // 
            this.viewStudentsButton.Location = new System.Drawing.Point(268, 23);
            this.viewStudentsButton.Name = "viewStudentsButton";
            this.viewStudentsButton.Size = new System.Drawing.Size(95, 23);
            this.viewStudentsButton.TabIndex = 2;
            this.viewStudentsButton.Text = "View Students";
            this.viewStudentsButton.UseVisualStyleBackColor = true;
            this.viewStudentsButton.Click += new System.EventHandler(this.viewStudentsButton_Click);
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(369, 23);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(75, 23);
            this.uploadButton.TabIndex = 0;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // materialDataGridView
            // 
            this.materialDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.materialDataGridView.Location = new System.Drawing.Point(51, 52);
            this.materialDataGridView.Name = "materialDataGridView";
            this.materialDataGridView.Size = new System.Drawing.Size(393, 126);
            this.materialDataGridView.TabIndex = 1;
            this.materialDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // classesPanel
            // 
            this.classesPanel.BackColor = System.Drawing.Color.Blue;
            this.classesPanel.Controls.Add(this.CCIDLabel);
            this.classesPanel.Controls.Add(this.instructorLabel);
            this.classesPanel.Controls.Add(this.classLabel);
            this.classesPanel.Controls.Add(this.courseTitleLabel);
            this.classesPanel.Location = new System.Drawing.Point(344, 374);
            this.classesPanel.Name = "classesPanel";
            this.classesPanel.Size = new System.Drawing.Size(345, 139);
            this.classesPanel.TabIndex = 4;
            this.classesPanel.Visible = false;
            // 
            // CCIDLabel
            // 
            this.CCIDLabel.AutoSize = true;
            this.CCIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCIDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CCIDLabel.Location = new System.Drawing.Point(12, 87);
            this.CCIDLabel.Name = "CCIDLabel";
            this.CCIDLabel.Size = new System.Drawing.Size(48, 20);
            this.CCIDLabel.TabIndex = 6;
            this.CCIDLabel.Text = "CCID";
            this.CCIDLabel.Click += new System.EventHandler(this.CCIDLabel_Click);
            // 
            // instructorLabel
            // 
            this.instructorLabel.AutoSize = true;
            this.instructorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.instructorLabel.Location = new System.Drawing.Point(12, 67);
            this.instructorLabel.Name = "instructorLabel";
            this.instructorLabel.Size = new System.Drawing.Size(75, 20);
            this.instructorLabel.TabIndex = 5;
            this.instructorLabel.Text = "instructor";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.classLabel.Location = new System.Drawing.Point(12, 47);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(45, 20);
            this.classLabel.TabIndex = 4;
            this.classLabel.Text = "class";
            // 
            // courseTitleLabel
            // 
            this.courseTitleLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.courseTitleLabel.AutoSize = true;
            this.courseTitleLabel.BackColor = System.Drawing.Color.Blue;
            this.courseTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTitleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.courseTitleLabel.LinkColor = System.Drawing.Color.White;
            this.courseTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.courseTitleLabel.Margin = new System.Windows.Forms.Padding(10, 10, 13, 10);
            this.courseTitleLabel.Name = "courseTitleLabel";
            this.courseTitleLabel.Padding = new System.Windows.Forms.Padding(10);
            this.courseTitleLabel.Size = new System.Drawing.Size(160, 45);
            this.courseTitleLabel.TabIndex = 3;
            this.courseTitleLabel.TabStop = true;
            this.courseTitleLabel.Text = "Course Title";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(242, 428);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Blue;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Location = new System.Drawing.Point(715, 393);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 162);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(25, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "CCID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "instructor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(28, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "class";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Blue;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(3, 16);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(10, 10, 13, 10);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Padding = new System.Windows.Forms.Padding(10);
            this.linkLabel1.Size = new System.Drawing.Size(160, 45);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Course Title";
            // 
            // Teacher_Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.classesPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Teacher_Courses";
            this.Text = "Teacher_Courses";
            this.Load += new System.EventHandler(this.Teacher_Courses_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TeacherCoursesDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialDataGridView)).EndInit();
            this.classesPanel.ResumeLayout(false);
            this.classesPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView TeacherCoursesDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coursecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.DataGridView materialDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public System.Windows.Forms.Panel classesPanel;
        private System.Windows.Forms.Label CCIDLabel;
        private System.Windows.Forms.Label instructorLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.LinkLabel courseTitleLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button viewStudentsButton;
    }
}