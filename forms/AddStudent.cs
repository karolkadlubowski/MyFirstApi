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
        private PanelService panelService { get; }
        public ITeacherService TeacherService { get; set; }
        public AddStudent(Teacher leadTeacher)
        {
            panelService = new PanelService();
            this.TeacherService = new TeacherService(leadTeacher);
            InitializeComponent();
            StudentNameTextBox.GotFocus += (sen, eve) => panelService.RemoveText(StudentNameTextBox);
            StudentSurnameTextBox.GotFocus += (sen, eve) => panelService.RemoveText(StudentSurnameTextBox);
            StudentNameTextBox.LostFocus += (sen, eve) => panelService.AddText(StudentNameTextBox, "Imię");
            StudentSurnameTextBox.LostFocus += (sen, eve) => panelService.AddText(StudentSurnameTextBox, "Nazwisko");
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            if (TeacherService.AddStudent(StudentNameTextBox.Text, StudentSurnameTextBox.Text))
                MessageBox.Show("Pomyślnie dodano");
            else
                MessageBox.Show("Nie udało się dodać");
            this.Close();
        }
    }
}
