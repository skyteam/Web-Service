using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace FormHost
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class Service : IService
    {
        public string LogIn()
        {
            return "YOU HAVE LOGGED IN";
        }
    }
}
