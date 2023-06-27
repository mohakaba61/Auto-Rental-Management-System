
namespace ARMSClientApp
{
    partial class frmERPSystemForm
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
            this.IblTitle = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCreditCardMS = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnVehicleInventoryMS = new System.Windows.Forms.Button();
            this.btnCRM = new System.Windows.Forms.Button();
            this.btnHR = new System.Windows.Forms.Button();
            this.btnFinanceOperationsMS = new System.Windows.Forms.Button();
            this.btnMarketingMS = new System.Windows.Forms.Button();
            this.btnCustomerFieldServicesMS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IblTitle
            // 
            this.IblTitle.AutoSize = true;
            this.IblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblTitle.Location = new System.Drawing.Point(12, 26);
            this.IblTitle.Name = "IblTitle";
            this.IblTitle.Size = new System.Drawing.Size(501, 25);
            this.IblTitle.TabIndex = 0;
            this.IblTitle.Text = "Enterprise Resource Planning (ERP) System Portal";
            this.IblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCreditCardMS
            // 
            this.btnCreditCardMS.Location = new System.Drawing.Point(32, 68);
            this.btnCreditCardMS.Name = "btnCreditCardMS";
            this.btnCreditCardMS.Size = new System.Drawing.Size(454, 39);
            this.btnCreditCardMS.TabIndex = 1;
            this.btnCreditCardMS.Text = "Credit Card Management System";
            this.btnCreditCardMS.UseVisualStyleBackColor = true;
            this.btnCreditCardMS.Click += new System.EventHandler(this.btnCreditCardMS_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(175, 498);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 41);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit ERP";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVehicleInventoryMS
            // 
            this.btnVehicleInventoryMS.Location = new System.Drawing.Point(32, 123);
            this.btnVehicleInventoryMS.Name = "btnVehicleInventoryMS";
            this.btnVehicleInventoryMS.Size = new System.Drawing.Size(456, 39);
            this.btnVehicleInventoryMS.TabIndex = 3;
            this.btnVehicleInventoryMS.Text = "Vehicle Inventory Management System (Coming soon)";
            this.btnVehicleInventoryMS.UseVisualStyleBackColor = true;
            // 
            // btnCRM
            // 
            this.btnCRM.Location = new System.Drawing.Point(32, 179);
            this.btnCRM.Name = "btnCRM";
            this.btnCRM.Size = new System.Drawing.Size(456, 39);
            this.btnCRM.TabIndex = 4;
            this.btnCRM.Text = "Customer Relationship Management (CRM) System( Coming soon)";
            this.btnCRM.UseVisualStyleBackColor = true;
            // 
            // btnHR
            // 
            this.btnHR.Location = new System.Drawing.Point(32, 237);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(454, 39);
            this.btnHR.TabIndex = 5;
            this.btnHR.Text = "Human Resource Management System (Coming soon)";
            this.btnHR.UseVisualStyleBackColor = true;
            // 
            // btnFinanceOperationsMS
            // 
            this.btnFinanceOperationsMS.Location = new System.Drawing.Point(32, 294);
            this.btnFinanceOperationsMS.Name = "btnFinanceOperationsMS";
            this.btnFinanceOperationsMS.Size = new System.Drawing.Size(454, 39);
            this.btnFinanceOperationsMS.TabIndex = 6;
            this.btnFinanceOperationsMS.Text = "Finance & Operations Management System (Coming soon)";
            this.btnFinanceOperationsMS.UseVisualStyleBackColor = true;
            // 
            // btnMarketingMS
            // 
            this.btnMarketingMS.Location = new System.Drawing.Point(32, 349);
            this.btnMarketingMS.Name = "btnMarketingMS";
            this.btnMarketingMS.Size = new System.Drawing.Size(454, 39);
            this.btnMarketingMS.TabIndex = 7;
            this.btnMarketingMS.Text = "Marketing Management System (Coming soon)";
            this.btnMarketingMS.UseVisualStyleBackColor = true;
            // 
            // btnCustomerFieldServicesMS
            // 
            this.btnCustomerFieldServicesMS.Location = new System.Drawing.Point(32, 414);
            this.btnCustomerFieldServicesMS.Name = "btnCustomerFieldServicesMS";
            this.btnCustomerFieldServicesMS.Size = new System.Drawing.Size(454, 39);
            this.btnCustomerFieldServicesMS.TabIndex = 8;
            this.btnCustomerFieldServicesMS.Text = "Customer & Field Services Management System (Coming soon)";
            this.btnCustomerFieldServicesMS.UseVisualStyleBackColor = true;
            // 
            // frmERPSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 551);
            this.Controls.Add(this.btnCustomerFieldServicesMS);
            this.Controls.Add(this.btnMarketingMS);
            this.Controls.Add(this.btnFinanceOperationsMS);
            this.Controls.Add(this.btnHR);
            this.Controls.Add(this.btnCRM);
            this.Controls.Add(this.btnVehicleInventoryMS);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreditCardMS);
            this.Controls.Add(this.IblTitle);
            this.Name = "frmERPSystemForm";
            this.Text = "Enterprise Resource Planning (ERP) System Portal";
            this.Load += new System.EventHandler(this.frmERPSystemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IblTitle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCreditCardMS;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnVehicleInventoryMS;
        private System.Windows.Forms.Button btnCRM;
        private System.Windows.Forms.Button btnHR;
        private System.Windows.Forms.Button btnFinanceOperationsMS;
        private System.Windows.Forms.Button btnMarketingMS;
        private System.Windows.Forms.Button btnCustomerFieldServicesMS;
    }
}