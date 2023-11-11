
namespace LMS_UI
{
    partial class Admin_ViewStudents
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.departmentComnoBox = new System.Windows.Forms.ComboBox();
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.studentViewGridBox = new System.Windows.Forms.DataGridView();
            this.std_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIew = new System.Windows.Forms.DataGridViewLinkColumn();
            this.clsID = new System.Windows.Forms.Label();
            this.classIDComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentViewGridBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.classIDComboBox);
            this.panel1.Controls.Add(this.clsID);
            this.panel1.Controls.Add(this.studentViewGridBox);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.searchComboBox);
            this.panel1.Controls.Add(this.classComboBox);
            this.panel1.Controls.Add(this.departmentComnoBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 352);
            this.panel1.TabIndex = 0;
            // 
            // departmentComnoBox
            // 
            this.departmentComnoBox.FormattingEnabled = true;
            this.departmentComnoBox.Items.AddRange(new object[] {
            "Computer Science",
            "Math",
            "Physics",
            "English"});
            this.departmentComnoBox.Location = new System.Drawing.Point(40, 54);
            this.departmentComnoBox.Name = "departmentComnoBox";
            this.departmentComnoBox.Size = new System.Drawing.Size(121, 21);
            this.departmentComnoBox.TabIndex = 0;
            this.departmentComnoBox.SelectedIndexChanged += new System.EventHandler(this.departmentComnoBox_SelectedIndexChanged);
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(40, 81);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(121, 21);
            this.classComboBox.TabIndex = 1;
            this.classComboBox.SelectedIndexChanged += new System.EventHandler(this.classComboBox_SelectedIndexChanged);
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Location = new System.Drawing.Point(464, 54);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchComboBox.TabIndex = 3;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(464, 82);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(121, 20);
            this.searchTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(510, 106);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // studentViewGridBox
            // 
            this.studentViewGridBox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentViewGridBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentViewGridBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.std_ID,
            this.FName,
            this.LName,
            this.Class,
            this.Cls,
            this.VIew});
            this.studentViewGridBox.Location = new System.Drawing.Point(40, 151);
            this.studentViewGridBox.Name = "studentViewGridBox";
            this.studentViewGridBox.ReadOnly = true;
            this.studentViewGridBox.Size = new System.Drawing.Size(545, 173);
            this.studentViewGridBox.TabIndex = 6;
            // 
            // std_ID
            // 
            this.std_ID.HeaderText = "Std_ID";
            this.std_ID.Name = "std_ID";
            this.std_ID.ReadOnly = true;
            // 
            // FName
            // 
            this.FName.HeaderText = "FirstName";
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            // 
            // LName
            // 
            this.LName.HeaderText = "LastName";
            this.LName.Name = "LName";
            this.LName.ReadOnly = true;
            // 
            // Class
            // 
            this.Class.HeaderText = "ClassID";
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            // 
            // Cls
            // 
            this.Cls.HeaderText = "CLass";
            this.Cls.Name = "Cls";
            this.Cls.ReadOnly = true;
            // 
            // VIew
            // 
            this.VIew.HeaderText = "ViewDetails";
            this.VIew.Name = "VIew";
            this.VIew.ReadOnly = true;
            // 
            // clsID
            // 
            this.clsID.AutoSize = true;
            this.clsID.Location = new System.Drawing.Point(40, 109);
            this.clsID.Name = "clsID";
            this.clsID.Size = new System.Drawing.Size(46, 13);
            this.clsID.TabIndex = 8;
            this.clsID.Text = "Class ID";
            // 
            // classIDComboBox
            // 
            this.classIDComboBox.FormattingEnabled = true;
            this.classIDComboBox.Location = new System.Drawing.Point(101, 106);
            this.classIDComboBox.Name = "classIDComboBox";
            this.classIDComboBox.Size = new System.Drawing.Size(60, 21);
            this.classIDComboBox.TabIndex = 9;
            this.classIDComboBox.SelectedIndexChanged += new System.EventHandler(this.classIDComboBox_SelectedIndexChanged);
            // 
            // Admin_ViewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 352);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_ViewStudents";
            this.Text = "Admin_ViewStudents";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentViewGridBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView studentViewGridBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn std_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cls;
        private System.Windows.Forms.DataGridViewLinkColumn VIew;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.ComboBox departmentComnoBox;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private System.Windows.Forms.Label clsID;
        private System.Windows.Forms.ComboBox classIDComboBox;
    }
}