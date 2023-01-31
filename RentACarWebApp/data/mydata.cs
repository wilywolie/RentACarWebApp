using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACarWebApp.data
{
    public class mydata
    {
        public mydata()
        {
            markalar.Clear();
            markalar.Add(new Marka(1, "Audi", "img/Audi.png"));
            markalar.Add(new Marka(2, "BMW", "img/BMW.png"));
            Marka maudi = markalar.Where(m => m.markaid == 1).FirstOrDefault();
            modeller.Add(new Model(1, "a3", "img/img2.jpg", maudi));
            modeller.Add(new Model(2, "a5", "img/img3.png", maudi));
            modeller.Add(new Model(3, "a7", "img/img4.jpeg", maudi));

        }
        public static List<Marka> markalar = new List<Marka>();
        public static List<Model> modeller = new List<Model>();
    }
}