namespace Librus.forms
{
    partial class DeleteGradeForm
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
            this.deleteGradeButton = new System.Windows.Forms.Button();
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.gradesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.markAllCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // deleteGradeButton
            // 
            this.deleteGradeButton.Location = new System.Drawing.Point(34, 36);
            this.deleteGradeButton.Name = "deleteGradeButton";
            this.deleteGradeButton.Size = new System.Drawing.Size(247, 23);
            this.deleteGradeButton.TabIndex = 1;
            this.deleteGradeButton.Text = "Usuń";
            this.deleteGradeButton.UseVisualStyleBackColor = true;
            // 
            // studentComboBox
            // 
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(34, 77);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(247, 24);
            this.studentComboBox.TabIndex = 2;
            this.studentComboBox.SelectedIndexChanged += new System.EventHandler(this.studentComboBox_SelectedIndexChanged);
            // 
            // gradesCheckedListBox
            // 
            this.gradesCheckedListBox.FormattingEnabled = true;
            this.gradesCheckedListBox.Location = new System.Drawing.Point(34, 120);
            this.gradesCheckedListBox.Name = "gradesCheckedListBox";
            this.gradesCheckedListBox.Size = new System.Drawing.Size(247, 208);
            this.gradesCheckedListBox.TabIndex = 3;
            // 
            // markAllCheckBox
            // 
            this.markAllCheckBox.AutoSize = true;
            this.markAllCheckBox.Location = new System.Drawing.Point(34, 335);
            this.markAllCheckBox.Name = "markAllCheckBox";
            this.markAllCheckBox.Size = new System.Drawing.Size(147, 21);
            this.markAllCheckBox.TabIndex = 4;
            this.markAllCheckBox.Text = "Zaznacz wszystkie";
            this.markAllCheckBox.UseVisualStyleBackColor = true;
            // 
            // DeleteGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 361);
            this.Controls.Add(this.markAllCheckBox);
            this.Controls.Add(this.gradesCheckedListBox);
            this.Controls.Add(this.studentComboBox);
            this.Controls.Add(this.deleteGradeButton);
            this.Name = "DeleteGradeForm";
            this.Text = "DeleteGradeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteGradeButton;
        private System.Windows.Forms.ComboBox studentComboBox;
        private System.Windows.Forms.CheckedListBox gradesCheckedListBox;
        private System.Windows.Forms.CheckBox markAllCheckBox;
    }
}