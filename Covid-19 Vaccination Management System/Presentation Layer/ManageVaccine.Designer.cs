namespace Covid_19_Vaccination_Management_System.Presentation_Layer
{
    partial class ManageVaccine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageVaccine));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vaccineDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addVaccineQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addVaccineButton = new System.Windows.Forms.Button();
            this.addVaccineCountryNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addVaccineNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.updateVaccineQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.updateVaccineButton = new System.Windows.Forms.Button();
            this.updateCountryNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updateVaccineNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.updateVaccineIdTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.deleteVaccineIdTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.searchVaccineTextBox = new System.Windows.Forms.TextBox();
            this.searchVaccineDataGridView = new System.Windows.Forms.DataGridView();
            this.VaccineManagementBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vaccineDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addVaccineQuantityNumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateVaccineQuantityNumericUpDown)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchVaccineDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(377, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.vaccineDataGridView);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(630, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 270);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vaccine Inventory";
            // 
            // vaccineDataGridView
            // 
            this.vaccineDataGridView.AllowUserToAddRows = false;
            this.vaccineDataGridView.AllowUserToDeleteRows = false;
            this.vaccineDataGridView.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.vaccineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vaccineDataGridView.Location = new System.Drawing.Point(6, 17);
            this.vaccineDataGridView.Name = "vaccineDataGridView";
            this.vaccineDataGridView.ReadOnly = true;
            this.vaccineDataGridView.Size = new System.Drawing.Size(450, 183);
            this.vaccineDataGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load Vaccine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.addVaccineQuantityNumericUpDown);
            this.groupBox2.Controls.Add(this.addVaccineButton);
            this.groupBox2.Controls.Add(this.addVaccineCountryNameTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.addVaccineNameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 189);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Vaccine";
            // 
            // addVaccineQuantityNumericUpDown
            // 
            this.addVaccineQuantityNumericUpDown.Location = new System.Drawing.Point(141, 68);
            this.addVaccineQuantityNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.addVaccineQuantityNumericUpDown.Name = "addVaccineQuantityNumericUpDown";
            this.addVaccineQuantityNumericUpDown.Size = new System.Drawing.Size(134, 20);
            this.addVaccineQuantityNumericUpDown.TabIndex = 9;
            // 
            // addVaccineButton
            // 
            this.addVaccineButton.Location = new System.Drawing.Point(106, 138);
            this.addVaccineButton.Name = "addVaccineButton";
            this.addVaccineButton.Size = new System.Drawing.Size(97, 32);
            this.addVaccineButton.TabIndex = 8;
            this.addVaccineButton.Text = "Add Vaccine";
            this.addVaccineButton.UseVisualStyleBackColor = true;
            this.addVaccineButton.Click += new System.EventHandler(this.addVaccineButton_Click_1);
            // 
            // addVaccineCountryNameTextBox
            // 
            this.addVaccineCountryNameTextBox.Location = new System.Drawing.Point(141, 103);
            this.addVaccineCountryNameTextBox.Name = "addVaccineCountryNameTextBox";
            this.addVaccineCountryNameTextBox.Size = new System.Drawing.Size(135, 20);
            this.addVaccineCountryNameTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Country Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vaccine Name";
            // 
            // addVaccineNameTextBox
            // 
            this.addVaccineNameTextBox.Location = new System.Drawing.Point(140, 30);
            this.addVaccineNameTextBox.Name = "addVaccineNameTextBox";
            this.addVaccineNameTextBox.Size = new System.Drawing.Size(135, 20);
            this.addVaccineNameTextBox.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.updateVaccineQuantityNumericUpDown);
            this.groupBox3.Controls.Add(this.updateVaccineButton);
            this.groupBox3.Controls.Add(this.updateCountryNameTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.updateVaccineNameTextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.updateVaccineIdTextBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 223);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Vaccine";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // updateVaccineQuantityNumericUpDown
            // 
            this.updateVaccineQuantityNumericUpDown.Location = new System.Drawing.Point(140, 112);
            this.updateVaccineQuantityNumericUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.updateVaccineQuantityNumericUpDown.Name = "updateVaccineQuantityNumericUpDown";
            this.updateVaccineQuantityNumericUpDown.Size = new System.Drawing.Size(136, 20);
            this.updateVaccineQuantityNumericUpDown.TabIndex = 10;
            // 
            // updateVaccineButton
            // 
            this.updateVaccineButton.Location = new System.Drawing.Point(106, 182);
            this.updateVaccineButton.Name = "updateVaccineButton";
            this.updateVaccineButton.Size = new System.Drawing.Size(97, 32);
            this.updateVaccineButton.TabIndex = 8;
            this.updateVaccineButton.Text = "Update Vaccine";
            this.updateVaccineButton.UseVisualStyleBackColor = true;
            this.updateVaccineButton.Click += new System.EventHandler(this.updateVaccineButton_Click);
            // 
            // updateCountryNameTextBox
            // 
            this.updateCountryNameTextBox.Location = new System.Drawing.Point(141, 147);
            this.updateCountryNameTextBox.Name = "updateCountryNameTextBox";
            this.updateCountryNameTextBox.Size = new System.Drawing.Size(135, 20);
            this.updateCountryNameTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Country Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Quantity";
            // 
            // updateVaccineNameTextBox
            // 
            this.updateVaccineNameTextBox.Location = new System.Drawing.Point(140, 74);
            this.updateVaccineNameTextBox.Name = "updateVaccineNameTextBox";
            this.updateVaccineNameTextBox.Size = new System.Drawing.Size(135, 20);
            this.updateVaccineNameTextBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Vaccine Name";
            // 
            // updateVaccineIdTextBox
            // 
            this.updateVaccineIdTextBox.Location = new System.Drawing.Point(141, 36);
            this.updateVaccineIdTextBox.Name = "updateVaccineIdTextBox";
            this.updateVaccineIdTextBox.Size = new System.Drawing.Size(135, 20);
            this.updateVaccineIdTextBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Vaccine ID ";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.deleteVaccineIdTextBox);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(12, 508);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 127);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete Vaccine";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(110, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 32);
            this.button4.TabIndex = 8;
            this.button4.Text = "Delete Vaccine";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // deleteVaccineIdTextBox
            // 
            this.deleteVaccineIdTextBox.Location = new System.Drawing.Point(141, 35);
            this.deleteVaccineIdTextBox.Name = "deleteVaccineIdTextBox";
            this.deleteVaccineIdTextBox.Size = new System.Drawing.Size(135, 20);
            this.deleteVaccineIdTextBox.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Vaccine ID ";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.searchVaccineTextBox);
            this.groupBox5.Controls.Add(this.searchVaccineDataGridView);
            this.groupBox5.Location = new System.Drawing.Point(630, 322);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(462, 339);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search Vaccine By Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Vaccine Name";
            // 
            // searchVaccineTextBox
            // 
            this.searchVaccineTextBox.Location = new System.Drawing.Point(207, 52);
            this.searchVaccineTextBox.Name = "searchVaccineTextBox";
            this.searchVaccineTextBox.Size = new System.Drawing.Size(135, 20);
            this.searchVaccineTextBox.TabIndex = 8;
            this.searchVaccineTextBox.TextChanged += new System.EventHandler(this.searchVaccineTextBox_TextChanged);
            // 
            // searchVaccineDataGridView
            // 
            this.searchVaccineDataGridView.AllowUserToAddRows = false;
            this.searchVaccineDataGridView.AllowUserToDeleteRows = false;
            this.searchVaccineDataGridView.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.searchVaccineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchVaccineDataGridView.Location = new System.Drawing.Point(6, 116);
            this.searchVaccineDataGridView.Name = "searchVaccineDataGridView";
            this.searchVaccineDataGridView.ReadOnly = true;
            this.searchVaccineDataGridView.Size = new System.Drawing.Size(446, 193);
            this.searchVaccineDataGridView.TabIndex = 0;
            // 
            // VaccineManagementBackButton
            // 
            this.VaccineManagementBackButton.Location = new System.Drawing.Point(986, 675);
            this.VaccineManagementBackButton.Name = "VaccineManagementBackButton";
            this.VaccineManagementBackButton.Size = new System.Drawing.Size(106, 38);
            this.VaccineManagementBackButton.TabIndex = 7;
            this.VaccineManagementBackButton.Text = "Back ";
            this.VaccineManagementBackButton.UseVisualStyleBackColor = true;
            this.VaccineManagementBackButton.Click += new System.EventHandler(this.VaccineManagementBackButton_Click);
            // 
            // ManageVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1120, 725);
            this.Controls.Add(this.VaccineManagementBackButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManageVaccine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vaccine Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageVaccine_FormClosing);
            this.Load += new System.EventHandler(this.ManageVaccine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vaccineDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addVaccineQuantityNumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateVaccineQuantityNumericUpDown)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchVaccineDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView vaccineDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox addVaccineCountryNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addVaccineNameTextBox;
        private System.Windows.Forms.NumericUpDown addVaccineQuantityNumericUpDown;
        private System.Windows.Forms.Button addVaccineButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown updateVaccineQuantityNumericUpDown;
        private System.Windows.Forms.Button updateVaccineButton;
        private System.Windows.Forms.TextBox updateCountryNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox updateVaccineNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox updateVaccineIdTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox deleteVaccineIdTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox searchVaccineTextBox;
        private System.Windows.Forms.DataGridView searchVaccineDataGridView;
        private System.Windows.Forms.Button VaccineManagementBackButton;
    }
}