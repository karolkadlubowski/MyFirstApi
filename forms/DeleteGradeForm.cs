using Librus.data;
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
        private IDatabase database {get;}

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
            var gradeStudentSubject = database.GradeStudentSubjectRepository.GetWhere(gSS => gSS.StudentId == studentId && gSS.SubjectId == TeacherService.LeadTeacher.SubjectId).ToList().Select(gSS => gSS.GradeId + " - " + gSS.Description);
            gradesCheckedListBox.Items.AddRange(gradeStudentSubject.Cast<object>().ToArray());
        }
    }
}
