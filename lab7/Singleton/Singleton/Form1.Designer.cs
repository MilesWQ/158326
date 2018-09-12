namespace Singleton
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.listInspections = new System.Windows.Forms.ListBox();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            this.lblReqDetailsPrompt = new System.Windows.Forms.Label();
            this.lblRequestDetails = new System.Windows.Forms.Label();
            this.lblNumPrompt = new System.Windows.Forms.Label();
            this.lblNumberOfRequest = new System.Windows.Forms.Label();
            this.lblTotalPricePrompt = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(274, 25);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(0, 20);
            this.lblHeader.TabIndex = 0;
            // 
            // listInspections
            // 
            this.listInspections.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listInspections.FormattingEnabled = true;
            this.listInspections.ItemHeight = 16;
            this.listInspections.Location = new System.Drawing.Point(261, 169);
            this.listInspections.Name = "listInspections";
            this.listInspections.Size = new System.Drawing.Size(291, 100);
            this.listInspections.TabIndex = 1;
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(33, 57);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(191, 20);
            this.lblPrompt.TabIndex = 2;
            this.lblPrompt.Text = "Select the inspection type";
            // 
            // btnRequest
            // 
            this.btnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Location = new System.Drawing.Point(37, 111);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(162, 23);
            this.btnRequest.TabIndex = 3;
            this.btnRequest.Text = "Request Inspection";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // lblReqDetailsPrompt
            // 
            this.lblReqDetailsPrompt.AutoSize = true;
            this.lblReqDetailsPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqDetailsPrompt.Location = new System.Drawing.Point(34, 187);
            this.lblReqDetailsPrompt.Name = "lblReqDetailsPrompt";
            this.lblReqDetailsPrompt.Size = new System.Drawing.Size(192, 16);
            this.lblReqDetailsPrompt.TabIndex = 4;
            this.lblReqDetailsPrompt.Text = "Details of inspection requested";
            // 
            // lblRequestDetails
            // 
            this.lblRequestDetails.AutoSize = true;
            this.lblRequestDetails.Location = new System.Drawing.Point(34, 292);
            this.lblRequestDetails.Name = "lblRequestDetails";
            this.lblRequestDetails.Size = new System.Drawing.Size(0, 13);
            this.lblRequestDetails.TabIndex = 5;
            // 
            // lblNumPrompt
            // 
            this.lblNumPrompt.AutoSize = true;
            this.lblNumPrompt.Location = new System.Drawing.Point(546, 315);
            this.lblNumPrompt.Name = "lblNumPrompt";
            this.lblNumPrompt.Size = new System.Drawing.Size(182, 13);
            this.lblNumPrompt.TabIndex = 6;
            this.lblNumPrompt.Text = "Total number of inspection requested";
            // 
            // lblNumberOfRequest
            // 
            this.lblNumberOfRequest.AutoSize = true;
            this.lblNumberOfRequest.Location = new System.Drawing.Point(572, 347);
            this.lblNumberOfRequest.Name = "lblNumberOfRequest";
            this.lblNumberOfRequest.Size = new System.Drawing.Size(0, 13);
            this.lblNumberOfRequest.TabIndex = 7;
            // 
            // lblTotalPricePrompt
            // 
            this.lblTotalPricePrompt.AutoSize = true;
            this.lblTotalPricePrompt.Location = new System.Drawing.Point(261, 347);
            this.lblTotalPricePrompt.Name = "lblTotalPricePrompt";
            this.lblTotalPricePrompt.Size = new System.Drawing.Size(141, 13);
            this.lblTotalPricePrompt.TabIndex = 8;
            this.lblTotalPricePrompt.Text = "Total price for all inspections";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(264, 376);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 13);
            this.lblTotalPrice.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 503);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTotalPricePrompt);
            this.Controls.Add(this.lblNumberOfRequest);
            this.Controls.Add(this.lblNumPrompt);
            this.Controls.Add(this.lblRequestDetails);
            this.Controls.Add(this.lblReqDetailsPrompt);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.listInspections);
            this.Controls.Add(this.lblHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ListBox listInspections;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Label lblReqDetailsPrompt;
        private System.Windows.Forms.Label lblRequestDetails;
        private System.Windows.Forms.Label lblNumPrompt;
        private System.Windows.Forms.Label lblNumberOfRequest;
        private System.Windows.Forms.Label lblTotalPricePrompt;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}

