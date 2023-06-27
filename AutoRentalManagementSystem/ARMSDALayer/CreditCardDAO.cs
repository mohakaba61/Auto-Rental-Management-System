using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMSDALayer
{


    public class CreditCardDAO : ICreditCardDAO
    {

        #region "GETRECORDBYID(KEY) DATA ACCESS METHOD"

        public CreditCardDTO GetRecordByID(string key)
        {

            //Step 1-GET the Connection from SQLServerDAOFactory Object & Create ADO SqlConnection Object
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();

                //Step 3-Create SQL string
                string strSQL = "SELECT CREDITCARD.CreditCardNumber, CREDITCARD.CreditCardOwnerName, " +
                "CREDITCARD.CreditCardIssuingCompany, CREDITCARDMERCHANT.MerchantCode, " +
                "CREDITCARDMERCHANT.MerchantName, CREDITCARD.ExpDate, CREDITCARD.AddressLine1, " +
                "CREDITCARD.AddressLine2, CREDITCARD.City, CREDITCARD.StateCode, CREDITCARD.ZipCode, " +
                "CREDITCARD.Country, CREDITCARD.CreditCardLimit, CREDITCARD.CreditCardBalance, " +
                "CREDITCARD.ActivationStatus " +
                "FROM CREDITCARD, CREDITCARDMERCHANT " +
                "WHERE CREDITCARD.MerchantCode = CREDITCARDMERCHANT.MerchantCode " +
                "AND CREDITCARD.CreditCardNumber = @CreditCardNumber;";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);

                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;

                //Step 6-Add Parameter to. NOTE WE ARE ASSIGNING METHOD PARAMETER
                objCmd.Parameters.Add("@CreditCardNumber", SqlDbType.VarChar).Value = key;

                //Step 7-Create DATAREADER POINTER & Execute Query via COMMAND OBJECT ExecuteReader Method 
                // which returns a populated DATAREADER OBJECT with the results of the query
                SqlDataReader objDR = objCmd.ExecuteReader();
                

                //Step 8-Test to make sure there is data in the DataReader Object
                if (objDR.HasRows)
                {
                    //Create Data Transfer Object
                    CreditCardDTO objDTO = new CreditCardDTO();

                    //Step 8a-Call Read() Method to point and read the first record
                    objDR.Read();

                    //Step 8b-Extract data from a row s Object Populates itself.
                    //IMPORTANT! Note that data must be extracted in the ORDER 
                    //in which the QUERY RETURNS THE DATA.
                    objDTO.CreditCardNumber = objDR.GetString(0);
                    objDTO.CreditCardOwnerName = objDR.GetString(1);
                    objDTO.CreditCardIssuingCompany = objDR.GetString(2);
                    objDTO.MerchantCode = objDR.GetByte(3);
                    objDTO.MerchantName = objDR.GetString(4);
                    objDTO.ExpDate = objDR.GetDateTime(5);
                    objDTO.AddressLine1 = objDR.GetString(6);
                    objDTO.AddressLine2 = objDR.GetString(7);
                    objDTO.City = objDR.GetString(8);
                    objDTO.StateCode = objDR.GetString(9);
                    objDTO.ZipCode = objDR.GetString(10);
                    objDTO.Country = objDR.GetString(11);
                    objDTO.CreditCardLimit = objDR.GetDecimal(12);
                    objDTO.CreditCardBalance = objDR.GetDecimal(13);
                    objDTO.ActivationStatus = objDR.GetBoolean(14);

                    //Step 8b- Return Data Transfer Object
                    return objDTO;
                }

                //Step 9 - Terminate ADO Objects
                objDR.Close();
                objDR = null;
                objCmd.Dispose();
                objCmd = null;

                //Step10- return null since no data found
                return null;

            }//End of try

            //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO GetRecordByID(key) " +
                    "Method: {0} " + objE.Message);
               // Console.WriteLine("Error Message: " + objE.Message);
              //  Console.WriteLine("Error Message: " + objE.GetType().Name);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of GetRecordByID

        #endregion "GETRECORDBYID(KEY) DATA ACCESS METHOD"


        #region "INSERT(DTO) DATA ACCESS METHOD"

        public bool Insert(CreditCardDTO objDTO)
        {
            //Step 1-GET the Connection from SQLServerDAOFactory Object & Create ADO SqlConnection Object
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();

                //Step 3-Create SQL string
                string strSQL = "INSERT INTO CreditCard (CreditCardNumber, CreditCardOwnerName, " +
                "CreditCardIssuingCompany, MerchantCode, ExpDate, " +
                "AddressLine1,AddressLine2,City,StateCode,ZipCode,Country, " +
                "CreditCardLimit,CreditCardBalance,ActivationStatus) " +
                "VALUES(@CreditCardNumber, @CreditCardOwnerName, @CreditCardIssuingCompany, " +
                "@MerchantCode, @ExpDate, @AddressLine1, @AddressLine2, @City, " +
                "@StateCode, @ZipCode, @Country, @CreditCardLimit, @CreditCardBalance, @ActivationStatus);";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);

                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;

                //Step 6-Add Parameter to. NOTE WE ARE ASSIGNING METHOD PARAMETER
                //IMPORTANT! Parameter TOKENS @XXXXX name must match same name Used in the INSERT QUERY 
                //AND IN LISTED IN THE ORDER LISTED IN INSERT QUERY! NOTE WE ARE ASSIGNING ALL OBJECT'S DATA
                objCmd.Parameters.Add("@CreditCardNumber", SqlDbType.VarChar).Value = objDTO.CreditCardNumber;
                objCmd.Parameters.Add("@CreditCardOwnerName", SqlDbType.VarChar).Value = objDTO.CreditCardOwnerName;
                objCmd.Parameters.Add("@CreditCardIssuingCompany", SqlDbType.VarChar).Value = objDTO.CreditCardIssuingCompany;
                objCmd.Parameters.Add("@MerchantCode", SqlDbType.TinyInt).Value = objDTO.MerchantCode;
                objCmd.Parameters.Add("@ExpDate", SqlDbType.DateTime).Value = objDTO.ExpDate;
                objCmd.Parameters.Add("@AddressLine1", SqlDbType.VarChar).Value = objDTO.AddressLine1;
                objCmd.Parameters.Add("@AddressLine2", SqlDbType.VarChar).Value = objDTO.AddressLine2;
                objCmd.Parameters.Add("@City", SqlDbType.VarChar).Value = objDTO.City;
                objCmd.Parameters.Add("@StateCode", SqlDbType.Char).Value = objDTO.StateCode.ToCharArray();
                objCmd.Parameters.Add("@ZipCode", SqlDbType.VarChar).Value = objDTO.ZipCode;
                objCmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = objDTO.Country;
                objCmd.Parameters.Add("@CreditCardLimit", SqlDbType.Decimal).Value = objDTO.CreditCardLimit;
                objCmd.Parameters.Add("@CreditCardBalance", SqlDbType.Decimal).Value = objDTO.CreditCardBalance;
                objCmd.Parameters.Add("@ActivationStatus", SqlDbType.Bit).Value = objDTO.ActivationStatus;

                //Step 7-Execute ACTION-Query, Test result and throw exception if failed
                int intRecordsAffected = objCmd.ExecuteNonQuery();



                //Step 8-validate if INSERT QUERY was successful
                if (intRecordsAffected == 1)
                {
                    //Step 8a-Return true
                    return true;
                }

                //Step 9 - Terminate ADO Objects
                objCmd.Dispose();
                objCmd = null;

                //Step10-return false
                return false;

            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO Insert(CreditCardDTO objDTO)" +
                    " Method: {0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }

        }//End of Insert


        #endregion "INSERT(DTO) DATA ACCESS METHOD"


        #region "UPDATE(DTO) DATA ACCESS METHOD"

        public bool Update(CreditCardDTO objDTO)
        {
            //Step 1-GET the Connection from SQLServerDAOFactory Object & Create ADO SqlConnection Object
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();

                //Step 3-Create SQL string
                string strSQL = "UPDATE CreditCard SET CreditCardOwnerName = @CreditCardOwnerName, " +
                "CreditCardIssuingCompany = @CreditCardIssuingCompany, " +
                "MerchantCode=@MerchantCode, " +
                "ExpDate = @ExpDate, " +
                "AddressLine1 = @AddressLine1, " +
                "AddressLine2 = @AddressLine2, " +
                "City = @City, " +
                "StateCode = @StateCode, " +
                "ZipCode = @ZipCode, " +
                "Country = @Country, " +
                "CreditCardLimit = @CreditCardLimit, " +
                "CreditCardBalance = @CreditCardBalance, " +
                "ActivationStatus = @ActivationStatus " +
                "WHERE CreditCardNumber = @CreditCardNumber;";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);

                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;

                //Step 6-Add Parameter to. NOTE WE ARE ASSIGNING METHOD PARAMETER
                //IMPORTANT! Parameter TOKENS @XXXXX name must match same name Used in the UPDATE QUERY 
                //AND IN LISTED IN THE ORDER LISTED IN INSERT QUERY! NOTE WE ARE ASSIGNING ALL OBJECT'S DATA
                objCmd.Parameters.Add("@CreditCardOwnerName", SqlDbType.VarChar).Value = objDTO.CreditCardOwnerName;
                objCmd.Parameters.Add("@CreditCardIssuingCompany", SqlDbType.VarChar).Value = objDTO.CreditCardIssuingCompany;
                objCmd.Parameters.Add("@MerchantCode", SqlDbType.TinyInt).Value = objDTO.MerchantCode;
                objCmd.Parameters.Add("@ExpDate", SqlDbType.DateTime).Value = objDTO.ExpDate;
                objCmd.Parameters.Add("@AddressLine1", SqlDbType.VarChar).Value = objDTO.AddressLine1;
                objCmd.Parameters.Add("@AddressLine2", SqlDbType.VarChar).Value = objDTO.AddressLine2;
                objCmd.Parameters.Add("@City", SqlDbType.VarChar).Value = objDTO.City;
                objCmd.Parameters.Add("@StateCode", SqlDbType.Char).Value = objDTO.StateCode.ToCharArray();
                objCmd.Parameters.Add("@ZipCode", SqlDbType.VarChar).Value = objDTO.ZipCode;
                objCmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = objDTO.Country;
                objCmd.Parameters.Add("@CreditCardLimit", SqlDbType.Decimal).Value = objDTO.CreditCardLimit;
                objCmd.Parameters.Add("@CreditCardBalance", SqlDbType.Decimal).Value = objDTO.CreditCardBalance;
                objCmd.Parameters.Add("@ActivationStatus", SqlDbType.Bit).Value = objDTO.ActivationStatus;
                objCmd.Parameters.Add("@CreditCardNumber", SqlDbType.VarChar).Value = objDTO.CreditCardNumber;


                //Step 7-Execute ACTION-Query, Test result and throw exception if failed
                int intRecordsAffected = objCmd.ExecuteNonQuery();



                //Step 8-validate if INSERT QUERY was successful
                if (intRecordsAffected == 1)
                {
                    //Step 8a-Return true
                    return true;
                }

                //Step 9 - Terminate ADO Objects
                objCmd.Dispose();
                objCmd = null;

                //Step10-return false
                return false;

            }//End of try

            //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO Update(CreditCardDTO objDTO) " +
                    "Method: {0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }

        }//End of Update




        #endregion "UPDATE(DTO) DATA ACCESS METHOD"


        #region "DELETE(KEY) DATA ACCESS METHOD"

        public bool Delete(string key)
        {
            //Step 1-GET the Connection from SQLServerDAOFactory Object & Create ADO SqlConnection Object
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();

                //Step 3-Create SQL string
                string strSQL = "DELETE FROM CreditCard WHERE CreditCardNumber = @CreditCardNumber;";


                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);

                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;

                //Step 6-Add Parameter to. NOTE WE ARE ASSIGNING METHOD PARAMETER
                //IMPORTANT! Parameter TOKENS @XXXXX name must match same name Used in the UPDATE QUERY 
                //AND IN LISTED IN THE ORDER LISTED IN INSERT QUERY! NOTE WE ARE ASSIGNING ALL OBJECT'S DATA
                objCmd.Parameters.Add("@CreditCardNumber", SqlDbType.VarChar).Value = key;


                //Step 7-Execute ACTION-Query, Test result and throw exception if failed
                int intRecordsAffected = objCmd.ExecuteNonQuery();



                //Step 8-validate if INSERT QUERY was successful
                if (intRecordsAffected == 1)
                {
                    //Step 8a-Return true
                    return true;
                }

                //Step 9 - Terminate ADO Objects
                objCmd.Dispose();
                objCmd = null;

                //Step10-return false
                return false;

            }//End of try

            //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO Delete(key) " +
                    "Method: {0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }

        }//End of Delete


        #endregion "DELETE(KEY) DATA ACCESS METHOD"


        #region "GETALLRECORDS() DATA ACCESS METHOD"

        // strSQL = "Select CreditCardNumber,
        // CreditCardOwnerName,
        // CreditCardIssuingCompany,
        // c.MerchantCode,
        // m.MerchantName,
        // ExpDate, AddressLine1,
        // AddressLine2,
        // City, StateCode,
        // ZipCode,
        // Country,
        // CreditCardLimit,
        // CreditCardBalance,
        // ActivationStatus
        // from CreditCard c INNER JOIN CreditCardMerchant m ON m.MerchantCode = c.MerchantCode";

        public List<CreditCardDTO> GetAllRecords()
        {

            //Step 1-GET the Connection from SQLServerDAOFactory Object & Create ADO SqlConnection Object  
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();

                //Step 3-Create SQL string
                string strSQL = "SELECT CREDITCARD.CreditCardNumber, CREDITCARD.CreditCardOwnerName, " +
                "CREDITCARD.CreditCardIssuingCompany, CREDITCARD.MerchantCode, " +
                "CREDITCARDMERCHANT.MerchantName, CREDITCARD.ExpDate, CREDITCARD.AddressLine1, " +
                "CREDITCARD.AddressLine2, CREDITCARD.City, CREDITCARD.StateCode, CREDITCARD.ZipCode, " +
                "CREDITCARD.Country, CREDITCARD.CreditCardLimit, " +
                "CREDITCARD.CreditCardBalance, CREDITCARD.ActivationStatus " +
                "FROM CREDITCARD, CREDITCARDMERCHANT " +
                "WHERE CREDITCARD.MerchantCode = CREDITCARDMERCHANT.MerchantCode;";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);

                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;


                //Step 7-Create DATAREADER POINTER & Execute Query via
                //COMMAND OBJECT ExecuteReader Method which returns a populated
                //DATAREADER OBJECT with the results of the query
                SqlDataReader objDR = objCmd.ExecuteReader();

                //Step 8-Test to make sure there is data in the DataReader Object
                if (objDR.HasRows)
                {
                    //Step 9-Test Create a Generic List Collection Object of Data Transfer Objects
                    List<CreditCardDTO> colRecordList = new List<CreditCardDTO>();

                    //Step 10-Loop through the Collection to Add Data Transfer Object
                    while (objDR.Read())
                    {
                        //10a-Create Data Transfer Object
                        CreditCardDTO objDTO = new CreditCardDTO();

                        //10b-Populate Data Transfer Object with DataReader records. IMPORTANT! Note that data
                        // must be extracted in the ORDER in which the QUERY RETURNS THE DATA.
                        objDTO.CreditCardNumber = objDR.GetString(0);
                        objDTO.CreditCardOwnerName = objDR.GetString(1);
                        objDTO.CreditCardIssuingCompany = objDR.GetString(2);
                        objDTO.MerchantCode = objDR.GetByte(3);
                        objDTO.MerchantName = objDR.GetString(4);
                        objDTO.ExpDate = objDR.GetDateTime(5);
                        objDTO.AddressLine1 = objDR.GetString(6);
                        objDTO.AddressLine2 = objDR.GetString(7);
                        objDTO.City = objDR.GetString(8);
                        objDTO.StateCode = objDR.GetString(9);
                        objDTO.ZipCode = objDR.GetString(10);
                        objDTO.Country = objDR.GetString(11);
                        objDTO.CreditCardLimit = objDR.GetDecimal(12);
                        objDTO.CreditCardBalance = objDR.GetDecimal(13);
                        objDTO.ActivationStatus = objDR.GetBoolean(14);

                        //Step 10c-Add Data Transfer Object to the collection
                        colRecordList.Add(objDTO);

                    }//End of loop

                    //Step 11-Return the collection
                    return colRecordList;
                }
                else
                {
                    //Step 12 - Terminate ADO Objects
                    objDR.Close();
                    objDR = null;
                    objCmd.Dispose();
                    objCmd = null;

                    //Step13-return null since no records found
                    return null;

                }//End of if/else
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO GetAllRecords() " +
                                    "Method: {0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of GetAllRecords


        #endregion "GETALLRECORDS() DATA ACCESS METHOD"


    }//End of Class

}
