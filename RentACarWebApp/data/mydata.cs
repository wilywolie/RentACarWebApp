using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace otoGaleriWebApp.data
{
    public class mydata
    {
        public mydata()
        {
            markalar.Clear();
            markalar.Add(new marka(1, "audi", "img/audi.png"));
            markalar.Add(new marka(2, "bmw", "img/bmw.png"));
            modeller.Clear();

            marka maudi = markalar.Where(marka => marka.markaid == 1).FirstOrDefault();
            modeller.Add(new model(1, "a3", "img/img2.jpg", maudi));
            modeller.Add(new model(2, "a6", "img/img3.png", maudi));
            modeller.Add(new model(3, "a7", "img/img4.jpeg", maudi));
            marka mbmw = markalar.Where(marka => marka.markaid == 2).FirstOrDefault();
            modeller.Add(new model(4, "e200", "img/img6.jpg", mbmw));
        }
        public static List<marka> markalar = new List<marka>();
        public static List<model> modeller = new List<model>();

    }
}