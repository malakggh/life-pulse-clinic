namespace life_pulse_clinic
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
            this.button3 = new System.Windows.Forms.Button();
            this.bloodTestButton = new System.Windows.Forms.Button();
            this.patientButton = new System.Windows.Forms.Button();
            this.questionButton = new System.Windows.Forms.Button();
            this.resultsButton = new System.Windows.Forms.Button();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(204, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(12, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 68);
            this.button3.TabIndex = 2;
            this.button3.Text = "Force Excel Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bloodTestButton
            // 
            this.bloodTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bloodTestButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bloodTestButton.Location = new System.Drawing.Point(12, 250);
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
            this.patientButton.Location = new System.Drawing.Point(12, 80);
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
            this.questionButton.Location = new System.Drawing.Point(12, 162);
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
            this.resultsButton.Location = new System.Drawing.Point(12, 341);
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
            this.doctorLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.doctorLabel.Location = new System.Drawing.Point(12, 9);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(125, 24);
            this.doctorLabel.TabIndex = 7;
            this.doctorLabel.Text = "DoctorName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 533);
            this.Controls.Add(this.doctorLabel);
            this.Controls.Add(this.resultsButton);
            this.Controls.Add(this.questionButton);
            this.Controls.Add(this.patientButton);
            this.Controls.Add(this.bloodTestButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Life Pulse Clinic";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button3;
        private Button bloodTestButton;
        private Button patientButton;
        private Button questionButton;
        private Button resultsButton;
        private Label doctorLabel;
    }
}