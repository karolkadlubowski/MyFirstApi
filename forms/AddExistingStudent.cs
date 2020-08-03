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
    public partial class AddExistingStudent : Form
    {
        public ITeacherService TeacherService { get; set; }

        public AddExistingStudent(TeacherService leadTeacher)
        {
            this.TeacherService = leadTeacher;
            this.database = new Database();
            this.StudentsList = database.StudentRepository.GetAll().ToList();
            InitializeComponent();
            var studentsCombo = this.StudentsList.Select(student => student.Name + " " + student.Surname);
            StudentComboBox.Items.AddRange(studentsCombo.Cast<object>().ToArray());
        }

        private IDatabase database { get; }

        private List<Student> StudentsList {get;set;}

        private void AddExistingStudentButton_Click(object sender, EventArgs e)
        {
            if (TeacherService.AddExistingStudent(StudentsList[StudentComboBox.SelectedIndex], TeacherService.LeadTeacher.SubjectId))
                MessageBox.Show("Pomyslnie dodano");
            else
                MessageBox.Show("Nie udalo sie dodac");
        }
    }
}
