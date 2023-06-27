
namespace ARMSClientApp
{
    partial class frmMailWelcomeForm
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
            this.btnPOS = new System.Windows.Forms.Button();
            this.iblTitle = new System.Windows.Forms.Label();
            this.btnERP = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPOS
            // 
            this.btnPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.Location = new System.Drawing.Point(37, 91);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(425, 48);
            this.btnPOS.TabIndex = 1;
            this.btnPOS.Text = "Point-of-Sales & Rental";
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.button2_Click);
            // 
            // iblTitle
            // 
            this.iblTitle.AutoSize = true;
            this.iblTitle.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iblTitle.Location = new System.Drawing.Point(104, 26);
            this.iblTitle.Name = "iblTitle";
            this.iblTitle.Size = new System.Drawing.Size(284, 32);
            this.iblTitle.TabIndex = 2;
            this.iblTitle.Text = "EZRental POS System";
            this.iblTitle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnERP
            // 
            this.btnERP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnERP.Location = new System.Drawing.Point(37, 163);
            this.btnERP.Name = "btnERP";
            this.btnERP.Size = new System.Drawing.Size(425, 48);
            this.btnERP.TabIndex = 3;
            this.btnERP.Text = "Enterprise Resource Planning (ERP) System Portal";
            this.btnERP.UseVisualStyleBackColor = true;
            this.btnERP.Click += new System.EventHandler(this.btnERP_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(151, 300);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(164, 39);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmMailWelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(492, 365);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnERP);
            this.Controls.Add(this.iblTitle);
            this.Controls.Add(this.btnPOS);
            this.Name = "frmMailWelcomeForm";
            this.Text = "EZRental POS System";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmMailWelcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Label iblTitle;
        private System.Windows.Forms.Button btnERP;
        private System.Windows.Forms.Button btnExit;
    }
}

