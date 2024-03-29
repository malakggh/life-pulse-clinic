﻿namespace life_pulse_clinic
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.bloodTestButton = new System.Windows.Forms.Button();
            this.patientButton = new System.Windows.Forms.Button();
            this.questionButton = new System.Windows.Forms.Button();
            this.resultsButton = new System.Windows.Forms.Button();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1251, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bloodTestButton
            // 
            this.bloodTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bloodTestButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bloodTestButton.Location = new System.Drawing.Point(12, 367);
            this.bloodTestButton.Name = "bloodTestButton";
            this.bloodTestButton.Size = new System.Drawing.Size(372, 61);
            this.bloodTestButton.TabIndex = 3;
            this.bloodTestButton.Text = "Add Blood Tests";
            this.bloodTestButton.UseVisualStyleBackColor = true;
            this.bloodTestButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // patientButton
            // 
            this.patientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patientButton.Location = new System.Drawing.Point(12, 179);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(372, 61);
            this.patientButton.TabIndex = 4;
            this.patientButton.Text = "Add New Patient";
            this.patientButton.UseVisualStyleBackColor = true;
            this.patientButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // questionButton
            // 
            this.questionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questionButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.questionButton.Location = new System.Drawing.Point(12, 274);
            this.questionButton.Name = "questionButton";
            this.questionButton.Size = new System.Drawing.Size(372, 61);
            this.questionButton.TabIndex = 5;
            this.questionButton.Text = "Get More Info";
            this.questionButton.UseVisualStyleBackColor = true;
            this.questionButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // resultsButton
            // 
            this.resultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultsButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultsButton.Location = new System.Drawing.Point(12, 449);
            this.resultsButton.Name = "resultsButton";
            this.resultsButton.Size = new System.Drawing.Size(372, 61);
            this.resultsButton.TabIndex = 6;
            this.resultsButton.Text = "Show Results";
            this.resultsButton.UseVisualStyleBackColor = true;
            this.resultsButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.doctorLabel.Location = new System.Drawing.Point(12, 97);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(163, 31);
            this.doctorLabel.TabIndex = 7;
            this.doctorLabel.Text = "DoctorName";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(1121, 24);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(142, 31);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "99/99/9999";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1027, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Force Excel to Exit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rage Italic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 44);
            this.label4.TabIndex = 12;
            this.label4.Text = "Life Pulse Clinic";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(533, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 630);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.doctorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultsButton);
            this.Controls.Add(this.questionButton);
            this.Controls.Add(this.patientButton);
            this.Controls.Add(this.bloodTestButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Life Pulse Clinic";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button bloodTestButton;
        private Button patientButton;
        private Button questionButton;
        private Button resultsButton;
        private Label doctorLabel;
        private Label dateLabel;
        private Label label1;
        private Label label4;
        private PictureBox pictureBox1;
    }
}