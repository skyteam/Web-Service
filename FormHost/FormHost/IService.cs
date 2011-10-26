using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;
using System.ServiceModel.Description;

namespace FormHost
{

    [ServiceContract(Namespace = "http://myuri.org/Simple")]
    public interface IService
    {
        [OperationContract]
        string LogIn();
    }
}
