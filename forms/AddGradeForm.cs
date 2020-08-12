using Librus.models;
using Librus.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librus.forms
{
    public partial class AddGradeForm : Form
    {
        public TeacherService TeacherService { get; set; }
        private PanelService panelService { get; set; }

        public AddGradeForm(TeacherService teacherService)
        {
            panelService = new PanelService();
            TeacherService = teacherService;
            InitializeComponent();
            var students = TeacherService.Students.Select(student => student.Name + " " + student.Surname);
            studentsCheckedListBox.Items.AddRange(students.Cast<object>().ToArray());
            gradesComboBox.Items.AddRange(TeacherService.Grades.Select(grade => grade.Value).Cast<object>().ToArray());
            descriptionTextBox.GotFocus += (s, eve) => panelService.RemoveText(descriptionTextBox);
            descriptionTextBox.LostFocus += (s, eve) => panelService.AddText(descriptionTextBox, "Dodaj opis");
        }

        private void markAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int studentsAmount = studentsCheckedListBox.Items.Count;
            CheckState checkState = (markAllCheckBox.Checked == true) ? CheckState.Checked : CheckState.Unchecked;
            for (int i = 0; i < studentsAmount; i++)
                studentsCheckedListBox.SetItemCheckState(i, checkState);
        }

        private void addGradeButton_Click(object sender, EventArgs e)
        {
            var checkedStudents = studentsCheckedListBox.CheckedIndices;
            if (gradesComboBox.Text.Length != 0 && checkedStudents.Count != 0)
            {
                int[] students = new int[checkedStudents.Count];
                int i = 0;
                foreach (int index in checkedStudents)
                    students[i++]=TeacherService.Students[index].Id;
                if (TeacherService.AddGradeRange(gradesComboBox.SelectedIndex + 1, students, TeacherService.LeadTeacher.SubjectId, descriptionTextBox.Text))
                {
                    MessageBox.Show("Pomyślnie dodano ocenę");
                    return;
                }
            }
            MessageBox.Show("Nie udało się dodać oceny");
        }
    }
}
