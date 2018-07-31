namespace ParkingKiosk2
{
    partial class Form1
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
            this.ChooseParkingType = new System.Windows.Forms.Label();
            this.Notice = new System.Windows.Forms.Label();
            this.HoursPrompt = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.Charge = new System.Windows.Forms.Label();
            this.InputHours = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentRadioBtn = new System.Windows.Forms.RadioButton();
            this.staffRadiobtn = new System.Windows.Forms.RadioButton();
            this.generalRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChooseParkingType
            // 
            this.ChooseParkingType.AutoSize = true;
            this.ChooseParkingType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseParkingType.Location = new System.Drawing.Point(52, 65);
            this.ChooseParkingType.Name = "ChooseParkingType";
            this.ChooseParkingType.Size = new System.Drawing.Size(192, 24);
            this.ChooseParkingType.TabIndex = 0;
            this.ChooseParkingType.Text = "Choose Parking Type";
            // 
            // Notice
            // 
            this.Notice.AutoSize = true;
            this.Notice.Location = new System.Drawing.Point(53, 13);
            this.Notice.Name = "Notice";
            this.Notice.Size = new System.Drawing.Size(87, 13);
            this.Notice.TabIndex = 3;
            this.Notice.Text = "Parking Availabe\r\n";
            // 
            // HoursPrompt
            // 
            this.HoursPrompt.AutoSize = true;
            this.HoursPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursPrompt.Location = new System.Drawing.Point(52, 203);
            this.HoursPrompt.Name = "HoursPrompt";
            this.HoursPrompt.Size = new System.Drawing.Size(262, 24);
            this.HoursPrompt.TabIndex = 4;
            this.HoursPrompt.Text = "Enter number of hours parked";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(99, 247);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(136, 35);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "Calculate Charge";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Charge
            // 
            this.Charge.AutoSize = true;
            this.Charge.Location = new System.Drawing.Point(317, 247);
            this.Charge.Name = "Charge";
            this.Charge.Size = new System.Drawing.Size(0, 13);
            this.Charge.TabIndex = 7;
            // 
            // InputHours
            // 
            this.InputHours.Location = new System.Drawing.Point(320, 207);
            this.InputHours.Name = "InputHours";
            this.InputHours.Size = new System.Drawing.Size(100, 20);
            this.InputHours.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studentRadioBtn);
            this.groupBox1.Controls.Add(this.staffRadiobtn);
            this.groupBox1.Controls.Add(this.generalRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(266, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 120);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parking Type";
            // 
            // studentRadioBtn
            // 
            this.studentRadioBtn.AutoSize = true;
            this.studentRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRadioBtn.Location = new System.Drawing.Point(6, 88);
            this.studentRadioBtn.Name = "studentRadioBtn";
            this.studentRadioBtn.Size = new System.Drawing.Size(84, 24);
            this.studentRadioBtn.TabIndex = 2;
            this.studentRadioBtn.TabStop = true;
            this.studentRadioBtn.Text = "Student";
            this.studentRadioBtn.UseVisualStyleBackColor = true;
            // 
            // staffRadiobtn
            // 
            this.staffRadiobtn.AutoSize = true;
            this.staffRadiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffRadiobtn.Location = new System.Drawing.Point(6, 58);
            this.staffRadiobtn.Name = "staffRadiobtn";
            this.staffRadiobtn.Size = new System.Drawing.Size(62, 24);
            this.staffRadiobtn.TabIndex = 1;
            this.staffRadiobtn.TabStop = true;
            this.staffRadiobtn.Text = "Staff";
            this.staffRadiobtn.UseVisualStyleBackColor = true;
            // 
            // generalRadioBtn
            // 
            this.generalRadioBtn.AutoSize = true;
            this.generalRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalRadioBtn.Location = new System.Drawing.Point(6, 28);
            this.generalRadioBtn.Name = "generalRadioBtn";
            this.generalRadioBtn.Size = new System.Drawing.Size(130, 24);
            this.generalRadioBtn.TabIndex = 0;
            this.generalRadioBtn.TabStop = true;
            this.generalRadioBtn.Text = "General Public";
            this.generalRadioBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 314);
            this.Controls.Add(this.InputHours);
            this.Controls.Add(this.Charge);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.HoursPrompt);
            this.Controls.Add(this.Notice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ChooseParkingType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChooseParkingType;
        private System.Windows.Forms.Label Notice;
        private System.Windows.Forms.Label HoursPrompt;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label Charge;
        private System.Windows.Forms.TextBox InputHours;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton generalRadioBtn;
        private System.Windows.Forms.RadioButton studentRadioBtn;
        private System.Windows.Forms.RadioButton staffRadiobtn;
    }
}

