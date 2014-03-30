using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace KinoDBCommonService.Model
{
    public class Miejsce
    {

        int miejsceId;
        int salaId;
        int rzad;
        int kolumna ;

        [DataMember]
        public int MiejsceId
        {
            get { return miejsceId; }
            set { miejsceId = value; }
        }
        [DataMember]
        public int SalaId
        {
            get { return salaId; }
            set { salaId = value; }
        }
        [DataMember]
        public int Rzad
        {
            get { return rzad; }
            set { rzad = value; }
        }
        [DataMember]
        public int Kolumna
        {
            get { return kolumna; }
            set { kolumna = value; }
        }


    }
}