namespace Covid_19_Vaccination_Management_System.Presentation_Layer
{
    partial class UserManagement
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
            this.loadUserButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.userManagementBackButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateUserIdTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.userInfroUpdateButton = new System.Windows.Forms.Button();
            this.updateUserEmailTextBox = new System.Windows.Forms.TextBox();
            this.updateUserPasswordTextBox = new System.Windows.Forms.TextBox();
            this.updateUserNamTextBox = new System.Windows.Forms.TextBox();
            this.updateUserNTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.userDeleteButton = new System.Windows.Forms.Button();
            this.userDeleteIdTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.updateDateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadUserButton
            // 
            this.loadUserButton.Location = new System.Drawing.Point(852, 278);
            this.loadUserButton.Name = "loadUserButton";
            this.loadUserButton.Size = new System.Drawing.Size(146, 43);
            this.loadUserButton.TabIndex = 3;
            this.loadUserButton.Text = "Load User";
            this.loadUserButton.UseVisualStyleBackColor = true;
            this.loadUserButton.Click += new System.EventHandler(this.loadUserButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 260);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToAddRows = false;
            this.userDataGridView.AllowUserToDeleteRows = false;
            this.userDataGridView.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Location = new System.Drawing.Point(6, 19);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            this.userDataGridView.Size = new System.Drawing.Size(964, 235);
            this.userDataGridView.TabIndex = 0;
            // 
            // userManagementBackButton
            // 
            this.userManagementBackButton.Location = new System.Drawing.Point(919, 606);
            this.userManagementBackButton.Name = "userManagementBackButton";
            this.userManagementBackButton.Size = new System.Drawing.Size(79, 31);
            this.userManagementBackButton.TabIndex = 4;
            this.userManagementBackButton.Text = "Back";
            this.userManagementBackButton.UseVisualStyleBackColor = true;
            this.userManagementBackButton.Click += new System.EventHandler(this.userManagementBackButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.femaleRadioButton);
            this.groupBox2.Controls.Add(this.maleRadioButton);
            this.groupBox2.Controls.Add(this.bloodGroupComboBox);
            this.groupBox2.Controls.Add(this.updateDateOfBirthDateTimePicker);
            this.groupBox2.Controls.Add(this.updateUserIdTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.userInfroUpdateButton);
            this.groupBox2.Controls.Add(this.updateUserEmailTextBox);
            this.groupBox2.Controls.Add(this.updateUserPasswordTextBox);
            this.groupBox2.Controls.Add(this.updateUserNamTextBox);
            this.groupBox2.Controls.Add(this.updateUserNTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(34, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 341);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update User";
            // 
            // updateUserIdTextBox
            // 
            this.updateUserIdTextBox.Location = new System.Drawing.Point(128, 23);
            this.updateUserIdTextBox.Name = "updateUserIdTextBox";
            this.updateUserIdTextBox.Size = new System.Drawing.Size(201, 20);
            this.updateUserIdTextBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Id";
            // 
            // userInfroUpdateButton
            // 
            this.userInfroUpdateButton.Location = new System.Drawing.Point(143, 297);
            this.userInfroUpdateButton.Name = "userInfroUpdateButton";
            this.userInfroUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.userInfroUpdateButton.TabIndex = 14;
            this.userInfroUpdateButton.Text = "Update";
            this.userInfroUpdateButton.UseVisualStyleBackColor = true;
            this.userInfroUpdateButton.Click += new System.EventHandler(this.userInfroUpdateButton_Click);
            // 
            // updateUserEmailTextBox
            // 
            this.updateUserEmailTextBox.Location = new System.Drawing.Point(128, 153);
            this.updateUserEmailTextBox.Name = "updateUserEmailTextBox";
            this.updateUserEmailTextBox.Size = new System.Drawing.Size(201, 20);
            this.updateUserEmailTextBox.TabIndex = 10;
            // 
            // updateUserPasswordTextBox
            // 
            this.updateUserPasswordTextBox.Location = new System.Drawing.Point(128, 122);
            this.updateUserPasswordTextBox.Name = "updateUserPasswordTextBox";
            this.updateUserPasswordTextBox.Size = new System.Drawing.Size(201, 20);
            this.updateUserPasswordTextBox.TabIndex = 9;
            // 
            // updateUserNamTextBox
            // 
            this.updateUserNamTextBox.Location = new System.Drawing.Point(128, 88);
            this.updateUserNamTextBox.Name = "updateUserNamTextBox";
            this.updateUserNamTextBox.Size = new System.Drawing.Size(201, 20);
            this.updateUserNamTextBox.TabIndex = 8;
            // 
            // updateUserNTextBox
            // 
            this.updateUserNTextBox.Location = new System.Drawing.Point(128, 54);
            this.updateUserNTextBox.Name = "updateUserNTextBox";
            this.updateUserNTextBox.Size = new System.Drawing.Size(201, 20);
            this.updateUserNTextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "BloodGroup";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date Of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Emal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox.Controls.Add(this.userDeleteButton);
            this.groupBox.Controls.Add(this.userDeleteIdTextBox);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Location = new System.Drawing.Point(397, 515);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(245, 122);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Delete User";
            // 
            // userDeleteButton
            // 
            this.userDeleteButton.Location = new System.Drawing.Point(86, 78);
            this.userDeleteButton.Name = "userDeleteButton";
            this.userDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.userDeleteButton.TabIndex = 19;
            this.userDeleteButton.Text = "Delete";
            this.userDeleteButton.UseVisualStyleBackColor = true;
            this.userDeleteButton.Click += new System.EventHandler(this.userDeleteButton_Click);
            // 
            // userDeleteIdTextBox
            // 
            this.userDeleteIdTextBox.Location = new System.Drawing.Point(63, 42);
            this.userDeleteIdTextBox.Name = "userDeleteIdTextBox";
            this.userDeleteIdTextBox.Size = new System.Drawing.Size(149, 20);
            this.userDeleteIdTextBox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Id";
            // 
            // updateDateOfBirthDateTimePicker
            // 
            this.updateDateOfBirthDateTimePicker.Location = new System.Drawing.Point(128, 186);
            this.updateDateOfBirthDateTimePicker.MaxDate = new System.DateTime(2021, 8, 21, 21, 23, 7, 0);
            this.updateDateOfBirthDateTimePicker.Name = "updateDateOfBirthDateTimePicker";
            this.updateDateOfBirthDateTimePicker.Size = new System.Drawing.Size(201, 20);
            this.updateDateOfBirthDateTimePicker.TabIndex = 12;
            this.updateDateOfBirthDateTimePicker.Value = new System.DateTime(2021, 7, 11, 0, 0, 0, 0);
            // 
            // bloodGroupComboBox
            // 
            this.bloodGroupComboBox.FormattingEnabled = true;
            this.bloodGroupComboBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.bloodGroupComboBox.Location = new System.Drawing.Point(128, 252);
            this.bloodGroupComboBox.Name = "bloodGroupComboBox";
            this.bloodGroupComboBox.Size = new System.Drawing.Size(201, 21);
            this.bloodGroupComboBox.TabIndex = 17;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(270, 222);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.femaleRadioButton.TabIndex = 19;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(130, 222);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.maleRadioButton.TabIndex = 18;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1024, 666);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.userManagementBackButton);
            this.Controls.Add(this.loadUserButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserManagement_FormClosing);
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadUserButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.Button userManagementBackButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button userInfroUpdateButton;
        private System.Windows.Forms.TextBox updateUserEmailTextBox;
        private System.Windows.Forms.TextBox updateUserPasswordTextBox;
        private System.Windows.Forms.TextBox updateUserNamTextBox;
        private System.Windows.Forms.TextBox updateUserNTextBox;
        private System.Windows.Forms.TextBox updateUserIdTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button userDeleteButton;
        private System.Windows.Forms.TextBox userDeleteIdTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox bloodGroupComboBox;
        private System.Windows.Forms.DateTimePicker updateDateOfBirthDateTimePicker;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
    }
}