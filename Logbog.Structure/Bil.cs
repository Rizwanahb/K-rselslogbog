using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logbog.Model
{
    public class Bil
    {
       
            private int _Bilid;
            private string _nummerplade;
            private string _bilfabrikat;
            private string _model;
            private DateTime _reg_dato;
            private decimal _antalkm;
            public int Bil_ID   // property
            {
                get { return _Bilid; }   // get method
                set { _Bilid = value; }  // set method
            }
            public string Nummerplade   // property
            {
                get { return _nummerplade; }   // get method
                set { _nummerplade = value; }  // set method
            }
            public string bilfabrikat   // property
            {
                get { return _bilfabrikat; }   // get method
                set { _bilfabrikat = value; }  // set method
            }
            public string model   // property
            {
                get { return _model; }   // get method
                set { _model = value; }  // set method
            }
            public DateTime regdato  // property
            {
                get { return _reg_dato; }   // get method
                set { _reg_dato = value; }  // set method
            }

            public decimal antalkm   // property
            {
                get { return _antalkm; }   // get method
                set { _antalkm = value; }  // set method
            }
        }
}
