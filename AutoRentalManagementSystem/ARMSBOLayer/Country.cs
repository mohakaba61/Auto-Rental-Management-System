using ARMSDALayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMSBOLayer
{
    public class Country
    {
        public int CountryID { get; set; }
        public string CountryCode2Char { get; set; }
        public string CountryCode3Char { get; set; }
        public string CountryName { get; set; }

        public Country()
        {
            this.CountryID = 0;
            this.CountryCode2Char = "";
            this.CountryCode3Char = "";
            this.CountryName = "";
        }
        public Country(int countryID, string code2Char, string code3Char, string countryName)
        {
            this.CountryID = countryID;
            this.CountryCode2Char = code2Char;
            this.CountryCode3Char = code3Char;
            this.CountryName = countryName;
        }
        ~Country()
        {

        }

        public void Print()
        {
            StreamWriter sw = new StreamWriter("Network_Printer.txt");
            sw.WriteLine(" Country ID={0}", CountryID);
            sw.WriteLine("Country Code 2 Character={0}", CountryCode2Char);
            sw.WriteLine("Country Code 3 Character={0}", CountryCode3Char);
            sw.WriteLine("Country Name={0}", CountryName);
            sw.WriteLine();
            sw.WriteLine();
            sw.Close();

        }

        public static List<Country> GetAllCountries()
        {
            return DALayer_GetAllCountries();
        }

        private static List<Country> DALayer_GetAllCountries()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory Base Class POINTER to get the SQL Server FACTORY 
                //Data Access Object using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the SQL FACTORY object GET DAO object to do the work
                CountryDAO objCountryDAO = objDAOFactory.GetCountryDAO();

                //Step 3-call CreditCardMerchantDAO DAO to do the work & return COLLECTION of Data Transfer Objects
                List<CountryDTO> objCountryDTOList = objCountryDAO.GetAllRecords();

                //Step 4- test if the List<objDTO> was returned from database 
                if (objCountryDTOList != null)
                {
                    //Step 5-Create a LIST Collection of CreditCardMerchant objects to populate with 
                    //the data from each DTO Object in of DTO collection
                    List<Country> objCountryList = new List<Country>();

                    //Step 6-Loop through List<CreditCardMerchantDTO> objCreditCardDTOList collection
                    foreach (CountryDTO objDTO in objCountryDTOList)
                    {
                        //Step 6a-Create new CreditCard object
                        Country objCountry = new Country();
                        //Step 6b-get the data from DTO object and SET CreditCard object

                        objCountry.CountryID = objDTO.CountryID;
                        objCountry.CountryCode2Char = objDTO.CountryCode2Char;
                        objCountry.CountryCode3Char = objDTO.CountryCode3Char;
                        objCountry.CountryName = objDTO.CountryName;


                        //Step 6c-Add CreditCard Object to the objCreditCardList List<CreditCard> COLLECTION 
                        objCountryList.Add(objCountry);
                    }//End of foreach
                     //Step 6d-once copy process ends, Return objCreditCardList List<CreditCard> COLLECTION
                    return objCountryList;
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
        }
        }
}
