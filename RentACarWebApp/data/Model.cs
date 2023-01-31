using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACarWebApp.data
{
    public class Model
    {
        public enum yakit
        {
            benzin,
            mazot,
            hibrit,
            otogaz
        }
        public Model()
        {

        }
        public Model(int _modelid, string _modeladi, string _modelimrul, Marka _marrkasi)
        {
            modelid = _modelid;
            modeladi = _modeladi;
            modelimageurl = _modelimrul;
            markasi = _marrkasi;
        }
        public int modelid { get; set; }
        public int modelyili { get; set; }
        public string modeladi { get; set; }
        public yakit yakitturu { get; set; }
        public string modelimageurl { get; set; }
        public Marka markasi { get; set; }

    }
}