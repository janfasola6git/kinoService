using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace KinoDBCommonService.Model
{
    public class Platnosc
    {
       
        int platnoscId;
        int rezerwacjaId;
        int typPlatnosciId;
        int kwota;

        [DataMember]
        public int PlatnoscId
        {
            get { return platnoscId; }
            set { platnoscId = value; }
        }
        [DataMember]
        public int RezerwacjaId
        {
            get { return rezerwacjaId; }
            set { rezerwacjaId = value; }
        }
        [DataMember]
        public int TypPlatnosciId
        {
            get { return typPlatnosciId; }
            set { typPlatnosciId = value; }
        }
        [DataMember]
        public int Kwota
        {
            get { return kwota; }
            set { kwota = value; }
        }

    }
}