using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FitBit_Dashboard
{
    public partial class AddGroupForm : Form
    {
        private Dashboard dash;
        public AddGroupForm(Dashboard mainDash)
        {
            InitializeComponent();
            this.dash = mainDash;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Group group = new Group(groupTextBox.Text.ToString());
            dash.addGroup(group);
            Close();
            dash.populateGroupsComboBox();
        }
    }
}
