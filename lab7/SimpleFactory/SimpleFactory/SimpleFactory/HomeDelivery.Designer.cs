namespace SimpleFactoryForm
{
    partial class HomeDelivery
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
            this.listPizza = new System.Windows.Forms.ListBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What type of pizza do you want";
            // 
            // listPizza
            // 
            this.listPizza.FormattingEnabled = true;
            this.listPizza.Location = new System.Drawing.Point(245, 125);
            this.listPizza.Name = "listPizza";
            this.listPizza.Size = new System.Drawing.Size(120, 95);
            this.listPizza.TabIndex = 1;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.BackColor = System.Drawing.SystemColors.Info;
            this.lblOrder.Location = new System.Drawing.Point(242, 277);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(13, 13);
            this.lblOrder.TabIndex = 2;
            this.lblOrder.Text = "--";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(75, 277);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order Here";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // HomeDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 354);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.listPizza);
            this.Controls.Add(this.label1);
            this.Name = "HomeDelivery";
            this.Text = "Home Delivery";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listPizza;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Button btnOrder;
    }
}

