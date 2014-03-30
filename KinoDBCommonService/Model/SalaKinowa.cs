using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace KinoDBCommonService.Model
{

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class SalaKinowa
    {
       int   saalaId;
       int  nrSali;
      
        [DataMember]
       public int NrSali
        {
            get { return nrSali; }
            set { nrSali = value; }
        }


    }
}
