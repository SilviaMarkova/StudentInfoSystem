using StudentInfoSystem.Data;
using StudentInfoSystem.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace StudentInfoSystem.View
{
    public partial class MainForm : Form
    {
        public UserStatus userStatus { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelFaculty_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void deleteInfo()
        {
            textFirstName.Text = String.Empty;
            textMiddleName.Text = String.Empty;
            textLastName.Text = String.Empty;
            textFaculty.Text = String.Empty;
            textSpeciality.Text = String.Empty;
            textFakNum.Text = String.Empty;
            textFlow.Text = String.Empty;
            textGroup.Text = String.Empty;
            comboBoxOks.Items.Clear();

        }
        //trqbva da se opravi da vzima danni ot bazata danni
        public void showInfo(Student student)
        {
            textFirstName.Text = student.FirstName;
            textMiddleName.Text = student.SecondName;
            textLastName.Text = student.LastName;
            textFaculty.Text = student.Faculty;
            textSpeciality.Text = student.Specialty;
            textFakNum.Text = student.FakNumber;
            textFlow.Text = student.Potok;
            textGroup.Text = Convert.ToString(student.Group);
           
        }
        public void disableControls()
        {
            textFirstName.Enabled = false;
            textMiddleName.Enabled = false;
            textLastName.Enabled = false;
            textFaculty.Enabled = false;
            textSpeciality.Enabled = false;
            textFakNum.Enabled = false;
            textFlow.Enabled = false;
            textGroup.Enabled = false;
            comboBoxOks.Enabled = false;
        }
        public void enableControls()
        {
            textFirstName.Enabled = true;
            textMiddleName.Enabled = true;
            textLastName.Enabled = true;
            textFaculty.Enabled = true;
            textSpeciality.Enabled = true;
            textFakNum.Enabled = true;
            textFlow.Enabled = true;
            textGroup.Enabled = true;
            comboBoxOks.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            deleteInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            disableControls();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            enableControls();
        }

        public void checkLogin(User user)
        {
           Student st =  StudentValidation.IsThereStudent(user);
          
            switch (userStatus)
            {
                case UserStatus.ANONYMOUS:
                    deleteInfo();
                    disableControls();
                    break;
                case UserStatus.STUDENT:
                    showInfo(st);
                    break;
                case UserStatus.ADMIN:
                    showInfo(st);
                    break;
                default:
                    break;
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.Cancel) 
            {
                userStatus = UserStatus.ANONYMOUS;
                disableControls();
                deleteInfo();

            }
            else
            {
                userStatus = UserStatus.STUDENT;
                checkLogin(loginForm.user);
                enableControls();
            }
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

    }
}
