namespace Librus.forms
{
    partial class AddGradeForm
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
            this.studentsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.gradesComboBox = new System.Windows.Forms.ComboBox();
            this.markAllCheckBox = new System.Windows.Forms.CheckBox();
            this.addGradeButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // studentsCheckedListBox
            // 
            this.studentsCheckedListBox.FormattingEnabled = true;
            this.studentsCheckedListBox.Location = new System.Drawing.Point(280, 45);
            this.studentsCheckedListBox.Name = "studentsCheckedListBox";
            this.studentsCheckedListBox.Size = new System.Drawing.Size(269, 344);
            this.studentsCheckedListBox.TabIndex = 0;
            // 
            // gradesComboBox
            // 
            this.gradesComboBox.FormattingEnabled = true;
            this.gradesComboBox.Location = new System.Drawing.Point(12, 360);
            this.gradesComboBox.Name = "gradesComboBox";
            this.gradesComboBox.Size = new System.Drawing.Size(262, 24);
            this.gradesComboBox.TabIndex = 1;
            // 
            // markAllCheckBox
            // 
            this.markAllCheckBox.AutoSize = true;
            this.markAllCheckBox.Location = new System.Drawing.Point(280, 396);
            this.markAllCheckBox.Name = "markAllCheckBox";
            this.markAllCheckBox.Size = new System.Drawing.Size(154, 21);
            this.markAllCheckBox.TabIndex = 2;
            this.markAllCheckBox.Text = "Zaznacz wszystkich";
            this.markAllCheckBox.UseVisualStyleBackColor = true;
            // 
            // addGradeButton
            // 
            this.addGradeButton.Location = new System.Drawing.Point(12, 277);
            this.addGradeButton.Name = "addGradeButton";
            this.addGradeButton.Size = new System.Drawing.Size(262, 23);
            this.addGradeButton.TabIndex = 3;
            this.addGradeButton.Text = "Dodaj ocenę";
            this.addGradeButton.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(13, 318);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(261, 22);
            this.descriptionTextBox.TabIndex = 4;
            this.descriptionTextBox.Text = "Dodaj opis";
            // 
            // AddGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.addGradeButton);
            this.Controls.Add(this.markAllCheckBox);
            this.Controls.Add(this.gradesComboBox);
            this.Controls.Add(this.studentsCheckedListBox);
            this.Name = "AddGradeForm";
            this.Text = "AddGradeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox studentsCheckedListBox;
        private System.Windows.Forms.ComboBox gradesComboBox;
        private System.Windows.Forms.CheckBox markAllCheckBox;
        private System.Windows.Forms.Button addGradeButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
    }
}