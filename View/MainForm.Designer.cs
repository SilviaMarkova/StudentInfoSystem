namespace StudentInfoSystem.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.studentTab = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupStudentInfo = new System.Windows.Forms.GroupBox();
            this.textGroup = new System.Windows.Forms.TextBox();
            this.textFlow = new System.Windows.Forms.TextBox();
            this.numericUpDownCourse = new System.Windows.Forms.NumericUpDown();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelFlow = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxOks = new System.Windows.Forms.ComboBox();
            this.textFakNum = new System.Windows.Forms.TextBox();
            this.textSpeciality = new System.Windows.Forms.TextBox();
            this.textFaculty = new System.Windows.Forms.TextBox();
            this.labelFakNum = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelOks = new System.Windows.Forms.Label();
            this.labelSpeciality = new System.Windows.Forms.Label();
            this.labelFaculty = new System.Windows.Forms.Label();
            this.groupPersonalInfo = new System.Windows.Forms.GroupBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textMiddleName = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.l = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.groupPhoto = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradesTab = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.studentTab.SuspendLayout();
            this.groupStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).BeginInit();
            this.groupPersonalInfo.SuspendLayout();
            this.groupPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(647, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.studentTab);
            this.tabControl1.Controls.Add(this.gradesTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(647, 435);
            this.tabControl1.TabIndex = 1;
            // 
            // studentTab
            // 
            this.studentTab.Controls.Add(this.button4);
            this.studentTab.Controls.Add(this.button3);
            this.studentTab.Controls.Add(this.button2);
            this.studentTab.Controls.Add(this.buttonDelete);
            this.studentTab.Controls.Add(this.groupStudentInfo);
            this.studentTab.Controls.Add(this.groupPersonalInfo);
            this.studentTab.Controls.Add(this.groupPhoto);
            this.studentTab.Location = new System.Drawing.Point(4, 22);
            this.studentTab.Name = "studentTab";
            this.studentTab.Padding = new System.Windows.Forms.Padding(3);
            this.studentTab.Size = new System.Drawing.Size(639, 409);
            this.studentTab.TabIndex = 0;
            this.studentTab.Text = "Студент";
            this.studentTab.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Enable";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Disable";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(19, 277);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupStudentInfo
            // 
            this.groupStudentInfo.Controls.Add(this.textGroup);
            this.groupStudentInfo.Controls.Add(this.textFlow);
            this.groupStudentInfo.Controls.Add(this.numericUpDownCourse);
            this.groupStudentInfo.Controls.Add(this.labelGroup);
            this.groupStudentInfo.Controls.Add(this.labelFlow);
            this.groupStudentInfo.Controls.Add(this.labelCourse);
            this.groupStudentInfo.Controls.Add(this.comboBoxStatus);
            this.groupStudentInfo.Controls.Add(this.comboBoxOks);
            this.groupStudentInfo.Controls.Add(this.textFakNum);
            this.groupStudentInfo.Controls.Add(this.textSpeciality);
            this.groupStudentInfo.Controls.Add(this.textFaculty);
            this.groupStudentInfo.Controls.Add(this.labelFakNum);
            this.groupStudentInfo.Controls.Add(this.labelStatus);
            this.groupStudentInfo.Controls.Add(this.labelOks);
            this.groupStudentInfo.Controls.Add(this.labelSpeciality);
            this.groupStudentInfo.Controls.Add(this.labelFaculty);
            this.groupStudentInfo.Location = new System.Drawing.Point(213, 168);
            this.groupStudentInfo.Name = "groupStudentInfo";
            this.groupStudentInfo.Size = new System.Drawing.Size(417, 232);
            this.groupStudentInfo.TabIndex = 2;
            this.groupStudentInfo.TabStop = false;
            this.groupStudentInfo.Text = "Студентска информация";
            // 
            // textGroup
            // 
            this.textGroup.Location = new System.Drawing.Point(330, 97);
            this.textGroup.Name = "textGroup";
            this.textGroup.Size = new System.Drawing.Size(55, 20);
            this.textGroup.TabIndex = 15;
            // 
            // textFlow
            // 
            this.textFlow.Location = new System.Drawing.Point(330, 60);
            this.textFlow.Name = "textFlow";
            this.textFlow.Size = new System.Drawing.Size(55, 20);
            this.textFlow.TabIndex = 14;
            // 
            // numericUpDownCourse
            // 
            this.numericUpDownCourse.Location = new System.Drawing.Point(330, 29);
            this.numericUpDownCourse.Name = "numericUpDownCourse";
            this.numericUpDownCourse.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownCourse.TabIndex = 13;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(280, 100);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(39, 13);
            this.labelGroup.TabIndex = 12;
            this.labelGroup.Text = "Група:";
            this.labelGroup.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelFlow
            // 
            this.labelFlow.AutoSize = true;
            this.labelFlow.Location = new System.Drawing.Point(278, 63);
            this.labelFlow.Name = "labelFlow";
            this.labelFlow.Size = new System.Drawing.Size(41, 13);
            this.labelFlow.TabIndex = 11;
            this.labelFlow.Text = "Поток:";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(285, 31);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(34, 13);
            this.labelCourse.TabIndex = 10;
            this.labelCourse.Text = "Курс:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(115, 138);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(134, 21);
            this.comboBoxStatus.TabIndex = 9;
            // 
            // comboBoxOks
            // 
            this.comboBoxOks.FormattingEnabled = true;
            this.comboBoxOks.Location = new System.Drawing.Point(115, 97);
            this.comboBoxOks.Name = "comboBoxOks";
            this.comboBoxOks.Size = new System.Drawing.Size(134, 21);
            this.comboBoxOks.TabIndex = 8;
            // 
            // textFakNum
            // 
            this.textFakNum.Location = new System.Drawing.Point(115, 173);
            this.textFakNum.Name = "textFakNum";
            this.textFakNum.Size = new System.Drawing.Size(134, 20);
            this.textFakNum.TabIndex = 7;
            // 
            // textSpeciality
            // 
            this.textSpeciality.Location = new System.Drawing.Point(115, 63);
            this.textSpeciality.Name = "textSpeciality";
            this.textSpeciality.Size = new System.Drawing.Size(134, 20);
            this.textSpeciality.TabIndex = 6;
            // 
            // textFaculty
            // 
            this.textFaculty.Location = new System.Drawing.Point(115, 31);
            this.textFaculty.Name = "textFaculty";
            this.textFaculty.Size = new System.Drawing.Size(134, 20);
            this.textFaculty.TabIndex = 5;
            // 
            // labelFakNum
            // 
            this.labelFakNum.AutoSize = true;
            this.labelFakNum.Location = new System.Drawing.Point(28, 176);
            this.labelFakNum.Name = "labelFakNum";
            this.labelFakNum.Size = new System.Drawing.Size(71, 13);
            this.labelFakNum.TabIndex = 4;
            this.labelFakNum.Text = "Фак. номер:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(55, 138);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(44, 13);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Статус:";
            // 
            // labelOks
            // 
            this.labelOks.AutoSize = true;
            this.labelOks.Location = new System.Drawing.Point(67, 100);
            this.labelOks.Name = "labelOks";
            this.labelOks.Size = new System.Drawing.Size(32, 13);
            this.labelOks.TabIndex = 2;
            this.labelOks.Text = "ОКС:";
            // 
            // labelSpeciality
            // 
            this.labelSpeciality.AutoSize = true;
            this.labelSpeciality.Location = new System.Drawing.Point(23, 63);
            this.labelSpeciality.Name = "labelSpeciality";
            this.labelSpeciality.Size = new System.Drawing.Size(76, 13);
            this.labelSpeciality.TabIndex = 1;
            this.labelSpeciality.Text = "Специалност:";
            // 
            // labelFaculty
            // 
            this.labelFaculty.AutoSize = true;
            this.labelFaculty.Location = new System.Drawing.Point(39, 31);
            this.labelFaculty.Name = "labelFaculty";
            this.labelFaculty.Size = new System.Drawing.Size(60, 13);
            this.labelFaculty.TabIndex = 0;
            this.labelFaculty.Text = "Факултет:";
            this.labelFaculty.Click += new System.EventHandler(this.labelFaculty_Click);
            // 
            // groupPersonalInfo
            // 
            this.groupPersonalInfo.Controls.Add(this.textLastName);
            this.groupPersonalInfo.Controls.Add(this.textMiddleName);
            this.groupPersonalInfo.Controls.Add(this.textFirstName);
            this.groupPersonalInfo.Controls.Add(this.l);
            this.groupPersonalInfo.Controls.Add(this.labelMiddleName);
            this.groupPersonalInfo.Controls.Add(this.labelFirstName);
            this.groupPersonalInfo.Location = new System.Drawing.Point(212, 3);
            this.groupPersonalInfo.Name = "groupPersonalInfo";
            this.groupPersonalInfo.Size = new System.Drawing.Size(418, 159);
            this.groupPersonalInfo.TabIndex = 1;
            this.groupPersonalInfo.TabStop = false;
            this.groupPersonalInfo.Text = "Лични данни";
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(116, 110);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(171, 20);
            this.textLastName.TabIndex = 5;
            // 
            // textMiddleName
            // 
            this.textMiddleName.Location = new System.Drawing.Point(116, 69);
            this.textMiddleName.Name = "textMiddleName";
            this.textMiddleName.Size = new System.Drawing.Size(171, 20);
            this.textMiddleName.TabIndex = 4;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(116, 27);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(171, 20);
            this.textFirstName.TabIndex = 3;
            this.textFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(44, 113);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(56, 13);
            this.l.TabIndex = 2;
            this.l.Text = "Фамилия";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(47, 72);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(53, 13);
            this.labelMiddleName.TabIndex = 1;
            this.labelMiddleName.Text = "Презиме";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(71, 30);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(29, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Име";
            this.labelFirstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupPhoto
            // 
            this.groupPhoto.Controls.Add(this.pictureBox1);
            this.groupPhoto.Location = new System.Drawing.Point(6, 3);
            this.groupPhoto.Name = "groupPhoto";
            this.groupPhoto.Size = new System.Drawing.Size(200, 227);
            this.groupPhoto.TabIndex = 0;
            this.groupPhoto.TabStop = false;
            this.groupPhoto.Text = "Снимка";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(47, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 136);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gradesTab
            // 
            this.gradesTab.Location = new System.Drawing.Point(4, 22);
            this.gradesTab.Name = "gradesTab";
            this.gradesTab.Padding = new System.Windows.Forms.Padding(3);
            this.gradesTab.Size = new System.Drawing.Size(639, 409);
            this.gradesTab.TabIndex = 1;
            this.gradesTab.Text = "Оценки";
            this.gradesTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 462);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.studentTab.ResumeLayout(false);
            this.groupStudentInfo.ResumeLayout(false);
            this.groupStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).EndInit();
            this.groupPersonalInfo.ResumeLayout(false);
            this.groupPersonalInfo.PerformLayout();
            this.groupPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage studentTab;
        private System.Windows.Forms.GroupBox groupPersonalInfo;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textMiddleName;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.GroupBox groupPhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage gradesTab;
        private System.Windows.Forms.GroupBox groupStudentInfo;
        private System.Windows.Forms.Label labelSpeciality;
        private System.Windows.Forms.Label labelFaculty;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxOks;
        private System.Windows.Forms.TextBox textFakNum;
        private System.Windows.Forms.TextBox textSpeciality;
        private System.Windows.Forms.TextBox textFaculty;
        private System.Windows.Forms.Label labelFakNum;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelOks;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelFlow;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.TextBox textGroup;
        private System.Windows.Forms.TextBox textFlow;
        private System.Windows.Forms.NumericUpDown numericUpDownCourse;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDelete;
    }
}