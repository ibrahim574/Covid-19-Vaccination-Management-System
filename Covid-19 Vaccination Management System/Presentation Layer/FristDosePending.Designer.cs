namespace Covid_19_Vaccination_Management_System.Presentation_Layer
{
    partial class FristDosePending
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
            this.secondDoseCompletedUserDataGridView = new System.Windows.Forms.DataGridView();
            this.secondDoseCompletedBackButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondDoseCompletedUserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.secondDoseCompletedUserDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1132, 344);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frist Dose Pending";
            // 
            // secondDoseCompletedUserDataGridView
            // 
            this.secondDoseCompletedUserDataGridView.AllowUserToAddRows = false;
            this.secondDoseCompletedUserDataGridView.AllowUserToDeleteRows = false;
            this.secondDoseCompletedUserDataGridView.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.secondDoseCompletedUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secondDoseCompletedUserDataGridView.Location = new System.Drawing.Point(6, 19);
            this.secondDoseCompletedUserDataGridView.Name = "secondDoseCompletedUserDataGridView";
            this.secondDoseCompletedUserDataGridView.ReadOnly = true;
            this.secondDoseCompletedUserDataGridView.Size = new System.Drawing.Size(1120, 319);
            this.secondDoseCompletedUserDataGridView.TabIndex = 0;
            // 
            // secondDoseCompletedBackButton
            // 
            this.secondDoseCompletedBackButton.Location = new System.Drawing.Point(1048, 523);
            this.secondDoseCompletedBackButton.Name = "secondDoseCompletedBackButton";
            this.secondDoseCompletedBackButton.Size = new System.Drawing.Size(90, 37);
            this.secondDoseCompletedBackButton.TabIndex = 3;
            this.secondDoseCompletedBackButton.Text = "Back";
            this.secondDoseCompletedBackButton.UseVisualStyleBackColor = true;
            this.secondDoseCompletedBackButton.Click += new System.EventHandler(this.fristDoseCompletedBackButton_Click);
            // 
            // FristDosePending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1156, 572);
            this.Controls.Add(this.secondDoseCompletedBackButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "FristDosePending";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstDosePending";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SecondDoseCompleted_FormClosing);
            this.Load += new System.EventHandler(this.SecondDoseCompleted_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.secondDoseCompletedUserDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView secondDoseCompletedUserDataGridView;
        private System.Windows.Forms.Button secondDoseCompletedBackButton;
    }
}