namespace WeatherBroadcastForm
{
    partial class WeatherStation
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.textTemp = new System.Windows.Forms.TextBox();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.textHumidity = new System.Windows.Forms.TextBox();
            this.lblPressure = new System.Windows.Forms.Label();
            this.textPressure = new System.Windows.Forms.TextBox();
            this.btnSetMeasurement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(60, 55);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(217, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Weather Data Station";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(37, 130);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(86, 16);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "Temperature";
            // 
            // textTemp
            // 
            this.textTemp.Location = new System.Drawing.Point(129, 130);
            this.textTemp.Name = "textTemp";
            this.textTemp.Size = new System.Drawing.Size(100, 20);
            this.textTemp.TabIndex = 2;
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.Location = new System.Drawing.Point(40, 184);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(60, 16);
            this.lblHumidity.TabIndex = 3;
            this.lblHumidity.Text = "Humidity";
            // 
            // textHumidity
            // 
            this.textHumidity.Location = new System.Drawing.Point(129, 184);
            this.textHumidity.Name = "textHumidity";
            this.textHumidity.Size = new System.Drawing.Size(100, 20);
            this.textHumidity.TabIndex = 4;
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressure.Location = new System.Drawing.Point(40, 237);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(62, 16);
            this.lblPressure.TabIndex = 5;
            this.lblPressure.Text = "Pressure";
            // 
            // textPressure
            // 
            this.textPressure.Location = new System.Drawing.Point(129, 237);
            this.textPressure.Name = "textPressure";
            this.textPressure.Size = new System.Drawing.Size(100, 20);
            this.textPressure.TabIndex = 6;
            // 
            // btnSetMeasurement
            // 
            this.btnSetMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetMeasurement.Location = new System.Drawing.Point(99, 300);
            this.btnSetMeasurement.Name = "btnSetMeasurement";
            this.btnSetMeasurement.Size = new System.Drawing.Size(111, 30);
            this.btnSetMeasurement.TabIndex = 7;
            this.btnSetMeasurement.Text = "Set Data";
            this.btnSetMeasurement.UseVisualStyleBackColor = true;
            this.btnSetMeasurement.Click += new System.EventHandler(this.btnSetMeasurement_Click);
            // 
            // WeatherStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 370);
            this.Controls.Add(this.btnSetMeasurement);
            this.Controls.Add(this.textPressure);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.textHumidity);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.textTemp);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblHeader);
            this.Name = "WeatherStation";
            this.Text = "WeatherStation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TextBox textTemp;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.TextBox textHumidity;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.TextBox textPressure;
        private System.Windows.Forms.Button btnSetMeasurement;
    }
}

