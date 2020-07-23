using Librus.forms;
using System.Windows.Forms;
using System;
using System.Drawing;
using Librus.data;
using System.Collections.Generic;
using Librus.models;
using System.Linq;

namespace Librus.services
{
    public interface IPanelService
    {
        void AddNewLabel(int top, int left, string text, RegisterOrLogin form);
        TextBox AddNewTextBox(int top, int left, string text, RegisterOrLogin form);
        Button AddNewButton(int top, int left, string text, RegisterOrLogin form);
        ComboBox AddNewComboBox(int top, int left, string text, RegisterOrLogin form);
    }

    public class PanelService : IPanelService
    {
        public PanelService()
        {
            this.database = new Database();
        }
        public Database database { get;}

        public void AddNewLabel(int top, int left, string text, RegisterOrLogin form)
        {
            Label label = new Label();
            form.Controls.Add(label);
            label.Top = top;
            label.Left = left == 0 ? (form.Width - label.Width) / 2 : left;
            label.Text = text;

        }

        public TextBox AddNewTextBox(int top, int left, string text, RegisterOrLogin form)
        {
            TextBox box = new TextBox();
            form.Controls.Add(box);
            box.Top = top;
            box.Left = left == 0 ? (form.Width - box.Width) / 2 : left;
            box.Text = text;
            return box;
        }

        public Button AddNewButton(int top, int left, string text, RegisterOrLogin form)
        {
            var button = new Button();
            form.Controls.Add(button);
            button.Top = top;
            button.Left = left == 0 ? (form.Width - button.Width) / 2 : left;
            button.Text = text;
            button.Click += new EventHandler(form.confirmButton_Click);
            return button;
        }

        public ComboBox AddNewComboBox(int top, int left, string text, RegisterOrLogin form)
        {
            var comboBox = new ComboBox();
            form.Controls.Add(comboBox);
            comboBox.Location = new Point(left==0 ? (form.Width-comboBox.Width)/2 : left, top);
            var subjects = database.SubjectRepository.GetAll().Select(s=>s.Name).ToList();
            comboBox.Items.AddRange(subjects.Cast<object>().ToArray());
            return comboBox;
        }
    }
}
