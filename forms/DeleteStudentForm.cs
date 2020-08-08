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
            var students = teacherService.Students.Select(student => student.Name + " " + student.Surname);
            StudentsComboBox.Items.AddRange(students.Cast<object>().ToArray());
        }

        private TeacherService teacherService { get; }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (KickFromCourseCheckBox.Checked && StudentsComboBox.Text.Count() != 0)
                if (teacherService.DeleteStudentFromTheCourse(teacherService.Students[StudentsComboBox.SelectedIndex], teacherService.LeadTeacher.SubjectId))
                    MessageBox.Show("Pomyślnie usunięto studenta z kursu");
                else
                    MessageBox.Show("Nie udało się usunąć studenta z kursu");

            else if (KickStudentCheckBox.Checked && StudentsComboBox.Text.Count() != 0)
                if (teacherService.DeleteStudentDefenitely(teacherService.Students[StudentsComboBox.SelectedIndex]))
                    MessageBox.Show("Anihilacja studenta zakończona");
                else
                    MessageBox.Show("Nie udało się wykończyć studenta");

            else
                MessageBox.Show("Prosze zaznaczyć odpowiednie pola");
        }
    }
}
