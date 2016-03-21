using MovieClasses;
using MovieManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinClient
{
    public partial class AddPersonForm : Form
    {

        private PersonManager personManager;

        public AddPersonForm(PersonManager personManager)
        {
            this.personManager = personManager;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var person = new Person()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text
            };
            personManager.AddPerson(person);
        }
    }
}
