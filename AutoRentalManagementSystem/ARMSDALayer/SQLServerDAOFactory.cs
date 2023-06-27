using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMSDALayer
{


    public class SQLServerDAOFactory : DALObjectFactoryBase
    {

        /***********************************************************************/
        //Name:         ConnectionString() Method
        //Purpose:      Centralized method that returns the Connection String that contains 
        //              the required Database Server information for connecting to 
        //              MS SQL Server data access.
        //Parameter:    None.
        //Return Value: string that contains the connection string.

        public static string ConnectionString()
        {
            return "Data Source =.\\SQLExpress; Initial Catalog = EZRentalDB; Integrated Security = True";

        }

        /***********************************************************************/
        //Name:         GetCreditCardDAO() Method
        //Purpose:      Method that returns the CreditCardDAO Data Access Object 
        //              that handles the data access for the CreditCard 
        //              class in the business object Layer.
        //Parameter:    None.
        //Return Value: a new CreditCardDAO object.
        public override CreditCardDAO GetCreditCardDAO()
        {
            //return CreditCardDAO Data Access Object to perform CreditCard class Data Access
            return new CreditCardDAO();

        }

        /***********************************************************************/
        //Name:         GetCreditCardMerchantDAO() Method
        //Purpose:      Method that returns the CreditCardMerchantDAO Data Access Object 
        //              that handles the data access for the CreditCardMerchant 
        //              class in the business object Layer.
        //Parameter:    None.
        //Return Value: a new CreditCardMerchantDAO object.
        public override CreditCardMerchantDAO GetCreditCardMerchantDAO()
        {
            //return CreditCardMerchantDAO Data Access Object to perform CreditCardMerchant class
            //Data Access
            return new CreditCardMerchantDAO();

        }


        /***********************************************************************/
        //Name:         GetUSStateDAO() Method
        //Purpose:      Method that returns the USStateDAO Data Access Object 
        //              that handles the data access for the USState 
        //              class in the business object Layer.
        //Parameter:    None.
        //Return Value: a new USStateDAO object.
        public override USStateDAO GetUSStateDAO()
        {
            //return USStateDAO Data Access Object to perform USState class Data Access
            return new USStateDAO();

        }


        /***********************************************************************/
        //Name:         GetCountryDAO() Method
        //Purpose:      Method that returns the CountryDAO Data Access Object 
        //              that handles the data access for the Country 
        //              class in the business object Layer.
        //Parameter:    None.
        //Return Value: a new CountryDAO object.
        public override CountryDAO GetCountryDAO()
        {
            //return CountryDAO Data Access Object to perform Country class Data Access
            return new CountryDAO();

        }



    }//End of class


}
