using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.TrySkipIisCustomErrors = true;  //Suppress IIS7 custom errors
            Response.StatusCode = 404;
            SetRobotsHeaderMetadata();

        }
        private void SetRobotsHeaderMetadata()
        {
        
            HtmlMeta meta = new HtmlMeta();
            HtmlMeta meta2 = new HtmlMeta();
            meta2.Name = "og:url";
            meta2.Content = "http://globo.com";

            meta.Name = "og:title";
            meta.Content = "Title";

            meta.Name = "og:description";
            meta.Content = "description";

            meta.Name = "og:image";
            meta.Content = "mydomain.com/testing.jpeg";

            meta.Name = "og:image:height";
            meta.Content = "2560";

            meta.Name = "og:image:height";
            meta.Content = "960";
            this.Page.Master.FindControl("cphPageMetaData").Controls.Add(meta);
            this.Page.Master.FindControl("cphPageMetaData").Controls.Add(meta2);
        }
    }
}