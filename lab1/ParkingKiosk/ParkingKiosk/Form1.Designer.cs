namespace ParkingKiosk
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
            this.Selector = new System.Windows.Forms.GroupBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.regulation = new System.Windows.Forms.Label();
            this.hourInputPrompt = new System.Windows.Forms.Label();
            this.inputHours = new System.Windows.Forms.TextBox();
            this.CalculationButton = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.amountPrompt = new System.Windows.Forms.Label();
            this.errorMessages = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.customerRadioBtn = new System.Windows.Forms.RadioButton();
            this.staffRadioBtn = new System.Windows.Forms.RadioButton();
            this.Selector.SuspendLayout();
            this.SuspendLayout();
            // 
            // Selector
            // 
            this.Selector.Controls.Add(this.staffRadioBtn);
            this.Selector.Controls.Add(this.customerRadioBtn);
            this.Selector.Location = new System.Drawing.Point(76, 13);
            this.Selector.Margin = new System.Windows.Forms.Padding(4);
            this.Selector.Name = "Selector";
            this.Selector.Padding = new System.Windows.Forms.Padding(4);
            this.Selector.Size = new System.Drawing.Size(267, 65);
            this.Selector.TabIndex = 0;
            this.Selector.TabStop = false;
            this.Selector.Text = "Select one";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(159, 86);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 28);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // regulation
            // 
            this.regulation.AutoSize = true;
            this.regulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.regulation.Location = new System.Drawing.Point(73, 133);
            this.regulation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.regulation.Name = "regulation";
            this.regulation.Size = new System.Drawing.Size(0, 17);
            this.regulation.TabIndex = 3;
            // 
            // hourInputPrompt
            // 
            this.hourInputPrompt.AutoSize = true;
            this.hourInputPrompt.Location = new System.Drawing.Point(73, 220);
            this.hourInputPrompt.Name = "hourInputPrompt";
            this.hourInputPrompt.Size = new System.Drawing.Size(95, 17);
            this.hourInputPrompt.TabIndex = 4;
            this.hourInputPrompt.Text = "Hours Parked";
            // 
            // inputHours
            // 
            this.inputHours.Enabled = false;
            this.inputHours.Location = new System.Drawing.Point(203, 217);
            this.inputHours.Name = "inputHours";
            this.inputHours.Size = new System.Drawing.Size(100, 23);
            this.inputHours.TabIndex = 5;
            // 
            // CalculationButton
            // 
            this.CalculationButton.Enabled = false;
            this.CalculationButton.Location = new System.Drawing.Point(340, 215);
            this.CalculationButton.Name = "CalculationButton";
            this.CalculationButton.Size = new System.Drawing.Size(100, 26);
            this.CalculationButton.TabIndex = 6;
            this.CalculationButton.Text = "Calculate";
            this.CalculationButton.UseVisualStyleBackColor = true;
            this.CalculationButton.Click += new System.EventHandler(this.CalculationButton_Click);
            // 
            // result
            // 
            this.result.Enabled = false;
            this.result.Location = new System.Drawing.Point(203, 259);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 23);
            this.result.TabIndex = 7;
            // 
            // amountPrompt
            // 
            this.amountPrompt.AutoSize = true;
            this.amountPrompt.Location = new System.Drawing.Point(73, 259);
            this.amountPrompt.Name = "amountPrompt";
            this.amountPrompt.Size = new System.Drawing.Size(56, 17);
            this.amountPrompt.TabIndex = 8;
            this.amountPrompt.Text = "Amount";
            // 
            // errorMessages
            // 
            this.errorMessages.AutoSize = true;
            this.errorMessages.ForeColor = System.Drawing.Color.Red;
            this.errorMessages.Location = new System.Drawing.Point(128, 291);
            this.errorMessages.Name = "errorMessages";
            this.errorMessages.Size = new System.Drawing.Size(0, 17);
            this.errorMessages.TabIndex = 9;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(462, 214);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 26);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // customerRadioBtn
            // 
            this.customerRadioBtn.AutoSize = true;
            this.customerRadioBtn.Location = new System.Drawing.Point(24, 24);
            this.customerRadioBtn.Name = "customerRadioBtn";
            this.customerRadioBtn.Size = new System.Drawing.Size(86, 21);
            this.customerRadioBtn.TabIndex = 0;
            this.customerRadioBtn.TabStop = true;
            this.customerRadioBtn.Text = "Customer";
            this.customerRadioBtn.UseVisualStyleBackColor = true;
            // 
            // staffRadioBtn
            // 
            this.staffRadioBtn.AutoSize = true;
            this.staffRadioBtn.Location = new System.Drawing.Point(137, 24);
            this.staffRadioBtn.Name = "staffRadioBtn";
            this.staffRadioBtn.Size = new System.Drawing.Size(55, 21);
            this.staffRadioBtn.TabIndex = 1;
            this.staffRadioBtn.TabStop = true;
            this.staffRadioBtn.Text = "Staff";
            this.staffRadioBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 347);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.errorMessages);
            this.Controls.Add(this.amountPrompt);
            this.Controls.Add(this.result);
            this.Controls.Add(this.CalculationButton);
            this.Controls.Add(this.inputHours);
            this.Controls.Add(this.hourInputPrompt);
            this.Controls.Add(this.regulation);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.Selector);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ParkingKiosk";
            this.Selector.ResumeLayout(false);
            this.Selector.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Selector;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label regulation;
        private System.Windows.Forms.Label hourInputPrompt;
        private System.Windows.Forms.TextBox inputHours;
        private System.Windows.Forms.Button CalculationButton;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label amountPrompt;
        private System.Windows.Forms.Label errorMessages;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RadioButton staffRadioBtn;
        private System.Windows.Forms.RadioButton customerRadioBtn;
    }
}

