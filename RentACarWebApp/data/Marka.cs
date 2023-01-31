using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACarWebApp.data
{
    public class Marka
    {
        public Marka()
        {

        }
        public Marka(int _markaid, string _markaadi, string _markaimageurl)
        {
            markaid = _markaid;
            markaadi = _markaadi;
            markaimageurl = _markaimageurl;

        }
        public int markaid { get; set; }
        public string markaadi { get; set; }
        public string markaimageurl { get; set; }



    }
}