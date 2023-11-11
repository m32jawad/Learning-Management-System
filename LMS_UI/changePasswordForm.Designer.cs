
namespace LMS_UI
{
    partial class changePasswordForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currentTB = new System.Windows.Forms.TextBox();
            this.createNewTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmNewTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.loginIDTB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.confirmNewTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.createNewTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.currentTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Password";
            // 
            // currentTB
            // 
            this.currentTB.Location = new System.Drawing.Point(123, 33);
            this.currentTB.Name = "currentTB";
            this.currentTB.Size = new System.Drawing.Size(100, 20);
            this.currentTB.TabIndex = 1;
            // 
            // createNewTB
            // 
            this.createNewTB.Location = new System.Drawing.Point(123, 59);
            this.createNewTB.Name = "createNewTB";
            this.createNewTB.Size = new System.Drawing.Size(100, 20);
            this.createNewTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Create New";
            // 
            // confirmNewTB
            // 
            this.confirmNewTB.Location = new System.Drawing.Point(123, 85);
            this.confirmNewTB.Name = "confirmNewTB";
            this.confirmNewTB.Size = new System.Drawing.Size(100, 20);
            this.confirmNewTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm New";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(148, 111);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "LoginID";
            // 
            // loginIDTB
            // 
            this.loginIDTB.Location = new System.Drawing.Point(231, 6);
            this.loginIDTB.Name = "loginIDTB";
            this.loginIDTB.ReadOnly = true;
            this.loginIDTB.Size = new System.Drawing.Size(46, 20);
            this.loginIDTB.TabIndex = 2;
            // 
            // changePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 214);
            this.Controls.Add(this.loginIDTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "changePasswordForm";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.changePasswordForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox confirmNewTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox createNewTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox currentTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loginIDTB;
    }
}