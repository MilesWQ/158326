namespace WeatherBroadcastForm
{
    partial class WeatherStatistics
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAverageTemp = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnDeRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Average Temp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max Temp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Min Temp";
            // 
            // lblAverageTemp
            // 
            this.lblAverageTemp.AutoSize = true;
            this.lblAverageTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageTemp.Location = new System.Drawing.Point(231, 89);
            this.lblAverageTemp.Name = "lblAverageTemp";
            this.lblAverageTemp.Size = new System.Drawing.Size(16, 24);
            this.lblAverageTemp.TabIndex = 3;
            this.lblAverageTemp.Text = "-";
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTemp.Location = new System.Drawing.Point(231, 153);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(16, 24);
            this.lblMaxTemp.TabIndex = 4;
            this.lblMaxTemp.Text = "-";
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinTemp.Location = new System.Drawing.Point(231, 217);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(16, 24);
            this.lblMinTemp.TabIndex = 5;
            this.lblMinTemp.Text = "-";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(133, 285);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(131, 48);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnDeRegister
            // 
            this.btnDeRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeRegister.Location = new System.Drawing.Point(133, 351);
            this.btnDeRegister.Name = "btnDeRegister";
            this.btnDeRegister.Size = new System.Drawing.Size(131, 48);
            this.btnDeRegister.TabIndex = 7;
            this.btnDeRegister.Text = "De-Register";
            this.btnDeRegister.UseVisualStyleBackColor = true;
            this.btnDeRegister.Click += new System.EventHandler(this.btnDeRegister_Click);
            // 
            // WeatherStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.btnDeRegister);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblMinTemp);
            this.Controls.Add(this.lblMaxTemp);
            this.Controls.Add(this.lblAverageTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WeatherStatistics";
            this.Text = "WeatherStatistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAverageTemp;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnDeRegister;
    }
}