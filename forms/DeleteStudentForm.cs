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
    public partial class DeleteStudentForm : Form
    {
        public DeleteStudentForm(TeacherService teacherService)
        {
            this.teacherService = teacherService;
            InitializeComponent();
            StudentsComboBox.Items.AddRange(teacherService.Students.Cast<object>().ToArray());
        }

        private TeacherService teacherService { get; }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (KickFromCourseCheckBox.Checked && StudentsComboBox.Text.Count() != 0)
                teacherService.DeleteStudentFromTheCourse(teacherService.Students[StudentsComboBox.SelectedIndex], teacherService.LeadTeacher.SubjectId);
        }
    }
}
