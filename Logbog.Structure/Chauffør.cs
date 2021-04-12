using System;


namespace Logbog.Model
{
    public class Chauffør
    {
        private int _chID;
        private string _fNavn;
        private string _eNavn;
        private DateTime _opretdato;

        public int Ch_ID   // property
        {
            get { return _chID; }   // get method
            set { _chID = value; }  // set method
        }
        public string ForNavn   // property
        {
            get { return _fNavn; }   // get method
            set { _fNavn = value; }  // set method
        }
        public string EfterNavn   // property
        {
            get { return _eNavn; }   // get method
            set { _eNavn = value; }  // set method
        }
        public DateTime OpretDato   // property
        {
            get { return _opretdato; }   // get method
            set { _opretdato = value; }  // set method
        }




    }
}
