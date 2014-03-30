using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;


namespace KinoDBCommonService.Model
{
    [DataContract]
    public class Film
    {
        int  filmId;
        string tytul;
        int rokProdukcji;
        int czasTrwania;
        int dataPremSwiat;
        int dataPremPolska;

        [DataMember]
        public string Tytul
        {
            get { return tytul; }
            set { tytul = value; }
        }

    }
}