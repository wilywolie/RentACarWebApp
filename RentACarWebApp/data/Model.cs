
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace otoGaleriWebApp.data
{
    public enum yakit
    {
        benzin,
        mazot,
        hibrit,
        otogaz
    }

    public class model
    {
        public model()
        {

        }
        public model(int _modelid, string _modeladi, string _modelimurl, marka _markasi)
        {
            modelid = _modelid;
            modeladi = _modeladi;
            modelimageurl = _modelimurl;
            markasi = _markasi;
        }
        public int modelid { set; get; }
        public string modeladi { set; get; }
        public yakit yakitturu { set; get; }
        public int modelyili { set; get; }
        public string modelimageurl { set; get; }
        public marka markasi { get; set; }
    }
}