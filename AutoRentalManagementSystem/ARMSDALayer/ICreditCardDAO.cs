using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMSDALayer
{


    public interface ICreditCardDAO
    {

        CreditCardDTO GetRecordByID(string key);

        bool Insert(CreditCardDTO objDTO);

        bool Update(CreditCardDTO objDTO);

        bool Delete(string key);

        List<CreditCardDTO> GetAllRecords();

    }//End of Interface

}
