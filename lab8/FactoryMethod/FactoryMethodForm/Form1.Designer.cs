namespace FactoryMethodForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnOZ = new System.Windows.Forms.RadioButton();
            this.radioBtnNZ = new System.Windows.Forms.RadioButton();
            this.typeList = new System.Windows.Forms.ListBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblOrder = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What flavour of coffee do you want";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnOZ);
            this.groupBox1.Controls.Add(this.radioBtnNZ);
            this.groupBox1.Location = new System.Drawing.Point(68, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Cafe";
            // 
            // radioBtnOZ
            // 
            this.radioBtnOZ.AutoSize = true;
            this.radioBtnOZ.Location = new System.Drawing.Point(98, 20);
            this.radioBtnOZ.Name = "radioBtnOZ";
            this.radioBtnOZ.Size = new System.Drawing.Size(65, 17);
            this.radioBtnOZ.TabIndex = 1;
            this.radioBtnOZ.TabStop = true;
            this.radioBtnOZ.Text = "OZ Cafe";
            this.radioBtnOZ.UseVisualStyleBackColor = true;
            // 
            // radioBtnNZ
            // 
            this.radioBtnNZ.AutoSize = true;
            this.radioBtnNZ.Location = new System.Drawing.Point(7, 20);
            this.radioBtnNZ.Name = "radioBtnNZ";
            this.radioBtnNZ.Size = new System.Drawing.Size(65, 17);
            this.radioBtnNZ.TabIndex = 0;
            this.radioBtnNZ.TabStop = true;
            this.radioBtnNZ.Text = "NZ Cafe";
            this.radioBtnNZ.UseVisualStyleBackColor = true;
            // 
            // typeList
            // 
            this.typeList.FormattingEnabled = true;
            this.typeList.Location = new System.Drawing.Point(275, 137);
            this.typeList.Name = "typeList";
            this.typeList.Size = new System.Drawing.Size(120, 95);
            this.typeList.TabIndex = 2;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(68, 272);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(163, 272);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(10, 13);
            this.lblOrder.TabIndex = 4;
            this.lblOrder.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 385);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.typeList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnNZ;
        private System.Windows.Forms.RadioButton radioBtnOZ;
        private System.Windows.Forms.ListBox typeList;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblOrder;
    }
}

