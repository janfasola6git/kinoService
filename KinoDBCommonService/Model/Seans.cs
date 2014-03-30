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
    public class Seans
    {
        int seansId;
        int salaId;
        
        Film film;

        DateTime dataStart;
        DateTime dataStop;
        
        [DataMember]
        public Film Film
        {
            get { return film; }
            set { film = value; }
        }
        
       
    }
}
