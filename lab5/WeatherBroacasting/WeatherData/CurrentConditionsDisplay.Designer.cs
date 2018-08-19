namespace WeatherBroadcast
{
    partial class CurrentConditionsDisplay
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
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.pressure = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.unsubscribe = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(61, 95);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(49, 20);
            this.lblTemp.TabIndex = 0;
            this.lblTemp.Text = "Temp";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.Location = new System.Drawing.Point(61, 153);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(70, 20);
            this.lblHumidity.TabIndex = 1;
            this.lblHumidity.Text = "Humidity";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressure.Location = new System.Drawing.Point(63, 212);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(72, 20);
            this.lblPressure.TabIndex = 2;
            this.lblPressure.Text = "Pressure";
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp.Location = new System.Drawing.Point(196, 95);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(0, 20);
            this.temp.TabIndex = 3;
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidity.Location = new System.Drawing.Point(196, 153);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(0, 20);
            this.humidity.TabIndex = 4;
            // 
            // pressure
            // 
            this.pressure.AutoSize = true;
            this.pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressure.Location = new System.Drawing.Point(195, 212);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(0, 20);
            this.pressure.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(121, 269);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(117, 33);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.register_Click);
            // 
            // unsubscribe
            // 
            this.unsubscribe.Location = new System.Drawing.Point(121, 318);
            this.unsubscribe.Name = "unsubscribe";
            this.unsubscribe.Size = new System.Drawing.Size(117, 32);
            this.unsubscribe.TabIndex = 7;
            this.unsubscribe.Text = "Unsubscribe";
            this.unsubscribe.UseVisualStyleBackColor = true;
            this.unsubscribe.Click += new System.EventHandler(this.unsubscribe_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(51, 21);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(259, 31);
            this.header.TabIndex = 8;
            this.header.Text = "Current Conditions";
            // 
            // CurrentConditionsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 380);
            this.Controls.Add(this.header);
            this.Controls.Add(this.unsubscribe);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pressure);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblTemp);
            this.Name = "CurrentConditionsDisplay";
            this.Text = "Current Conditions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button unsubscribe;
        private System.Windows.Forms.Label header;
    }
}

