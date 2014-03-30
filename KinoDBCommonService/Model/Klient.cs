using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace KinoDBCommonService.Model
{
    public class Klient
    {
        int klientId ;
        string imie;
        string nazwisko;
        string adres;
        string login;
        string email;
        string password;

        [DataMember]
        public int KlientId
        {
            get { return klientId; }
            set { klientId = value; }
        }
        [DataMember]
        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }
        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}