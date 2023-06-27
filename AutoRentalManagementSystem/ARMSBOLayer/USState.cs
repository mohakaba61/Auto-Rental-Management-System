using ARMSDALayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMSBOLayer
{
    public class USState
    {
        public byte StateID { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }


        public USState()
        {

            this.StateID = 0;
            this.StateCode = "";
            this.StateName = "";
        }
        public USState(byte stateID, string stateCode, string stateName)
        {
            this.StateID = stateID;
            this.StateCode = stateCode;
            this.StateName = stateName;
        }
        ~USState()
        {

        }
        public void Print()
        {
            StreamWriter sw = new StreamWriter("Network_Printer.txt");
            sw.WriteLine("US State ID={0}", StateID);
            sw.WriteLine("US State Code={0}", StateCode);
            sw.WriteLine("US State Name={0}", StateName);
            sw.WriteLine();
            sw.WriteLine();
            sw.Close();

        }
        public static List<USState> GetAllUSStates()
        {
            return DALayer_GetAllUSStates();
        }
        private static List<USState> DALayer_GetAllUSStates()
        {

            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory Base Class POINTER to get the SQL Server FACTORY 
                //Data Access Object using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the SQL FACTORY object GET DAO object to do the work
                USStateDAO objUSStateDAO = objDAOFactory.GetUSStateDAO();

                //Step 3-call CreditCardMerchantDAO DAO to do the work & return COLLECTION of Data Transfer Objects
                List<USStateDTO> objUSStateDTOList = objUSStateDAO.GetAllRecords();

                //Step 4- test if the List<objDTO> was returned from database 
                if (objUSStateDTOList != null)
                {
                    //Step 5-Create a LIST Collection of CreditCardMerchant objects to populate with 
                    //the data from each DTO Object in of DTO collection
                    List<USState> objUSStateList = new List<USState>();

                    //Step 6-Loop through List<CreditCardMerchantDTO> objCreditCardDTOList collection
                    foreach (USStateDTO objDTO in objUSStateDTOList)
                    {
                        //Step 6a-Create new CreditCard object
                        USState objUSState = new USState();
                        //Step 6b-get the data from DTO object and SET CreditCard object

                        objUSState.StateID = objDTO.StateID;
                        objUSState.StateCode = objDTO.StateCode;
                        objUSState.StateName = objDTO.StateName;


                        //Step 6c-Add CreditCard Object to the objCreditCardList List<CreditCard> COLLECTION 
                        objUSStateList.Add(objUSState);
                    }//End of foreach
                     //Step 6d-once copy process ends, Return objCreditCardList List<CreditCard> COLLECTION
                    return objUSStateList;
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
                throw new Exception("Unexpected Error in DALayer_GetAllUSState(key) Method: {0} " +
                objE.Message);
            }
        }//End of method




  
    }
}
