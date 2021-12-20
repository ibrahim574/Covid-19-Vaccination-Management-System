namespace Covid_19_Vaccination_Management_System.Presentation_Layer
{
    partial class FirstDoseCompleted
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
            this.firstDoseCompletedUserdataGridView = new System.Windows.Forms.DataGridView();
            this.fristDoseCompletedBackButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstDoseCompletedUserdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.firstDoseCompletedUserdataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1122, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "First Dose Completed";
            // 
            // firstDoseCompletedUserdataGridView
            // 
            this.firstDoseCompletedUserdataGridView.AllowUserToAddRows = false;
            this.firstDoseCompletedUserdataGridView.AllowUserToDeleteRows = false;
            this.firstDoseCompletedUserdataGridView.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.firstDoseCompletedUserdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firstDoseCompletedUserdataGridView.Location = new System.Drawing.Point(6, 19);
            this.firstDoseCompletedUserdataGridView.Name = "firstDoseCompletedUserdataGridView";
            this.firstDoseCompletedUserdataGridView.ReadOnly = true;
            this.firstDoseCompletedUserdataGridView.Size = new System.Drawing.Size(1110, 281);
            this.firstDoseCompletedUserdataGridView.TabIndex = 0;
            // 
            // fristDoseCompletedBackButton
            // 
            this.fristDoseCompletedBackButton.Location = new System.Drawing.Point(1044, 550);
            this.fristDoseCompletedBackButton.Name = "fristDoseCompletedBackButton";
            this.fristDoseCompletedBackButton.Size = new System.Drawing.Size(90, 37);
            this.fristDoseCompletedBackButton.TabIndex = 2;
            this.fristDoseCompletedBackButton.Text = "Back";
            this.fristDoseCompletedBackButton.UseVisualStyleBackColor = true;
            this.fristDoseCompletedBackButton.Click += new System.EventHandler(this.fristDoseCompletedBackButton_Click);
            // 
            // FirstDoseCompleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1146, 599);
            this.Controls.Add(this.fristDoseCompletedBackButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "FirstDoseCompleted";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstDoseCompleted";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirstDoseCompleted_FormClosing);
            this.Load += new System.EventHandler(this.FirstDoseCompleted_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.firstDoseCompletedUserdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView firstDoseCompletedUserdataGridView;
        private System.Windows.Forms.Button fristDoseCompletedBackButton;
    }
}