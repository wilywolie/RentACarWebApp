using otoGaleriWebApp.data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otoGaleriWebApp
{
    public partial class modelekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlMarkalar.DataSource = mydata.markalar;
                ddlMarkalar.DataTextField = "markaadi";
                ddlMarkalar.DataValueField = "markaid";
                ddlMarkalar.DataBind();
            }

        }
        async protected void fileUpload(object sender, EventArgs e)
        {
            //Debug.WriteLine("file upload işlemleri");
            model yenimodel = new model();
            yenimodel.modeladi = txtMarkaAdi.Text;
            yenimodel.modelid = int.Parse(txtMarkaId.Text);
            marka secilenmarka = mydata.markalar.Where(m => m.markaid == int.Parse(ddlMarkalar.SelectedValue)).FirstOrDefault();
            yenimodel.markasi = secilenmarka;
            yenimodel.modelimageurl = "img/" + fileResim.FileName;
            if (fileResim.HasFile)
            {
                await saveimage();
            }

            mydata.modeller.Add(yenimodel);



        }
        async Task saveimage()
        {
            fileResim.SaveAs(Server.MapPath("~/img/" + fileResim.FileName));
            //Response.Redirect("modeller.aspx");
        }

    }
}