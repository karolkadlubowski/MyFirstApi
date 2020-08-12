using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Librus.data;
using Librus.models;
using Librus.services;

namespace Librus.forms
{
    public partial class RegisterOrLogin : Form
    {
        private readonly IPanelService panelService;

        private readonly IAuthService authService;

        private readonly INavigationService navigationService;

        public RegisterOrLogin()
        {
            this.panelService = new PanelService();
            this.authService = new AuthService();
            this.navigationService = new NavigationService();
            InitializeComponent();
        }

        private TextBox loginBox { get; set; }
        private TextBox passwordBox { get; set; }
        private Button confirmButton { get; set; }
        private ComboBox subjectBox { get; set; }


        private void loginButton_Click_1(object sender, EventArgs e)
        {
            loginButton.Dispose();
            registerButton.Dispose();
            panelService.AddNewLabel(10, 10, "Podaj dane:", this);
            loginBox = panelService.AddNewTextBox(40, 0, "Login", this);
            passwordBox = panelService.AddNewTextBox(70, 0, "Haslo", this);
            confirmButton = panelService.AddNewButton(100, 0, "Zaloguj", this);
        }

        

        public void confirmButton_Click(object sender, EventArgs e)
        {

            if (confirmButton.Text == "Zaloguj")
            {
                Teacher leadTeacher = authService.Login(loginBox.Text, passwordBox.Text);
                if (leadTeacher == null)
                {
                    MessageBox.Show("Nie udało się zalogować");
                    navigationService.Navigate<RegisterOrLogin, RegisterOrLogin>(this, typeof(RegisterOrLogin),true);
                }
                else
                {
                    MessageBox.Show("Pomyślnie zalogowano");
                   
                    navigationService.Navigate<RegisterOrLogin, LibrusPanel>(this, typeof(LibrusPanel),leadTeacher, hideCurrent: true);
                }
            }
            else
            {
                if (authService.Register(loginBox.Text, passwordBox.Text, subjectBox.Text))
                {
                    MessageBox.Show("Pomyślnie zarejestrowano");
                }
                else
                {
                    MessageBox.Show("Nie udało się zarejestrować");
                }
                navigationService.Navigate<RegisterOrLogin, RegisterOrLogin>(this, typeof(RegisterOrLogin), true);
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            loginButton.Dispose();
            registerButton.Dispose();
            panelService.AddNewLabel(10, 10, "Podaj dane:", this);
            loginBox = panelService.AddNewTextBox(40, 0, "Login", this);
            passwordBox = panelService.AddNewTextBox(70, 0, "Haslo", this);
            subjectBox = panelService.AddNewComboBox(100, 0, "hehe", this);
            confirmButton = panelService.AddNewButton(130, 0, "Zarejestruj", this);
            /*loginBox.GotFocus += (s, eve) => panelService.RemoveText(loginBox);
            loginBox.LostFocus += (s, eve) => panelService.AddText(loginBox, "Login");*/
        }
    }
}
