
namespace LMS_UI
{
    partial class Admin_AddCourses
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.courseIdTextBox = new System.Windows.Forms.TextBox();
            this.courseTittleTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.departmentCombobox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.coursesGridView = new System.Windows.Forms.DataGridView();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coursesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "course id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "course tittle";
            // 
            // courseIdTextBox
            // 
            this.courseIdTextBox.Location = new System.Drawing.Point(139, 75);
            this.courseIdTextBox.Name = "courseIdTextBox";
            this.courseIdTextBox.Size = new System.Drawing.Size(113, 20);
            this.courseIdTextBox.TabIndex = 2;
            // 
            // courseTittleTextbox
            // 
            this.courseTittleTextbox.Location = new System.Drawing.Point(139, 96);
            this.courseTittleTextbox.Name = "courseTittleTextbox";
            this.courseTittleTextbox.Size = new System.Drawing.Size(113, 20);
            this.courseTittleTextbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "department";
            // 
            // departmentCombobox
            // 
            this.departmentCombobox.FormattingEnabled = true;
            this.departmentCombobox.Items.AddRange(new object[] {
            "Computer Science",
            "Math",
            "English",
            "Urdu"});
            this.departmentCombobox.Location = new System.Drawing.Point(139, 28);
            this.departmentCombobox.Name = "departmentCombobox";
            this.departmentCombobox.Size = new System.Drawing.Size(113, 21);
            this.departmentCombobox.TabIndex = 5;
            this.departmentCombobox.SelectedIndexChanged += new System.EventHandler(this.departmentCombobox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(274, 29);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(64, 26);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(274, 60);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(64, 26);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(274, 92);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(64, 26);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // coursesGridView
            // 
            this.coursesGridView.AllowUserToDeleteRows = false;
            this.coursesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseID,
            this.Title,
            this.Department});
            this.coursesGridView.Location = new System.Drawing.Point(48, 145);
            this.coursesGridView.Name = "coursesGridView";
            this.coursesGridView.ReadOnly = true;
            this.coursesGridView.Size = new System.Drawing.Size(325, 161);
            this.coursesGridView.TabIndex = 9;
            this.coursesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.coursesGridView_CellContentClick);
            // 
            // CourseID
            // 
            this.CourseID.HeaderText = "CourseCode";
            this.CourseID.Name = "CourseID";
            this.CourseID.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // CCodeTextBox
            // 
            this.CCodeTextBox.Location = new System.Drawing.Point(139, 52);
            this.CCodeTextBox.Name = "CCodeTextBox";
            this.CCodeTextBox.ReadOnly = true;
            this.CCodeTextBox.Size = new System.Drawing.Size(113, 20);
            this.CCodeTextBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 319);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Code";
            // 
            // Admin_AddCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 343);
            this.Controls.Add(this.CCodeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.coursesGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.departmentCombobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.courseTittleTextbox);
            this.Controls.Add(this.courseIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Admin_AddCourses";
            this.Text = "Admin_AddCourses";
            this.Load += new System.EventHandler(this.Admin_AddCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coursesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courseIdTextBox;
        private System.Windows.Forms.TextBox courseTittleTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox departmentCombobox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView coursesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.TextBox CCodeTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
    }
}