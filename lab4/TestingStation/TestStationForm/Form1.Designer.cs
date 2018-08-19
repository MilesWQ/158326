namespace TestStationForm
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
            System.Windows.Forms.Label lblTotalNumberPrompt;
            this.lblStationInfo = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCreateDb = new System.Windows.Forms.Button();
            this.btnLoadDb = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblItemSelected = new System.Windows.Forms.Label();
            this.lblSelectedDetails = new System.Windows.Forms.Label();
            this.lblTotalPricePrompt = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalNumber = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            lblTotalNumberPrompt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalNumberPrompt
            // 
            lblTotalNumberPrompt.AutoSize = true;
            lblTotalNumberPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalNumberPrompt.Location = new System.Drawing.Point(571, 276);
            lblTotalNumberPrompt.Name = "lblTotalNumberPrompt";
            lblTotalNumberPrompt.Size = new System.Drawing.Size(283, 20);
            lblTotalNumberPrompt.TabIndex = 9;
            lblTotalNumberPrompt.Text = "Total Number of Inspection Requested";
            // 
            // lblStationInfo
            // 
            this.lblStationInfo.AutoSize = true;
            this.lblStationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationInfo.Location = new System.Drawing.Point(344, 18);
            this.lblStationInfo.Name = "lblStationInfo";
            this.lblStationInfo.Size = new System.Drawing.Size(0, 20);
            this.lblStationInfo.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(73, 99);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 16);
            this.lblMessage.TabIndex = 1;
            // 
            // btnCreateDb
            // 
            this.btnCreateDb.Location = new System.Drawing.Point(638, 39);
            this.btnCreateDb.Name = "btnCreateDb";
            this.btnCreateDb.Size = new System.Drawing.Size(100, 32);
            this.btnCreateDb.TabIndex = 2;
            this.btnCreateDb.Text = "CreateDB";
            this.btnCreateDb.UseVisualStyleBackColor = true;
            this.btnCreateDb.Click += new System.EventHandler(this.btnCreateDb_Click);
            // 
            // btnLoadDb
            // 
            this.btnLoadDb.Location = new System.Drawing.Point(638, 99);
            this.btnLoadDb.Name = "btnLoadDb";
            this.btnLoadDb.Size = new System.Drawing.Size(100, 27);
            this.btnLoadDb.TabIndex = 3;
            this.btnLoadDb.Text = "LoadDB";
            this.btnLoadDb.UseVisualStyleBackColor = true;
            this.btnLoadDb.Click += new System.EventHandler(this.btnLoadDb_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(286, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(264, 170);
            this.dataGridView1.TabIndex = 4;
            // 
            // lblItemSelected
            // 
            this.lblItemSelected.AutoSize = true;
            this.lblItemSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemSelected.Location = new System.Drawing.Point(12, 229);
            this.lblItemSelected.Name = "lblItemSelected";
            this.lblItemSelected.Size = new System.Drawing.Size(237, 20);
            this.lblItemSelected.TabIndex = 5;
            this.lblItemSelected.Text = "Details of Inspection Requested";
            // 
            // lblSelectedDetails
            // 
            this.lblSelectedDetails.AutoSize = true;
            this.lblSelectedDetails.Location = new System.Drawing.Point(16, 276);
            this.lblSelectedDetails.Name = "lblSelectedDetails";
            this.lblSelectedDetails.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedDetails.TabIndex = 6;
            // 
            // lblTotalPricePrompt
            // 
            this.lblTotalPricePrompt.AutoSize = true;
            this.lblTotalPricePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPricePrompt.Location = new System.Drawing.Point(274, 340);
            this.lblTotalPricePrompt.Name = "lblTotalPricePrompt";
            this.lblTotalPricePrompt.Size = new System.Drawing.Size(276, 20);
            this.lblTotalPricePrompt.TabIndex = 7;
            this.lblTotalPricePrompt.Text = "Total price for all inspection requested";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(275, 372);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 13);
            this.lblTotalPrice.TabIndex = 8;
            // 
            // lblTotalNumber
            // 
            this.lblTotalNumber.AutoSize = true;
            this.lblTotalNumber.Location = new System.Drawing.Point(575, 312);
            this.lblTotalNumber.Name = "lblTotalNumber";
            this.lblTotalNumber.Size = new System.Drawing.Size(0, 13);
            this.lblTotalNumber.TabIndex = 10;
            // 
            // btnRequest
            // 
            this.btnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Location = new System.Drawing.Point(48, 158);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(159, 38);
            this.btnRequest.TabIndex = 11;
            this.btnRequest.Text = "Request Inspection";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.lblTotalNumber);
            this.Controls.Add(lblTotalNumberPrompt);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTotalPricePrompt);
            this.Controls.Add(this.lblSelectedDetails);
            this.Controls.Add(this.lblItemSelected);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLoadDb);
            this.Controls.Add(this.btnCreateDb);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblStationInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStationInfo;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCreateDb;
        private System.Windows.Forms.Button btnLoadDb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblItemSelected;
        private System.Windows.Forms.Label lblSelectedDetails;
        private System.Windows.Forms.Label lblTotalPricePrompt;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalNumber;
        private System.Windows.Forms.Button btnRequest;
    }
}

