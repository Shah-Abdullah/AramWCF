using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AramShopRESTWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MissCall" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MissCall.svc or MissCall.svc.cs at the Solution Explorer and start debugging.
    public class MissCall : IMissCall
    {
    

        public string CatchNumberAndSave(string Number)
        {
            return "Your Recieved Number is = " + Number;
        }
    }
}
