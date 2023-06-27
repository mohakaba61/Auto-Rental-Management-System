
namespace ARMSClientApp
{
    partial class frmCreditCardRegistrationForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dptExpDate = new System.Windows.Forms.DateTimePicker();
            this.cbAtivationStatus = new System.Windows.Forms.ComboBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.cbStateCode = new System.Windows.Forms.ComboBox();
            this.cbCreditCardMerchantName = new System.Windows.Forms.ComboBox();
            this.boxCity = new System.Windows.Forms.TextBox();
            this.boxZipCode = new System.Windows.Forms.TextBox();
            this.boxCreditCardBalance = new System.Windows.Forms.TextBox();
            this.boxCreditCardLimit = new System.Windows.Forms.TextBox();
            this.boxAdressLine2 = new System.Windows.Forms.TextBox();
            this.boxAdressLine1 = new System.Windows.Forms.TextBox();
            this.txtBoxCardCompany = new System.Windows.Forms.TextBox();
            this.txtBoxCardName = new System.Windows.Forms.TextBox();
            this.txtBoxCardNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblTitle5 = new System.Windows.Forms.Label();
            this.lblTitle12 = new System.Windows.Forms.Label();
            this.lblTitle11 = new System.Windows.Forms.Label();
            this.lblTitle10 = new System.Windows.Forms.Label();
            this.lblTitle9 = new System.Windows.Forms.Label();
            this.lblTitle8 = new System.Windows.Forms.Label();
            this.lblTitle7 = new System.Windows.Forms.Label();
            this.lblTitle6 = new System.Windows.Forms.Label();
            this.lblTitle13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(24, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(295, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Credit Card Registration";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Plum;
            this.groupBox2.Controls.Add(this.dptExpDate);
            this.groupBox2.Controls.Add(this.cbAtivationStatus);
            this.groupBox2.Controls.Add(this.cbCountry);
            this.groupBox2.Controls.Add(this.cbStateCode);
            this.groupBox2.Controls.Add(this.cbCreditCardMerchantName);
            this.groupBox2.Controls.Add(this.boxCity);
            this.groupBox2.Controls.Add(this.boxZipCode);
            this.groupBox2.Controls.Add(this.boxCreditCardBalance);
            this.groupBox2.Controls.Add(this.boxCreditCardLimit);
            this.groupBox2.Controls.Add(this.boxAdressLine2);
            this.groupBox2.Controls.Add(this.boxAdressLine1);
            this.groupBox2.Controls.Add(this.txtBoxCardCompany);
            this.groupBox2.Controls.Add(this.txtBoxCardName);
            this.groupBox2.Controls.Add(this.txtBoxCardNumber);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblTitle1);
            this.groupBox2.Controls.Add(this.lblTitle2);
            this.groupBox2.Controls.Add(this.lblTitle3);
            this.groupBox2.Controls.Add(this.lbl);
            this.groupBox2.Controls.Add(this.lblTitle5);
            this.groupBox2.Controls.Add(this.lblTitle12);
            this.groupBox2.Controls.Add(this.lblTitle11);
            this.groupBox2.Controls.Add(this.lblTitle10);
            this.groupBox2.Controls.Add(this.lblTitle9);
            this.groupBox2.Controls.Add(this.lblTitle8);
            this.groupBox2.Controls.Add(this.lblTitle7);
            this.groupBox2.Controls.Add(this.lblTitle6);
            this.groupBox2.Controls.Add(this.lblTitle13);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(29, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 648);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // dptExpDate
            // 
            this.dptExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptExpDate.Location = new System.Drawing.Point(197, 195);
            this.dptExpDate.Name = "dptExpDate";
            this.dptExpDate.Size = new System.Drawing.Size(130, 22);
            this.dptExpDate.TabIndex = 38;
            // 
            // cbAtivationStatus
            // 
            this.cbAtivationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAtivationStatus.FormattingEnabled = true;
            this.cbAtivationStatus.Location = new System.Drawing.Point(197, 574);
            this.cbAtivationStatus.Name = "cbAtivationStatus";
            this.cbAtivationStatus.Size = new System.Drawing.Size(156, 24);
            this.cbAtivationStatus.TabIndex = 36;
            this.cbAtivationStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(197, 446);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(156, 24);
            this.cbCountry.TabIndex = 35;
            // 
            // cbStateCode
            // 
            this.cbStateCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStateCode.FormattingEnabled = true;
            this.cbStateCode.Location = new System.Drawing.Point(197, 352);
            this.cbStateCode.Name = "cbStateCode";
            this.cbStateCode.Size = new System.Drawing.Size(136, 24);
            this.cbStateCode.TabIndex = 34;
            // 
            // cbCreditCardMerchantName
            // 
            this.cbCreditCardMerchantName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCreditCardMerchantName.FormattingEnabled = true;
            this.cbCreditCardMerchantName.Location = new System.Drawing.Point(197, 162);
            this.cbCreditCardMerchantName.Name = "cbCreditCardMerchantName";
            this.cbCreditCardMerchantName.Size = new System.Drawing.Size(174, 24);
            this.cbCreditCardMerchantName.TabIndex = 32;
            // 
            // boxCity
            // 
            this.boxCity.Location = new System.Drawing.Point(197, 306);
            this.boxCity.Name = "boxCity";
            this.boxCity.Size = new System.Drawing.Size(130, 22);
            this.boxCity.TabIndex = 31;
            // 
            // boxZipCode
            // 
            this.boxZipCode.Location = new System.Drawing.Point(197, 397);
            this.boxZipCode.Name = "boxZipCode";
            this.boxZipCode.Size = new System.Drawing.Size(181, 22);
            this.boxZipCode.TabIndex = 29;
            // 
            // boxCreditCardBalance
            // 
            this.boxCreditCardBalance.Location = new System.Drawing.Point(197, 530);
            this.boxCreditCardBalance.Name = "boxCreditCardBalance";
            this.boxCreditCardBalance.Size = new System.Drawing.Size(181, 22);
            this.boxCreditCardBalance.TabIndex = 27;
            this.boxCreditCardBalance.Text = "3000.00";
            // 
            // boxCreditCardLimit
            // 
            this.boxCreditCardLimit.Location = new System.Drawing.Point(197, 492);
            this.boxCreditCardLimit.Name = "boxCreditCardLimit";
            this.boxCreditCardLimit.Size = new System.Drawing.Size(181, 22);
            this.boxCreditCardLimit.TabIndex = 25;
            this.boxCreditCardLimit.Text = "3000.00";
            // 
            // boxAdressLine2
            // 
            this.boxAdressLine2.Location = new System.Drawing.Point(197, 278);
            this.boxAdressLine2.Name = "boxAdressLine2";
            this.boxAdressLine2.Size = new System.Drawing.Size(228, 22);
            this.boxAdressLine2.TabIndex = 24;
            // 
            // boxAdressLine1
            // 
            this.boxAdressLine1.Location = new System.Drawing.Point(197, 240);
            this.boxAdressLine1.Name = "boxAdressLine1";
            this.boxAdressLine1.Size = new System.Drawing.Size(228, 22);
            this.boxAdressLine1.TabIndex = 23;
            // 
            // txtBoxCardCompany
            // 
            this.txtBoxCardCompany.Location = new System.Drawing.Point(197, 131);
            this.txtBoxCardCompany.Name = "txtBoxCardCompany";
            this.txtBoxCardCompany.Size = new System.Drawing.Size(181, 22);
            this.txtBoxCardCompany.TabIndex = 20;
            // 
            // txtBoxCardName
            // 
            this.txtBoxCardName.Location = new System.Drawing.Point(197, 96);
            this.txtBoxCardName.Name = "txtBoxCardName";
            this.txtBoxCardName.Size = new System.Drawing.Size(181, 22);
            this.txtBoxCardName.TabIndex = 19;
            // 
            // txtBoxCardNumber
            // 
            this.txtBoxCardNumber.Location = new System.Drawing.Point(197, 59);
            this.txtBoxCardNumber.Name = "txtBoxCardNumber";
            this.txtBoxCardNumber.Size = new System.Drawing.Size(181, 22);
            this.txtBoxCardNumber.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Credit Card Number";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.Location = new System.Drawing.Point(25, 101);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(122, 17);
            this.lblTitle1.TabIndex = 17;
            this.lblTitle1.Text = "Card Owner Name";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.Location = new System.Drawing.Point(25, 134);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(142, 17);
            this.lblTitle2.TabIndex = 16;
            this.lblTitle2.Text = "Card Issuing Company";
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle3.Location = new System.Drawing.Point(25, 169);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(138, 17);
            this.lblTitle3.TabIndex = 15;
            this.lblTitle3.Text = "Card Merchant Name";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(25, 204);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(100, 17);
            this.lbl.TabIndex = 14;
            this.lbl.Text = "Expiration Date";
            // 
            // lblTitle5
            // 
            this.lblTitle5.AutoSize = true;
            this.lblTitle5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle5.Location = new System.Drawing.Point(25, 245);
            this.lblTitle5.Name = "lblTitle5";
            this.lblTitle5.Size = new System.Drawing.Size(98, 17);
            this.lblTitle5.TabIndex = 13;
            this.lblTitle5.Text = "Address Line 1";
            // 
            // lblTitle12
            // 
            this.lblTitle12.AutoSize = true;
            this.lblTitle12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle12.Location = new System.Drawing.Point(25, 533);
            this.lblTitle12.Name = "lblTitle12";
            this.lblTitle12.Size = new System.Drawing.Size(130, 17);
            this.lblTitle12.TabIndex = 12;
            this.lblTitle12.Text = "Credit Limit Balance";
            // 
            // lblTitle11
            // 
            this.lblTitle11.AutoSize = true;
            this.lblTitle11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle11.Location = new System.Drawing.Point(25, 497);
            this.lblTitle11.Name = "lblTitle11";
            this.lblTitle11.Size = new System.Drawing.Size(111, 17);
            this.lblTitle11.TabIndex = 11;
            this.lblTitle11.Text = "Credit Card Limit";
            // 
            // lblTitle10
            // 
            this.lblTitle10.AutoSize = true;
            this.lblTitle10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle10.Location = new System.Drawing.Point(25, 449);
            this.lblTitle10.Name = "lblTitle10";
            this.lblTitle10.Size = new System.Drawing.Size(55, 17);
            this.lblTitle10.TabIndex = 10;
            this.lblTitle10.Text = "Country";
            // 
            // lblTitle9
            // 
            this.lblTitle9.AutoSize = true;
            this.lblTitle9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle9.Location = new System.Drawing.Point(25, 402);
            this.lblTitle9.Name = "lblTitle9";
            this.lblTitle9.Size = new System.Drawing.Size(62, 17);
            this.lblTitle9.TabIndex = 9;
            this.lblTitle9.Text = "Zip Code";
            // 
            // lblTitle8
            // 
            this.lblTitle8.AutoSize = true;
            this.lblTitle8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle8.Location = new System.Drawing.Point(25, 359);
            this.lblTitle8.Name = "lblTitle8";
            this.lblTitle8.Size = new System.Drawing.Size(38, 17);
            this.lblTitle8.TabIndex = 8;
            this.lblTitle8.Text = "State";
            // 
            // lblTitle7
            // 
            this.lblTitle7.AutoSize = true;
            this.lblTitle7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle7.Location = new System.Drawing.Point(25, 315);
            this.lblTitle7.Name = "lblTitle7";
            this.lblTitle7.Size = new System.Drawing.Size(32, 17);
            this.lblTitle7.TabIndex = 7;
            this.lblTitle7.Text = "City";
            // 
            // lblTitle6
            // 
            this.lblTitle6.AutoSize = true;
            this.lblTitle6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle6.Location = new System.Drawing.Point(25, 281);
            this.lblTitle6.Name = "lblTitle6";
            this.lblTitle6.Size = new System.Drawing.Size(98, 17);
            this.lblTitle6.TabIndex = 6;
            this.lblTitle6.Text = "Address Line 2";
            // 
            // lblTitle13
            // 
            this.lblTitle13.AutoSize = true;
            this.lblTitle13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle13.Location = new System.Drawing.Point(25, 574);
            this.lblTitle13.Name = "lblTitle13";
            this.lblTitle13.Size = new System.Drawing.Size(108, 17);
            this.lblTitle13.TabIndex = 5;
            this.lblTitle13.Text = "Activation Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Credit Card information:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Location = new System.Drawing.Point(29, 725);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 84);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(348, 30);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(77, 35);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(230, 30);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 35);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCreditCardRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(526, 821);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCreditCardRegistrationForm";
            this.Text = "Credit Card Registration";
            this.Load += new System.EventHandler(this.frmCreditCardRegistrationForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbAtivationStatus;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.ComboBox cbStateCode;
        private System.Windows.Forms.ComboBox cbCreditCardMerchantName;
        private System.Windows.Forms.TextBox boxCity;
        private System.Windows.Forms.TextBox boxZipCode;
        private System.Windows.Forms.TextBox boxAdressLine2;
        private System.Windows.Forms.TextBox boxAdressLine1;
        private System.Windows.Forms.TextBox txtBoxCardCompany;
        private System.Windows.Forms.TextBox txtBoxCardName;
        private System.Windows.Forms.TextBox txtBoxCardNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblTitle5;
        private System.Windows.Forms.Label lblTitle12;
        private System.Windows.Forms.Label lblTitle11;
        private System.Windows.Forms.Label lblTitle10;
        private System.Windows.Forms.Label lblTitle9;
        private System.Windows.Forms.Label lblTitle8;
        private System.Windows.Forms.Label lblTitle7;
        private System.Windows.Forms.Label lblTitle6;
        private System.Windows.Forms.Label lblTitle13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dptExpDate;
        private System.Windows.Forms.TextBox boxCreditCardBalance;
        private System.Windows.Forms.TextBox boxCreditCardLimit;
    }
}