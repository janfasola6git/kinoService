using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace KinoDBCommonService.Model
{
    public class Pracownik
    {        
        int pracownikId;
        int typPracownikaId ;
        string imie;
        string nazwisko;
        string pesel;
        string adres;
        string email;

        [DataMember]
        public int PracownikId
        {
            get { return pracownikId; }
            set { pracownikId = value; }
        }
        [DataMember]
        public int TypPracownikaId
        {
            get { return typPracownikaId; }
            set { typPracownikaId = value; }
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
        [DataMember]
        public string Pesel
        {
            get { return pesel; }
            set { pesel = value; }
        }
        [DataMember]
        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }
        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        
    }
}