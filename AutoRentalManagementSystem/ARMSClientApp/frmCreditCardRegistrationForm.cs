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
    public partial class frmCreditCardRegistrationForm : Form
    {
        public frmCreditCardRegistrationForm()
        {
            InitializeComponent();
        }

        private void frmCreditCardRegistrationForm_Load(object sender, EventArgs e)
        {
            //BINDING cbCreditCardMerchant ComboBox to the CreditCardMerchant Class GetAllCreditCardMerchants Static Method
            cbCreditCardMerchantName.DataSource = CreditCardMerchant.GetAllCreditCardMerchants();

            //Set DisplayMember property to indicate which property gets displayed on the combobox
            //Set ValueMember Property to indicate which property to get data from in the code
            cbCreditCardMerchantName.DisplayMember = "MerchantName";
            cbCreditCardMerchantName.ValueMember = "MerchantCode";      //in this case we return the Merchant code

            //BINDING State ComboBox to the USState Class GetAllUSStates Static Method
            cbStateCode.DataSource = USState.GetAllUSStates();

            //Set DisplayMember property to indicate which property gets displayed on the combobox
            //Set ValueMember Property to indicate which property to get data from in the code
            cbStateCode.DisplayMember = "StateName";
            cbStateCode.ValueMember = "StateCode";           //in this case we return the state code

            //BINDING Country ComboBox to the Country Class GetAllCountry Static Method
            cbCountry.DataSource = Country.GetAllCountries();

            //Set DisplayMember property to indicate which property gets displayed on the combobox
            //Set ValueMember Property to indicate which property is GOTTEN to used in the code
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryName";        //in this case we return the country name

            //Initialized Credit Card Limit & Credit Card Balance Text boxes
            //Create Default object & set text boxes with properties from object
            CreditCard objCreditCard = new CreditCard();
            boxCreditCardBalance.Text = Convert.ToString(objCreditCard.CreditCardLimit); ;
            boxCreditCardLimit.Text = Convert.ToString(objCreditCard.CreditCardBalance);

            //Programmatically set the properties to the Activation Status Combo Box
            //and ADD the activated and deactivated items to the Combo Box
            cbAtivationStatus.Items.Add("Activate");
            cbAtivationStatus.Items.Add("Deactivate");

            //SET SELECTED TEXT Property to populate the ActivationStatus ComboBox to Activated
            cbAtivationStatus.SelectedText = "Activate";


            //Other Code needed inside the Form_Loa()Event Handler

        }//End of Event-Handler




        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Close this form
            //program flow automatically goes back to Main Form
            //which opened this form aa a dialog form.
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //Step A - start Excption handling
            try
            {
                //Step1 - Create a Credit Card Object
                CreditCard objCreditCard = new CreditCard();
                //Set Object with parameters values
                objCreditCard.CreditCardNumber = txtBoxCardNumber.Text;
                objCreditCard.CreditCardOwnerName = txtBoxCardName.Text;
                objCreditCard.CreditCardIssuingCompany = txtBoxCardCompany.Text;
                objCreditCard.MerchantCode = Convert.ToByte(cbCreditCardMerchantName.SelectedValue);



                objCreditCard.ExpDate = dptExpDate.Value;
                objCreditCard.AddressLine1 = boxAdressLine1.Text;
                objCreditCard.AddressLine2 = boxAdressLine2.Text;
                objCreditCard.City = boxCity.Text;
                objCreditCard.StateCode = cbStateCode.SelectedValue.ToString();
                objCreditCard.ZipCode = boxZipCode.Text;
                objCreditCard.Country = cbCountry.SelectedValue.ToString();
                objCreditCard.CreditCardLimit = Convert.ToDecimal(boxCreditCardLimit.Text);
                objCreditCard.CreditCardBalance = Convert.ToDecimal(boxCreditCardBalance.Text);
                //        objCreditCard.ActivationStatus = cbAtivationStatus.Text.Trim();


                //The CreditCard ActivationStatus property is READ-ONLY and you CANNOT SET IT. Therefor you need

                //To call the CreditCard Class Activate() or Deactive method depending what is selected in the ActivationStatus Combobox.

                //This means you need to FIRST extract the value from the ActivationStatus Combobox and then TEST that value and

                //decide whether to call CreditCard Class Activate() or Deactive method.

                //Create a string variable to host the value of the item selected in the ActivationStatus ComboBox.

                //In this case, I DID NOT SET the Selected Value Member, therefore to Extract the selected Activation Status in the list,

                //you need to use the combobox SelectedItem method and converting it to a string to assign it to the string just created.

                //The SelectedItem property also has a ToString() method that will do the work. To do this call the

                //GET the SelectedItem Property and using DOT operation, call the ToString() method as follows:  CBactstatus.SelectedItem.ToString():

                string activationStatus = cbAtivationStatus.SelectedItem.ToString();

                if (activationStatus == "Activate")

                {
                    objCreditCard.Activate();
                }
                else
                {
                    objCreditCard.Deactivate();
                }
                //Create a boolean variable to store the results of

                //callint the object's INSERT() method to go do the work of inserting to database.

                bool results = objCreditCard.Insert();

                if (results)
                {
                    MessageBox.Show("Credit Card succesfully inserted");
                }

                else
                {
                    MessageBox.Show("Unexpected error, please contact administrator");
                }
            }//End of Try

            catch (Exception objE)

            {
                MessageBox.Show("Unexpected error, please contact administrator " + objE);
                
            }
            
        }
    }

}