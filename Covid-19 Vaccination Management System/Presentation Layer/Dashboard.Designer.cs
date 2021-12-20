namespace Covid_19_Vaccination_Management_System.Presentation_Layer
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registeredUserButton = new System.Windows.Forms.Button();
            this.vaccineManagementButton = new System.Windows.Forms.Button();
            this.userManagementButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboardLogoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 110);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // registeredUserButton
            // 
            this.registeredUserButton.Location = new System.Drawing.Point(78, 274);
            this.registeredUserButton.Name = "registeredUserButton";
            this.registeredUserButton.Size = new System.Drawing.Size(136, 61);
            this.registeredUserButton.TabIndex = 1;
            this.registeredUserButton.Text = "Registered User";
            this.registeredUserButton.UseVisualStyleBackColor = true;
            this.registeredUserButton.Click += new System.EventHandler(this.registeredUserButton_Click);
            // 
            // vaccineManagementButton
            // 
            this.vaccineManagementButton.Location = new System.Drawing.Point(363, 274);
            this.vaccineManagementButton.Name = "vaccineManagementButton";
            this.vaccineManagementButton.Size = new System.Drawing.Size(136, 61);
            this.vaccineManagementButton.TabIndex = 2;
            this.vaccineManagementButton.Text = "Vaccine Management";
            this.vaccineManagementButton.UseVisualStyleBackColor = true;
            this.vaccineManagementButton.Click += new System.EventHandler(this.vaccineManagementButton_Click);
            // 
            // userManagementButton
            // 
            this.userManagementButton.Location = new System.Drawing.Point(657, 274);
            this.userManagementButton.Name = "userManagementButton";
            this.userManagementButton.Size = new System.Drawing.Size(136, 61);
            this.userManagementButton.TabIndex = 3;
            this.userManagementButton.Text = "User Management";
            this.userManagementButton.UseVisualStyleBackColor = true;
            this.userManagementButton.Click += new System.EventHandler(this.userManagementButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(78, 425);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 61);
            this.button4.TabIndex = 4;
            this.button4.Text = "Statistics";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dashboard";
            // 
            // dashboardLogoutButton
            // 
            this.dashboardLogoutButton.Location = new System.Drawing.Point(774, 525);
            this.dashboardLogoutButton.Name = "dashboardLogoutButton";
            this.dashboardLogoutButton.Size = new System.Drawing.Size(80, 30);
            this.dashboardLogoutButton.TabIndex = 6;
            this.dashboardLogoutButton.Text = "Logout";
            this.dashboardLogoutButton.UseVisualStyleBackColor = true;
            this.dashboardLogoutButton.Click += new System.EventHandler(this.dashboardLogoutButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(866, 567);
            this.Controls.Add(this.dashboardLogoutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.userManagementButton);
            this.Controls.Add(this.vaccineManagementButton);
            this.Controls.Add(this.registeredUserButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashbord";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashbord_FormClosing);
            this.Load += new System.EventHandler(this.Dashbord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button registeredUserButton;
        private System.Windows.Forms.Button vaccineManagementButton;
        private System.Windows.Forms.Button userManagementButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dashboardLogoutButton;
    }
}