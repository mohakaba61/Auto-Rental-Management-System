using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using ARMSDALayer;

namespace ARMSBOLayer
{
  public  class CreditCardMerchant
    {
        public byte MerchantCode { get; set; }
        public string MerchantName { get; set; }

        public CreditCardMerchant()
        {
            MerchantCode = 0;
            MerchantName = "";
        }

        public CreditCardMerchant(byte merchantCode, string merchantName)
        {
            this.MerchantName = merchantName;
            this.MerchantCode = merchantCode;
        }

        ~CreditCardMerchant()
        {

        }

        public void print()
        {
            StreamWriter sw = new StreamWriter("Network_Printer.txt", true);

            sw.WriteLine("Merchant Code={0}", MerchantCode);
            sw.WriteLine("Merchant Name={0}", MerchantName);


        }
        public static List<CreditCardMerchant> GetAllCreditCardMerchants()
        {
            return DALayer_GetAllCreditCardMerchants();
        }

        //=================================================================
        //Name:         DALayer_GetAllCreditCardMerchants() Method
        //Purpose:      Method that CALLS the Data Access Layer services to
        //              do the work and query the database and return a  
        //              LIST COLLECTION with all the CreditCard records data 
        //              via a light-weight DATA TRANSFER OBJECTS(DTO),
        //Algorithm:    Calls the Data Access Layer to do the work
        //Parameter:    None.
        //Return Value: A LIST COLLECTION containing Data Transfer Objects. Each DTO contain 
        //              a row from the customer table.
        protected static List<CreditCardMerchant> DALayer_GetAllCreditCardMerchants()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory Base Class POINTER to get the SQL Server FACTORY 
                //Data Access Object using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the SQL FACTORY object GET DAO object to do the work
                CreditCardMerchantDAO objCreditCardMerchantDAO = objDAOFactory.GetCreditCardMerchantDAO();

                //Step 3-call CreditCardMerchantDAO DAO to do the work & return COLLECTION of Data Transfer Objects
                List<CreditCardMerchantDTO> objCreditCardMerchantDTOList = objCreditCardMerchantDAO.GetAllRecords();

                //Step 4- test if the List<objDTO> was returned from database 
                if (objCreditCardMerchantDTOList != null)
                {
                    //Step 5-Create a LIST Collection of CreditCardMerchant objects to populate with 
                    //the data from each DTO Object in of DTO collection
                    List<CreditCardMerchant> objCreditCardMerchantList = new List<CreditCardMerchant>();

                    //Step 6-Loop through List<CreditCardMerchantDTO> objCreditCardDTOList collection
                    foreach (CreditCardMerchantDTO objDTO in objCreditCardMerchantDTOList)
                    {
                        //Step 6a-Create new CreditCard object
                        CreditCardMerchant objCreditCardMerchant = new CreditCardMerchant();
                        //Step 6b-get the data from DTO object and SET CreditCard object

                        objCreditCardMerchant.MerchantCode = objDTO.MerchantCode;
                        objCreditCardMerchant.MerchantName = objDTO.MerchantName;


                        //Step 6c-Add CreditCard Object to the objCreditCardList List<CreditCard> COLLECTION 
                        objCreditCardMerchantList.Add(objCreditCardMerchant);
                    }//End of foreach
                     //Step 6d-once copy process ends, Return objCreditCardList List<CreditCard> COLLECTION
                    return objCreditCardMerchantList;
                }//End of if
                else
                {
                    //Step 6e- No DTO collection object returned from DALayer, return a null
                    return null;
                }
            }//End of try
             //Step B-Traps for general exception. 
            catch (Exception objE)
            {
                //Step C-Re-Throw a general exceptions
                throw new Exception("Unexpected Error in DALayer_GetAllCreditCardMerchants(key) Method: {0} " +
                objE.Message);
            }
        }//End of method





    }

}
