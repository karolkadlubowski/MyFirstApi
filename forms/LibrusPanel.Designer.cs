namespace Librus.forms
{
    partial class LibrusPanel
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
            this.StudentsGrid = new System.Windows.Forms.DataGridView();
            this.LeadTeacherLabel = new System.Windows.Forms.Label();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.AddGradeButton = new System.Windows.Forms.Button();
            this.AddToCourseButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.DeleteGradeButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentsGrid
            // 
            this.StudentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsGrid.Location = new System.Drawing.Point(5, 139);
            this.StudentsGrid.Name = "StudentsGrid";
            this.StudentsGrid.RowHeadersWidth = 51;
            this.StudentsGrid.RowTemplate.Height = 24;
            this.StudentsGrid.Size = new System.Drawing.Size(487, 285);
            this.StudentsGrid.TabIndex = 0;
            // 
            // LeadTeacherLabel
            // 
            this.LeadTeacherLabel.AutoSize = true;
            this.LeadTeacherLabel.Location = new System.Drawing.Point(408, 13);
            this.LeadTeacherLabel.Name = "LeadTeacherLabel";
            this.LeadTeacherLabel.Size = new System.Drawing.Size(78, 17);
            this.LeadTeacherLabel.TabIndex = 1;
            this.LeadTeacherLabel.Text = "Użytkownik";
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(34, 13);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(117, 23);
            this.AddStudentButton.TabIndex = 2;
            this.AddStudentButton.Text = "Dodaj studenta";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // AddGradeButton
            // 
            this.AddGradeButton.Location = new System.Drawing.Point(34, 98);
            this.AddGradeButton.Name = "AddGradeButton";
            this.AddGradeButton.Size = new System.Drawing.Size(117, 23);
            this.AddGradeButton.TabIndex = 3;
            this.AddGradeButton.Text = "Dodaj ocenę";
            this.AddGradeButton.UseVisualStyleBackColor = true;
            // 
            // AddToCourseButton
            // 
            this.AddToCourseButton.Location = new System.Drawing.Point(34, 54);
            this.AddToCourseButton.Name = "AddToCourseButton";
            this.AddToCourseButton.Size = new System.Drawing.Size(117, 23);
            this.AddToCourseButton.TabIndex = 4;
            this.AddToCourseButton.Text = "Dodaj do kursu";
            this.AddToCourseButton.UseVisualStyleBackColor = true;
            this.AddToCourseButton.Click += new System.EventHandler(this.AddToCourseButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(411, 98);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "Odśwież";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.Location = new System.Drawing.Point(206, 12);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(126, 23);
            this.DeleteStudentButton.TabIndex = 7;
            this.DeleteStudentButton.Text = "Usuń studenta";
            this.DeleteStudentButton.UseVisualStyleBackColor = true;
            // 
            // DeleteGradeButton
            // 
            this.DeleteGradeButton.Location = new System.Drawing.Point(206, 98);
            this.DeleteGradeButton.Name = "DeleteGradeButton";
            this.DeleteGradeButton.Size = new System.Drawing.Size(126, 23);
            this.DeleteGradeButton.TabIndex = 8;
            this.DeleteGradeButton.Text = "Usuń ocenę";
            this.DeleteGradeButton.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(410, 54);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 9;
            this.LogoutButton.Text = "Wyloguj";
            this.LogoutButton.UseVisualStyleBackColor = true;
            // 
            // LibrusPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.DeleteGradeButton);
            this.Controls.Add(this.DeleteStudentButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.AddToCourseButton);
            this.Controls.Add(this.AddGradeButton);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.LeadTeacherLabel);
            this.Controls.Add(this.StudentsGrid);
            this.Name = "LibrusPanel";
            this.Text = "LibrusPanel";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentsGrid;
        private System.Windows.Forms.Label LeadTeacherLabel;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button AddGradeButton;
        private System.Windows.Forms.Button AddToCourseButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button DeleteStudentButton;
        private System.Windows.Forms.Button DeleteGradeButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}