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
    public partial class AddStudent : Form
    {

        public ITeacherService TeacherService { get; set; }
        public AddStudent(Teacher leadTeacher)
        {
            this.TeacherService = new TeacherService(leadTeacher);
            InitializeComponent();
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            if (TeacherService.AddStudent(StudentNameTextBox.Text, StudentSurnameTextBox.Text, TeacherService.LeadTeacher.SubjectId))
                MessageBox.Show("Pomyślnie dodano");
            else
                MessageBox.Show("Nie udało się dodać");
            this.Close();
        }
    }
}
