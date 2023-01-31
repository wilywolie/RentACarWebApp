using otoGaleriWebApp.data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otoGaleriWebApp
{
    public partial class modeller : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["markaadi"] != null)
            {
                string gelenad = Request.QueryString["markaadi"].ToString();
                Repeater1.DataSource = mydata.modeller.Where(m => m.markasi.markaadi == gelenad);
            }
            else
            {
                Repeater1.DataSource = mydata.modeller;
            }
            Repeater1.DataBind();

        }


        protected void item_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).CommandArgument);
            Debug.WriteLine(id + " nolu Obje tıklandı");
            model m = mydata.modeller.Where(mdl => mdl.modelid == id).FirstOrDefault();
            mydata.modeller.Remove(m);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}