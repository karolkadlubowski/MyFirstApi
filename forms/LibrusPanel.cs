using Librus.services;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using SQLite;
using Librus.models;
using System.Activities.Expressions;

namespace Librus.forms
{
    public partial class LibrusPanel : Form
    {

        private readonly IPanelService panelService;

        private readonly INavigationService navigationService;
        private readonly ITeacherService teacherService;

        public LibrusPanel(Teacher leadTeacher)
        {
            this.teacherService = new TeacherService(leadTeacher);
            this.panelService = new PanelService();
            this.navigationService = new NavigationService();   
            InitializeComponent();
            LeadTeacherLabel.Text = leadTeacher.Login;
            StudentsGrid.DataSource = teacherService.Students;
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            navigationService.Navigate<LibrusPanel, AddStudent>(this, typeof(AddStudent),this.teacherService.LeadTeacher);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            navigationService.Navigate<LibrusPanel, LibrusPanel>(this, typeof(LibrusPanel), this.teacherService.LeadTeacher,true);
        }

        private void AddToCourseButton_Click(object sender, EventArgs e)
        {
            navigationService.Navigate<LibrusPanel, AddExistingStudent>(this, typeof(AddExistingStudent), teacherService);
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            navigationService.Navigate<LibrusPanel, DeleteStudentForm>(this, typeof(DeleteStudentForm), teacherService);
        }

        private void AddGradeButton_Click(object sender, EventArgs e)
        {
            navigationService.Navigate<LibrusPanel, AddGradeForm>(this, typeof(AddGradeForm), teacherService);
        }
    }
}
