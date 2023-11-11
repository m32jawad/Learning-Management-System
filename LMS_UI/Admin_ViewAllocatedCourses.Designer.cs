
namespace LMS_UI
{
    partial class Admin_ViewAllocatedCourses
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
            this.CousesDataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchByComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CousesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CousesDataGridView
            // 
            this.CousesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.CousesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CousesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CousesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CTitle,
            this.Cl_ID,
            this.Class,
            this.TID,
            this.T_Name});
            this.CousesDataGridView.Location = new System.Drawing.Point(27, 111);
            this.CousesDataGridView.Name = "CousesDataGridView";
            this.CousesDataGridView.Size = new System.Drawing.Size(461, 207);
            this.CousesDataGridView.TabIndex = 12;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(425, 79);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(51, 23);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchByComboBox
            // 
            this.searchByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByComboBox.FormattingEnabled = true;
            this.searchByComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searchByComboBox.Items.AddRange(new object[] {
            "Course ID",
            "Class ID",
            "Teacher ID"});
            this.searchByComboBox.Location = new System.Drawing.Point(332, 55);
            this.searchByComboBox.Name = "searchByComboBox";
            this.searchByComboBox.Size = new System.Drawing.Size(144, 21);
            this.searchByComboBox.TabIndex = 10;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(328, 82);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(91, 20);
            this.searchTextBox.TabIndex = 9;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(135, 21);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(261, 25);
            this.headerLabel.TabIndex = 8;
            this.headerLabel.Text = "View Allocated Courses";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Items.AddRange(new object[] {
            "Computer Science",
            "Math",
            "English",
            "Physics"});
            this.departmentComboBox.Location = new System.Drawing.Point(45, 59);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(121, 21);
            this.departmentComboBox.TabIndex = 7;
            this.departmentComboBox.SelectedIndexChanged += new System.EventHandler(this.departmentComboBox_SelectedIndexChanged);
            // 
            // CID
            // 
            this.CID.HeaderText = "Course ID";
            this.CID.Name = "CID";
            this.CID.Width = 79;
            // 
            // CTitle
            // 
            this.CTitle.HeaderText = "Title";
            this.CTitle.Name = "CTitle";
            this.CTitle.Width = 52;
            // 
            // Cl_ID
            // 
            this.Cl_ID.HeaderText = "Class ID";
            this.Cl_ID.Name = "Cl_ID";
            this.Cl_ID.Width = 71;
            // 
            // Class
            // 
            this.Class.HeaderText = "Class";
            this.Class.Name = "Class";
            this.Class.Width = 57;
            // 
            // TID
            // 
            this.TID.HeaderText = "Teacher ID";
            this.TID.Name = "TID";
            this.TID.Width = 86;
            // 
            // T_Name
            // 
            this.T_Name.HeaderText = "Teacher";
            this.T_Name.Name = "T_Name";
            this.T_Name.Width = 72;
            // 
            // Admin_ViewAllocatedCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 342);
            this.Controls.Add(this.CousesDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchByComboBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.departmentComboBox);
            this.Name = "Admin_ViewAllocatedCourses";
            this.Text = "Admin_ViewAllocatedCourses";
            ((System.ComponentModel.ISupportInitialize)(this.CousesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CousesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn TID;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_Name;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox searchByComboBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ComboBox departmentComboBox;
    }
}