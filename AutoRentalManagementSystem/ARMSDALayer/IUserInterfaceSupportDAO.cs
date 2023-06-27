using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMSDALayer
{
    public interface IUserInterfaceSupportDAO<T>
    {

        List<T> GetAllRecords();


    } //End of Interface


}
