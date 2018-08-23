namespace DuckSimulatorForm
{
    partial class SimulatorForm
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
            this.title = new System.Windows.Forms.GroupBox();
            this.radioRubberDuck = new System.Windows.Forms.RadioButton();
            this.radioDecoyDuck = new System.Windows.Forms.RadioButton();
            this.radioRedHead = new System.Windows.Forms.RadioButton();
            this.radioMallard = new System.Windows.Forms.RadioButton();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnFly = new System.Windows.Forms.Button();
            this.btnQuack = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.title.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Controls.Add(this.radioRubberDuck);
            this.title.Controls.Add(this.radioDecoyDuck);
            this.title.Controls.Add(this.radioRedHead);
            this.title.Controls.Add(this.radioMallard);
            this.title.Location = new System.Drawing.Point(27, 47);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(123, 139);
            this.title.TabIndex = 0;
            this.title.TabStop = false;
            this.title.Text = "Duck Type";
            // 
            // radioRubberDuck
            // 
            this.radioRubberDuck.AutoSize = true;
            this.radioRubberDuck.Location = new System.Drawing.Point(7, 108);
            this.radioRubberDuck.Name = "radioRubberDuck";
            this.radioRubberDuck.Size = new System.Drawing.Size(89, 17);
            this.radioRubberDuck.TabIndex = 3;
            this.radioRubberDuck.TabStop = true;
            this.radioRubberDuck.Text = "Rubber Duck";
            this.radioRubberDuck.UseVisualStyleBackColor = true;
            // 
            // radioDecoyDuck
            // 
            this.radioDecoyDuck.AutoSize = true;
            this.radioDecoyDuck.Location = new System.Drawing.Point(7, 79);
            this.radioDecoyDuck.Name = "radioDecoyDuck";
            this.radioDecoyDuck.Size = new System.Drawing.Size(85, 17);
            this.radioDecoyDuck.TabIndex = 2;
            this.radioDecoyDuck.TabStop = true;
            this.radioDecoyDuck.Text = "Decoy Duck";
            this.radioDecoyDuck.UseVisualStyleBackColor = true;
            // 
            // radioRedHead
            // 
            this.radioRedHead.AutoSize = true;
            this.radioRedHead.Location = new System.Drawing.Point(7, 52);
            this.radioRedHead.Name = "radioRedHead";
            this.radioRedHead.Size = new System.Drawing.Size(74, 17);
            this.radioRedHead.TabIndex = 1;
            this.radioRedHead.TabStop = true;
            this.radioRedHead.Text = "Red Head";
            this.radioRedHead.UseVisualStyleBackColor = true;
            // 
            // radioMallard
            // 
            this.radioMallard.AutoSize = true;
            this.radioMallard.Location = new System.Drawing.Point(7, 27);
            this.radioMallard.Name = "radioMallard";
            this.radioMallard.Size = new System.Drawing.Size(59, 17);
            this.radioMallard.TabIndex = 0;
            this.radioMallard.TabStop = true;
            this.radioMallard.Text = "Mallard";
            this.radioMallard.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(234, 47);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(101, 30);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnFly
            // 
            this.btnFly.Location = new System.Drawing.Point(234, 99);
            this.btnFly.Name = "btnFly";
            this.btnFly.Size = new System.Drawing.Size(101, 28);
            this.btnFly.TabIndex = 2;
            this.btnFly.Text = "Fly";
            this.btnFly.UseVisualStyleBackColor = true;
            this.btnFly.Click += new System.EventHandler(this.btnFly_Click);
            // 
            // btnQuack
            // 
            this.btnQuack.Location = new System.Drawing.Point(234, 148);
            this.btnQuack.Name = "btnQuack";
            this.btnQuack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnQuack.Size = new System.Drawing.Size(101, 31);
            this.btnQuack.TabIndex = 3;
            this.btnQuack.Text = "Quack";
            this.btnQuack.UseVisualStyleBackColor = true;
            this.btnQuack.Click += new System.EventHandler(this.btnQuack_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(155, 206);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(16, 13);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "---";
            // 
            // SimulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 255);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnQuack);
            this.Controls.Add(this.btnFly);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.title);
            this.Name = "SimulatorForm";
            this.Text = "DuckSimulator";
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox title;
        private System.Windows.Forms.RadioButton radioRubberDuck;
        private System.Windows.Forms.RadioButton radioDecoyDuck;
        private System.Windows.Forms.RadioButton radioRedHead;
        private System.Windows.Forms.RadioButton radioMallard;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnFly;
        private System.Windows.Forms.Button btnQuack;
        private System.Windows.Forms.Label lblMessage;
    }
}

