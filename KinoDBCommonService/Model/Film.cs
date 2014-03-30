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
        public int FilmId
        {
            get { return filmId; }
            set { filmId = value; }
        }
        [DataMember]
        public string Tytul
        {
            get { return tytul; }
            set { tytul = value; }
        }
        [DataMember]
        public int RokProdukcji
        {
            get { return rokProdukcji; }
            set { rokProdukcji = value; }
        }
        [DataMember]
        public int CzasTrwania
        {
            get { return czasTrwania; }
            set { czasTrwania = value; }
        }
        [DataMember]
        public int DataPremSwiat
        {
            get { return dataPremSwiat; }
            set { dataPremSwiat = value; }
        }
        [DataMember]
        public int DataPremPolska
        {
            get { return dataPremPolska; }
            set { dataPremPolska = value; }
        }

    }
}