using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RentACarWebApp.data;

namespace RentACarWebApp
{
    public partial class main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mydata veriler = new mydata();

            Marka m1 = new Marka();
            m1.markaadi = "mercedes";
            m1.markaid = 3;
            m1.markaimageurl = "img/mercedes.png";

            mydata.markalar.Add(m1);

           

            img1.ImageUrl = mydata.markalar[0].markaimageurl;
            lblModel1.Text = mydata.markalar[0].markaadi;
            img2.ImageUrl = mydata.markalar[2].markaimageurl;
            lblModel2.Text = mydata.markalar[2].markaadi;


        }
    }
}