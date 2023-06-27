
namespace ARMSClientApp
{
    partial class frmCreditCardSearchForm
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
            this.iblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxCardNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.boxCity = new System.Windows.Forms.TextBox();
            this.boxState = new System.Windows.Forms.TextBox();
            this.boxZipCode = new System.Windows.Forms.TextBox();
            this.boxCountry = new System.Windows.Forms.TextBox();
            this.boxCreditCardBalance = new System.Windows.Forms.TextBox();
            this.boxActivationStatus = new System.Windows.Forms.TextBox();
            this.boxCreditCardLimit = new System.Windows.Forms.TextBox();
            this.boxAdressLine2 = new System.Windows.Forms.TextBox();
            this.boxAdressLine1 = new System.Windows.Forms.TextBox();
            this.boxExp = new System.Windows.Forms.TextBox();
            this.txtBoxMerchantName = new System.Windows.Forms.TextBox();
            this.txtBoxCardCompany = new System.Windows.Forms.TextBox();
            this.txtBoxCardName = new System.Windows.Forms.TextBox();
            this.txtBoxCardNumber1 = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.lblTitle4 = new System.Windows.Forms.Label();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // iblTitle
            // 
            this.iblTitle.AutoSize = true;
            this.iblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iblTitle.Location = new System.Drawing.Point(12, 21);
            this.iblTitle.Name = "iblTitle";
            this.iblTitle.Size = new System.Drawing.Size(198, 25);
            this.iblTitle.TabIndex = 1;
            this.iblTitle.Text = "Credit Card Search";
            this.iblTitle.Click += new System.EventHandler(this.iblTitle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Plum;
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtBoxCardNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 93);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightPink;
            this.btnSearch.Location = new System.Drawing.Point(349, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxCardNumber
            // 
            this.txtBoxCardNumber.Location = new System.Drawing.Point(115, 52);
            this.txtBoxCardNumber.Name = "txtBoxCardNumber";
            this.txtBoxCardNumber.Size = new System.Drawing.Size(189, 22);
            this.txtBoxCardNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Card Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Credit Card Number & Click Search:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Plum;
            this.groupBox2.Controls.Add(this.boxCity);
            this.groupBox2.Controls.Add(this.boxState);
            this.groupBox2.Controls.Add(this.boxZipCode);
            this.groupBox2.Controls.Add(this.boxCountry);
            this.groupBox2.Controls.Add(this.boxCreditCardBalance);
            this.groupBox2.Controls.Add(this.boxActivationStatus);
            this.groupBox2.Controls.Add(this.boxCreditCardLimit);
            this.groupBox2.Controls.Add(this.boxAdressLine2);
            this.groupBox2.Controls.Add(this.boxAdressLine1);
            this.groupBox2.Controls.Add(this.boxExp);
            this.groupBox2.Controls.Add(this.txtBoxMerchantName);
            this.groupBox2.Controls.Add(this.txtBoxCardCompany);
            this.groupBox2.Controls.Add(this.txtBoxCardName);
            this.groupBox2.Controls.Add(this.txtBoxCardNumber1);
            this.groupBox2.Controls.Add(this.lblTitle);
            this.groupBox2.Controls.Add(this.lblTitle1);
            this.groupBox2.Controls.Add(this.lblTitle2);
            this.groupBox2.Controls.Add(this.lblTitle3);
            this.groupBox2.Controls.Add(this.lblTitle4);
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
            this.groupBox2.Location = new System.Drawing.Point(13, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 603);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // boxCity
            // 
            this.boxCity.Location = new System.Drawing.Point(178, 306);
            this.boxCity.Name = "boxCity";
            this.boxCity.Size = new System.Drawing.Size(130, 22);
            this.boxCity.TabIndex = 31;
            // 
            // boxState
            // 
            this.boxState.Location = new System.Drawing.Point(178, 354);
            this.boxState.Name = "boxState";
            this.boxState.Size = new System.Drawing.Size(130, 22);
            this.boxState.TabIndex = 30;
            // 
            // boxZipCode
            // 
            this.boxZipCode.Location = new System.Drawing.Point(178, 397);
            this.boxZipCode.Name = "boxZipCode";
            this.boxZipCode.Size = new System.Drawing.Size(181, 22);
            this.boxZipCode.TabIndex = 29;
            // 
            // boxCountry
            // 
            this.boxCountry.Location = new System.Drawing.Point(178, 449);
            this.boxCountry.Name = "boxCountry";
            this.boxCountry.Size = new System.Drawing.Size(181, 22);
            this.boxCountry.TabIndex = 28;
            // 
            // boxCreditCardBalance
            // 
            this.boxCreditCardBalance.Location = new System.Drawing.Point(178, 530);
            this.boxCreditCardBalance.Name = "boxCreditCardBalance";
            this.boxCreditCardBalance.Size = new System.Drawing.Size(181, 22);
            this.boxCreditCardBalance.TabIndex = 27;
            // 
            // boxActivationStatus
            // 
            this.boxActivationStatus.Location = new System.Drawing.Point(178, 569);
            this.boxActivationStatus.Name = "boxActivationStatus";
            this.boxActivationStatus.Size = new System.Drawing.Size(181, 22);
            this.boxActivationStatus.TabIndex = 26;
            // 
            // boxCreditCardLimit
            // 
            this.boxCreditCardLimit.Location = new System.Drawing.Point(178, 492);
            this.boxCreditCardLimit.Name = "boxCreditCardLimit";
            this.boxCreditCardLimit.Size = new System.Drawing.Size(181, 22);
            this.boxCreditCardLimit.TabIndex = 25;
            // 
            // boxAdressLine2
            // 
            this.boxAdressLine2.Location = new System.Drawing.Point(178, 278);
            this.boxAdressLine2.Name = "boxAdressLine2";
            this.boxAdressLine2.Size = new System.Drawing.Size(228, 22);
            this.boxAdressLine2.TabIndex = 24;
            // 
            // boxAdressLine1
            // 
            this.boxAdressLine1.Location = new System.Drawing.Point(178, 240);
            this.boxAdressLine1.Name = "boxAdressLine1";
            this.boxAdressLine1.Size = new System.Drawing.Size(228, 22);
            this.boxAdressLine1.TabIndex = 23;
            // 
            // boxExp
            // 
            this.boxExp.Location = new System.Drawing.Point(178, 199);
            this.boxExp.Name = "boxExp";
            this.boxExp.Size = new System.Drawing.Size(181, 22);
            this.boxExp.TabIndex = 22;
            // 
            // txtBoxMerchantName
            // 
            this.txtBoxMerchantName.Location = new System.Drawing.Point(178, 166);
            this.txtBoxMerchantName.Name = "txtBoxMerchantName";
            this.txtBoxMerchantName.Size = new System.Drawing.Size(181, 22);
            this.txtBoxMerchantName.TabIndex = 21;
            // 
            // txtBoxCardCompany
            // 
            this.txtBoxCardCompany.Location = new System.Drawing.Point(178, 131);
            this.txtBoxCardCompany.Name = "txtBoxCardCompany";
            this.txtBoxCardCompany.Size = new System.Drawing.Size(181, 22);
            this.txtBoxCardCompany.TabIndex = 20;
            // 
            // txtBoxCardName
            // 
            this.txtBoxCardName.Location = new System.Drawing.Point(178, 96);
            this.txtBoxCardName.Name = "txtBoxCardName";
            this.txtBoxCardName.Size = new System.Drawing.Size(181, 22);
            this.txtBoxCardName.TabIndex = 19;
            // 
            // txtBoxCardNumber1
            // 
            this.txtBoxCardNumber1.Location = new System.Drawing.Point(178, 59);
            this.txtBoxCardNumber1.Name = "txtBoxCardNumber1";
            this.txtBoxCardNumber1.Size = new System.Drawing.Size(181, 22);
            this.txtBoxCardNumber1.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 64);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(133, 17);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Credit Card Number";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Location = new System.Drawing.Point(6, 101);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(124, 17);
            this.lblTitle1.TabIndex = 17;
            this.lblTitle1.Text = "Card Owner Name";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Location = new System.Drawing.Point(6, 134);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(149, 17);
            this.lblTitle2.TabIndex = 16;
            this.lblTitle2.Text = "Card Issuing Company";
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Location = new System.Drawing.Point(6, 169);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(142, 17);
            this.lblTitle3.TabIndex = 15;
            this.lblTitle3.Text = "Card Merchant Name";
            // 
            // lblTitle4
            // 
            this.lblTitle4.AutoSize = true;
            this.lblTitle4.Location = new System.Drawing.Point(6, 204);
            this.lblTitle4.Name = "lblTitle4";
            this.lblTitle4.Size = new System.Drawing.Size(104, 17);
            this.lblTitle4.TabIndex = 14;
            this.lblTitle4.Text = "Expiration Date";
            // 
            // lblTitle5
            // 
            this.lblTitle5.AutoSize = true;
            this.lblTitle5.Location = new System.Drawing.Point(6, 245);
            this.lblTitle5.Name = "lblTitle5";
            this.lblTitle5.Size = new System.Drawing.Size(103, 17);
            this.lblTitle5.TabIndex = 13;
            this.lblTitle5.Text = "Address Line 1";
            // 
            // lblTitle12
            // 
            this.lblTitle12.AutoSize = true;
            this.lblTitle12.Location = new System.Drawing.Point(6, 533);
            this.lblTitle12.Name = "lblTitle12";
            this.lblTitle12.Size = new System.Drawing.Size(133, 17);
            this.lblTitle12.TabIndex = 12;
            this.lblTitle12.Text = "Credit Limit Balance";
            // 
            // lblTitle11
            // 
            this.lblTitle11.AutoSize = true;
            this.lblTitle11.Location = new System.Drawing.Point(6, 497);
            this.lblTitle11.Name = "lblTitle11";
            this.lblTitle11.Size = new System.Drawing.Size(112, 17);
            this.lblTitle11.TabIndex = 11;
            this.lblTitle11.Text = "Credit Card Limit";
            // 
            // lblTitle10
            // 
            this.lblTitle10.AutoSize = true;
            this.lblTitle10.Location = new System.Drawing.Point(6, 449);
            this.lblTitle10.Name = "lblTitle10";
            this.lblTitle10.Size = new System.Drawing.Size(57, 17);
            this.lblTitle10.TabIndex = 10;
            this.lblTitle10.Text = "Country";
            // 
            // lblTitle9
            // 
            this.lblTitle9.AutoSize = true;
            this.lblTitle9.Location = new System.Drawing.Point(6, 402);
            this.lblTitle9.Name = "lblTitle9";
            this.lblTitle9.Size = new System.Drawing.Size(65, 17);
            this.lblTitle9.TabIndex = 9;
            this.lblTitle9.Text = "Zip Code";
            // 
            // lblTitle8
            // 
            this.lblTitle8.AutoSize = true;
            this.lblTitle8.Location = new System.Drawing.Point(6, 359);
            this.lblTitle8.Name = "lblTitle8";
            this.lblTitle8.Size = new System.Drawing.Size(41, 17);
            this.lblTitle8.TabIndex = 8;
            this.lblTitle8.Text = "State";
            // 
            // lblTitle7
            // 
            this.lblTitle7.AutoSize = true;
            this.lblTitle7.Location = new System.Drawing.Point(6, 315);
            this.lblTitle7.Name = "lblTitle7";
            this.lblTitle7.Size = new System.Drawing.Size(31, 17);
            this.lblTitle7.TabIndex = 7;
            this.lblTitle7.Text = "City";
            // 
            // lblTitle6
            // 
            this.lblTitle6.AutoSize = true;
            this.lblTitle6.Location = new System.Drawing.Point(6, 281);
            this.lblTitle6.Name = "lblTitle6";
            this.lblTitle6.Size = new System.Drawing.Size(103, 17);
            this.lblTitle6.TabIndex = 6;
            this.lblTitle6.Text = "Address Line 2";
            // 
            // lblTitle13
            // 
            this.lblTitle13.AutoSize = true;
            this.lblTitle13.Location = new System.Drawing.Point(6, 574);
            this.lblTitle13.Name = "lblTitle13";
            this.lblTitle13.Size = new System.Drawing.Size(113, 17);
            this.lblTitle13.TabIndex = 5;
            this.lblTitle13.Text = "Activation Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Credit Card information:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Plum;
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Location = new System.Drawing.Point(453, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 603);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.LightPink;
            this.btnPrint.Location = new System.Drawing.Point(65, 73);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(107, 30);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(190, 17);
            this.label18.TabIndex = 19;
            this.label18.Text = "Print Credit Card information:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Plum;
            this.groupBox4.Controls.Add(this.btnExit);
            this.groupBox4.Location = new System.Drawing.Point(14, 805);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(666, 59);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightPink;
            this.btnExit.Location = new System.Drawing.Point(504, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCreditCardSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(692, 876);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iblTitle);
            this.Name = "frmCreditCardSearchForm";
            this.Text = "Credit Card Search";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label iblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBoxCardNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Label lblTitle4;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox boxCreditCardLimit;
        private System.Windows.Forms.TextBox boxAdressLine2;
        private System.Windows.Forms.TextBox boxAdressLine1;
        private System.Windows.Forms.TextBox boxExp;
        private System.Windows.Forms.TextBox txtBoxMerchantName;
        private System.Windows.Forms.TextBox txtBoxCardCompany;
        private System.Windows.Forms.TextBox txtBoxCardName;
        private System.Windows.Forms.TextBox txtBoxCardNumber1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox boxCity;
        private System.Windows.Forms.TextBox boxState;
        private System.Windows.Forms.TextBox boxZipCode;
        private System.Windows.Forms.TextBox boxCountry;
        private System.Windows.Forms.TextBox boxCreditCardBalance;
        private System.Windows.Forms.TextBox boxActivationStatus;
    }
}