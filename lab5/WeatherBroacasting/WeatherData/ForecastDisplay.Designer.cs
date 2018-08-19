namespace WeatherBroadcast
{
    partial class ForecastDisplay
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
            this.lblPrompt = new System.Windows.Forms.Label();
            this.condition = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.unsubscribe = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(23, 130);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(156, 20);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "Expected conditions:";
            // 
            // condition
            // 
            this.condition.AutoSize = true;
            this.condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condition.Location = new System.Drawing.Point(202, 130);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(0, 20);
            this.condition.TabIndex = 1;
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(106, 192);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(163, 33);
            this.register.TabIndex = 2;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // unsubscribe
            // 
            this.unsubscribe.Location = new System.Drawing.Point(106, 256);
            this.unsubscribe.Name = "unsubscribe";
            this.unsubscribe.Size = new System.Drawing.Size(163, 36);
            this.unsubscribe.TabIndex = 3;
            this.unsubscribe.Text = "Unsubscribe";
            this.unsubscribe.UseVisualStyleBackColor = true;
            this.unsubscribe.Click += new System.EventHandler(this.unsubscribe_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(124, 46);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(129, 31);
            this.header.TabIndex = 4;
            this.header.Text = "Forecast";
            // 
            // ForecastDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 349);
            this.Controls.Add(this.header);
            this.Controls.Add(this.unsubscribe);
            this.Controls.Add(this.register);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.lblPrompt);
            this.Name = "ForecastDisplay";
            this.Text = "ForecastDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Label condition;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button unsubscribe;
        private System.Windows.Forms.Label header;
    }
}