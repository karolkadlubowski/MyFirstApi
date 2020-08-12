using Librus.data;
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
    public partial class DeleteGradeForm : Form
    {
        public ITeacherService TeacherService { get; set; }
        private IDatabase database { get; }

        private List<GradeStudentSubject> gradeStudentSubject {get;set;}

        public DeleteGradeForm(TeacherService teacherService)
        {
            this.database = new Database();
            this.TeacherService = teacherService;
            InitializeComponent();
            studentComboBox.Items.AddRange(teacherService.Students.Select(student => student.Name + " " + student.Surname).Cast<object>().ToArray());
        }

        private void studentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            gradesCheckedListBox.Items.Clear();
            int index = studentComboBox.SelectedIndex;
            int studentId = TeacherService.Students[studentComboBox.SelectedIndex].Id;
            this.gradeStudentSubject = database.GradeStudentSubjectRepository.GetWhere(gSS => gSS.StudentId == studentId && gSS.SubjectId == TeacherService.LeadTeacher.SubjectId).ToList();
            var gradeStudentSubjectString = this.gradeStudentSubject.Select(gSS => gSS.GradeId + " - " + gSS.Description);
            gradesCheckedListBox.Items.AddRange(gradeStudentSubjectString.Cast<object>().ToArray());
        }

        private void markAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int gradesAmount = gradesCheckedListBox.Items.Count;
            CheckState checkState = markAllCheckBox.Checked ? CheckState.Checked : CheckState.Unchecked;
            for (int i = 0; i < gradesAmount; i++)
                gradesCheckedListBox.SetItemCheckState(i, checkState);
        }

        private void deleteGradeButton_Click(object sender, EventArgs e)
        {
            var checkedIndexes = gradesCheckedListBox.CheckedIndices;
            List<GradeStudentSubject> gSSToDelete = new List<GradeStudentSubject>();
            foreach (int index in checkedIndexes)
                gSSToDelete.Add(this.gradeStudentSubject[index]);
            if (TeacherService.DeleteGrade(gSSToDelete))
                MessageBox.Show("Pomyślnie usunięto oceny");
            else
                MessageBox.Show("Nie udało się usunąć ocen");

        }
    }
}
