using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMSDALayer
{
    public abstract class DALObjectFactoryBase
    {
        //Constant variables that identifies the DATA SOURCE being
        //targetted for Data Access.
        //These variables will work in conjuntion with the 
        //static GetDataSourceDAOFactory(int targetDatasource) method of this class.
        public const int SQLSERVER = 1;
        public const int ORACLE = 2;
        public const int MYSQL = 3;

        /***********************************************************************/
        //Name:         GetDataSourceDAOFactory(int targetDatasource) Method
        //Purpose:      key method in the DLA strategy. This method starts the
        //              DATA ACCESS PROCESS, by RETURNING the appropriate 
        //              DATA SOURCE Data Access Object for a particular data source.
        //              Method determines which is the TARGET DATASOURCE such as 
        //              MS SQLServer or Oracle etc.  Which data source is being 
        //              targeted depends on the target datasouce integer passed as 
        //              parameter.  This value is one of the PUBLIC CONSTANT VARIABLES
        //              of this class SQLSERVER =1, ORACLE =2 & MYSQL = 3.
        //Parameter:    An integer variable containing either SQLSERVER =1, ORACLE =2 & MYSQL = 3.
        //              The client of the DAL needs to call this method passing 
        //              one of the CONSTANT VARIABLES in this class: DALObjectFactoryBase.SQLSERVER,
        //              DALObjectFactoryBase.ORACLE or DALObjectFactoryBase.MYSQL.
        //Return Value: Depending on the PARAMETER passed, it will return either a
        //              SQLServerDAOFactory OBJECT that will perfom the data access on MSSQLServer
        //              or OracleDAOFactory OBJECT for Oracle data access, etc.


        public static DALObjectFactoryBase GetDataSourceDAOFactory(int targetDataSourceFactory)
        {
            switch (targetDataSourceFactory)
            {
                case 1:     //MS SQLServer Data Source

                    //Return an object of the SQLServer Data Access Object Factory
                    //SQLServerDAOFactory Class
                    return new SQLServerDAOFactory();

                case 2:     //Oracle Data Source

                    //Out of scope of this project and course.
                    //Throw NotImplementedException
                    throw new NotImplementedException();

                case 3:     //MySQL Data Source

                    //Out of scope of this project and course.
                    //Throw NotImplementedException
                    throw new NotImplementedException();


                //case X: other data sources targeted for this application here


                default:    //Default valued returned when the integer options is not a case
                    return null;

            }//End of switch

        }//End of method


        /****************************************************************************/
        //Purpose:      Abstract methods are method declarations that only contain
        //              a header with the keyword ABSTRACT. Method is NOT implemented
        //              in this BASE CLASS, but MUST be implemented by any sub or
        //              derived classes that which to inherit from this base class.
        public abstract CreditCardDAO GetCreditCardDAO();
        public abstract CreditCardMerchantDAO GetCreditCardMerchantDAO();
         public abstract USStateDAO GetUSStateDAO();
        public abstract CountryDAO GetCountryDAO();


    }//End of class


}
