using ARMSBOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMSClientApp
{
    public partial class frmCreditCardSearchForm : Form
    {
         CreditCard objCreditCard;
        public frmCreditCardSearchForm()
        {
            InitializeComponent();
        }

        private void iblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close this form
            //program flow automatically goes back to Main Form
            //which opened this form aa a dialog form.
            this.Close();
        }

        /***********************************************************************/
        //Name: Search() Event-handler
        //Purpose: User enter’s ID in ID Number textbox
        // Calls objCreditCard.Load(ID) method to get data from database
        // if customer found, data is displayed on form
        // if customer not found, user is prompted

        private void btnSearch_Click(object sender, EventArgs e)
        {

            //Step A - start Excption handling
            try
            {
                //Step1 - Create a Credit Card Object
                objCreditCard = new CreditCard();
                //Call Customer Object Load(ID) method to execute SELECT query
                //to the database and populate itself with the record returned
                //from the query
                bool success = objCreditCard.Load(txtBoxCardNumber.Text.Trim());
                //Step 2-If validate customer is found
                if (success)
                {
                    //Step 3-Then Data is extracted from customer object & placed on textboxes
                    txtBoxCardNumber1.Text = objCreditCard.CreditCardNumber;
                    txtBoxCardName.Text = objCreditCard.CreditCardOwnerName;
                    txtBoxCardCompany.Text = objCreditCard.CreditCardIssuingCompany;
                    txtBoxMerchantName.Text = objCreditCard.MerchantName;
                    boxExp.Text = objCreditCard.ExpDate.ToString(); 
                    boxAdressLine1.Text = objCreditCard.AddressLine1;
                    boxAdressLine2.Text = objCreditCard.AddressLine2;
                    boxCity.Text = objCreditCard.City;
                    boxState.Text = objCreditCard.StateCode;
                    boxZipCode.Text = objCreditCard.ZipCode;
                    boxCountry.Text = objCreditCard.Country;
                    boxCreditCardLimit.Text = objCreditCard.CreditCardLimit.ToString();
                    boxCreditCardBalance.Text = objCreditCard.CreditCardBalance.ToString();
                    boxActivationStatus.Text = objCreditCard.ActivationStatus.ToString();

                }
                else
                {
                    //Step 4-prompt user customer not found
                    MessageBox.Show("Credit Card Not Found");
                    //Step 5-Clear all controls
                    txtBoxCardNumber1.Text = "";
                    txtBoxCardName.Text = "";
                    txtBoxCardCompany.Text = "";
                    txtBoxMerchantName.Text = "";
                    boxExp.Text = "";
                    boxAdressLine1.Text = "";
                    boxAdressLine2.Text = "";
                    boxCity.Text = "";
                    boxState.Text = "";
                    boxZipCode.Text = "";
                    boxCountry.Text = "";
                    boxCreditCardLimit.Text = "";
                    boxCreditCardBalance.Text = "";
                    boxActivationStatus.Text = "";

                }
            }//End of try

         catch (System.Exception)
                {
                    //Step C- throw system exception since run time error has occured;
                    MessageBox.Show("Error in search!");
                }

            }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            objCreditCard.Print();
        }
    }
}
