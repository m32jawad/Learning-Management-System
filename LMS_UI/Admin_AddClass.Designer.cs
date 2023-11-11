
namespace LMS_UI
{
    partial class Admin_AddClass
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
            this.label3 = new System.Windows.Forms.Label();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.addSectionTextBox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.addSemesterTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.classesGridView = new System.Windows.Forms.DataGridView();
            this.classID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "section";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Semester";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Items.AddRange(new object[] {
            "Computer Science",
            "Math",
            "English",
            "Physics"});
            this.departmentComboBox.Location = new System.Drawing.Point(148, 66);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(100, 21);
            this.departmentComboBox.TabIndex = 3;
            this.departmentComboBox.SelectedIndexChanged += new System.EventHandler(this.addDepartmentComboBox_SelectedIndexChanged);
            // 
            // addSectionTextBox
            // 
            this.addSectionTextBox.Location = new System.Drawing.Point(148, 108);
            this.addSectionTextBox.Name = "addSectionTextBox";
            this.addSectionTextBox.Size = new System.Drawing.Size(100, 20);
            this.addSectionTextBox.TabIndex = 4;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(245, 71);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(55, 24);
            this.submit.TabIndex = 6;
            this.submit.Text = "Add";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // addSemesterTextBox
            // 
            this.addSemesterTextBox.Location = new System.Drawing.Point(148, 129);
            this.addSemesterTextBox.Name = "addSemesterTextBox";
            this.addSemesterTextBox.Size = new System.Drawing.Size(100, 20);
            this.addSemesterTextBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.classesGridView);
            this.groupBox1.Controls.Add(this.submit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 270);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // classesGridView
            // 
            this.classesGridView.AllowUserToDeleteRows = false;
            this.classesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.classesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classID,
            this.Title,
            this.Department,
            this.Dep});
            this.classesGridView.Location = new System.Drawing.Point(6, 102);
            this.classesGridView.Name = "classesGridView";
            this.classesGridView.ReadOnly = true;
            this.classesGridView.Size = new System.Drawing.Size(325, 161);
            this.classesGridView.TabIndex = 10;
            // 
            // classID
            // 
            this.classID.HeaderText = "ClassID";
            this.classID.Name = "classID";
            this.classID.ReadOnly = true;
            this.classID.Width = 68;
            // 
            // Title
            // 
            this.Title.HeaderText = "Semester";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 76;
            // 
            // Department
            // 
            this.Department.HeaderText = "Section";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            this.Department.Width = 68;
            // 
            // Dep
            // 
            this.Dep.HeaderText = "Department";
            this.Dep.Name = "Dep";
            this.Dep.ReadOnly = true;
            this.Dep.Width = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ClassID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // Admin_AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 337);
            this.Controls.Add(this.addSemesterTextBox);
            this.Controls.Add(this.addSectionTextBox);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin_AddClass";
            this.Text = "Admin_AddClass";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.TextBox addSectionTextBox;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox addSemesterTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView classesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn classID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dep;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}