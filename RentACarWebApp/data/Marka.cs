using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace otoGaleriWebApp.data
{
    public class marka
    {
        public marka()//constructor
        {

        }
        public marka(int _markaid, string _markaadi, string _markaimageurl)//constructor
        {
            markaid = _markaid;
            markaadi = _markaadi;
            markaimageurl = _markaimageurl;

        }

        public int markaid { set; get; }
        public string markaadi { set; get; }
        public string markaimageurl { set; get; }
        //List<model> modeller = new List<model>();

    }
}