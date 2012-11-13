using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using FitBit_Dashboard;

namespace FitBit_Dashboard
{
    public partial class add_user_form : Form
    {
        private User theUser;
        private Dashboard dash;

        public add_user_form()
        {
            InitializeComponent();
        }

        public void start(Dashboard theDash)
        {
            this.dash = theDash;
            populateGroupComboBox();
        }

        public void populateGroupComboBox()
        {
            groupComboBox.Items.Clear();
            foreach (DictionaryEntry item in dash.groups)
            {
                groupComboBox.Items.Add(item.Key.ToString());
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.ToString().Equals("") || textBox1.Text.ToString().Equals(""))
            {
                MessageBox.Show("There must be something entered into the first name and last name fields.");
                return;
            }
            String firstName = nameTextBox.Text.ToString();
            String lastName = textBox1.Text.ToString();
            String displayName = textBox2.Text.ToString();
            theUser = new User(firstName, lastName, displayName, groupComboBox.Text.ToString());
            dash.addUser(theUser);
            nameTextBox.Text = "";
            groupComboBox.Text = "None";
            Close();
        }

        public User getUser()
        {
            return theUser;
        }
    }
}
