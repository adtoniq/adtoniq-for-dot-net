using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdtoniqForDotNet
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string nonce = Request.Params.Get("adtoniqNonce");
                string apikey = Request.Params.Get("adtoniqAPIKey");

                if (! string.IsNullOrEmpty(nonce) && ! string.IsNullOrEmpty(apikey) && apikey.Equals(AdtoniqLauncher.apiKey))
                {
                    AdtoniqLauncher.adtoniq.getLatestJavaScript(nonce);
                }
            }
        }
    }
}