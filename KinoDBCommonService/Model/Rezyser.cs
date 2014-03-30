using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace KinoDBCommonService.Model
{
    public class Rezyser
    {
        int rezyserId;
        string imie;
        string nazwisko;

        [DataMember]
        public int RezyserId
        {
            get { return rezyserId; }
            set { rezyserId = value; }
        }
        [DataMember]
        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }
        [DataMember]
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }
    }
}