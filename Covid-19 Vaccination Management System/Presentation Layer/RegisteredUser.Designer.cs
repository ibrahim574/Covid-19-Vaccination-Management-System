namespace Covid_19_Vaccination_Management_System.Presentation_Layer
{
    partial class RegisteredUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.registeredUserDataGridView = new System.Windows.Forms.DataGridView();
            this.loadRegisteredUserButton = new System.Windows.Forms.Button();
            this.registeredUserBackButton = new System.Windows.Forms.Button();
            this.loadFirstDoseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loadCompletedVaccinationButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchByVaccineTextBox = new System.Windows.Forms.TextBox();
            this.searchByVaccineDataGridView = new System.Windows.Forms.DataGridView();
            this.vaccineLoadButton = new System.Windows.Forms.Button();
            this.vaccineLoadDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loadFirstSecondDoseButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registeredUserDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchByVaccineDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccineLoadDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.registeredUserDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(332, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1124, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registered User Information";
            // 
            // registeredUserDataGridView
            // 
            this.registeredUserDataGridView.AllowUserToAddRows = false;
            this.registeredUserDataGridView.AllowUserToDeleteRows = false;
            this.registeredUserDataGridView.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.registeredUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registeredUserDataGridView.Location = new System.Drawing.Point(6, 19);
            this.registeredUserDataGridView.Name = "registeredUserDataGridView";
            this.registeredUserDataGridView.ReadOnly = true;
            this.registeredUserDataGridView.Size = new System.Drawing.Size(1112, 235);
            this.registeredUserDataGridView.TabIndex = 0;
            // 
            // loadRegisteredUserButton
            // 
            this.loadRegisteredUserButton.Location = new System.Drawing.Point(810, 288);
            this.loadRegisteredUserButton.Name = "loadRegisteredUserButton";
            this.loadRegisteredUserButton.Size = new System.Drawing.Size(146, 43);
            this.loadRegisteredUserButton.TabIndex = 1;
            this.loadRegisteredUserButton.Text = "Load Registered User";
            this.loadRegisteredUserButton.UseVisualStyleBackColor = true;
            this.loadRegisteredUserButton.Click += new System.EventHandler(this.loadRegisteredUserButton_Click);
            // 
            // registeredUserBackButton
            // 
            this.registeredUserBackButton.Location = new System.Drawing.Point(1441, 726);
            this.registeredUserBackButton.Name = "registeredUserBackButton";
            this.registeredUserBackButton.Size = new System.Drawing.Size(107, 36);
            this.registeredUserBackButton.TabIndex = 2;
            this.registeredUserBackButton.Text = "Back";
            this.registeredUserBackButton.UseVisualStyleBackColor = true;
            this.registeredUserBackButton.Click += new System.EventHandler(this.registeredUserBackButton_Click);
            // 
            // loadFirstDoseButton
            // 
            this.loadFirstDoseButton.Location = new System.Drawing.Point(67, 58);
            this.loadFirstDoseButton.Name = "loadFirstDoseButton";
            this.loadFirstDoseButton.Size = new System.Drawing.Size(100, 22);
            this.loadFirstDoseButton.TabIndex = 3;
            this.loadFirstDoseButton.Text = "Load";
            this.loadFirstDoseButton.UseVisualStyleBackColor = true;
            this.loadFirstDoseButton.Click += new System.EventHandler(this.loadFirstDoseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Load Information of users who got first dose";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.loadFirstDoseButton);
            this.groupBox2.Location = new System.Drawing.Point(24, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 93);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frist Dose";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.loadCompletedVaccinationButton);
            this.groupBox4.Location = new System.Drawing.Point(24, 269);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 99);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vaccinated User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Load Information of users who got vaccinated";
            // 
            // loadCompletedVaccinationButton
            // 
            this.loadCompletedVaccinationButton.Location = new System.Drawing.Point(70, 58);
            this.loadCompletedVaccinationButton.Name = "loadCompletedVaccinationButton";
            this.loadCompletedVaccinationButton.Size = new System.Drawing.Size(97, 21);
            this.loadCompletedVaccinationButton.TabIndex = 3;
            this.loadCompletedVaccinationButton.Text = "Load";
            this.loadCompletedVaccinationButton.UseVisualStyleBackColor = true;
            this.loadCompletedVaccinationButton.Click += new System.EventHandler(this.loadCompletedVaccinationButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.searchByVaccineTextBox);
            this.groupBox5.Controls.Add(this.searchByVaccineDataGridView);
            this.groupBox5.Controls.Add(this.vaccineLoadButton);
            this.groupBox5.Controls.Add(this.vaccineLoadDataGridView);
            this.groupBox5.Location = new System.Drawing.Point(24, 402);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1405, 312);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search User By Designated Vaccine Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Search User by Vaccine Name";
            // 
            // searchByVaccineTextBox
            // 
            this.searchByVaccineTextBox.Location = new System.Drawing.Point(686, 239);
            this.searchByVaccineTextBox.Name = "searchByVaccineTextBox";
            this.searchByVaccineTextBox.Size = new System.Drawing.Size(154, 20);
            this.searchByVaccineTextBox.TabIndex = 3;
            this.searchByVaccineTextBox.TextChanged += new System.EventHandler(this.searchByVaccineTextBox_TextChanged);
            // 
            // searchByVaccineDataGridView
            // 
            this.searchByVaccineDataGridView.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.searchByVaccineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchByVaccineDataGridView.Location = new System.Drawing.Point(198, 34);
            this.searchByVaccineDataGridView.Name = "searchByVaccineDataGridView";
            this.searchByVaccineDataGridView.Size = new System.Drawing.Size(1201, 183);
            this.searchByVaccineDataGridView.TabIndex = 2;
            // 
            // vaccineLoadButton
            // 
            this.vaccineLoadButton.Location = new System.Drawing.Point(40, 274);
            this.vaccineLoadButton.Name = "vaccineLoadButton";
            this.vaccineLoadButton.Size = new System.Drawing.Size(91, 23);
            this.vaccineLoadButton.TabIndex = 1;
            this.vaccineLoadButton.Text = "Load Vaccine";
            this.vaccineLoadButton.UseVisualStyleBackColor = true;
            this.vaccineLoadButton.Click += new System.EventHandler(this.vaccineLoadButton_Click);
            // 
            // vaccineLoadDataGridView
            // 
            this.vaccineLoadDataGridView.AllowUserToAddRows = false;
            this.vaccineLoadDataGridView.AllowUserToDeleteRows = false;
            this.vaccineLoadDataGridView.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.vaccineLoadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vaccineLoadDataGridView.Location = new System.Drawing.Point(6, 34);
            this.vaccineLoadDataGridView.Name = "vaccineLoadDataGridView";
            this.vaccineLoadDataGridView.ReadOnly = true;
            this.vaccineLoadDataGridView.Size = new System.Drawing.Size(160, 225);
            this.vaccineLoadDataGridView.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.loadFirstSecondDoseButton);
            this.groupBox3.Location = new System.Drawing.Point(24, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 92);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "First Dose Pending";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Load Information of users who didn\'t got any dose";
            // 
            // loadFirstSecondDoseButton
            // 
            this.loadFirstSecondDoseButton.Location = new System.Drawing.Point(79, 58);
            this.loadFirstSecondDoseButton.Name = "loadFirstSecondDoseButton";
            this.loadFirstSecondDoseButton.Size = new System.Drawing.Size(77, 23);
            this.loadFirstSecondDoseButton.TabIndex = 3;
            this.loadFirstSecondDoseButton.Text = "Load";
            this.loadFirstSecondDoseButton.UseVisualStyleBackColor = true;
            this.loadFirstSecondDoseButton.Click += new System.EventHandler(this.loadFirstSecondDoseButton_Click_1);
            // 
            // RegisteredUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1560, 774);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.registeredUserBackButton);
            this.Controls.Add(this.loadRegisteredUserButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegisteredUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisteredUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisteredUser_FormClosing);
            this.Load += new System.EventHandler(this.RegisteredUser_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.registeredUserDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchByVaccineDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccineLoadDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView registeredUserDataGridView;
        private System.Windows.Forms.Button loadRegisteredUserButton;
        private System.Windows.Forms.Button registeredUserBackButton;
        private System.Windows.Forms.Button loadFirstDoseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loadCompletedVaccinationButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchByVaccineTextBox;
        private System.Windows.Forms.DataGridView searchByVaccineDataGridView;
        private System.Windows.Forms.Button vaccineLoadButton;
        private System.Windows.Forms.DataGridView vaccineLoadDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loadFirstSecondDoseButton;
    }
}