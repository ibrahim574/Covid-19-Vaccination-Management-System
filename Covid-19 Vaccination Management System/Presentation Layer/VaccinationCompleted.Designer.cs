namespace Covid_19_Vaccination_Management_System.Presentation_Layer
{
    partial class VaccinationCompleted
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
            this.vaccineCompletedUserDataGridView = new System.Windows.Forms.DataGridView();
            this.vaccinationCompletedbackButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vaccineCompletedUserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vaccineCompletedUserDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1036, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vaccination Completed";
            // 
            // vaccineCompletedUserDataGridView
            // 
            this.vaccineCompletedUserDataGridView.AllowUserToAddRows = false;
            this.vaccineCompletedUserDataGridView.AllowUserToDeleteRows = false;
            this.vaccineCompletedUserDataGridView.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.vaccineCompletedUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vaccineCompletedUserDataGridView.Location = new System.Drawing.Point(6, 19);
            this.vaccineCompletedUserDataGridView.Name = "vaccineCompletedUserDataGridView";
            this.vaccineCompletedUserDataGridView.ReadOnly = true;
            this.vaccineCompletedUserDataGridView.Size = new System.Drawing.Size(1024, 303);
            this.vaccineCompletedUserDataGridView.TabIndex = 0;
            // 
            // vaccinationCompletedbackButton
            // 
            this.vaccinationCompletedbackButton.Location = new System.Drawing.Point(952, 532);
            this.vaccinationCompletedbackButton.Name = "vaccinationCompletedbackButton";
            this.vaccinationCompletedbackButton.Size = new System.Drawing.Size(90, 37);
            this.vaccinationCompletedbackButton.TabIndex = 1;
            this.vaccinationCompletedbackButton.Text = "Back";
            this.vaccinationCompletedbackButton.UseVisualStyleBackColor = true;
            this.vaccinationCompletedbackButton.Click += new System.EventHandler(this.vaccinationCompletedbackButton_Click);
            // 
            // VaccinationCompleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1060, 581);
            this.Controls.Add(this.vaccinationCompletedbackButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "VaccinationCompleted";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VaccinationCompleted";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VaccinationCompleted_FormClosing);
            this.Load += new System.EventHandler(this.VaccinationCompleted_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vaccineCompletedUserDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView vaccineCompletedUserDataGridView;
        private System.Windows.Forms.Button vaccinationCompletedbackButton;
    }
}