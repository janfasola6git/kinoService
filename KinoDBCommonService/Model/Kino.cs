using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace KinoDBCommonService.Model
{
    public class Kino
    {
       int kinoId ;
       string nazwa ;
       string adres;

       [DataMember]
       public int KinoId
       {
           get { return kinoId; }
           set { kinoId = value; }
       }
       [DataMember]
       public string Nazwa
       {
           get { return nazwa; }
           set { nazwa = value; }
       }
       [DataMember]
       public string Adres
       {
           get { return adres; }
           set { adres = value; }
       }
    }
}