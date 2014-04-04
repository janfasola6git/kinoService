using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KinoDBCommonService.Model;

namespace KinoDBCommonService.DBController
{
    public class DBControllerGet
    {
        #region GetFilms

        public Film GetFilmById(int _id)
        {
           //TODO
            return null;
        }

        public List<Film> GetFilmsByTitle(string _title)
        {
             //TODO
            return null; 
        }

        #endregion kupa

        #region GetActor

        public Aktor GetAktorById(int _id)
        {
             //TODO
            return null;
        }

        public List<Aktor> GetAktorByName(string _name)
        {
             //TODO
            return null;
        }
        #endregion GetActor

        #region GetRezyser

        public Rezyser GetARezyserById(int _id)
        {
             //TODO
            return null;
        }

        public List<Rezyser> GetRezyserByName(string _name)
        {
             //TODO
            return null;
        }
        #endregion GetRezyser

        #region GetSeans

        public List<Seans> GetSeansByDate(DateTime _data)
        { 
            //TODO
            return null;
        }

        #endregion GetSeans
    }
}