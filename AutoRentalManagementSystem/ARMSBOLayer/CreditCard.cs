

using ARMSDALayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ARMSBOLayer
{

    public class CreditCard
    {
        //private data members
        private string m_CreditCardNumer, m_CreditCardOwnerName, m_CreditCardIssuingCompany;
        private byte m_MerchantCode;
        private string m_MerchantName;
        private DateTime m_ExpDate;
        private string m_AddressLine1, m_AddressLine2, m_City, m_State, m_ZipCode, m_Country;
        private decimal m_CreditCardLimit, m_CreditCardBalance;
        private bool m_ActivationStatus;

        //public properties:

        public string CreditCardNumber
        {
            get { return m_CreditCardNumer; }
            set { m_CreditCardNumer = value; }
        }
        public string CreditCardOwnerName
        {
            get { return m_CreditCardOwnerName; }
            set { m_CreditCardOwnerName = value; }
        }
        public string CreditCardIssuingCompany
        {
            get { return m_CreditCardIssuingCompany; }
            set { m_CreditCardIssuingCompany = value; }
        }
        public byte MerchantCode
        {
            get { return m_MerchantCode; }
            set { m_MerchantCode = value; }
        }

        public string MerchantName
        {
            get { return m_MerchantName; }
            set { m_MerchantName = value; }
        }

        public DateTime ExpDate
        {
            get { return m_ExpDate; }
            set { m_ExpDate = value; }
        }
        public string AddressLine1
        {
            get { return m_AddressLine1; }
            set { m_AddressLine1 = value; }
        }
        public string AddressLine2
        {
            get { return m_AddressLine2; }
            set { m_AddressLine2 = value; }
        }
        public string City
        {
            get { return m_City; }
            set { m_City = value; }
        }
        public string StateCode
        {
            get { return m_State; }
            set { m_State = value; }
        }
        public string ZipCode
        {
            get { return m_ZipCode; }
            set { m_ZipCode = value; }
        }
        public string Country
        {
            get { return m_Country; }
            set { m_Country = value; }
        }
        public decimal CreditCardLimit
        {
            get { return m_CreditCardLimit; }
            set { m_CreditCardLimit = value; }
        }
        public decimal CreditCardBalance
        {
            get { return m_CreditCardBalance; }
            set { m_CreditCardBalance = value; }
        }
        public bool ActivationStatus
        {
            get { return m_ActivationStatus; }
            set { m_ActivationStatus = value; }
        }

        public CreditCard()
        {
            m_CreditCardNumer = " ";
            m_CreditCardOwnerName = " ";
            m_CreditCardIssuingCompany = " ";
            m_MerchantCode = 0;
            m_MerchantName = " ";
            m_ExpDate = new DateTime().Date;
            m_AddressLine1 = " ";
            m_AddressLine2 = " ";
            m_City = " ";
            m_State = " ";
            m_ZipCode = " ";
            m_Country = " ";
            m_CreditCardLimit = 3000.0M;
            m_CreditCardBalance = 3000.0M;
            m_ActivationStatus = true;

        }

        public CreditCard(string CardNumber, string CardOwnerName, string CardIssuingCompany, byte merchantCode,
             string merchantName, string expDate, string addressLine1, string addressLine2, string city, string state,
                 string zipCode, string country)
        {

            this.m_CreditCardNumer = CardNumber;
            this.m_CreditCardOwnerName = CardOwnerName;
           this.m_CreditCardIssuingCompany = CardIssuingCompany;
          this.  m_MerchantCode = merchantCode;
            this.m_MerchantName = merchantName;
            this.m_ExpDate = DateTime.Parse(expDate);
            this.m_AddressLine1 = addressLine1;
            this.m_AddressLine2 = addressLine2;
            this.m_City = city;
            this.m_State = state;
            this.m_ZipCode = zipCode;
            this.m_Country = country;
            m_CreditCardLimit = 3000.0M;
            m_CreditCardBalance = 3000.0M;
            m_ActivationStatus = true;

        }

        ~CreditCard()
        {

        }

        public void Print()
        {
            StreamWriter sw = new StreamWriter("Network_Printer.txt", true);
            sw.WriteLine("Credit Card information: ");
            sw.WriteLine("Credit Card Number={0}", m_CreditCardNumer);
            sw.WriteLine("Credit Card Owner Name={0}", m_CreditCardOwnerName);
            sw.WriteLine("Credit Card Issuing Compagny={0}", m_CreditCardIssuingCompany);
            sw.WriteLine("Merchant Code={0}", m_MerchantCode);
            sw.WriteLine("Merchant Name={0}", m_MerchantName);
            sw.WriteLine("Expiration Date={0}", m_ExpDate);
            sw.WriteLine("AddressLine1={0}", m_AddressLine1);
            sw.WriteLine("AddressLine2={0}", m_AddressLine2);
            sw.WriteLine("City={0}", m_City);
            sw.WriteLine("State code={0}", m_State);
            sw.WriteLine("Zip Code={0}", m_ZipCode);
            sw.WriteLine("Country={0}", m_Country);
            sw.WriteLine("Credit Card Limit={0}", m_CreditCardLimit);
            sw.WriteLine("Credit Card Balance={0}", m_CreditCardBalance);
            sw.WriteLine("Activation Status={0}", m_ActivationStatus);

            sw.WriteLine();
            sw.WriteLine();
            sw.Close();

        }
        public bool Activate()
        {
            m_ActivationStatus = true;
            return m_ActivationStatus;
        }
        public bool Deactivate()
        {
            m_ActivationStatus = false;
            return m_ActivationStatus;
        }

        /***********************************************************************/
        //Name: Load(key) Method
        //Purpose: Public Data Access Method that starts the loading of this
        // object's data from database.
        //Algorithm: Step1 - calls PROTECTED DALayer_Load(key) method to
        // perform the data access by calling Data Access Layer services
        // to do the work and query the database.
        //Parameter: The key or ID of the object to load.
        //Return Value: Boolean true if found and retrieved from database, false
        // otherwise.
        public bool Load(string key)
        {
            //Step 1 - Calls DALayer_Load(key) method to do the work
            return DALayer_Load(key);
        }
        /***********************************************************************/
        //Name: Insert() Method
        //Purpose: Public Data Access Method that starts the inserting of this
        // object's data to Credit Card database table.
        //Algorithm: Step 1-Calls PROTECTED DALayer_Insert() method to perform
        // the data access by calling Data Access Layer services
        // to do the work and insert to the database.
        //Parameter: None
        //Return Value: Boolean true if success, false otherwise.
        public bool Insert()
        {
            //Step 1 - Calls DALayer_Inser() method to do the work
            return DALayer_Insert();
        }


        /***********************************************************************/
        //Name: Update() Method
        //Purpose: Public Data Access Method that starts the update of this
        // object's data to database.
        //Algorithm: Step 1-Calls PROTECTED DALayer_Update() method to perform
        // the data access by calling Data Access Layer services
        // to do the work and query the database.
        //Parameter: None
        //Return Value: Boolean true if success, false otherwise.
        public bool Update()
        {
            //Step 1 - Calls DALayer_Update(key) method to do the work
            return DALayer_Update();
        }

        /***********************************************************************/
        //Name: Delete(key) Method
        //Purpose: Public Data Access Method that starts the deleting of
        // record in database whose key is passed as parameter.
        //Algorithm: Step 1-Calls PROTECTED DALayer_Delete(key) method to perform
        // the data access by calling Data Access Layer services
        // to do the work and delete the record in the database.
        //Parameter: The key or ID of the object to load.
        //Return Value: Boolean true if success, false otherwise.
        public bool Delete(string key)
        {
            //Step 1 - Calls DALayer_Delete(key) method to do the work
            return DALayer_Delete(key);
        }


        /***********************************************************************/
        //Name: STATIC GetAllCreditCards() Method
        //Purpose: Public STATIC Data Access Method that starts the fetching of
        // all the creditcards from the data to database.
        //Algorithm: Step 1-Calls PROTECTED DALayer_GetAllCreditCards() method to
        // performthe data access by calling Data Access Layer services
        // to do the work and query the database and return a
        // LIST COLLECTION of of all the CreditCards in the Credit Card
        // database table.
        //Parameter: None.
        //Return Value: LIST COLLECTION with all the customer records.
        public static List<CreditCard> GetAllCreditCards()
        {
            return DALayer_GetAllCreditCards();

        }



        //=================================================================
        //Name:        DALayer_Load(key) Method
        //Purpose:      Method that CALLS the Data Access Layer services 
        //              to do the work and query the database.
        //Algorithm:    Calls the Data Access Layer to do the work
        //Parameter:    The key or ID of the object to load.
        //Return Value: Boolean true if found and retrieved from database, false 
        //              otherwise.
        protected bool DALayer_Load(string key)
        {

            try
            {
                //Step 1-Use DAL object Factory Base Class POINTER to get the SQL Server FACTORY 
                //Data Access Object using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();

                //Call the CreditCardDAO Data Access Object to do the work 
                CreditCardDTO objDTO = objCreditCardDAO.GetRecordByID(key);

                //Check if DTO object exists & populate this objct with DTO object's properties
                if (objDTO != null)
                {
                    //Get the data from the Data Transfer Object
                    this.CreditCardNumber = objDTO.CreditCardNumber;
                    this.CreditCardOwnerName = objDTO.CreditCardOwnerName;
                    this.CreditCardIssuingCompany = objDTO.CreditCardIssuingCompany;
                    this.MerchantCode = objDTO.MerchantCode;
                    this.MerchantName = objDTO.MerchantName;
                    this.ExpDate = objDTO.ExpDate;
                    this.AddressLine1 = objDTO.AddressLine1;
                    this.AddressLine2 = objDTO.AddressLine2;
                    this.City = objDTO.City;
                    this.StateCode = objDTO.StateCode;
                    this.ZipCode = objDTO.ZipCode;
                    this.Country = objDTO.Country;
                    this.CreditCardLimit = objDTO.CreditCardLimit;
                    this.CreditCardBalance = objDTO.CreditCardBalance;


                    //Handle activation status
                    if (objDTO.ActivationStatus == true)
                        this.Activate();
                    else
                        this.Deactivate();
                    //since it has been populated, return true
                    return true;
                }
                else
                {
                    //if null or no object returned from DALayer, return false
                    return false;
                }
            }//End of try 
            catch (Exception objE)
            {
                //Rethrow general exceptions
                throw new Exception("Unexpected Error is DALayer_Load(key) Method: {0} " + objE.Message);
            }
        }//End of method

        //=================================================================
        //Name:        DALayer_Insert() Method
        //Purpose:      Method that CALLS the Data Access Layer services 
        //              to do the work of INSERTING record to the database.
        //Algorithm:    Calls the Data Access Layer to do the work
        //Parameter:    None.
        //Return Value: Boolean true if record inserted, false otherwise.
        protected bool DALayer_Insert()
        {
            try
            {
                //Step 1-Use DAL object Factory Base Class POINTER to get the SQL Server FACTORY 
                //Data Access Object using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();

                //Call the CreditCardDAO Data Access Object to do the work 
                CreditCardDTO objDTO = new CreditCardDTO();

                //Populate the data transfer object with data from THIS object to send to database
                objDTO.CreditCardNumber = this.CreditCardNumber;
                objDTO.CreditCardOwnerName = this.CreditCardOwnerName;
                objDTO.CreditCardIssuingCompany = this.CreditCardIssuingCompany;
                objDTO.MerchantCode = this.MerchantCode;
                objDTO.MerchantName = this.MerchantName;
                objDTO.ExpDate = this.ExpDate;
                objDTO.AddressLine1 = this.AddressLine1;
                objDTO.AddressLine2 = this.AddressLine2;
                objDTO.City = this.City;
                objDTO.StateCode = this.StateCode;
                objDTO.ZipCode = this.ZipCode;
                objDTO.Country = this.Country;
                objDTO.CreditCardLimit = this.CreditCardLimit;
                objDTO.CreditCardBalance = this.CreditCardBalance;
                objDTO.ActivationStatus = this.ActivationStatus;

                //Call the CreditCardDAO Data Access Object to do the work
                bool inserted = objCreditCardDAO.Insert(objDTO);

                //Test if insert to database was successful return true
                if (inserted == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }//End of try
            catch (Exception objE)
            {
                //Rethrow general exceptions
                throw new Exception("Unexpected Error is DALayer_Insert() Method: {0} " + objE.Message);
            }
        }//End of Method


        //=================================================================
        //Name:        DALayer_Update() Method
        //Purpose:     Method that CALLS the Data Access Layer services to
        //             to do the work of UPDATING record to the database.
        //Algorithm:    Calls the Data Access Layer to do the work
        //Parameter:    None.
        //Return Value: Boolean true if record updated, false otherwise.
        protected bool DALayer_Update()
        {
            try
            {
                //Step 1-Use DAL object Factory Base Class POINTER to get the SQL Server FACTORY 
                //Data Access Object using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();

                //Call the CreditCardDAO Data Access Object to do the work 
                CreditCardDTO objDTO = new CreditCardDTO();

                //Populate the data transfer object with data from THIS object to send to database
                objDTO.CreditCardNumber = this.CreditCardNumber;
                objDTO.CreditCardOwnerName = this.CreditCardOwnerName;
                objDTO.CreditCardIssuingCompany = this.CreditCardIssuingCompany;
                objDTO.MerchantCode = this.MerchantCode;
                objDTO.MerchantName = this.MerchantName;
                objDTO.ExpDate = this.ExpDate;
                objDTO.AddressLine1 = this.AddressLine1;
                objDTO.AddressLine2 = this.AddressLine2;
                objDTO.City = this.City;
                objDTO.StateCode = this.StateCode;
                objDTO.ZipCode = this.ZipCode;
                objDTO.Country = this.Country;
                objDTO.CreditCardLimit = this.CreditCardLimit;
                objDTO.CreditCardBalance = this.CreditCardBalance;
                objDTO.ActivationStatus = this.ActivationStatus;

                //Call the CreditCardDAO data access object to do the work
                bool updated = objCreditCardDAO.Update(objDTO);

                //test if insert to the database was successful & MARK object as old return true
                if (updated == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }//End of try
            catch (Exception objE)
            {
                //Rethrow general exceptions
                throw new Exception("Unexpected Error is DALayer_Update() Method: {0} " + objE.Message);
            }
        }//End of Method

        //=================================================================
        //Name:        DALayer_Delete(key) Method
        //Purpose:      Method that CALLS the Data Access Layer services to 
        //              work of DELETING record from the database.
        //Algorithm:    Calls the Data Access Layer to do the work
        //Parameter:    key or ID of record in database.
        //Return Value: Boolean true if record deleted, false otherwise.
        protected bool DALayer_Delete(string key)
        {
            try
            {
                //Step 1-Use DAL object Factory Base Class POINTER to get the SQL Server FACTORY 
                //Data Access Object using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();

                //call the CreditCArdDAO data access object to do the work
                bool deleted = objCreditCardDAO.Delete(key);

                //test if delete to the database was successful & MARK object as old return true
                if (deleted == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }//End of try
            catch (Exception objE)
            {
                //Rethrow general exceptions
                throw new Exception("Unexpected Error is DALayer_Delete() Method: {0} " + objE.Message);
            }
        }//End of Method

        //=================================================================
        //Name:         DALayer_GetAllCreditCards() Method
        //Purpose:      Method that CALLS the Data Access Layer services to
        //              do the work and query the database and return a  
        //              LIST COLLECTION with all the CreditCard records data 
        //              via a light-weight DATA TRANSFER OBJECTS(DTO),
        //Algorithm:    Calls the Data Access Layer to do the work
        //Parameter:    None.
        //Return Value: A LIST COLLECTION containing Data Transfer Objects. Each DTO contain 
        //              a row from the customer table.
        protected static List<CreditCard> DALayer_GetAllCreditCards()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory Base Class POINTER to get the SQL Server FACTORY 
                //Data Access Object using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the SQL FACTORY object GET DAO object to do the work
                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();

                //Step 3-call CreditCardDAO DAO to do the work & return COLLECTION of Data Transfer Objects
                List<CreditCardDTO> objCreditCardDTOList = objCreditCardDAO.GetAllRecords();

                //Step 4- test if List<objDTO> DTO collection exists 
                if (objCreditCardDTOList != null)
                {
                    //Step 5-Create a LIST Collection of CreditCard object to get copy of DTO collection
                    List<CreditCard> objCreditCardList = new List<CreditCard>();

                    //Step 6-Loop through List<CreditCardDTO> objCreditCardDTOList collection
                    foreach (CreditCardDTO objDTO in objCreditCardDTOList)
                    {
                        //Step 6a-Create new CreditCard object
                        CreditCard objCreditCard = new CreditCard();
                        //Step 6b-get the data from DTO object and SET CreditCard object
                        objCreditCard.CreditCardNumber = objDTO.CreditCardNumber;
                        objCreditCard.CreditCardOwnerName = objDTO.CreditCardOwnerName;
                        objCreditCard.CreditCardOwnerName = objDTO.CreditCardIssuingCompany;
                        objCreditCard.MerchantCode = objDTO.MerchantCode;
                        objCreditCard.MerchantName = objDTO.MerchantName;
                        objCreditCard.ExpDate = objDTO.ExpDate;
                        objCreditCard.AddressLine1 = objDTO.AddressLine1;
                        objCreditCard.AddressLine2 = objDTO.AddressLine2;
                        objCreditCard.City = objDTO.City;
                        objCreditCard.StateCode = objDTO.StateCode;
                        objCreditCard.ZipCode = objDTO.ZipCode;
                        objCreditCard.Country = objDTO.Country;
                        objCreditCard.CreditCardLimit = objDTO.CreditCardLimit;
                        objCreditCard.CreditCardBalance = objDTO.CreditCardBalance;

                        //Handle activation status accordingly since ActivationStutus property is read only
                        if (objDTO.ActivationStatus == true)
                            objCreditCard.Activate();
                        else
                            objCreditCard.Deactivate();

                        //Step 6c-Add CreditCard Object to the objCreditCardList List<CreditCard> COLLECTION 
                        objCreditCardList.Add(objCreditCard);
                    }//End of foreach
                     //Step 6d-once copy process ends, Return objCreditCardList List<CreditCard> COLLECTION
                    return objCreditCardList;
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
                throw new Exception("Unexpected Error in DALayer_GetAllCreditCards(key) Method: {0} " +
                objE.Message);
            }
        }//End of method











    }

}


