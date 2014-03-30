using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace KinoDBCommonService.Model
{
    public class Rezerwacja
    {
        int rezerwacjaId;
        int klientId;
        int pracownikId;
        int seansId;

        [DataMember]
        public int PracownikId
        {
            get { return pracownikId; }
            set { pracownikId = value; }
        }
        [DataMember]
        public int KlientId
        {
            get { return klientId; }
            set { klientId = value; }
        }
        [DataMember]
        public int PracownikId
        {
            get { return pracownikId; }
            set { pracownikId = value; }
        }
        [DataMember]
        public int SeansId
        {
            get { return seansId; }
            set { seansId = value; }
        }
    }
}