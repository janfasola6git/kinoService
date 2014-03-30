using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;


namespace KinoDBCommonService.Model
{
    public class Aktor
    {

        [DataContract]
        public class Film
        {
            int aktorId;
            string imie;
            string nazwisko;
            

            [DataMember]
            public int AktorId
            {
                get { return aktorId; }
                set { aktorId = value; }
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
}