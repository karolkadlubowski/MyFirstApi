using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librus.forms
{
    public partial class RegisterOrLogin : Form
    {
        public RegisterOrLogin()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username, password;
            panelService(out username,out password);
            var loginButton = AddNewButton(80, 0, "Zaloguj");
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username, password;
            panelService(out username, out password);
            
        }

        private void panelService(out string username,out string password)
        {
            loginButton.Dispose();
            registerButton.Dispose();
            AddNewLabel(10, 10, "Podaj dane:");
            //AddNewLabel(40, 10, "Login:");
            //AddNewLabel(70, 10, "Haslo:");
            var loginBox = AddNewTextBox(30, 0, "Login");
            //System.Windows.Forms.TextBox password = AddNewTextBox(70, 0, "Haslo");
            var passwordBox = AddNewTextBox(55, 0, "Haslo");
            username = loginBox.Text;
            password = passwordBox.Text;
        }

        public System.Windows.Forms.Label AddNewLabel(int top, int left, string text)
        {
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            this.Controls.Add(label);
            label.Top = top;
            label.Left = left == 0 ? (this.Width-label.Width)/2 : left;
            label.Text = text;
            return label;
        }

        public System.Windows.Forms.TextBox AddNewTextBox(int top, int left, string text)
        {
            System.Windows.Forms.TextBox box = new System.Windows.Forms.TextBox();
            this.Controls.Add(box);
            box.Top = top;
            box.Left = left == 0 ? (this.Width - box.Width) / 2 : left;
            box.Text = text;
            return box;
        }

        public System.Windows.Forms.Button AddNewButton(int top, int left, string text)
        {
            var button = new System.Windows.Forms.Button();
            button.Top = top;
            button.Left = left == 0 ? (this.Width - button.Width) / 2 : left;
            button.Text = text;
            return button;
        }

    }
}
