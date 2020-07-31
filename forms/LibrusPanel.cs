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
            StudentsGrid.DataSource = teacherService.Teachers;
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            navigationService.Navigate<LibrusPanel, AddStudent>(this, typeof(AddStudent),this.teacherService.LeadTeacher);
        }
    }
}
