namespace Librus.forms
{
    partial class AddExistingStudent
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
            this.StudentComboBox = new System.Windows.Forms.ComboBox();
            this.AddExistingStudentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentComboBox
            // 
            this.StudentComboBox.FormattingEnabled = true;
            this.StudentComboBox.Location = new System.Drawing.Point(99, 63);
            this.StudentComboBox.Name = "StudentComboBox";
            this.StudentComboBox.Size = new System.Drawing.Size(187, 24);
            this.StudentComboBox.TabIndex = 0;
            // 
            // AddExistingStudentButton
            // 
            this.AddExistingStudentButton.Location = new System.Drawing.Point(99, 142);
            this.AddExistingStudentButton.Name = "AddExistingStudentButton";
            this.AddExistingStudentButton.Size = new System.Drawing.Size(187, 23);
            this.AddExistingStudentButton.TabIndex = 1;
            this.AddExistingStudentButton.Text = "Dodaj studenta do kursu";
            this.AddExistingStudentButton.UseVisualStyleBackColor = true;
            // 
            // AddExistingStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 297);
            this.Controls.Add(this.AddExistingStudentButton);
            this.Controls.Add(this.StudentComboBox);
            this.Name = "AddExistingStudent";
            this.Text = "AddExistingStudent";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox StudentComboBox;
        private System.Windows.Forms.Button AddExistingStudentButton;
    }
}