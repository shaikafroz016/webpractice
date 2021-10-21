using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcfclient_netframe.BAL
{
    public class BAL_CLASS
    {
        ServiceReference1.ServiceClient sr = new ServiceReference1.ServiceClient();
        public IList<ServiceReference1.emp> GetRec1()
        {
           IList<ServiceReference1.emp> ls= sr.GetRec();
            return ls;
        }
    }
}