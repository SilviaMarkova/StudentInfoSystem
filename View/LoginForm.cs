using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentInfoSystem.Logic;
using StudentInfoSystem.Data;

namespace StudentInfoSystem.View
{
    public partial class LoginForm : Form
    {
        public User user { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            user = null;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            LoginValidation lv = new LoginValidation(textBoxUserName.Text, textBoxPassword.Text);
            User usr;
            if (lv.ValidateUserInput(out usr))
            {
                this.user = usr;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(lv.errText);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
