namespace Librus.forms
{
    partial class DeleteStudentForm
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
            this.KickFromCourseCheckBox = new System.Windows.Forms.CheckBox();
            this.StudentsComboBox = new System.Windows.Forms.ComboBox();
            this.KickStudentCheckBox = new System.Windows.Forms.CheckBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KickFromCourseCheckBox
            // 
            this.KickFromCourseCheckBox.AutoSize = true;
            this.KickFromCourseCheckBox.Location = new System.Drawing.Point(227, 49);
            this.KickFromCourseCheckBox.Name = "KickFromCourseCheckBox";
            this.KickFromCourseCheckBox.Size = new System.Drawing.Size(113, 21);
            this.KickFromCourseCheckBox.TabIndex = 0;
            this.KickFromCourseCheckBox.Text = "Usuń z kursu";
            this.KickFromCourseCheckBox.UseVisualStyleBackColor = true;
            // 
            // StudentsComboBox
            // 
            this.StudentsComboBox.FormattingEnabled = true;
            this.StudentsComboBox.Location = new System.Drawing.Point(46, 46);
            this.StudentsComboBox.Name = "StudentsComboBox";
            this.StudentsComboBox.Size = new System.Drawing.Size(121, 24);
            this.StudentsComboBox.TabIndex = 1;
            // 
            // KickStudentCheckBox
            // 
            this.KickStudentCheckBox.AutoSize = true;
            this.KickStudentCheckBox.Location = new System.Drawing.Point(227, 76);
            this.KickStudentCheckBox.Name = "KickStudentCheckBox";
            this.KickStudentCheckBox.Size = new System.Drawing.Size(135, 21);
            this.KickStudentCheckBox.TabIndex = 2;
            this.KickStudentCheckBox.Text = "Usuń studenta :)";
            this.KickStudentCheckBox.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(227, 114);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(129, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Kasuj";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 149);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.KickStudentCheckBox);
            this.Controls.Add(this.StudentsComboBox);
            this.Controls.Add(this.KickFromCourseCheckBox);
            this.Name = "DeleteStudentForm";
            this.Text = "DeleteStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox KickFromCourseCheckBox;
        private System.Windows.Forms.ComboBox StudentsComboBox;
        private System.Windows.Forms.CheckBox KickStudentCheckBox;
        private System.Windows.Forms.Button DeleteButton;
    }
}