using Librus.data;
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
        public AddExistingStudent()
        {
            this.Database = new Database();
            InitializeComponent();
            StudentComboBox.Items=
        }

        private IDatabase Database { get; }
    }
}
