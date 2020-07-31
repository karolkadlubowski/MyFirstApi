namespace Librus.forms
{
    partial class AddStudent
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
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.StudentNameTextBox = new System.Windows.Forms.TextBox();
            this.StudentSurnameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(148, 176);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(100, 23);
            this.AddStudentButton.TabIndex = 0;
            this.AddStudentButton.Text = "Dodaj";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.Location = new System.Drawing.Point(148, 78);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.StudentNameTextBox.TabIndex = 1;
            this.StudentNameTextBox.Text = "Imię";
            // 
            // StudentSurnameTextBox
            // 
            this.StudentSurnameTextBox.Location = new System.Drawing.Point(148, 116);
            this.StudentSurnameTextBox.Name = "StudentSurnameTextBox";
            this.StudentSurnameTextBox.Size = new System.Drawing.Size(100, 22);
            this.StudentSurnameTextBox.TabIndex = 2;
            this.StudentSurnameTextBox.Text = "Nazwisko";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 287);
            this.Controls.Add(this.StudentSurnameTextBox);
            this.Controls.Add(this.StudentNameTextBox);
            this.Controls.Add(this.AddStudentButton);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.TextBox StudentNameTextBox;
        private System.Windows.Forms.TextBox StudentSurnameTextBox;
    }
}